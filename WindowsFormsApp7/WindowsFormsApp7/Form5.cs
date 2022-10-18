using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace WindowsFormsApp7
{
    public partial class Form5 : Form
    {
        private SoundPlayer lose;
        private SoundPlayer _soundPlayer;
        public Form5()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("music/sneaky_snitch.wav");
            lose = new SoundPlayer("music/laught.wav");
            lose.Play();
            this.Size = new Size(640, 360);
            timer1.Start();
            this.BackgroundImage = Image.FromFile("pics/" + "lose_screen.jpg");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _soundPlayer.PlayLooping();
            this.Close();
        }

        private void Form5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
