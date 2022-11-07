using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_12
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void HSVBoxColoring()
        {
            var imaginaryHSV = Logic.getImaginaryHSV(double.Parse(textBoxH.Text), double.Parse(textBoxS.Text), double.Parse(textBoxV.Text));
            pictureBoxHSV.BackColor = Color.FromArgb(255, imaginaryHSV.R(), imaginaryHSV.G(), imaginaryHSV.B());
        }

        private string checkBoxRange(string text, int min, int max)
        {
            if (text.Length > 0)
            {
                try
                {
                    double value = double.Parse(text);
                    if (value < min || value > max)
                    {
                        MessageBox.Show("Значение текущего поля не может быть меньше " + min + " или больше " + max + " !!!");
                        return "0";
                    }
                    else
                    {
                        return text;
                    }
                }
                catch(FormatException) {
                    MessageBox.Show("Вводите только цифры, пожалуйста");
                    return "0";
                }
            }
            else
            {
                return "0";
            }
        }

        private void RTextChanged(object sender, EventArgs e)
        {
            textBoxR.Text = checkBoxRange(textBoxR.Text, 0 , 255);
            pictureBoxRGB.BackColor = Color.FromArgb(255,int.Parse(textBoxR.Text), int.Parse(textBoxG.Text), int.Parse(textBoxB.Text));
        }

        private void gTextChanged(object sender, EventArgs e)
        {
            textBoxG.Text = checkBoxRange(textBoxG.Text, 0, 255);
            pictureBoxRGB.BackColor = Color.FromArgb(255, int.Parse(textBoxR.Text), int.Parse(textBoxG.Text), int.Parse(textBoxB.Text));
        }

        private void bTextChanged(object sender, EventArgs e)
        {
            textBoxB.Text = checkBoxRange(textBoxB.Text, 0, 255);
            pictureBoxRGB.BackColor = Color.FromArgb(255, int.Parse(textBoxR.Text), int.Parse(textBoxG.Text), int.Parse(textBoxB.Text));
        }

        private void HTextChanged(object sender, EventArgs e)
        {
            textBoxH.Text = checkBoxRange(textBoxH.Text, 0, 360);
            HSVBoxColoring();
        }

        private void STextChanged(object sender, EventArgs e)
        {
            textBoxS.Text = checkBoxRange(textBoxS.Text, 0, 1);
            HSVBoxColoring();
        }

        private void VTextChanged(object sender, EventArgs e)
        {
            textBoxV.Text = checkBoxRange(textBoxV.Text, 0, 1);
            HSVBoxColoring();
        }

        private void fillHSVForm(HSV hsv)
        {
            textBoxH.Text = "" + hsv.HUE();
            textBoxS.Text = "" + hsv.SAT();
            textBoxV.Text = "" + hsv.VAL();
        }
            private void fillRGBForm(RGB rgb)
        {
            textBoxR.Text = "" + rgb.R();
            textBoxG.Text = "" + rgb.G();
            textBoxB.Text = "" + rgb.B();
        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            var imagHSV = new RGB(double.Parse(textBoxH.Text), double.Parse(textBoxS.Text), double.Parse(textBoxV.Text));
            var tempRGB = new RGB(int.Parse(textBoxR.Text), int.Parse(textBoxG.Text), int.Parse(textBoxB.Text));
            tempRGB += new Red(imagHSV.R());
            tempRGB += new Green(imagHSV.G());
            tempRGB += new Blue(imagHSV.B());
            var tempHSV = new HSV(tempRGB.R(), tempRGB.G(), tempRGB.B());
            fillHSVForm(tempHSV);
            fillRGBForm(tempRGB);
            HSVBoxColoring();
            pictureBoxRGB.BackColor = pictureBoxHSV.BackColor;
        }

        private void buttonRGBToHSV_Click(object sender, EventArgs e)
        {
            HSV tempHSV = new HSV(int.Parse(textBoxR.Text), int.Parse(textBoxG.Text), int.Parse(textBoxB.Text));
            fillHSVForm(tempHSV);
            HSVBoxColoring();
        }

        private void buttonHSVToRGB_Click(object sender, EventArgs e)
        {
            var tempRGB = new RGB(double.Parse(textBoxH.Text), double.Parse(textBoxS.Text), double.Parse(textBoxV.Text));
            fillRGBForm(tempRGB);
            pictureBoxRGB.BackColor = Color.FromArgb(255, tempRGB.R(), tempRGB.G(), tempRGB.B());
        }
    }
}
