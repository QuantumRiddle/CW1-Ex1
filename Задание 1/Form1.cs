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
        int s,m = 0;
        int n = 0;
        int select = 0;
        int right = 0;
        int[] right_answ = { 2, 4, 4, 2, 3, 2, 2, 3, 4, 1, 4, 3, 3, 1, 1 };

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            next(n);
        }


        public void next (int n)
        {

            label1.Text = (n+1) + "/15";

            string[] right_answers = {
                "Операционная система", 
                "Оба варианта A и B верны", 
                "System File Checker",        
                "Add or Remove Programs",     
                "Виртуальным помощником",                
                ".exe",                                  
                "Восстанавливает систему до предыдущего состояния", 
                "Место для изменения системных настроек",
                "Windows Chrome",                        
                "Alt + Tab",                             
                "Task Manager",                          
                "Set Priority",                          
                "Режим, который позволяет запускать только основные службы и драйверы", 
                "Disk Cleanup",                          
                "Microsoft Photos"                       
            };

            ;
            string[] questions = {
                "Что такое Windows?",
                "Как открыть диспетчер задач в Windows?",
                "Какая утилита позволяет проверить и восстановить системные файлы Windows?",
                "Как называется программа для удаления программ в Windows?",
                "Чем является 'Cortana' в Windows 10?",
                "Какое расширение файлов используется для исполняемых файлов в Windows?",
                "Что делает функция 'System Restore'?",
                "Что такое 'Control Panel'?",
                "Что из перечисленного не является версией Windows?",
                "Какая комбинация клавиш используется для переключения между открытыми приложениями?",
                "Какой инструмент в Windows позволяет просматривать информацию о железе и его производительности?",
                "Как называется функция, которая позволяет временно усилить приоритет процесса в Windows?",
                "Что такое 'Safe Mode' в Windows?",
                "Какая утилита используется для удаления временных файлов в Windows?",
                "Какое приложение в Windows используется для просмотра фотографий по умолчанию?",
            };


            string[,] questionsAndAnswers = new string[,]
            {
                {"Браузер", "Операционная система", "Программа для видеомонтажа", "Антивирус"},
                {"Ctrl + Shift + Esc", "Ctrl + Alt + Delete", "Alt + F4", "Оба варианта A и B верны"},
                {"Disk Cleanup", "System Restore", "Command Prompt", "System File Checker"},
                {"Program Remover", "Add or Remove Programs", "Windows Uninstaller", "Delete Programs"},
                {"Антивирусом", "Файловым менеджером", "Виртуальным помощником", "Поисковой системой"},
                {".txt", ".exe", ".docx", ".mp3"},
                {"Открывает доступ в интернет", "Восстанавливает систему до предыдущего состояния", "Сканирует диск на наличие вирусов", "Удаляет неиспользуемые файлы"},
                {"Место для управления файлами", "Программа для редактирования текста", "Место для изменения системных настроек", "Инструмент для рисования"},
                {"Windows 95", "Windows XP", "Windows Vista", "Windows Chrome"},
                {"Alt + Tab", "Ctrl + Tab", "Shift + Tab", "Win + Tab"},
                {"Device Manager", "Disk Management", "Resource Monitor", "Task Manager"},
                {"Turbo Boost", "Overclock", "Set Priority", "Quick Access"},
                {"Режим повышенной безопасности", "Режим для быстрого запуска Windows", "Режим, который позволяет запускать только основные службы и драйверы", "Онлайн-сервис от Microsoft"},
                {"Disk Cleanup", "Disk Defragmenter", "CHKDSK", "Format"},
                {"Microsoft Photos", "Windows Viewer", "Paint", "Adobe Photoshop"}
            };

            text_question.Text = questions[n];
            radioButton1.Text = questionsAndAnswers[n, 0];
            radioButton2.Text = questionsAndAnswers[n, 1];
            radioButton3.Text = questionsAndAnswers[n, 2];
            radioButton4.Text = questionsAndAnswers[n, 3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            if (select == right_answ[n])
            {
                right++;               
            }

            select = 0;

            if (n < 14)
            {
                n++;
                next(n);
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show(text: "Вы набрали " + right + "/15 баллов! Время прохождения " + label2.Text );
                n = 0;
                right = 0;
                next(n);
                s = 0;
                m = 0;
                timer1.Enabled = true;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            select = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            select = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            select = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            select = 4;
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
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            
            
            if (s == 60)
            {
                m++;
                s = 0;
            }
            label2.Text = $"{m:00}:{s:00}";


        }
    }
}