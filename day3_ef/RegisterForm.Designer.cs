namespace day3_ef
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            name = new Label();
            label2 = new Label();
            pa = new Label();
            aaa = new Label();
            name_txt = new TextBox();
            age_txt = new TextBox();
            password_txt = new TextBox();
            username_txt = new TextBox();
            regsiter_btn = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = SystemColors.ControlLightLight;
            name.Location = new Point(72, 65);
            name.Name = "name";
            name.Size = new Size(56, 25);
            name.TabIndex = 0;
            name.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(438, 65);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // pa
            // 
            pa.AutoSize = true;
            pa.BackColor = SystemColors.ControlLightLight;
            pa.Location = new Point(438, 152);
            pa.Name = "pa";
            pa.Size = new Size(89, 25);
            pa.TabIndex = 2;
            pa.Text = "password";
            // 
            // aaa
            // 
            aaa.AutoSize = true;
            aaa.BackColor = SystemColors.ControlLightLight;
            aaa.Location = new Point(72, 152);
            aaa.Name = "aaa";
            aaa.Size = new Size(41, 25);
            aaa.TabIndex = 3;
            aaa.Text = "age";
            // 
            // name_txt
            // 
            name_txt.Location = new Point(170, 59);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(150, 31);
            name_txt.TabIndex = 4;
            // 
            // age_txt
            // 
            age_txt.Location = new Point(170, 146);
            age_txt.Name = "age_txt";
            age_txt.Size = new Size(150, 31);
            age_txt.TabIndex = 5;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(561, 149);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(150, 31);
            password_txt.TabIndex = 6;
            // 
            // username_txt
            // 
            username_txt.Location = new Point(561, 62);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(150, 31);
            username_txt.TabIndex = 7;
            // 
            // regsiter_btn
            // 
            regsiter_btn.BackColor = SystemColors.ControlLightLight;
            regsiter_btn.Location = new Point(330, 303);
            regsiter_btn.Name = "regsiter_btn";
            regsiter_btn.Size = new Size(112, 34);
            regsiter_btn.TabIndex = 8;
            regsiter_btn.Text = "Register";
            regsiter_btn.UseVisualStyleBackColor = false;
            regsiter_btn.Click += regsiter_btn_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 422);
            Controls.Add(regsiter_btn);
            Controls.Add(username_txt);
            Controls.Add(password_txt);
            Controls.Add(age_txt);
            Controls.Add(name_txt);
            Controls.Add(aaa);
            Controls.Add(pa);
            Controls.Add(label2);
            Controls.Add(name);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label label2;
        private Label pa;
        private Label aaa;
        private TextBox name_txt;
        private TextBox age_txt;
        private TextBox password_txt;
        private TextBox username_txt;
        private Button regsiter_btn;
    }
}