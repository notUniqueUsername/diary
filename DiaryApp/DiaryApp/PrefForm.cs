using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryAppLibs;

namespace DiaryApp
{
    public partial class PrefForm : Form
    {
        private string _pathTOFile;
        public DiaryPrefeferences DiaryPreferences { private set; get; } = new DiaryPrefeferences(@"C:\Users\Valeriy\Desktop\-click-nice_1.mp3");
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public PrefForm(string pathTOAdudio)
        {
            InitializeComponent();
            _pathTOFile = pathTOAdudio;
            var lastIndex = pathTOAdudio.LastIndexOf(@"\");
            label1.Text = pathTOAdudio.Substring(lastIndex + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiaryPreferences = new DiaryPrefeferences(_pathTOFile);
            DialogResult = DialogResult.OK;
        }

        private void ChangeFileLabel(string path)
        {
            _pathTOFile = path;
            var lastIndex = path.LastIndexOf(@"\");
            label1.Text = path.Substring(lastIndex + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ChangeFileLabel(openFileDialog.FileName);
            }
        }
    }
}
