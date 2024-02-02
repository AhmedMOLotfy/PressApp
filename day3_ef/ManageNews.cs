using Castle.Components.DictionaryAdapter.Xml;
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
    public partial class ManageNews : Form
    {
        public Auther auther;
        NewsContext db;
        int curId = 0;
        public Form? activeForm = null;
        public ManageNews(Auther auther)
        {

            InitializeComponent();
            db = new NewsContext();

            // custom format for time picker
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm"; // Only use hours and minutes
            timePicker.ShowUpDown = true;

            // get the current auther value
            this.auther = auther;

            // fill data grid view with news of current auther
            getLatestNewsAutherData();

            // assign the datasourse of combobox od depts
            category_cmb.DataSource =
                db.Catalogs.Select(n =>
                    new { Id = n.id, Name = n.name }).ToList();

            category_cmb.ValueMember = "Id";
            category_cmb.DisplayMember = "Name";

        }

        private void ManageNews_Load(object sender, EventArgs e)
        {
            // to show add button and hide update and delete
            showInsert(true);
        }

        private void dgv_autherNews_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            curId = (int)dgv_autherNews.SelectedRows[0].Cells[0].Value;
            News? news = db.News.Where(n => n.id == curId).SingleOrDefault();

            // assign the selected row to inputs
            title_txt.Text = news?.title;
            brief_txt.Text = news?.brief;
            category_cmb.SelectedValue = news?.catalog.id;
            desc_richText.Text = news?.desc;
            DateTime curDate = new DateTime(news.date.Year,
                news.date.Month, news.date.Day);
            datePicker.Value = curDate;
            DateTime curTime = new DateTime(news.date.Year,
                news.date.Month, news.date.Day, news.time.Hour, news.time.Minute, news.time.Second);
            timePicker.Value = curTime;

            // to hide add button and show update and delete
            showInsert(false);

        }

        private void getLatestNewsAutherData()
        {
            // fill data grid view with news of current auther
            dgv_autherNews.DataSource = db.News.
                Where(n => n.auther_id == auther.id).
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            News news = new News()
            {
                title = title_txt.Text,
                brief = brief_txt.Text,
                desc = desc_richText.Text,
                cat_id = (int)category_cmb.SelectedValue!,
                date = new DateOnly(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day),
                time = new TimeOnly(timePicker.Value.Hour, datePicker.Value.Minute, datePicker.Value.Second),
                auther_id = auther.id,
            };


            db.News.Add(news);
            db.SaveChanges();

            MessageBox.Show("Inserted successfully");


            resetFields();
            getLatestNewsAutherData();

        }

        private void showInsert(bool show)
        {
            add_btn.Visible = show;
            update_btn.Visible = !show;
            delete_btn.Visible = !show;
        }

        private void resetFields()
        {
            title_txt.Text = brief_txt.Text = desc_richText.Text = "";
            category_cmb.SelectedIndex = 0;
            datePicker.Value = new DateTime(2000, 1, 1);
            timePicker.Value = new DateTime(2000, 1, 1, 0, 0, 0);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            News? news = db.News.Where(n => n.id == curId).SingleOrDefault();

            news.title = title_txt.Text;
            news.brief = brief_txt.Text;
            news.desc = desc_richText.Text;
            news.cat_id = (int)category_cmb.SelectedValue!;
            news.date = new DateOnly(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day);
            news.time = new TimeOnly(timePicker.Value.Hour, datePicker.Value.Minute, datePicker.Value.Second);
            news.auther_id = auther.id;

            db.SaveChanges();

            MessageBox.Show("Updated successfully");

            showInsert(true);
            resetFields();
            getLatestNewsAutherData();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            News? news = db.News.Where(n => n.id == curId).SingleOrDefault();

            db.News.Remove(news);

            db.SaveChanges();

            MessageBox.Show("Deleted successfully");

            showInsert(true);
            resetFields();
            getLatestNewsAutherData();

        }

        private void viewProfile_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new AutherProfile(this));
        }

        public void openChildForm(Form childFrom)
        {
            activeForm = childFrom;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;

            nvg_panel.Controls.Add(activeForm);
            nvg_panel.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();

            nvg_panel.Dock = DockStyle.Fill;
        }

        private void showNews_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewsAllNews(this));
        }
    }
}
