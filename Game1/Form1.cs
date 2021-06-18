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
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;
        }
        //Taariq did this
        private void verifyAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }
            if(questionNumber == totalQuestions)
            {
                MessageBox.Show(
                    "Quiz Ended" + Environment.NewLine +
                    "You have answered " +score + " correctly"+ Environment.NewLine +
                    "Press OK to go back"

                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }


            questionNumber++;
            askQuestion(questionNumber);
        }
        //Umar did this
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.fridge;

                    lblQuestions.Text = "Choose the correct spelling of the image above";

                    button1.Text = "Yskas";
                    button2.Text = "Uiskes";
                    button3.Text = "Yskes";
                    button4.Text = "Uyskas";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.basket;

                    lblQuestions.Text = "Choose the correct spelling of the image above";

                    button1.Text = "Manchie";
                    button2.Text = "Munchie";
                    button3.Text = "Basket";
                    button4.Text = "Mandjie";

                    correctAnswer = 4;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.bed;

                    lblQuestions.Text = "What is the above object";

                    button1.Text = "Tafel";
                    button2.Text = "Stool";
                    button3.Text = "Bed";
                    button4.Text = "kooi";

                    correctAnswer = 4;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.chair;

                    lblQuestions.Text = "What is the above object";

                    button1.Text = "Kooi";
                    button2.Text = "Stool";
                    button3.Text = "Floor";
                    button4.Text = "Venster";

                    correctAnswer = 2;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.clock;

                    lblQuestions.Text = "Choose the correct spelling of the image above";

                    button1.Text = "klok";
                    button2.Text = "Cloc";
                    button3.Text = "clock";
                    button4.Text = "klock";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.door;

                    lblQuestions.Text = "Choose the correct spelling of the image above";

                    button1.Text = "Deer";
                    button2.Text = "Duur";
                    button3.Text = "Deur";
                    button4.Text = "Duier";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.kettle;

                    lblQuestions.Text = "What is the above object";

                    button1.Text = "Stoof";
                    button2.Text = "Stool";
                    button3.Text = "Ketel";
                    button4.Text = "Mundjie";

                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.table;

                    lblQuestions.Text = "Choose the correct spelling of the image above";

                    button1.Text = "Tafel";
                    button2.Text = "Taafil";
                    button3.Text = "Tafil";
                    button4.Text = "Taffel";

                    correctAnswer = 1;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.window;

                    lblQuestions.Text = "What is the above object";

                    button1.Text = "Mundjie";
                    button2.Text = "Venster";
                    button3.Text = "Yskas";
                    button4.Text = "Klock";

                    correctAnswer = 2;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.stove;

                    lblQuestions.Text = "What is the above object";

                    button1.Text = "Klock";
                    button2.Text = "Ketel";
                    button3.Text = "Venster";
                    button4.Text = "Stoof";

                    correctAnswer = 4;

                    break;
            }
        }
    }
}
