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
    public partial class ViewDriver : Drivers.BasicForm
    {
        Model1 db = new Model1();
        public static bool add = false;//переменная для обозначения добавления или редактирования водителя
        public ViewDriver()
        {
            InitializeComponent();
        }

        private void ViewDriver_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.drivers.ToList();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            add = true;
            AddChangeDriver addchange = new AddChangeDriver();
            addchange.db = db;
            DialogResult dr = addchange.ShowDialog();
            if(dr == DialogResult.OK)
            {
                driversBindingSource.DataSource = db.drivers.ToList();
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            add = false;
            AddChangeDriver addchange = new AddChangeDriver();
            drivers drivers = (drivers)driversBindingSource.Current;
            addchange.db = db;
            addchange.drivers = drivers;
            DialogResult dr = addchange.ShowDialog();
            if (dr == DialogResult.OK)
            {
                driversBindingSource.DataSource = db.drivers.ToList();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            drivers drivers = (drivers)driversBindingSource.Current;
            DialogResult dr = MessageBox.Show("Вы действтиельно хотите удалить водителя - " +
                drivers.Surname.ToString() + "?", "Удаление водителя",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.drivers.Remove(drivers);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            driversBindingSource.DataSource = db.drivers.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            License pmf = new License();
            pmf.Show();
            Hide();
        }
    }
}
