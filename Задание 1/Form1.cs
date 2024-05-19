using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        int n = 0;
        int seclect = 0;
        int right = 0;
        int[] right_answ = {3,4,2,4,2,2,1,3,2,2,1,3,2,4,4};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            next(n);
        }
        

        public void next (int n)
        {   
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            label1.Text = (n+1) + "/15";

            string[] right_answers = {
                "Условное обозначение данных", "Java", "equals()", "if", "private", "Сокрытие деталей реализации", "map()", "PostgreSQL", "GET", "Quick sort", "Singleton", "new", "React", "[1, 2, 3, 4, 5]", @"""1020"""
            };

            ;
            string[] questions = {
                "Что такое переменная в программировании?",
                "Какой язык программирования является строго типизированным?",
                "Какой метод в Java используется для сравнения строк?",
                "Что из следующего не является циклом?",
                "Какой спецификатор доступа в Java делает члены класса доступными только внутри того же класса?",
                "Что такое инкапсуляция?",
                "Какая функция JavaScript создает новый массив, применяя заданную функцию к каждому элементу исходного массива?",
                "Какая база данных является реляционной?",
                "Какой HTTP метод используется для получения данных с сервера?",
                "Что из перечисленного является алгоритмом сортировки?",
                "Какой паттерн проектирования подразумевает создание одного экземпляра класса?",
                "Какое ключевое слово в C# используется для создания экземпляра объекта?",
                "Какая библиотека в JavaScript часто используется для построения пользовательских интерфейсов?",
                "Как в Python создать список чисел от 1 до 5?",
                "Чему равна переменная x после выполнения следующего кода JavaScript: var x = 10 + '20';?"
            };


            string[,] questionsAndAnswers = new string[,]
            {
                {"Инструкция", "Устройство хранения данных", "Условное обозначение данных", "Тип данных"},
                {"Python", "JavaScript", "PHP", "Java"},
                {"compare()", "equals()", "isEqual()", "compareTo()"},
                {"for", "while", "do-while", "if"},
                {"public", "private", "protected", "default"},
                {"Процесс перенаправления вызова функции", "Сокрытие деталей реализации", "Механизм наследования классов", "Разделение программы на модули"},
                {"map()", "filter()", "reduce()", "forEach()"},
                {"MongoDB", "Redis", "PostgreSQL", "Cassandra"},
                {"POST", "GET", "PUT", "DELETE"},
                {"Binary search", "Quick sort", "First-in-first-out (FIFO)", "Secure Socket Layer (SSL)"},
                {"Singleton", "Adapter", "Observer", "Decorator"},
                {"struct", "class", "new", "this"},
                {"jQuery", "React", "Lodash", "Axios"},
                {"list(1, 5)", "[1, 5]", "range(1, 6)", "[1, 2, 3, 4, 5]"},
                {"30", "1020", "30", @"""1020"""}
            };

            text_question.Text = questions[n];
            radioButton1.Text = questionsAndAnswers[n, 0];
            radioButton2.Text = questionsAndAnswers[n, 1];
            radioButton3.Text = questionsAndAnswers[n, 2];
            radioButton4.Text = questionsAndAnswers[n, 3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            if (seclect == right_answ[n])
            {
                right++;
            }
            if (n < 14)
            {
                n++;
                next(n);
            }
            else
            {
                MessageBox.Show(text: "Вы набрали " + right + "/15 баллов!");
                n = 0;
                right = 0;
                next(n);

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            seclect = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            seclect = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            seclect = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            seclect = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n--;
                next(n);
            }
            if (right > 0)
            {
                right--;
            }
        }
    }
}