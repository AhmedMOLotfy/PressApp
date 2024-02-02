using day3_ef.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day3_ef
{
    public partial class RegisterForm : Form
    {
        Form1 form1;

        NewsContext db;
        public RegisterForm(Form1 form)
        {
            InitializeComponent();

            form1 = form;
            db = new NewsContext();
        }

        private void regsiter_btn_Click(object sender, EventArgs e)
        {
            // get data
            Auther auther = new Auther()
            {
                name = name_txt.Text,
                age = Convert.ToInt32(age_txt.Text),
                username = username_txt.Text,
                password = password_txt.Text,
            };

            // add to Student
            db.Authers.Add(auther);

            // SAVE TO DATABSE
            db.SaveChanges();

            // GET BACK TO LOGIN SCREEN
            form1.nvg_panel.Dock = DockStyle.Bottom;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
