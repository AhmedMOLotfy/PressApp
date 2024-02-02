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
    public partial class AutherProfile : Form
    {
        ManageNews newsN;
        NewsContext db;
        Auther auther;
        public AutherProfile(ManageNews news)
        {
            InitializeComponent();
            newsN = news;
            auther = newsN.auther;
            db = new NewsContext();
        }

        private void AutherProfile_Load(object sender, EventArgs e)
        {
            Auther auther = db.Authers.Where(a => a.id == this.auther.id).Single();

            if (auther != null)
            {
                username_txt.Text = auther.username;
                name_txt.Text = auther.name;
                age_txt.Text = auther.age.ToString();
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            newsN.nvg_panel.Dock = DockStyle.Bottom;
        }
    }
}
