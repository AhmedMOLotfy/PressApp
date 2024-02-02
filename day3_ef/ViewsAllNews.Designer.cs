namespace day3_ef
{
    partial class ViewsAllNews
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
            dvg_allNews = new DataGridView();
            back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg_allNews).BeginInit();
            SuspendLayout();
            // 
            // dvg_allNews
            // 
            dvg_allNews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_allNews.Location = new Point(12, 102);
            dvg_allNews.Name = "dvg_allNews";
            dvg_allNews.RowHeadersWidth = 62;
            dvg_allNews.Size = new Size(776, 336);
            dvg_allNews.TabIndex = 0;
            // 
            // back_btn
            // 
            back_btn.BackColor = SystemColors.ControlLightLight;
            back_btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            back_btn.Location = new Point(30, 24);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(182, 54);
            back_btn.TabIndex = 1;
            back_btn.Text = "To Dashboard";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // ViewsAllNews
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back_btn);
            Controls.Add(dvg_allNews);
            Name = "ViewsAllNews";
            Text = "ViewsAllNews";
            ((System.ComponentModel.ISupportInitialize)dvg_allNews).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvg_allNews;
        private Button back_btn;
    }
}