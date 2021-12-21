using System.Windows.Forms;

namespace TabControlStatusSaveTextFile
{
    public partial class UserControlPage : UserControl
    {
        public string Data
        {
            get
            {
                return textBoxData.Text;
            }
            set
            {
                textBoxData.Text = value;
            }
        }

        public UserControlPage()
        {
            InitializeComponent();
        }
    }
}