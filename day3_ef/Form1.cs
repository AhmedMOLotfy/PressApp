using day3_ef.Models;

namespace day3_ef
{
    public partial class Form1 : Form
    {
        NewsContext db;
        public Form? activeForm = null;

        public Form1()
        {
            InitializeComponent();
            db = new NewsContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.BackColor = Color.Transparent;
            lbl2.BackColor = Color.Transparent;
        }

        private void regsiter_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm(this));
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            string usermame = username_txt.Text;
            string passwrd = password_txt.Text;

            Auther? auther = db.Authers.Where((a) =>  a.username == usermame && a.password == passwrd).SingleOrDefault();
            if(auther != null)
            {
                MessageBox.Show("Logged In Successfully");
                openChildForm(new ManageNews(auther));
            }
            else
            {
                MessageBox.Show("either username or password is not correct");
            }
        }
    }
}
