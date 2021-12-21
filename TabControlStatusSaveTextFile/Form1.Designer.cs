
namespace TabControlStatusSaveTextFile
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.buttonAddTab = new System.Windows.Forms.Button();
            this.buttonRemoveTab = new System.Windows.Forms.Button();
            this.buttonLoadStatus = new System.Windows.Forms.Button();
            this.buttonSaveStatus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 82);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(660, 340);
            this.tabControl.TabIndex = 0;
            // 
            // buttonAddTab
            // 
            this.buttonAddTab.Location = new System.Drawing.Point(12, 15);
            this.buttonAddTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddTab.Name = "buttonAddTab";
            this.buttonAddTab.Size = new System.Drawing.Size(86, 49);
            this.buttonAddTab.TabIndex = 1;
            this.buttonAddTab.Text = "add tab";
            this.buttonAddTab.UseVisualStyleBackColor = true;
            this.buttonAddTab.Click += new System.EventHandler(this.ButtonAddTab_Click);
            // 
            // buttonRemoveTab
            // 
            this.buttonRemoveTab.Location = new System.Drawing.Point(114, 15);
            this.buttonRemoveTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveTab.Name = "buttonRemoveTab";
            this.buttonRemoveTab.Size = new System.Drawing.Size(86, 49);
            this.buttonRemoveTab.TabIndex = 2;
            this.buttonRemoveTab.Text = "remove tab";
            this.buttonRemoveTab.UseVisualStyleBackColor = true;
            this.buttonRemoveTab.Click += new System.EventHandler(this.ButtonRemoveTab_Click);
            // 
            // buttonLoadStatus
            // 
            this.buttonLoadStatus.Location = new System.Drawing.Point(318, 15);
            this.buttonLoadStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadStatus.Name = "buttonLoadStatus";
            this.buttonLoadStatus.Size = new System.Drawing.Size(86, 49);
            this.buttonLoadStatus.TabIndex = 4;
            this.buttonLoadStatus.Text = "load status";
            this.buttonLoadStatus.UseVisualStyleBackColor = true;
            this.buttonLoadStatus.Click += new System.EventHandler(this.ButtonLoadStatus_Click);
            // 
            // buttonSaveStatus
            // 
            this.buttonSaveStatus.Location = new System.Drawing.Point(216, 15);
            this.buttonSaveStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveStatus.Name = "buttonSaveStatus";
            this.buttonSaveStatus.Size = new System.Drawing.Size(86, 49);
            this.buttonSaveStatus.TabIndex = 3;
            this.buttonSaveStatus.Text = "save status";
            this.buttonSaveStatus.UseVisualStyleBackColor = true;
            this.buttonSaveStatus.Click += new System.EventHandler(this.ButtonSaveStatus_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLoadStatus);
            this.panel1.Controls.Add(this.buttonAddTab);
            this.panel1.Controls.Add(this.buttonSaveStatus);
            this.panel1.Controls.Add(this.buttonRemoveTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 82);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 422);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "TabControl Status Save TextFile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonAddTab;
        private System.Windows.Forms.Button buttonRemoveTab;
        private System.Windows.Forms.Button buttonLoadStatus;
        private System.Windows.Forms.Button buttonSaveStatus;
        private System.Windows.Forms.Panel panel1;
    }
}

