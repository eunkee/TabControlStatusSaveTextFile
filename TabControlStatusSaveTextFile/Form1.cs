using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TabControlStatusSaveTextFile
{
    public partial class Form1 : Form
    {
        private readonly List<TabPage> tabPages = new List<TabPage>();
        private readonly List<UserControlPage> userControlPages = new List<UserControlPage>();
        private readonly string _fileName = "Temp.txt";
        private string _deskFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string deskPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            _deskFilePath = Path.Combine(deskPath, _fileName);

            //ButtonLoadStatus_Click(null, null);
        }

        private void AddTabControl(string data = "")
        {
            int index = tabPages.Count;
            TabPage tabPage = new TabPage
            {
                Location = new Point(4, 24),
                Margin = new Padding(3, 4, 3, 4),
                Name = $"tabPage{index + 1}",
                Padding = new Padding(3, 4, 3, 4),
                Size = new Size(652, 312),
                TabIndex = index,
                Text = $"tabPage{index + 1}",
                UseVisualStyleBackColor = true
            };

            UserControlPage userControlPage = new UserControlPage
            {
                Data = data,
                Dock = DockStyle.Fill
            };

            userControlPages.Add(userControlPage);
            tabPage.Controls.Add(userControlPage);

            tabPages.Add(tabPage);
            this.tabControl.Controls.Add(tabPage);
        }

        private void ButtonAddTab_Click(object sender, EventArgs e)
        {
            AddTabControl();
        }

        private void ButtonRemoveTab_Click(object sender, EventArgs e)
        {
            int index = tabPages.Count - 1;
            if (index >= 0)
            {
                userControlPages.RemoveAt(index);
                this.tabControl.Controls.RemoveAt(index);
                tabPages.RemoveAt(index);
            }
        }

        private void ButtonSaveStatus_Click(object sender, EventArgs e)
        {
            if (_deskFilePath.Length <= 0)
            {
                return;
            }

            if (userControlPages.Count <= 0)
            {
                return;
            }

            ClassTextData[] classTextDatas = new ClassTextData[userControlPages.Count];
            int index = 0;
            foreach (UserControlPage item in userControlPages)
            {
                ClassTextData itemData = new ClassTextData
                {
                    Index = index,
                    Data = item.Data
                };
                classTextDatas[index] = itemData;
                index++;
            }

            string saveData = JsonConvert.SerializeObject(classTextDatas);
            File.WriteAllText(_deskFilePath, saveData.ToString());

            MessageBox.Show("Success Save File");
        }

        private void ButtonLoadStatus_Click(object sender, EventArgs e)
        {
            if (_deskFilePath.Length <= 0)
            {
                return;
            }
            if (!File.Exists(_deskFilePath))
            {
                return;
            }

            string loadData = File.ReadAllText(_deskFilePath);
            ClassTextData[] classTextDatas = JsonConvert.DeserializeObject<ClassTextData[]>(loadData);

            tabControl.Controls.Clear();
            tabPages.Clear();
            userControlPages.Clear();

            foreach (ClassTextData item in classTextDatas)
            {
                AddTabControl(item.Data);
            }

            MessageBox.Show("Success Load File");
        }
    }
}