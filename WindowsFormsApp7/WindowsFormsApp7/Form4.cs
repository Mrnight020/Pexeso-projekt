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
    public partial class Form4 : Form
    {
        private SoundPlayer winner;
        private SoundPlayer _soundPlayer;
        public Form4()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("music/sneaky_snitch.wav");
            winner = new SoundPlayer("music/gangsta.wav");
            winner.Play();
            this.Size = new Size(640, 360);
            timer1.Start();
            this.BackgroundImage = Image.FromFile("pics/" + "win_screen.jpg");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _soundPlayer.PlayLooping();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
