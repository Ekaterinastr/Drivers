using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers
{
    public partial class PinCode : Drivers.BasicForm
    {
        public PinCode()
        {
            InitializeComponent();
        }

        private void PinCode_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 10);
            int value1 = rnd.Next(0, 10);
            int value2 = rnd.Next(0, 10);
            int value3 = rnd.Next(0, 10);
            pinCodTb.Text = $"{value}" + $"{value1}" + $"{value2}" + $"{value3}";
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(sendPibTb.Text == "")
            {
                MessageBox.Show("Внимание! Незаполненные поле!", "Ошибка пин-кода: пустые поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(pinCodTb.Text != sendPibTb.Text)
                {
                    MessageBox.Show("Внимание!Пин-код не совпадает!", "Ошибка пин-кода: несоответствие пин-кода",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ViewDriver vd = new ViewDriver();
                    vd.Show();
                    Hide();
                }
            }
        }
    }
}
