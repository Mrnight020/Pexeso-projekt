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
        public int cas;

        public Level_1(int ACas)
        {
            InitializeComponent();
            LoadPictures();
            cas = ACas;
            this.BackColor = Color.Black;
        }

        public int promena = 0;
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int countDownTime;
        bool gameOver = false;
        bool neco = false;

        private void TimerEvent(object sender, EventArgs e)
        {
            
            if (neco == false)
            {
                countDownTime = cas;
                neco = true;
            }
            countDownTime--;

            lblTimeLeft.Text = "Time Left: " + countDownTime;

            if (countDownTime < 1)
            {
                GameOver("Times Up, You Lose");

                foreach (PictureBox x in pictures)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics/" + (string)x.Tag + ".png");
                    }
                }
            }
            

        }

        private void LoadPictures()
        {
            int leftPos = 20;
            int topPos = 20;
            int rows = 0;

            for (int i = 0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 110;
                newPic.Width = 110;
                newPic.BackColor = Color.LightGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 3)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 140;
                }

                if (rows == 3)
                {
                    leftPos = 20;
                    topPos += 140;
                    rows = 0;
                }
            }

            RestartGame();
        }

        int picture_counter = 0;
        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                // dont register a click if the game is over
                return;
            }

            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("pics/" + (string)picA.Tag + ".png");
                    firstChoice = (string)picA.Tag;
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;
                if (picture_counter == (((pictures.Count/2) - 1)) && picB.Image == null)
                {
                    picB.Image = Image.FromFile("pics/" + (string)picB.Tag + ".png");
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                    timer2.Start();
                    promena = promena++;
                    GameTimer.Stop();
                }


                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("pics/" + (string)picB.Tag + ".png");
                    secondChoice = (string)picB.Tag;
                }
            }   
            else
            {
                CheckPictures(picA, picB);
            }
        }
        private void RestartGameEventButtom(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void RestartGame()
        {
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            numbers = randomList;
            picture_counter = 0;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            tries = 0;
            lblStatus.Text = "Mismatched: " + tries + " times.";
            lblTimeLeft.Text = "Time Left: " + cas;
            gameOver = false;
            GameTimer.Start();
            countDownTime = cas;

        }

        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if (firstChoice == secondChoice)
            {
                A.Tag = null;
                B.Tag = null;
                picture_counter++;
            }
            else
            {
                tries++;
                lblStatus.Text = "Mismatched " + tries + " times.";
            }

            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }
        }

        private void GameOver(string msg)
        {
            GameTimer.Stop();
            gameOver = true;
            MessageBox.Show(msg + " Click Restart to Play Again.", "Moo Says: ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1(promena);
            form.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}