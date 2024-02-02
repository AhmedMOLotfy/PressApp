namespace day3_ef
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl1 = new Label();
            lbl2 = new Label();
            username_txt = new TextBox();
            password_txt = new TextBox();
            login_btn = new Button();
            regsiter_btn = new Button();
            nvg_panel = new Panel();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlLightLight;
            lbl1.Location = new Point(246, 100);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(97, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "Username";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(246, 178);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(92, 25);
            lbl2.TabIndex = 1;
            lbl2.Text = "Password";
            // 
            // username_txt
            // 
            username_txt.Location = new Point(355, 94);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(259, 31);
            username_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(355, 178);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(259, 31);
            password_txt.TabIndex = 3;
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.ButtonHighlight;
            login_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            login_btn.Location = new Point(373, 324);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(112, 34);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // regsiter_btn
            // 
            regsiter_btn.BackColor = SystemColors.ControlLightLight;
            regsiter_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            regsiter_btn.Location = new Point(711, 324);
            regsiter_btn.Name = "regsiter_btn";
            regsiter_btn.Size = new Size(112, 34);
            regsiter_btn.TabIndex = 5;
            regsiter_btn.Text = "Register";
            regsiter_btn.UseVisualStyleBackColor = false;
            regsiter_btn.Click += regsiter_btn_Click;
            // 
            // nvg_panel
            // 
            nvg_panel.Location = new Point(1, 428);
            nvg_panel.Name = "nvg_panel";
            nvg_panel.Size = new Size(867, 10);
            nvg_panel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(864, 438);
            Controls.Add(nvg_panel);
            Controls.Add(regsiter_btn);
            Controls.Add(login_btn);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Press";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox username_txt;
        private TextBox password_txt;
        private Button login_btn;
        private Button regsiter_btn;
        public Panel nvg_panel;
    }
}
