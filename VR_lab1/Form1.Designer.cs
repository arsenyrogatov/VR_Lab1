namespace VR_lab1
{
    partial class Form1
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
            this.rgb_pictureBox = new System.Windows.Forms.PictureBox();
            this.yuv_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFile_button = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuv_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rgb_pictureBox
            // 
            this.rgb_pictureBox.Location = new System.Drawing.Point(12, 60);
            this.rgb_pictureBox.Name = "rgb_pictureBox";
            this.rgb_pictureBox.Size = new System.Drawing.Size(500, 500);
            this.rgb_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rgb_pictureBox.TabIndex = 0;
            this.rgb_pictureBox.TabStop = false;
            // 
            // yuv_pictureBox
            // 
            this.yuv_pictureBox.Location = new System.Drawing.Point(542, 60);
            this.yuv_pictureBox.Name = "yuv_pictureBox";
            this.yuv_pictureBox.Size = new System.Drawing.Size(500, 500);
            this.yuv_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yuv_pictureBox.TabIndex = 1;
            this.yuv_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "RGB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(536, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "YUV (только яркость)";
            // 
            // openFile_button
            // 
            this.openFile_button.AutoSize = true;
            this.openFile_button.Location = new System.Drawing.Point(12, 577);
            this.openFile_button.Name = "openFile_button";
            this.openFile_button.Size = new System.Drawing.Size(203, 44);
            this.openFile_button.TabIndex = 4;
            this.openFile_button.Text = "Выбрать файл";
            this.openFile_button.UseVisualStyleBackColor = true;
            this.openFile_button.Click += new System.EventHandler(this.openFile_button_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(232, 585);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(198, 29);
            this.status_label.TabIndex = 5;
            this.status_label.Text = "Файл не выбран";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "bmp";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Bitmap Picture (*.bmp)|*.bmp";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 640);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.openFile_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yuv_pictureBox);
            this.Controls.Add(this.rgb_pictureBox);
            this.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRAR Laba1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.rgb_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuv_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rgb_pictureBox;
        private System.Windows.Forms.PictureBox yuv_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openFile_button;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

