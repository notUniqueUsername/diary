using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
            TaskTimePicker.CustomFormat = "dd.MM.yyyy - H:m";
            RemindTimePicker.CustomFormat = "dd.MM.yyyy - H:m";
        }
    }
}
