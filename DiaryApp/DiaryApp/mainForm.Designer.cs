namespace DiaryApp
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PrefsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.FindListBox = new System.Windows.Forms.ListBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.NotifyContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(2, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Location = new System.Drawing.Point(83, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.BackColor = System.Drawing.Color.LightSalmon;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar1.Location = new System.Drawing.Point(2, 31);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(168, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Location = new System.Drawing.Point(289, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrefsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 32);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PrefsToolStripMenuItem
            // 
            this.PrefsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrefsToolStripMenuItem.Name = "PrefsToolStripMenuItem";
            this.PrefsToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.PrefsToolStripMenuItem.Text = "Настройки";
            this.PrefsToolStripMenuItem.Click += new System.EventHandler(this.PrefsToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(142, 28);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // TaskListBox
            // 
            this.TaskListBox.BackColor = System.Drawing.Color.LightSalmon;
            this.TaskListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.HorizontalScrollbar = true;
            this.TaskListBox.ItemHeight = 24;
            this.TaskListBox.Location = new System.Drawing.Point(2, 197);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(341, 216);
            this.TaskListBox.TabIndex = 7;
            this.TaskListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskListBox_MouseUp);
            // 
            // FindListBox
            // 
            this.FindListBox.BackColor = System.Drawing.Color.LightSalmon;
            this.FindListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FindListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FindListBox.FormattingEnabled = true;
            this.FindListBox.HorizontalScrollbar = true;
            this.FindListBox.ItemHeight = 24;
            this.FindListBox.Location = new System.Drawing.Point(168, 50);
            this.FindListBox.Name = "FindListBox";
            this.FindListBox.Size = new System.Drawing.Size(170, 144);
            this.FindListBox.TabIndex = 8;
            this.FindListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FindListBox_MouseDoubleClick);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowAllButton.BackColor = System.Drawing.Color.LightBlue;
            this.ShowAllButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ShowAllButton.Location = new System.Drawing.Point(252, 419);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(86, 23);
            this.ShowAllButton.TabIndex = 9;
            this.ShowAllButton.Text = "Показать все";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.NotifyContextMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Ежедневник";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // NotifyContextMenuStrip
            // 
            this.NotifyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.NotifyContextMenuStrip.Name = "contextMenuStrip1";
            this.NotifyContextMenuStrip.Size = new System.Drawing.Size(122, 48);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(343, 454);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.FindListBox);
            this.Controls.Add(this.TaskListBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.ShowIcon = false;
            this.Text = "Ежедневник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.NotifyContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PrefsToolStripMenuItem;
        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ListBox FindListBox;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyContextMenuStrip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}

