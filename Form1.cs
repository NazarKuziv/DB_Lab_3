using System;
using System.Windows.Forms;

namespace DB_Lab_3
{
    public partial class Form1 : Form
    {
        public static int level;
        public Form2 RefToForm2 { get; set; }

        public Form1(int l)
        {
            InitializeComponent();
            level = l;
        }

        static public Form2 form2 = null;
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.form1 = null;
            this.RefToForm2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(level == 0)
            {
                label1.Text = "You are Admin";
            }
            else
            {
                label1.Text = "You are Guest";
            }
        }
    }
}
