using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";

            textBox2.Text = "";
            label2.Text = "";

            textBox3.Text = "";
            label3.Text = "";

            textBox4.Text = "";
            label4.Text = "";

            textBox5.Text = "";
            label5.Text = "";

            textBox6.Text = "";
            label6.Text = "";

            textBox7.Text = "";
            label7.Text = "";

            textBox8.Text = "";
            label8.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            var test = textBox1.Text.ToString();

            //中音
            if (test.Equals("1"))
            {
                label1.Text = "A";
            }
            if (test.Equals("2"))
            {
                label1.Text = "S";
            }
            if (test.Equals("3"))
            {
                label1.Text = "D";
            }
            if (test.Equals("4"))
            {
                label1.Text = "F";
            }
            if (test.Equals("5"))
            {
                label1.Text = "G";
            }
            if (test.Equals("6"))
            {
                label1.Text = "H";
            }
            if (test.Equals("7"))
            {
                label1.Text = "J";
            }

            // 高音
            if (test.Equals("11"))
            {
                label1.Text = "Q";
            }
            if (test.Equals("12"))
            {
                label1.Text = "W";
            }
            if (test.Equals("13"))
            {
                label1.Text = "E";
            }
            if (test.Equals("14"))
            {
                label1.Text = "R";
            }
            if (test.Equals("15"))
            {
                label1.Text = "T";
            }
            if (test.Equals("16"))
            {
                label1.Text = "Y";
            }
            if (test.Equals("17"))
            {
                label1.Text = "U";
            }

            //低音
            if (test.Equals("01"))
            {
                label1.Text = "Z";
            }
            if (test.Equals("02"))
            {
                label1.Text = "X";
            }
            if (test.Equals("03"))
            {
                label1.Text = "C";
            }
            if (test.Equals("04"))
            {
                label1.Text = "V";
            }
            if (test.Equals("05"))
            {
                label1.Text = "B";
            }
            if (test.Equals("06"))
            {
                label1.Text = "N";
            }
            if (test.Equals("07"))
            {
                label1.Text = "M";
            }



        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var test = textBox2.Text.ToString();

            //中音
            if (test.Equals("1"))
            {
                label2.Text = "A";
            }
            if (test.Equals("2"))
            {
                label2.Text = "S";
            }
            if (test.Equals("3"))
            {
                label2.Text = "D";
            }
            if (test.Equals("4"))
            {
                label2.Text = "F";
            }
            if (test.Equals("5"))
            {
                label2.Text = "G";
            }
            if (test.Equals("6"))
            {
                label2.Text = "H";
            }
            if (test.Equals("7"))
            {
                label2.Text = "J";
            }

            // 高音
            if (test.Equals("11"))
            {
                label2.Text = "Q";
            }
            if (test.Equals("12"))
            {
                label2.Text = "W";
            }
            if (test.Equals("13"))
            {
                label2.Text = "E";
            }
            if (test.Equals("14"))
            {
                label2.Text = "R";
            }
            if (test.Equals("15"))
            {
                label2.Text = "T";
            }
            if (test.Equals("16"))
            {
                label2.Text = "Y";
            }
            if (test.Equals("17"))
            {
                label2.Text = "U";
            }

            //低音
            if (test.Equals("01"))
            {
                label2.Text = "Z";
            }
            if (test.Equals("02"))
            {
                label2.Text = "X";
            }
            if (test.Equals("03"))
            {
                label2.Text = "C";
            }
            if (test.Equals("04"))
            {
                label2.Text = "V";
            }
            if (test.Equals("05"))
            {
                label2.Text = "B";
            }
            if (test.Equals("06"))
            {
                label2.Text = "N";
            }
            if (test.Equals("07"))
            {
                label2.Text = "M";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var test = textBox3.Text.ToString();

            //中音
            if (test.Equals("1"))
            {
                label3.Text = "A";
            }
            if (test.Equals("2"))
            {
                label3.Text = "S";
            }
            if (test.Equals("3"))
            {
                label3.Text = "D";
            }
            if (test.Equals("4"))
            {
                label3.Text = "F";
            }
            if (test.Equals("5"))
            {
                label3.Text = "G";
            }
            if (test.Equals("6"))
            {
                label3.Text = "H";
            }
            if (test.Equals("7"))
            {
                label3.Text = "J";
            }

            // 高音
            if (test.Equals("11"))
            {
                label3.Text = "Q";
            }
            if (test.Equals("12"))
            {
                label3.Text = "W";
            }
            if (test.Equals("13"))
            {
                label3.Text = "E";
            }
            if (test.Equals("14"))
            {
                label3.Text = "R";
            }
            if (test.Equals("15"))
            {
                label3.Text = "T";
            }
            if (test.Equals("16"))
            {
                label3.Text = "Y";
            }
            if (test.Equals("17"))
            {
                label3.Text = "U";
            }

            //低音
            if (test.Equals("01"))
            {
                label3.Text = "Z";
            }
            if (test.Equals("02"))
            {
                label3.Text = "X";
            }
            if (test.Equals("03"))
            {
                label3.Text = "C";
            }
            if (test.Equals("04"))
            {
                label3.Text = "V";
            }
            if (test.Equals("05"))
            {
                label3.Text = "B";
            }
            if (test.Equals("06"))
            {
                label3.Text = "N";
            }
            if (test.Equals("07"))
            {
                label3.Text = "M";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var test = textBox4.Text.ToString();

            //中音
            if (test.Equals("1"))
            {
                label4.Text = "A";
            }
            if (test.Equals("2"))
            {
                label4.Text = "S";
            }
            if (test.Equals("3"))
            {
                label4.Text = "D";
            }
            if (test.Equals("4"))
            {
                label4.Text = "F";
            }
            if (test.Equals("5"))
            {
                label4.Text = "G";
            }
            if (test.Equals("6"))
            {
                label4.Text = "H";
            }
            if (test.Equals("7"))
            {
                label4.Text = "J";
            }

            // 高音
            if (test.Equals("11"))
            {
                label4.Text = "Q";
            }
            if (test.Equals("12"))
            {
                label4.Text = "W";
            }
            if (test.Equals("13"))
            {
                label4.Text = "E";
            }
            if (test.Equals("14"))
            {
                label4.Text = "R";
            }
            if (test.Equals("15"))
            {
                label4.Text = "T";
            }
            if (test.Equals("16"))
            {
                label4.Text = "Y";
            }
            if (test.Equals("17"))
            {
                label4.Text = "U";
            }

            //低音
            if (test.Equals("01"))
            {
                label4.Text = "Z";
            }
            if (test.Equals("02"))
            {
                label4.Text = "X";
            }
            if (test.Equals("03"))
            {
                label4.Text = "C";
            }
            if (test.Equals("04"))
            {
                label4.Text = "V";
            }
            if (test.Equals("05"))
            {
                label4.Text = "B";
            }
            if (test.Equals("06"))
            {
                label4.Text = "N";
            }
            if (test.Equals("07"))
            {
                label4.Text = "M";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var test = textBox5.Text.ToString();

            //中音
            if (test.Equals("1"))
            {
                label5.Text = "A";
            }
            if (test.Equals("2"))
            {
                label5.Text = "S";
            }
            if (test.Equals("3"))
            {
                label5.Text = "D";
            }
            if (test.Equals("4"))
            {
                label5.Text = "F";
            }
            if (test.Equals("5"))
            {
                label5.Text = "G";
            }
            if (test.Equals("6"))
            {
                label5.Text = "H";
            }
            if (test.Equals("7"))
            {
                label5.Text = "J";
            }

            // 高音
            if (test.Equals("11"))
            {
                label5.Text = "Q";
            }
            if (test.Equals("12"))
            {
                label5.Text = "W";
            }
            if (test.Equals("13"))
            {
                label5.Text = "E";
            }
            if (test.Equals("14"))
            {
                label5.Text = "R";
            }
            if (test.Equals("15"))
            {
                label5.Text = "T";
            }
            if (test.Equals("16"))
            {
                label5.Text = "Y";
            }
            if (test.Equals("17"))
            {
                label5.Text = "U";
            }

            //低音
            if (test.Equals("01"))
            {
                label5.Text = "Z";
            }
            if (test.Equals("02"))
            {
                label5.Text = "X";
            }
            if (test.Equals("03"))
            {
                label5.Text = "C";
            }
            if (test.Equals("04"))
            {
                label5.Text = "V";
            }
            if (test.Equals("05"))
            {
                label5.Text = "B";
            }
            if (test.Equals("06"))
            {
                label5.Text = "N";
            }
            if (test.Equals("07"))
            {
                label5.Text = "M";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var test = textBox6.Text.ToString();

            //中音
            if (test.Equals("1"))
            {
                label6.Text = "A";
            }
            if (test.Equals("2"))
            {
                label6.Text = "S";
            }
            if (test.Equals("3"))
            {
                label6.Text = "D";
            }
            if (test.Equals("4"))
            {
                label6.Text = "F";
            }
            if (test.Equals("5"))
            {
                label6.Text = "G";
            }
            if (test.Equals("6"))
            {
                label6.Text = "H";
            }
            if (test.Equals("7"))
            {
                label6.Text = "J";
            }

            // 高音
            if (test.Equals("11"))
            {
                label6.Text = "Q";
            }
            if (test.Equals("12"))
            {
                label6.Text = "W";
            }
            if (test.Equals("13"))
            {
                label6.Text = "E";
            }
            if (test.Equals("14"))
            {
                label6.Text = "R";
            }
            if (test.Equals("15"))
            {
                label6.Text = "T";
            }
            if (test.Equals("16"))
            {
                label6.Text = "Y";
            }
            if (test.Equals("17"))
            {
                label6.Text = "U";
            }

            //低音
            if (test.Equals("01"))
            {
                label6.Text = "Z";
            }
            if (test.Equals("02"))
            {
                label6.Text = "X";
            }
            if (test.Equals("03"))
            {
                label6.Text = "C";
            }
            if (test.Equals("04"))
            {
                label6.Text = "V";
            }
            if (test.Equals("05"))
            {
                label6.Text = "B";
            }
            if (test.Equals("06"))
            {
                label6.Text = "N";
            }
            if (test.Equals("07"))
            {
                label6.Text = "M";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            var test = textBox7.Text.ToString();

            //中音
            if (test.Equals("1"))
            {
                label7.Text = "A";
            }
            if (test.Equals("2"))
            {
                label7.Text = "S";
            }
            if (test.Equals("3"))
            {
                label7.Text = "D";
            }
            if (test.Equals("4"))
            {
                label7.Text = "F";
            }
            if (test.Equals("5"))
            {
                label7.Text = "G";
            }
            if (test.Equals("6"))
            {
                label7.Text = "H";
            }
            if (test.Equals("7"))
            {
                label7.Text = "J";
            }

            // 高音
            if (test.Equals("11"))
            {
                label7.Text = "Q";
            }
            if (test.Equals("12"))
            {
                label7.Text = "W";
            }
            if (test.Equals("13"))
            {
                label7.Text = "E";
            }
            if (test.Equals("14"))
            {
                label7.Text = "R";
            }
            if (test.Equals("15"))
            {
                label7.Text = "T";
            }
            if (test.Equals("16"))
            {
                label7.Text = "Y";
            }
            if (test.Equals("17"))
            {
                label7.Text = "U";
            }

            //低音
            if (test.Equals("01"))
            {
                label7.Text = "Z";
            }
            if (test.Equals("02"))
            {
                label7.Text = "X";
            }
            if (test.Equals("03"))
            {
                label7.Text = "C";
            }
            if (test.Equals("04"))
            {
                label7.Text = "V";
            }
            if (test.Equals("05"))
            {
                label7.Text = "B";
            }
            if (test.Equals("06"))
            {
                label7.Text = "N";
            }
            if (test.Equals("07"))
            {
                label7.Text = "M";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            var test = textBox8.Text.ToString();

            //中音
            if (test.Equals("1"))
            {
                label8.Text = "A";
            }
            if (test.Equals("2"))
            {
                label8.Text = "S";
            }
            if (test.Equals("3"))
            {
                label8.Text = "D";
            }
            if (test.Equals("4"))
            {
                label8.Text = "F";
            }
            if (test.Equals("5"))
            {
                label8.Text = "G";
            }
            if (test.Equals("6"))
            {
                label8.Text = "H";
            }
            if (test.Equals("7"))
            {
                label8.Text = "J";
            }

            // 高音
            if (test.Equals("11"))
            {
                label8.Text = "Q";
            }
            if (test.Equals("12"))
            {
                label8.Text = "W";
            }
            if (test.Equals("13"))
            {
                label8.Text = "E";
            }
            if (test.Equals("14"))
            {
                label8.Text = "R";
            }
            if (test.Equals("15"))
            {
                label8.Text = "T";
            }
            if (test.Equals("16"))
            {
                label8.Text = "Y";
            }
            if (test.Equals("17"))
            {
                label8.Text = "U";
            }

            //低音
            if (test.Equals("01"))
            {
                label8.Text = "Z";
            }
            if (test.Equals("02"))
            {
                label8.Text = "X";
            }
            if (test.Equals("03"))
            {
                label8.Text = "C";
            }
            if (test.Equals("04"))
            {
                label8.Text = "V";
            }
            if (test.Equals("05"))
            {
                label8.Text = "B";
            }
            if (test.Equals("06"))
            {
                label8.Text = "N";
            }
            if (test.Equals("07"))
            {
                label8.Text = "M";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }


    }


