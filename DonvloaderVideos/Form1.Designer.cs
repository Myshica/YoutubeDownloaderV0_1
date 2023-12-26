namespace DonvloaderVideos
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Search_line = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Title_Video_text = new System.Windows.Forms.Label();
            this.Picture_Video_box = new System.Windows.Forms.PictureBox();
            this.Download_btn = new System.Windows.Forms.Button();
            this.save_video_dialog = new System.Windows.Forms.SaveFileDialog();
            this.Author_Video_Label = new System.Windows.Forms.Label();
            this.ProgressBar_Download = new System.Windows.Forms.ProgressBar();
            this.Video_Duration_Label = new System.Windows.Forms.Label();
            this.Size_File_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Video_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_line
            // 
            this.Search_line.Location = new System.Drawing.Point(30, 37);
            this.Search_line.Name = "Search_line";
            this.Search_line.Size = new System.Drawing.Size(447, 20);
            this.Search_line.TabIndex = 0;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_btn.Location = new System.Drawing.Point(483, 30);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 32);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Title_Video_text
            // 
            this.Title_Video_text.AutoSize = true;
            this.Title_Video_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_Video_text.Location = new System.Drawing.Point(27, 99);
            this.Title_Video_text.Name = "Title_Video_text";
            this.Title_Video_text.Size = new System.Drawing.Size(0, 17);
            this.Title_Video_text.TabIndex = 4;
            // 
            // Picture_Video_box
            // 
            this.Picture_Video_box.Location = new System.Drawing.Point(30, 125);
            this.Picture_Video_box.Name = "Picture_Video_box";
            this.Picture_Video_box.Size = new System.Drawing.Size(266, 161);
            this.Picture_Video_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Picture_Video_box.TabIndex = 5;
            this.Picture_Video_box.TabStop = false;
            // 
            // Download_btn
            // 
            this.Download_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Download_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download_btn.Location = new System.Drawing.Point(466, 303);
            this.Download_btn.Name = "Download_btn";
            this.Download_btn.Size = new System.Drawing.Size(106, 46);
            this.Download_btn.TabIndex = 6;
            this.Download_btn.Text = "Download";
            this.Download_btn.UseVisualStyleBackColor = false;
            this.Download_btn.Click += new System.EventHandler(this.Download_btn_Click);
            // 
            // Author_Video_Label
            // 
            this.Author_Video_Label.AutoSize = true;
            this.Author_Video_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author_Video_Label.Location = new System.Drawing.Point(27, 72);
            this.Author_Video_Label.Name = "Author_Video_Label";
            this.Author_Video_Label.Size = new System.Drawing.Size(0, 15);
            this.Author_Video_Label.TabIndex = 7;
            // 
            // ProgressBar_Download
            // 
            this.ProgressBar_Download.BackColor = System.Drawing.SystemColors.InfoText;
            this.ProgressBar_Download.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProgressBar_Download.Location = new System.Drawing.Point(30, 324);
            this.ProgressBar_Download.Name = "ProgressBar_Download";
            this.ProgressBar_Download.Size = new System.Drawing.Size(266, 13);
            this.ProgressBar_Download.Step = 100;
            this.ProgressBar_Download.TabIndex = 8;
            // 
            // Video_Duration_Label
            // 
            this.Video_Duration_Label.AutoSize = true;
            this.Video_Duration_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Video_Duration_Label.Location = new System.Drawing.Point(296, 273);
            this.Video_Duration_Label.Name = "Video_Duration_Label";
            this.Video_Duration_Label.Size = new System.Drawing.Size(0, 15);
            this.Video_Duration_Label.TabIndex = 9;
            // 
            // Size_File_Label
            // 
            this.Size_File_Label.AutoSize = true;
            this.Size_File_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size_File_Label.Location = new System.Drawing.Point(312, 324);
            this.Size_File_Label.Name = "Size_File_Label";
            this.Size_File_Label.Size = new System.Drawing.Size(0, 15);
            this.Size_File_Label.TabIndex = 10;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Size_File_Label);
            this.Controls.Add(this.Video_Duration_Label);
            this.Controls.Add(this.ProgressBar_Download);
            this.Controls.Add(this.Author_Video_Label);
            this.Controls.Add(this.Download_btn);
            this.Controls.Add(this.Picture_Video_box);
            this.Controls.Add(this.Title_Video_text);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Search_line);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Video Youtube";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Video_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_line;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label Title_Video_text;
        private System.Windows.Forms.PictureBox Picture_Video_box;
        private System.Windows.Forms.Button Download_btn;
        private System.Windows.Forms.SaveFileDialog save_video_dialog;
        private System.Windows.Forms.Label Author_Video_Label;
        private System.Windows.Forms.Label Video_Duration_Label;
        private System.Windows.Forms.Label Size_File_Label;
        public System.Windows.Forms.ProgressBar ProgressBar_Download;
    }
}

