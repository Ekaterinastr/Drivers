﻿using System;
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
    public partial class Authorization : Drivers.BasicForm
    {
        Model1 db = new Model1();
        public static Inspector drivers { get; set; }
        public Authorization()
        {
            InitializeComponent();
        }

        private void sighInButton_Click(object sender, EventArgs e)
        {
            if(loginTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Внимание! Вы заполнили не все поля!", "Ошибка авторизации: незаполненные поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Inspector drivers = db.Inspector.FirstOrDefault(x => x.Login == loginTb.Text.ToUpper());
                if((drivers != null) && drivers.Parol == passwordTb.Text)
                {
                    PinCode pc = new PinCode();
                    pc.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show($"Сотрудник с таким логином - {loginTb.Text} не существует!",
                        "Ошибка авторизации: логин не существует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
