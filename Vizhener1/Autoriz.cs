using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Vizhener1
{
    public partial class Autoriz : Form
    {
        public Autoriz()
        {
            InitializeComponent();
            AutoLoginBox.MaxLength = 25;           //ограничение на длину пароля и логина
            AutoPassBox.MaxLength = 30;
        }

        private void AutoButton_Click(object sender, EventArgs e)     //после проверки на корректность данных переход к основной программе 
        {
            if (userAuthSucceess())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                Shifr FormEvents = new Shifr();
                DialogResult dialogResult = FormEvents.ShowDialog();
            }
        }
        private bool userAuthSucceess()  //проверка на корректность
        {
            string pass = Hash.hashPassword(AutoPassBox.Text);
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Не корректные поля на форме");
                return false;
            }
            if (hasUser() == true)
            {
                MessageBox.Show("Вы вошли");

                return true;
            }

            else
            {
                MessageBox.Show("Не верный логин или пароль");
                return false;
            }
        }
        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(AutoLoginBox.Text) || isUnCorrectField(AutoPassBox.Text))
                return true;
            return false;

        }
        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field))
                return true;
            return false;
        }
        private bool hasUser()   //хэш
        {
            string pass = Hash.hashPassword(AutoPassBox.Text);

            if (new Database("Data Source=dataBase.db;Version=3;").ValidUser(AutoLoginBox.Text, pass) == true)
                return true;
            else return false;
        }

        private void exit_auto_Click(object sender, EventArgs e)  //закрытие программы
        {
            Application.Exit();
        }
        Point LastPoint;                               // возможность передвегать формочку по экрану

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void AutoLoginBox_KeyPress(object sender, KeyPressEventArgs e)        //запрет на вписывание пробела и занаков препинания в поля логина и пароля
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }

        private void AutoPassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }

        private void label_perehodNaReg_Click(object sender, EventArgs e)       //открытие формы регистрации
        {
            rega register = new rega();
            DialogResult dialogResult = register.ShowDialog();
        }

    }
}
