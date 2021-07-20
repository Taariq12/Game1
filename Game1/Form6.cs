using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Umar did this
namespace Game1
{
    public partial class Form6 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        public Form6()
        {
            InitializeComponent();

            askQuestiom(questionNumber);

            totalQuestions = 10;
        }

        private void verifyAnswersEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                MessageBox.Show(

                    "Quiz Ended" + Environment.NewLine +
                    "You have answered " + score + " correctly" + Environment.NewLine +
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
                    pictureBox1.Image = Properties.Resources.crying;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die baba lag";
                    button2.Text = "Die baba huil";
                    button3.Text = "Die kind huil";
                    button4.Text = "Die meisie lag";

                    correctAnswer = 2;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.fighting;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die twee meisies baklei";
                    button2.Text = "Die twee mans baklei";
                    button3.Text = "Die twee seuns baklei";
                    button4.Text = "Die twee mans baklei";

                    correctAnswer = 3;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.flying;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die seun loop";
                    button2.Text = "Die meisie vlieg";
                    button3.Text = "Dien seun vlieg";
                    button4.Text = "Die vrou loop";

                    correctAnswer = 3;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.laughing;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die meisie lag";
                    button2.Text = "Die vrou Lag";
                    button3.Text = "Die seun lag";
                    button4.Text = "Die baba lag";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.sitting;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die vrou sit";
                    button2.Text = "Die man sit";
                    button3.Text = "Die baba sit";
                    button4.Text = "Die ouma sit";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.laying;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die hond le";
                    button2.Text = "Die kat le";
                    button3.Text = "Die beer le";
                    button4.Text = "Die dra le";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.playing;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die seuns speel sokker";
                    button2.Text = "Die seuns skop die bal";
                    button3.Text = "Die measies speel sokker";
                    button4.Text = "Die mans speel skop die bal";

                    correctAnswer = 1;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.reading;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die vrou lees n' book ";
                    button2.Text = "Die meisie lees n' book";
                    button3.Text = "Die seun lees n' book";
                    button4.Text = "Die man lees n' book";

                    correctAnswer = 2;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.running;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die se un hardloop";
                    button2.Text = "Die vrou hardloop";
                    button3.Text = "Die mesie hardloop";
                    button4.Text = "Die man hardloop";

                    correctAnswer = 4;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.skipping;

                    lblQuestions.Text = "What is happening in the pictures above";

                    button1.Text = "Die kinders skip";
                    button2.Text = "Die kinders spring";
                    button3.Text = "Die kinders oorslaan";
                    button4.Text = "Die kinders speel";

                    correctAnswer = 3;

                    break;

            }
        }
    }
}

