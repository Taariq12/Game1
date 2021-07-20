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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoadLevelOne(object sender, EventArgs e)
        {
            Form4 gameWindow = new Form4();

            gameWindow.Show();
        }

        private void LoadLevelTwo(object sender, EventArgs e)
        {
            Form1 gameWindow = new Form1();

            gameWindow.Show();
        }

        private void LoadLevelThree(object sender, EventArgs e)
        {

            Form6 gameWindow = new Form6();

            gameWindow.Show();

        }

        private void loadHelp(object sender, EventArgs e)
        {
            Form3 helpWindow = new Form3();

            helpWindow.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
