using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace knigniMagazin
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            if (Login.Text == "" || pass.Text == "" || noname.Text == "" || 
                name.Text == "" || pass.Text == "" || role.Text == "")
            {
                MessageBox.Show("Задайте логин!");
                return;
            }
            Пользователи usr = db.Пользователи.Find(Login.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь уже зарегистрирован");
                return;
            }
            usr = new Пользователи
            {
                Логин = Login.Text,
                Пароль = pass.Text,
                Фамилия = noname.Text,
                Имя = name.Text,
                Роль = role.Text
            };
            db.Пользователи.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь " + usr.Логин + " зарегистрирован!");
            return;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
