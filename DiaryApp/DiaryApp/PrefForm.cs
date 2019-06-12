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
        private Color _color;
        private Color _fontColor;
        private string _pathTOFile;
        public DiaryPreferences DiaryPreferences { private set; get; } = new DiaryPreferences(@"C:\Users\Valeriy\Desktop\-click-nice_1.mp3"
            , Color.Black
            , Color.LightSalmon);
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public PrefForm(string pathTOAdudio, Color fontColor, Color color)
        {
            InitializeComponent();

            fontDialog.ShowColor = true;
            colorDialog.FullOpen = true;
            _pathTOFile = pathTOAdudio;
            _fontColor = fontColor;
            _color = color;
            var lastIndex = pathTOAdudio.LastIndexOf(@"\");
            AuidoNameLabel.Text = pathTOAdudio.Substring(lastIndex + 1);
            ChangeColor(_fontColor,_color);
        }

        private void ChangeColor(Color fontColor, Color color)
        {
            this.BackColor = color;
            this.ForeColor = fontColor;
            //acceptButton.ForeColor = fontColor;
            //AuidoNameLabel.ForeColor = fontColor;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            DiaryPreferences = new DiaryPreferences(_pathTOFile,_fontColor,_color);
            DialogResult = DialogResult.OK;
        }

        private void ChangeFileLabel(string path)
        {
            _pathTOFile = path;
            var lastIndex = path.LastIndexOf(@"\");
            AuidoNameLabel.Text = path.Substring(lastIndex + 1);
        }

        private void ChangeAudio_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ChangeFileLabel(openFileDialog.FileName);
            }
        }

        private void ChangeFontButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _fontColor = colorDialog.Color;
            }
        }

        private void ChangeBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _color = colorDialog.Color;
            }
        }
    }
}
