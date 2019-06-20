namespace DiaryApp
{
    partial class PrefForm
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
            this.ChangeAudioButton = new System.Windows.Forms.Button();
            this.AuidoNameLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ChangeFontButton = new System.Windows.Forms.Button();
            this.ChangeBackColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeAudioButton
            // 
            this.ChangeAudioButton.AutoSize = true;
            this.ChangeAudioButton.Location = new System.Drawing.Point(12, 12);
            this.ChangeAudioButton.Name = "ChangeAudioButton";
            this.ChangeAudioButton.Size = new System.Drawing.Size(213, 34);
            this.ChangeAudioButton.TabIndex = 0;
            this.ChangeAudioButton.Text = "Выберите аудиофайл";
            this.ChangeAudioButton.UseVisualStyleBackColor = true;
            this.ChangeAudioButton.Click += new System.EventHandler(this.ChangeAudio_Click);
            // 
            // AuidoNameLabel
            // 
            this.AuidoNameLabel.AutoSize = true;
            this.AuidoNameLabel.Location = new System.Drawing.Point(12, 49);
            this.AuidoNameLabel.Name = "AuidoNameLabel";
            this.AuidoNameLabel.Size = new System.Drawing.Size(60, 24);
            this.AuidoNameLabel.TabIndex = 1;
            this.AuidoNameLabel.Text = "label1";
            // 
            // acceptButton
            // 
            this.acceptButton.AutoSize = true;
            this.acceptButton.Location = new System.Drawing.Point(12, 123);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(122, 34);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.Accept_Click);
            // 
            // ChangeFontButton
            // 
            this.ChangeFontButton.AutoSize = true;
            this.ChangeFontButton.Location = new System.Drawing.Point(12, 83);
            this.ChangeFontButton.Name = "ChangeFontButton";
            this.ChangeFontButton.Size = new System.Drawing.Size(221, 34);
            this.ChangeFontButton.TabIndex = 3;
            this.ChangeFontButton.Text = "Выбрать цвет шрифта";
            this.ChangeFontButton.UseVisualStyleBackColor = true;
            this.ChangeFontButton.Click += new System.EventHandler(this.ChangeFontButton_Click);
            // 
            // ChangeBackColor
            // 
            this.ChangeBackColor.AutoSize = true;
            this.ChangeBackColor.Location = new System.Drawing.Point(239, 83);
            this.ChangeBackColor.Name = "ChangeBackColor";
            this.ChangeBackColor.Size = new System.Drawing.Size(197, 34);
            this.ChangeBackColor.TabIndex = 4;
            this.ChangeBackColor.Text = "Выбрать цвет фона";
            this.ChangeBackColor.UseVisualStyleBackColor = true;
            this.ChangeBackColor.Click += new System.EventHandler(this.ChangeBackColor_Click);
            // 
            // PrefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(468, 169);
            this.Controls.Add(this.ChangeBackColor);
            this.Controls.Add(this.ChangeFontButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.AuidoNameLabel);
            this.Controls.Add(this.ChangeAudioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "PrefForm";
            this.ShowIcon = false;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeAudioButton;
        private System.Windows.Forms.Label AuidoNameLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button ChangeFontButton;
        private System.Windows.Forms.Button ChangeBackColor;
    }
}