namespace day3_ef
{
    partial class AutherProfile
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
            name = new Label();
            age = new Label();
            label8 = new Label();
            name_txt = new TextBox();
            age_txt = new TextBox();
            username_txt = new TextBox();
            back_btn = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            name.Location = new Point(27, 89);
            name.Name = "name";
            name.Size = new Size(62, 25);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // age
            // 
            age.AutoSize = true;
            age.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            age.Location = new Point(27, 242);
            age.Name = "age";
            age.Size = new Size(46, 25);
            age.TabIndex = 1;
            age.Text = "Age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(27, 167);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 6;
            label8.Text = "UserName";
            // 
            // name_txt
            // 
            name_txt.Location = new Point(182, 83);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(505, 31);
            name_txt.TabIndex = 10;
            // 
            // age_txt
            // 
            age_txt.Location = new Point(182, 239);
            age_txt.Name = "age_txt";
            age_txt.Size = new Size(505, 31);
            age_txt.TabIndex = 11;
            // 
            // username_txt
            // 
            username_txt.Location = new Point(182, 164);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(505, 31);
            username_txt.TabIndex = 12;
            // 
            // back_btn
            // 
            back_btn.BackColor = SystemColors.ControlLightLight;
            back_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            back_btn.Location = new Point(27, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(182, 34);
            back_btn.TabIndex = 13;
            back_btn.Text = "To Dashboard";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // AutherProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(back_btn);
            Controls.Add(username_txt);
            Controls.Add(age_txt);
            Controls.Add(name_txt);
            Controls.Add(label8);
            Controls.Add(age);
            Controls.Add(name);
            Name = "AutherProfile";
            Text = "AutherProfile";
            Load += AutherProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label age;
        private Label label8;
        private TextBox name_txt;
        private TextBox age_txt;
        private TextBox username_txt;
        private Button back_btn;
    }
}