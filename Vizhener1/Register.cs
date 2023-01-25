using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizhener1
{
    public partial class rega : Form
    {
        public rega()
        {
            InitializeComponent();
            RegLoginBox.MaxLength = 25;        //ограничение на длину пароля и логина
            RegPassBox.MaxLength = 30;
        }
        private void RegButton_Click_1(object sender, EventArgs e)     // проверка регистрации и последущее закидывание в бд новго пользовтеля 
        {
            var RegPassBoxAgain = this.RegPassBoxAgain.Text;
            var RegPassBox = this.RegPassBox.Text;
            var RegLoginBox = this.RegLoginBox.Text;
            SQLiteConnection connection = new SQLiteConnection("Data Source=dataBase.db");  
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.Connection = connection;

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            command.CommandText = "SELECT * FROM 'users' WHERE login = @login";
            command.Parameters.Add("@login", DbType.String).Value = RegLoginBox;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (RegPassBoxAgain != RegPassBox)
            {
                MessageBox.Show("Пароли не совпадают", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (RegPassBox == "" || RegPassBoxAgain == "" || RegLoginBox == "")
            {
                MessageBox.Show("Заполните все поля", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже зарегестрирован", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                string pass = Hash.hashPassword(RegPassBox);             //хэширование пароля
                new Database("Data Source=dataBase.db;Version=3;").createUser(this.RegLoginBox.Text, pass);
                MessageBox.Show("Вы зарегестрированы", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            connection.Close();
        }

        private void exit_reg_Click(object sender, EventArgs e)          //закрытие формочки
        {
            this.Close();
        }
        Point LastPoint;                                                             // возможность передвегать формочку по экрану
        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void RegLoginBox_KeyPress(object sender, KeyPressEventArgs e)       //запрет на вписывание пробела и занаков препинания в поля логина и пароля
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }

        private void RegPassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }

        private void RegPassBoxAgain_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }
    }
}
 

