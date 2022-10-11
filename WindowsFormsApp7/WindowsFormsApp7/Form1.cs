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
    public partial class Form1 : Form
    {
        public bool Alvl_1 = false;
        public bool Alvl_2 = false;
        public bool Alvl_3 = false;
        public bool Alvl_4 = false;


        public Form1()
        {
            InitializeComponent();
 
        }
        bool Potvrzení_vygenerování = false;

        Font SmallFont = new Font("Arial", 18);
        Label Novy_Label = new Label();
        Button Novy_button = new Button();
        Button Novy_button2 = new Button();
        Button Novy_button3 = new Button();

        Button back_X = new Button();
        Label Nadpis = new Label();
        Button Level1 = new Button();
        Button Level2 = new Button();
        Button Level3 = new Button();
        Button Level4 = new Button();
        Button Level5 = new Button();

        private void Start_fucntion()
        {
            this.Size = new Size(359, 654);

            Novy_Label.Hide();
            Novy_button.Hide();
            Novy_button2.Hide();
            Novy_button3.Hide();

            while (Potvrzení_vygenerování == false)
            {
                this.Controls.Add(Nadpis);
                Nadpis.Text = "Levely";
                Nadpis.Location = new Point(125, 10);
                Nadpis.ForeColor = Color.White;
                Nadpis.Font = SmallFont;

                this.Controls.Add(Level1);
                Level1.Click += new EventHandler(Level_1);
                Level1.Top = 90;
                Level1.Left = 95;
                Level1.Font = SmallFont;
                Level1.Text = "Speedrun";
                Level1.Size = new Size(150, 75);
                Level1.ForeColor = Color.Red;

                this.Controls.Add(Level2);
                Level2.Click += new EventHandler(Level_2);
                Level2.Top = 180;
                Level2.Left = 95;
                Level2.Font = SmallFont;
                Level2.Text = "LimitlessTime";
                Level2.Size = new Size(150, 75);
                Level2.ForeColor = Color.Red;

                this.Controls.Add(Level3);
                Level3.Click += new EventHandler(Level_3);
                Level3.Top = 270;
                Level3.Left = 95;
                Level3.Font = SmallFont;
                Level3.Text = "level 2";
                Level3.Size = new Size(150, 75);
                Level3.ForeColor = Color.Red;

                this.Controls.Add(Level4);
                Level4.Click += new EventHandler(Level_4);
                Level4.Top = 360;
                Level4.Left = 95;
                Level4.Font = SmallFont;
                Level4.Text = "level 3";
                Level4.Size = new Size(150, 75);
                Level4.ForeColor = Color.Red;

                this.Controls.Add(Level5);
                Level5.Click += new EventHandler(Level_5);
                Level5.Top = 450;
                Level5.Left = 95;
                Level5.Font = SmallFont;
                Level5.Text = "level 4";
                Level5.Size = new Size(150, 75);
                Level5.ForeColor = Color.Red;

                this.Controls.Add(back_X);
                back_X.Click += new EventHandler(Back_X);
                back_X.Top = 10;
                back_X.Left = 10;
                back_X.Font = SmallFont;
                back_X.Text = "Back";
                back_X.Size = new Size(75, 32);
                back_X.ForeColor = Color.Red;
                Potvrzení_vygenerování = true;
            }

            Nadpis.Show();
            Level1.Show();
            Level2.Show();
            Level3.Show();
            Level4.Show();
            Level5.Show();
        }

        private void back()
        {
            Nadpis.Hide();
            Level1.Hide();
            Level2.Hide();
            Level3.Hide();
            Level4.Hide();
            Level5.Hide();

            Novy_Label.Show();
            Novy_button.Show();
            Novy_button2.Show();
            Novy_button3.Show();
            this.Size = new Size(359, 454);
        }

        protected void Fucking_button_Click1(object sender, EventArgs e)
        {
            Start_fucntion();

        }

        protected void Fucking_button_Click2(object sender, EventArgs e)
        {

        }

        
        protected void Fucking_button_Click3(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void Level_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }
        protected void Level_2(object sender, EventArgs e)
        {
            if(Alvl_1 == false)
            {
                Level_2 second = new Level_2();
                second.Show();
            }
        }
        protected void Level_3(object sender, EventArgs e)
        {
            Level_3 third = new Level_3();
            third.Show();
        }
        protected void Level_4(object sender, EventArgs e)
        {
            Level_4 Fourth = new Level_4();
            Fourth.Show();
        }
        protected void Level_5(object sender, EventArgs e)
        {
            Level_5 Fifth = new Level_5();
            Fifth.Show();
        }

        protected void Back_X(object sender, EventArgs e)
        {
            back();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(359, 500);
            label1.Hide();
            label2.Hide();
            button1.Hide();
            this.BackColor = System.Drawing.Color.Black;

            this.Controls.Add(Novy_Label);
            Novy_Label.Text = "MENU";
            Novy_Label.Location = new Point(125, 10);
            Novy_Label.ForeColor = Color.White;
            Novy_Label.Font = SmallFont;

            this.Controls.Add(Novy_button);
            Novy_button.Click += new EventHandler(Fucking_button_Click1);
            Novy_button.Top = 90;
            Novy_button.Left = 95;
            Novy_button.Font = SmallFont;
            Novy_button.Text = "Start";
            Novy_button.Size = new Size(150, 75);
            Novy_button.ForeColor = Color.Red;

            this.Controls.Add(Novy_button2);
            Novy_button2.Click += new EventHandler(Fucking_button_Click2);
            Novy_button2.Top = 190;
            Novy_button2.Left = 95;
            Novy_button2.Font = SmallFont;
            Novy_button2.Text = "Settings";
            Novy_button2.Size = new Size(150, 75);
            Novy_button2.ForeColor = Color.Red;

            this.Controls.Add(Novy_button3);
            Novy_button3.Click += new EventHandler(Fucking_button_Click3);
            Novy_button3.Top = 290;
            Novy_button3.Left = 95;
            Novy_button3.Font = SmallFont;
            Novy_button3.Text = "Exit";
            Novy_button3.Size = new Size(150, 75);
            Novy_button3.ForeColor = Color.Red;
            
        }

    }
}
