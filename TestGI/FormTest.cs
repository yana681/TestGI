using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGI
{
    public partial class FormTest : Form
    {
        Random rnd = new Random();
        string[] questions = { "2 + 2 * 2", "бревно", "пальцы", "уколы", "свечи" };
        int[] anwers = { 6, 9, 25, 60, 3 };
        int indexQuestion = 0;
        int countRightAnswer = 0;
        string[] diagnose = { "идиот", "кретин", "дурак", "норма", "талант", "гений" };
        int[] orderQuestions = {2, 3, 1, 0, 4}; 

        public FormTest()
        {
            InitializeComponent();
            startTest();
        }

        int[] shuffle()
        {
            int[] temp = {0, 1, 2, 3, 4};
            for (int i = 0; i < 10; i++)
            {
                int ind1 = rnd.Next(0, 5);
                int ind2 = rnd.Next(0, 5);
                int t = temp[ind1];
                temp[ind1] = temp[ind2];
                temp[ind2] = t;
            }
            return temp;
        }

        void startTest()
        {
            orderQuestions = shuffle();
            indexQuestion = 0;
            countRightAnswer = 0;
            labelQuestion.Text = questions[orderQuestions[indexQuestion]];
            labelNumberOfQuestion.Text = "Вопрос №" + (indexQuestion + 1).ToString();
            buttonNewStart.Visible = false;
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (indexQuestion < questions.Length)
            {
                int userAnswer = Convert.ToInt32(textBoxUserAnswer.Text);
                if (userAnswer == anwers[orderQuestions[indexQuestion]])
                    countRightAnswer++;
                indexQuestion++;
                if (indexQuestion < questions.Length)
                {
                    labelQuestion.Text = questions[orderQuestions[indexQuestion]];
                    labelNumberOfQuestion.Text = "Вопрос №" + (indexQuestion + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show(diagnose[countRightAnswer]);
                buttonNewStart.Visible = true;
            }

        }

        private void buttonNewStart_Click(object sender, EventArgs e)
        {
            startTest();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }
    }
}
