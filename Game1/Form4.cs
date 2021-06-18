using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Taariq did this 
namespace Game1
{
    public partial class Form4 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        public Form4()
        {
            InitializeComponent();

            askQuestiom(questionNumber);

            totalQuestions = 10; 

        }

        private void verifyAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if(questionNumber == totalQuestions)
            {
                MessageBox.Show(

                    "Quiz Ended" + Environment.NewLine +
                    "You have answered " + score + " correctly"+ Environment.NewLine+
                    "Press OK to return"
                    );
                score = 0;
                questionNumber = 0;
                askQuestiom(questionNumber);

            }



            questionNumber++;
            askQuestiom(questionNumber);

        }

        private void askQuestiom(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.three;

                    lblQuestions.Text = "What is the pictures above";

                    button1.Text = "Drie";
                    button2.Text = "Twee";
                    button3.Text = "Vyf";
                    button4.Text = "Agt";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.green;

                    lblQuestions.Text = "What is the picture above";

                    button1.Text = "Geel";
                    button2.Text = "Groen";
                    button3.Text = "Swart";
                    button4.Text = "Blou";

                    correctAnswer = 2;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.thirtyfive;

                    lblQuestions.Text = "What is the picture above";

                    button1.Text = "dertig en vyf";
                    button2.Text = "drie end seve";
                    button3.Text = "vyf en dertag";
                    button4.Text = "Thirty five";

                    correctAnswer = 3;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.purple;

                    lblQuestions.Text = "What is the piicture above";

                    button1.Text = "Rooi";
                    button2.Text = "Pienk";
                    button3.Text = "Groen";
                    button4.Text = "Pers";

                    correctAnswer = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.eleven;

                    lblQuestions.Text = "What is the piicture above";

                    button1.Text = "Elf";
                    button2.Text = "Twelf";
                    button3.Text = "Agt";
                    button4.Text = "een en een";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.red;

                    lblQuestions.Text = "What is the picture above";

                    button1.Text = "Blou";
                    button2.Text = "Rooi";
                    button3.Text = "Groen";
                    button4.Text = "Swart";

                    correctAnswer = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.seven;

                    lblQuestions.Text = "What is the picture above";

                    button1.Text = "Twee en dertag";
                    button2.Text = "Nege";
                    button3.Text = "Elf";
                    button4.Text = "Seve";

                    correctAnswer = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.black;

                    lblQuestions.Text = "What is the picture above";

                    button1.Text = "Blou";
                    button2.Text = "Pers";
                    button3.Text = "Swart";
                    button4.Text = "Geel";

                    correctAnswer = 3;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.nine;

                    lblQuestions.Text = "What is the picture above";

                    button1.Text = "Een";
                    button2.Text = "Vier";
                    button3.Text = "Nege";
                    button4.Text = "Tien";

                    correctAnswer = 3;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.blue;

                    lblQuestions.Text = "What is the picture above";

                    button1.Text = "Blou";
                    button2.Text = "Geel";
                    button3.Text = "Groen";
                    button4.Text = "Rooi";

                    correctAnswer = 1;

                    break;
            }

        }
    }
}
