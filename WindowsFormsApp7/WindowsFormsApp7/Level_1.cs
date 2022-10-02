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
    public partial class Level_1 : Form
    {
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 30;
        int countDownTime;
        bool gameOver = false;
        public Level_1()
        {
            InitializeComponent();
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        }

        private void RestartGameEvent(object sender, EventArgs e)
        {

        }

        private void LoadPictures()
        {

        }

        private void CheckPictures(PictureBox A, PictureBox B)
        {

        }

        private void GameOver()
        {

        }
    }
}
