namespace DesktopJournelApp
{
    partial class JournalPageUserControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.DearDiaryLabel = new System.Windows.Forms.Label();
            this.JournalRichTextBox = new System.Windows.Forms.RichTextBox();
            this.JournalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.JournalSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DearDiaryLabel
            // 
            this.DearDiaryLabel.AutoSize = true;
            this.DearDiaryLabel.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DearDiaryLabel.Location = new System.Drawing.Point(42, 28);
            this.DearDiaryLabel.Name = "DearDiaryLabel";
            this.DearDiaryLabel.Size = new System.Drawing.Size(194, 27);
            this.DearDiaryLabel.TabIndex = 0;
            this.DearDiaryLabel.Text = "Dear Diary...";
            // 
            // JournalRichTextBox
            // 
            this.JournalRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JournalRichTextBox.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalRichTextBox.Location = new System.Drawing.Point(47, 58);
            this.JournalRichTextBox.Name = "JournalRichTextBox";
            this.JournalRichTextBox.Size = new System.Drawing.Size(1557, 617);
            this.JournalRichTextBox.TabIndex = 1;
            this.JournalRichTextBox.Text = "";
            // 
            // JournalDateTimePicker
            // 
            this.JournalDateTimePicker.CalendarFont = new System.Drawing.Font("Footlight MT Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalDateTimePicker.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalDateTimePicker.Location = new System.Drawing.Point(1327, 21);
            this.JournalDateTimePicker.Name = "JournalDateTimePicker";
            this.JournalDateTimePicker.Size = new System.Drawing.Size(322, 34);
            this.JournalDateTimePicker.TabIndex = 2;
            this.JournalDateTimePicker.ValueChanged += new System.EventHandler(this.JournalDateTimePicker_ValueChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1614, 58);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(35, 617);
            this.vScrollBar1.TabIndex = 3;
            // 
            // JournalSaveButton
            // 
            this.JournalSaveButton.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalSaveButton.Location = new System.Drawing.Point(1528, 681);
            this.JournalSaveButton.Name = "JournalSaveButton";
            this.JournalSaveButton.Size = new System.Drawing.Size(132, 48);
            this.JournalSaveButton.TabIndex = 4;
            this.JournalSaveButton.Text = "Save";
            this.JournalSaveButton.UseVisualStyleBackColor = true;
            this.JournalSaveButton.Click += new System.EventHandler(this.JournalSaveButton_Click);
            // 
            // JournalPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.JournalSaveButton);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.JournalDateTimePicker);
            this.Controls.Add(this.JournalRichTextBox);
            this.Controls.Add(this.DearDiaryLabel);
            this.Name = "JournalPageUserControl";
            this.Size = new System.Drawing.Size(1724, 827);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DearDiaryLabel;
        private System.Windows.Forms.RichTextBox JournalRichTextBox;
        private System.Windows.Forms.DateTimePicker JournalDateTimePicker;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button JournalSaveButton;
    }
}
