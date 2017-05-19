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
using System.IO;

namespace JeopardyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] GameFile = null;

        int currentAnswer = 1000;

        int contestant1Score = 0;
        int contestant2Score = 0;
        int contestant3Score = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            themeMusic();
        }

        private void themeMusic()
        {
            SoundPlayer themeMusic = new SoundPlayer(JeopardyGame.Properties.Resources.themeSong);
            themeMusic.Play();
        }

        private void boardShuffleSound()
        {
            SoundPlayer boardShuffleSound = new SoundPlayer(JeopardyGame.Properties.Resources.boardNoise);
            boardShuffleSound.Play();
        }

        private void PopulateGameFile()
        {
            GameFile = null;

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open Saved File";
            ofd.Filter = "TXT files|*.txt";
            ofd.ShowDialog();

            string filename = ofd.FileName;

            try
            {
                GameFile = File.ReadAllLines(filename);
                label1.Text = filename;
            }

            catch
            {
                MessageBox.Show("No file was selected!");
            }
        }

        private void DisplayAnswer(int number)
        {
            if (number == 1)
                label6.Text = GameFile[0];
            if (number == 2)
                label6.Text = GameFile[1];
            if (number == 3)
                label6.Text = GameFile[2];
            if (number == 4)
                label6.Text = GameFile[3];
            if (number == 5)
                label6.Text = GameFile[4];
            if (number == 6)
                label6.Text = GameFile[5];
            if (number == 7)
                label6.Text = GameFile[6];
            if (number == 8)
                label6.Text = GameFile[7];
            if (number == 9)
                label6.Text = GameFile[8];
            if (number == 10)
                label6.Text = GameFile[9];
            if (number == 11)
                label6.Text = GameFile[10];
            if (number == 12)
                label6.Text = GameFile[11];
            if (number == 13)
                label6.Text = GameFile[12];
            if (number == 14)
                label6.Text = GameFile[13];
            if (number == 15)
                label6.Text = GameFile[14];
            if (number == 16)
                label6.Text = GameFile[15];
            if (number == 17)
                label6.Text = GameFile[16];
            if (number == 18)
                label6.Text = GameFile[17];
            if (number == 19)
                label6.Text = GameFile[18];
            if (number == 20)
                label6.Text = GameFile[19];
            if (number == 21)
                label6.Text = GameFile[20];
            if (number == 22)
                label6.Text = GameFile[21];
            if (number == 23)
                label6.Text = GameFile[22];
            if (number == 24)
                label6.Text = GameFile[23];
            if (number == 25)
                label6.Text = GameFile[24];
            if (number == 26)
                label6.Text = GameFile[25];
            if (number == 27)
                label6.Text = GameFile[26];
            if (number == 28)
                label6.Text = GameFile[27];
            if (number == 29)
                label6.Text = GameFile[28];
            if (number == 30)
                label6.Text = GameFile[29];
        }

        private void showQuestion(int i)
        {
            if (currentAnswer < 1000)
            {
                int temp = i + 30;
                label6.Text = GameFile[temp];
                currentAnswer = 1000;
            }
        }

        private void populateCategories()
        {
            label7.Text = GameFile[60];
            label8.Text = GameFile[61];
            label9.Text = GameFile[62];
            label10.Text = GameFile[63];
            label11.Text = GameFile[64];
            label12.Text = GameFile[65];
        }

        private void setButtonsEnabledToTrue()
        {
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            button41.Enabled = true;
            button42.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateGameFile();
            label6.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                populateCategories();
                setButtonsEnabledToTrue();
                boardShuffleSound();
            }

            catch
            {
                MessageBox.Show("Please choose a file!");
            }

            label6.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showQuestion(currentAnswer);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contestant1Score--;
            label2.Text = contestant1Score.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            contestant1Score++;
            label2.Text = contestant1Score.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            contestant2Score--;
            label3.Text = contestant2Score.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            contestant2Score++;
            label3.Text = contestant2Score.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            contestant3Score--;
            label4.Text = contestant3Score.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            contestant3Score++;
            label4.Text = contestant3Score.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DisplayAnswer(1);
            currentAnswer = 0;
            button13.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DisplayAnswer(2);
            currentAnswer = 1;
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DisplayAnswer(3);
            currentAnswer = 2;
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DisplayAnswer(4);
            currentAnswer = 03;
            button16.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DisplayAnswer(5);
            currentAnswer = 4;
            button17.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DisplayAnswer(6);
            currentAnswer = 5;
            button18.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DisplayAnswer(7);
            currentAnswer = 6;
            button19.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DisplayAnswer(8);
            currentAnswer = 7;
            button20.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DisplayAnswer(9);
            currentAnswer = 8;
            button21.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DisplayAnswer(10);
            currentAnswer = 9;
            button22.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DisplayAnswer(11);
            currentAnswer = 10;
            button23.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DisplayAnswer(12);
            currentAnswer = 11;
            button24.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DisplayAnswer(13);
            currentAnswer = 12;
            button25.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            DisplayAnswer(14);
            currentAnswer = 13;
            button26.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            DisplayAnswer(15);
            currentAnswer = 14;
            button27.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            DisplayAnswer(16);
            currentAnswer = 15;
            button28.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            DisplayAnswer(17);
            currentAnswer = 16;
            button29.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            DisplayAnswer(18);
            currentAnswer = 17;
            button30.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            DisplayAnswer(19);
            currentAnswer = 18;
            button31.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            DisplayAnswer(20);
            currentAnswer = 19;
            button32.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            DisplayAnswer(21);
            currentAnswer = 20;
            button33.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            DisplayAnswer(22);
            currentAnswer = 21;
            button34.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            DisplayAnswer(23);
            currentAnswer = 22;
            button35.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            DisplayAnswer(24);
            currentAnswer = 23;
            button36.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            DisplayAnswer(25);
            currentAnswer = 24;
            button37.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            DisplayAnswer(26);
            currentAnswer = 25;
            button38.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            DisplayAnswer(27);
            currentAnswer = 26;
            button39.Enabled = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            DisplayAnswer(28);
            currentAnswer = 27;
            button40.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            DisplayAnswer(29);
            currentAnswer = 28;
            button41.Enabled = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            DisplayAnswer(30);
            currentAnswer = 29;
            button42.Enabled = false;
        }
    }
}
