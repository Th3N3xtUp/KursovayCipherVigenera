using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vizhener1;

namespace Vizhener1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void StartAutoButton_Click(object sender, EventArgs e)      //кнопка авторизации
        {
            this.Hide();
            Autoriz autoriz = new Autoriz();
            DialogResult dialogResult = autoriz.ShowDialog();

        }

        private void StartRegButton_Click(object sender, EventArgs e)      //кнопка регистрации
        { 
            rega register = new rega();
            DialogResult dialogResult = register.ShowDialog();
        }


        Point LastPoint;                                                    // возможность передвегать формочку по экрану
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void exit_start_Click(object sender, EventArgs e)         // закрытие программы
        {
            Application.Exit();
        }
    }
}



