namespace day3_ef
{
    partial class ManageNews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_autherNews = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            title_txt = new TextBox();
            brief_txt = new TextBox();
            add_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            desc_richText = new RichTextBox();
            category_cmb = new ComboBox();
            timePicker = new DateTimePicker();
            datePicker = new DateTimePicker();
            viewProfile_btn = new Button();
            showNews_btn = new Button();
            nvg_panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_autherNews).BeginInit();
            SuspendLayout();
            // 
            // dgv_autherNews
            // 
            dgv_autherNews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_autherNews.Location = new Point(12, 302);
            dgv_autherNews.Name = "dgv_autherNews";
            dgv_autherNews.RowHeadersWidth = 62;
            dgv_autherNews.Size = new Size(833, 184);
            dgv_autherNews.TabIndex = 0;
            dgv_autherNews.RowHeaderMouseDoubleClick += dgv_autherNews_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 136);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 1;
            label1.Text = "desc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 202);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 79);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 3;
            label3.Text = "title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 79);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 4;
            label4.Text = "brief";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 202);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 5;
            label5.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 79);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 6;
            label6.Text = "category";
            // 
            // title_txt
            // 
            title_txt.Location = new Point(103, 76);
            title_txt.Name = "title_txt";
            title_txt.Size = new Size(150, 31);
            title_txt.TabIndex = 10;
            // 
            // brief_txt
            // 
            brief_txt.Location = new Point(364, 76);
            brief_txt.Name = "brief_txt";
            brief_txt.Size = new Size(150, 31);
            brief_txt.TabIndex = 11;
            // 
            // add_btn
            // 
            add_btn.BackColor = SystemColors.ControlLightLight;
            add_btn.Location = new Point(103, 251);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(112, 34);
            add_btn.TabIndex = 13;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // update_btn
            // 
            update_btn.BackColor = SystemColors.ControlLightLight;
            update_btn.Location = new Point(402, 251);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(112, 34);
            update_btn.TabIndex = 14;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = SystemColors.ControlLightLight;
            delete_btn.Location = new Point(666, 251);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(112, 34);
            delete_btn.TabIndex = 15;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // desc_richText
            // 
            desc_richText.Location = new Point(103, 125);
            desc_richText.Name = "desc_richText";
            desc_richText.Size = new Size(675, 46);
            desc_richText.TabIndex = 16;
            desc_richText.Text = "";
            // 
            // category_cmb
            // 
            category_cmb.FormattingEnabled = true;
            category_cmb.Location = new Point(628, 75);
            category_cmb.Name = "category_cmb";
            category_cmb.Size = new Size(150, 33);
            category_cmb.TabIndex = 17;
            // 
            // timePicker
            // 
            timePicker.Location = new Point(539, 199);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(237, 31);
            timePicker.TabIndex = 18;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(114, 199);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(327, 31);
            datePicker.TabIndex = 19;
            // 
            // viewProfile_btn
            // 
            viewProfile_btn.BackColor = SystemColors.ControlLightLight;
            viewProfile_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            viewProfile_btn.Location = new Point(114, 12);
            viewProfile_btn.Name = "viewProfile_btn";
            viewProfile_btn.Size = new Size(219, 34);
            viewProfile_btn.TabIndex = 20;
            viewProfile_btn.Text = "View Profile";
            viewProfile_btn.UseVisualStyleBackColor = false;
            viewProfile_btn.Click += viewProfile_btn_Click;
            // 
            // showNews_btn
            // 
            showNews_btn.BackColor = SystemColors.ControlLightLight;
            showNews_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            showNews_btn.Location = new Point(495, 12);
            showNews_btn.Name = "showNews_btn";
            showNews_btn.Size = new Size(219, 34);
            showNews_btn.TabIndex = 21;
            showNews_btn.Text = "Show All News";
            showNews_btn.UseVisualStyleBackColor = false;
            showNews_btn.Click += showNews_btn_Click;
            // 
            // nvg_panel
            // 
            nvg_panel.Location = new Point(-1, 516);
            nvg_panel.Name = "nvg_panel";
            nvg_panel.Size = new Size(846, 12);
            nvg_panel.TabIndex = 22;
            // 
            // ManageNews
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 535);
            Controls.Add(nvg_panel);
            Controls.Add(showNews_btn);
            Controls.Add(viewProfile_btn);
            Controls.Add(datePicker);
            Controls.Add(timePicker);
            Controls.Add(category_cmb);
            Controls.Add(desc_richText);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(brief_txt);
            Controls.Add(title_txt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_autherNews);
            Name = "ManageNews";
            Text = "ManageNews";
            Load += ManageNews_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_autherNews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_autherNews;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox title_txt;
        private TextBox brief_txt;
        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
        private RichTextBox desc_richText;
        private ComboBox category_cmb;
        private DateTimePicker timePicker;
        private DateTimePicker datePicker;
        private Button viewProfile_btn;
        private Button showNews_btn;
        public Panel nvg_panel;
    }
}