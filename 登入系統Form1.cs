using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            public Action Longin;
            public Action Cancel;
            private string UserName = "1234";
            private string PassWord = "12345";

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    private void button1_TextChanged(object sender, EventArgs e)
    {
        if (tbUser.Text == this UserName.Text || tbPassword.Text != this.PassWord)
                {
            MessageBox.Show("±b¸¹©Î±K½X¦³¿ù»~");
            return;
        }
        if (this.Longin != null)
            this.Login();
        }


    }
}
