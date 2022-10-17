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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Size = new Size(640, 360);
            timer1.Start();
            this.BackgroundImage = Image.FromFile("pics/" + "win_screen.jpg");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
