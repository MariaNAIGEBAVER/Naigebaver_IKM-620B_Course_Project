using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naigebaver_IKM_620B_Course_Project
{
    public partial class Form1 : Form
    {
        private bool Mode = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The time has passed!");
        }

        private void bStart_Click(object sender, EventArgs e)
        {

            if (Mode)
            {
                tbinput.Enabled = false;
                Mode = false;
                bStart.Text = "Пуск";
                tClock.Stop();

            }
            else
            {
                tbinput.Enabled = true;
                Mode = true;
                bStart.Text = "Стоп";
                tClock.Start(); 
            }

        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("Минуло 25 секунд", "Увага");// Виведення повідомлення
tClock.Start();
        }

        private void tbinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();
            if ((e.KeyChar >= '0') & (e.KeyChar <= '9') | (e.KeyChar == (char)8))
            {
                return;
            }
               else
            {
                tClock.Start();
                MessageBox.Show("Неправильний символ", "Помилка");
                tClock.Start();
                e.KeyChar = (char)0;
            }
        }
       
    }
}
