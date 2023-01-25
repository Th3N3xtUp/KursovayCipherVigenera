using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vizhener1
{
    public partial class Shifr : Form
    {
        public Shifr()
        {
            InitializeComponent();
        }

        private void ShifrButton_Click(object sender, EventArgs e)
        {
       
            string kluch = kluchBox.Text;                   //ввод ключа в текстбокс
            string mainalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";    //алфавиты
            string znakalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.!?;'':<>/(){}[] ";
            string checkalf = "";
            if (radioButton1.Checked)                                                               //проверка на выбор одного слова или предложения
            {
                checkalf = mainalf;

            }
            else
            {
                checkalf = znakalf;
            }

            string slovo = VvodBox.Text;               //ввод текста для дальнейшей работы с ним 
            string[] newslovo = new string[slovo.Length];
            Alfavit shif = new Alfavit(kluch, slovo, checkalf);      //обрашение к классу
            int[] a = new int[kluch.Length];
            a = shif.funckluch(kluch, checkalf, a);       // присваивание переменной а ключа
            newslovo = shif.funcshifr(slovo, checkalf, a, newslovo);        // присваивание переменной newslovo зашифрованное значение 
            string vivod = "";
            for (int i = 0; i < slovo.Length; i++)
            {
                vivod = vivod + newslovo[i];           // вывод зашифрованного слова
            }
            VivodBox.Text = vivod;

        }

        private void UnshufrButton_Click(object sender, EventArgs e)
        {
        
            string kluch = kluchBox.Text;
            string mainalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string znakalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.!?;'':<>/(){}[] ";
            string checkalf = "";
            if (radioButton1.Checked)
            {
                checkalf = mainalf;

            }
            else
            {
                checkalf = znakalf;
            }

            string slovo = VvodBox.Text;
            string[] newslovo = new string[slovo.Length];
            Alfavit shif = new Alfavit(kluch, slovo, checkalf);
            int[] a = new int[kluch.Length];
            a = shif.funckluch(kluch, checkalf, a);
            newslovo = shif.funcunshifr(slovo, checkalf, a, newslovo);         // присваивание переменной newslovo разшифрованное значение 
            string vivod = "";
            for (int i = 0; i < slovo.Length; i++)
            {
                vivod = vivod + newslovo[i];                  // вывод разшифрованного слова
            }
            VivodBox.Text = vivod;

            
        }

        private void button1_Click(object sender, EventArgs e)     //реализация сохранения файла
        {
            {
               if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                   return;

                string filename = saveFileDialog1.FileName;
               
                System.IO.File.WriteAllText(filename, VivodBox.Text);
                MessageBox.Show("Файл сохранен"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)      //реализация открытия файла
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName; 

            string fileText = System.IO.File.ReadAllText(filename);
            VvodBox.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void shifr_exit_Click(object sender, EventArgs e)       //закрытие формочки
        {
            Application.Exit();

        }
        Point LastPoint;                                   // возможность передвегать формочку по экрану
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

    }
}
