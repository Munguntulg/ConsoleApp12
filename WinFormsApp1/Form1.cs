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
        private TooniiMachie.MemoryApp.Memory memory = new TooniiMachie.MemoryApp.Memory();
        private Panel memoryPanel;

        private void Nemeh_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = int.Parse(too_haruulah.Text);
            too_haruulah.Clear();


        }

        private Label memoryValueLabel; // Add this at the class level if you want to update it from other places

        private void Memory_Click(object sender, EventArgs e)
        {
            if (memoryPanel == null)
            {
                memoryPanel = new Panel
                {
                    Size = new Size(220, 40),
                    Location = new Point(550, 60), // Set your desired location
                    BackColor = Color.FromArgb(240, 240, 240),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Memory value label
                memoryValueLabel = new Label
                {
                    Text = memory.Recall()?.ToString() ?? "0",
                    Location = new Point(10, 10),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold)
                };
                memoryPanel.Controls.Add(memoryValueLabel);

                // MC button
                Button mcButton = new Button
                {
                    Text = "MC",
                    Location = new Point(80, 5),
                    Size = new Size(40, 30)
                };
                mcButton.Click += (s, args) => { memory.Clear(); memoryValueLabel.Text = "0"; };
                memoryPanel.Controls.Add(mcButton);

                // M+ button
                Button mPlusButton = new Button
                {
                    Text = "M+",
                    Location = new Point(125, 5),
                    Size = new Size(40, 30)
                };
                mPlusButton.Click += (s, args) =>
                {
                    if (double.TryParse(too_haruulah.Text, out double val))
                    {
                        double current = memory.Recall() ?? 0;
                        double newValue = current + val;
                        memory.Store(newValue);
                        memoryValueLabel.Text = newValue.ToString();
                    }
                };
                memoryPanel.Controls.Add(mPlusButton);

                // M- button
                Button mMinusButton = new Button
                {
                    Text = "M-",
                    Location = new Point(170, 5),
                    Size = new Size(40, 30)
                };
                mMinusButton.Click += (s, args) =>
                {
                    if (double.TryParse(too_haruulah.Text, out double val))
                    {
                        double current = memory.Recall() ?? 0;
                        double newValue = current - val;
                        memory.Store(newValue);
                        memoryValueLabel.Text = newValue.ToString();
                    }
                };
                memoryPanel.Controls.Add(mMinusButton);

                this.Controls.Add(memoryPanel);
                memoryPanel.BringToFront();
            }
            else
            {
                // Toggle visibility and update value
                memoryPanel.Visible = !memoryPanel.Visible;
                memoryValueLabel.Text = memory.Recall()?.ToString() ?? "0";
            }
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
