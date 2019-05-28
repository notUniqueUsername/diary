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
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.DiaryMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.PrefsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.FindListBox = new System.Windows.Forms.ListBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerForRemind = new System.Windows.Forms.Timer(this.components);
            this.DiaryMainMenuStrip.SuspendLayout();
            this.NotifyContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.AddButton.Location = new System.Drawing.Point(2, 419);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.BackColor = System.Drawing.Color.LightBlue;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.RemoveButton.Location = new System.Drawing.Point(83, 419);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            // FindTextBox
            // 
            this.FindTextBox.BackColor = System.Drawing.Color.DarkCyan;
            this.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FindTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindTextBox.Location = new System.Drawing.Point(168, 31);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(115, 22);
            this.FindTextBox.TabIndex = 4;
            this.FindTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindTextBox_KeyUp);
            this.FindTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FindTextBox_KeyPress);
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FindButton.BackColor = System.Drawing.Color.LightBlue;
            this.FindButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.FindButton.Location = new System.Drawing.Point(289, 30);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(49, 23);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.Find_Click);
            // 
            // DiaryMainMenuStrip
            // 
            this.DiaryMainMenuStrip.BackColor = System.Drawing.Color.LightSalmon;
            this.DiaryMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrefsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.DiaryMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DiaryMainMenuStrip.Name = "DiaryMainMenuStrip";
            this.DiaryMainMenuStrip.Size = new System.Drawing.Size(343, 32);
            this.DiaryMainMenuStrip.TabIndex = 6;
            this.DiaryMainMenuStrip.Text = "menuStrip1";
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
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.OpenNotify_Click);
            // 
            // NotifyContextMenuStrip
            // 
            this.NotifyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.NotifyContextMenuStrip.Name = "contextMenuStrip1";
            this.NotifyContextMenuStrip.Size = new System.Drawing.Size(122, 48);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenNotify_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // TimerForRemind
            // 
            this.TimerForRemind.Enabled = true;
            this.TimerForRemind.Interval = 1000;
            this.TimerForRemind.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DiaryMainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(359, 493);
            this.Name = "Mainform";
            this.ShowIcon = false;
            this.Text = "Ежедневник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.DiaryMainMenuStrip.ResumeLayout(false);
            this.DiaryMainMenuStrip.PerformLayout();
            this.NotifyContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.MenuStrip DiaryMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PrefsToolStripMenuItem;
        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ListBox FindListBox;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyContextMenuStrip;
        private System.Windows.Forms.Timer TimerForRemind;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
    }
}

