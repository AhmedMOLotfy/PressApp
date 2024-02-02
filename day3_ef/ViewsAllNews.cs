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
    public partial class ViewsAllNews : Form
    {
        NewsContext db;
        ManageNews news;
        public ViewsAllNews(ManageNews news)
        {
            InitializeComponent();
            db = new NewsContext();

            // get news data
            getLatestNewsData();
            this.news = news;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.news.nvg_panel.Dock = DockStyle.Bottom;
        }

        private void getLatestNewsData()
        {
            // fill data grid view with news of current auther
            dvg_allNews.DataSource = db.News.
                Select(
                n =>
                new
                {
                    Id = n.id,
                    Title = n.title,
                    Brief = n.brief,
                    description = n.desc,
                    Date = n.date,
                    Time = n.time,
                    Auther = n.auther.name,
                    Category = n.catalog.name
                }
             ).ToList();
        }
    }
}
