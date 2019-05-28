namespace DiaryApp
{
    partial class AddTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RemindTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.RemindCheckBox = new System.Windows.Forms.CheckBox();
            this.AddfileButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.RedactPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedactPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.DarkTurquoise;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(3, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(336, 22);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.Text = "Название задачи";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // RemindTimePicker
            // 
            this.RemindTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemindTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindTimePicker.Location = new System.Drawing.Point(139, 81);
            this.RemindTimePicker.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.RemindTimePicker.Name = "RemindTimePicker";
            this.RemindTimePicker.Size = new System.Drawing.Size(200, 29);
            this.RemindTimePicker.TabIndex = 1;
            // 
            // TaskTimePicker
            // 
            this.TaskTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TaskTimePicker.Location = new System.Drawing.Point(139, 40);
            this.TaskTimePicker.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.TaskTimePicker.Name = "TaskTimePicker";
            this.TaskTimePicker.Size = new System.Drawing.Size(200, 29);
            this.TaskTimePicker.TabIndex = 2;
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskLabel.Location = new System.Drawing.Point(0, 40);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(54, 24);
            this.TaskLabel.TabIndex = 3;
            this.TaskLabel.Text = "Срок";
            // 
            // RemindCheckBox
            // 
            this.RemindCheckBox.AutoSize = true;
            this.RemindCheckBox.BackColor = System.Drawing.Color.LightSalmon;
            this.RemindCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemindCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemindCheckBox.Location = new System.Drawing.Point(3, 81);
            this.RemindCheckBox.Name = "RemindCheckBox";
            this.RemindCheckBox.Size = new System.Drawing.Size(130, 28);
            this.RemindCheckBox.TabIndex = 5;
            this.RemindCheckBox.Text = "Напомнить";
            this.RemindCheckBox.UseVisualStyleBackColor = false;
            this.RemindCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddfileButton
            // 
            this.AddfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddfileButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddfileButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.AddfileButton.Location = new System.Drawing.Point(4, 113);
            this.AddfileButton.Name = "AddfileButton";
            this.AddfileButton.Size = new System.Drawing.Size(129, 23);
            this.AddfileButton.TabIndex = 6;
            this.AddfileButton.Text = "Прикрепить файл";
            this.AddfileButton.UseVisualStyleBackColor = false;
            this.AddfileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLabel.Location = new System.Drawing.Point(135, 113);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(106, 24);
            this.FileNameLabel.TabIndex = 7;
            this.FileNameLabel.Text = "Имя файла";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConfirmButton.BackColor = System.Drawing.Color.LightBlue;
            this.ConfirmButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ConfirmButton.Location = new System.Drawing.Point(3, 142);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(71, 23);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "Закончить";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RedactPictureBox
            // 
            this.RedactPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RedactPictureBox.Image")));
            this.RedactPictureBox.Location = new System.Drawing.Point(320, 150);
            this.RedactPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.RedactPictureBox.Name = "RedactPictureBox";
            this.RedactPictureBox.Size = new System.Drawing.Size(16, 16);
            this.RedactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedactPictureBox.TabIndex = 9;
            this.RedactPictureBox.TabStop = false;
            this.RedactPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(344, 169);
            this.Controls.Add(this.RedactPictureBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.AddfileButton);
            this.Controls.Add(this.RemindCheckBox);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.TaskTimePicker);
            this.Controls.Add(this.RemindTimePicker);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTaskForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.RedactPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DateTimePicker RemindTimePicker;
        private System.Windows.Forms.DateTimePicker TaskTimePicker;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.CheckBox RemindCheckBox;
        private System.Windows.Forms.Button AddfileButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.PictureBox RedactPictureBox;
    }
}