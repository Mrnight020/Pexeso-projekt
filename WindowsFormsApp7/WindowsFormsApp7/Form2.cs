using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Size = new Size(270, 500);
            this.BackColor = Color.Black;
        }

        int Cas = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Cas = 150;
            Level_1 level = new Level_1(Cas);
            level.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cas = 120;
            Level_1 level = new Level_1(Cas);
            level.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cas = 90;
            Level_1 level = new Level_1(Cas);
            level.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cas = 31;
            Level_1 level = new Level_1(Cas);
            level.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
