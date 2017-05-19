using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JeopardyGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = "C:\\Users\\" + Environment.UserName.ToString() + "\\Desktop\\" + textBox1.Text + ".txt";
            LoadArray(n);
            this.Close();
        }

        private void LoadArray(string filename)
        {
            string[] lines = new string[66];
            string s = null;

            for (int i = 0; i < 66; i++)
            {
                if (i == 0)
                    s = textBox2.Text;
                if (i == 1)
                    s = textBox3.Text;
                if (i == 2)
                    s = textBox4.Text;
                if (i == 3)
                    s = textBox5.Text;
                if (i == 4)
                    s = textBox6.Text;
                if (i == 5)
                    s = textBox7.Text;
                if (i == 6)
                    s = textBox8.Text;
                if (i == 7)
                    s = textBox9.Text;
                if (i == 8)
                    s = textBox10.Text;
                if (i == 9)
                    s = textBox11.Text;
                if (i == 10)
                    s = textBox12.Text;
                if (i == 11)
                    s = textBox13.Text;
                if (i == 12)
                    s = textBox14.Text;
                if (i == 13)
                    s = textBox15.Text;
                if (i == 14)
                    s = textBox16.Text;
                if (i == 15)
                    s = textBox17.Text;
                if (i == 16)
                    s = textBox18.Text;
                if (i == 17)
                    s = textBox19.Text;
                if (i == 18)
                    s = textBox20.Text;
                if (i == 19)
                    s = textBox21.Text;
                if (i == 20)
                    s = textBox22.Text;
                if (i == 21)
                    s = textBox23.Text;
                if (i == 22)
                    s = textBox24.Text;
                if (i == 23)
                    s = textBox25.Text;
                if (i == 24)
                    s = textBox26.Text;
                if (i == 25)
                    s = textBox27.Text;
                if (i == 26)
                    s = textBox28.Text;
                if (i == 27)
                    s = textBox29.Text;
                if (i == 28)
                    s = textBox30.Text;
                if (i == 29)
                    s = textBox31.Text;
                if (i == 30)
                    s = textBox32.Text;
                if (i == 31)
                    s = textBox33.Text;
                if (i == 32)
                    s = textBox34.Text;
                if (i == 33)
                    s = textBox35.Text;
                if (i == 34)
                    s = textBox36.Text;
                if (i == 35)
                    s = textBox37.Text;
                if (i == 36)
                    s = textBox38.Text;
                if (i == 37)
                    s = textBox39.Text;
                if (i == 38)
                    s = textBox40.Text;
                if (i == 39)
                    s = textBox41.Text;
                if (i == 40)
                    s = textBox42.Text;
                if (i == 41)
                    s = textBox43.Text;
                if (i == 42)
                    s = textBox44.Text;
                if (i == 43)
                    s = textBox45.Text;
                if (i == 44)
                    s = textBox46.Text;
                if (i == 45)
                    s = textBox47.Text;
                if (i == 46)
                    s = textBox48.Text;
                if (i == 47)
                    s = textBox49.Text;
                if (i == 48)
                    s = textBox50.Text;
                if (i == 49)
                    s = textBox51.Text;
                if (i == 50)
                    s = textBox52.Text;
                if (i == 51)
                    s = textBox53.Text;
                if (i == 52)
                    s = textBox54.Text;
                if (i == 53)
                    s = textBox55.Text;
                if (i == 54)
                    s = textBox56.Text;
                if (i == 55)
                    s = textBox57.Text;
                if (i == 56)
                    s = textBox58.Text;
                if (i == 57)
                    s = textBox59.Text;
                if (i == 58)
                    s = textBox60.Text;
                if (i == 59)
                    s = textBox61.Text;
                if (i == 60)
                    s = textBox62.Text;
                if (i == 61)
                    s = textBox63.Text;
                if (i == 62)
                    s = textBox64.Text;
                if (i == 63)
                    s = textBox65.Text;
                if (i == 64)
                    s = textBox66.Text;
                if (i == 65)
                    s = textBox67.Text;

                lines[i] = s;
            }

            File.WriteAllLines(filename, lines);
        }
    }
}
