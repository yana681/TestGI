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
        List<ClassQuection> listQ = new List<ClassQuection>();
        
        Random rnd = new Random();
        int indexQuestion = 0;
        int countRightAnswer = 0;
        string[] diagnose = { "идиот", "кретин", "дурак", "норма", "талант", "гений" };
        int[] orderQuestions = {2, 3, 1, 0, 4}; 

        public FormTest()
        {
            InitializeComponent();
            //startTest();
            ClassQuection q1 = new ClassQuection("2 + 2 * 2", 6);
            listQ.Add(q1);
            ClassQuection q2 = new ClassQuection("Бревно нужно распелить на 10 ч сколько сделать распилов", 9);
            listQ.Add(q2);
            ClassQuection q3 = new ClassQuection("на двух руках 10 пб сколько п на 10 руках", 25);
            listQ.Add(q3);
            listQ.Add(new ClassQuection("Укол делают каждые полчаса сколько нужно минут на 3 укола ", 60));
            listQ.Add(new ClassQuection("77+12", 65));
            labelQuestion.Text = listQ[0].ToString();
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
            labelQuestion.Text = listQ[orderQuestions[indexQuestion]].ToString();
            labelNumberOfQuestion.Text = "Вопрос №" + (indexQuestion + 1).ToString();
            buttonNewStart.Visible = false;
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (indexQuestion < listQ.Count)
            {
                int userAnswer = Convert.ToInt32(textBoxUserAnswer.Text);
                if (listQ[orderQuestions[indexQuestion]].checkA(userAnswer))
                    countRightAnswer++;
                indexQuestion++;
                if (indexQuestion < listQ.Count)
                {
                    labelQuestion.Text = listQ[orderQuestions[indexQuestion]].ToString();
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
