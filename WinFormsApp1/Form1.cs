using TooniiMachine.Undsen;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Calculator calc;
        private string operation;
        private int zvvnvalue;
        public Form1()
        {
            InitializeComponent();
        }

        string op;
        int num1;
        int num2;
        int result;

        private void Nemeh_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = int.Parse(too_haruulah.Text);
            too_haruulah.Clear();


        }

        private void Memory_Click(object sender, EventArgs e)
        {

        }

        private void hasah_Click(object sender, EventArgs e)
        {
            op = "-";
            num1 = int.Parse(too_haruulah.Text);
            too_haruulah.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Tentsuu_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(too_haruulah.Text);
            if (op == "-")
            {
                result = num1 - num2;
            }
            else
            {
                result = num1 + num2;
            }
            too_haruulah.Text = result + "";

        }

        private void neg_Click(object sender, EventArgs e)
        {
            too_haruulah.Text = too_haruulah.Text + ((Button)sender).Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // memory clear button
            too_haruulah.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void too_haruulah_TextChanged(object sender, EventArgs e)
        {

        }

        private void butsah_Click(object sender, EventArgs e)
        {
            if (too_haruulah.Text.Length>0)
            {
                too_haruulah.Text = too_haruulah.Text.Remove(too_haruulah.Text.Length - 1);
            }
        }
    }
}
