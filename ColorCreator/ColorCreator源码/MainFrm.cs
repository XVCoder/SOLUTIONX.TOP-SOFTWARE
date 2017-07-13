using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCreator
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(200, 150);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 200, 150));
            this.picColorBoard.Image = bmp;
            txtInput.Text = "#000000";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.labelMsg.Text))
            {
                this.labelMsg.Text = "";
            }
            if (txtInput.Text.Length == 7)
            {
                Bitmap bmp = new Bitmap(200, 150);
                Graphics g = Graphics.FromImage(bmp);
                string hex = this.txtInput.Text;
                try
                {
                    Color _color = System.Drawing.ColorTranslator.FromHtml(hex);
                    Brush b = new SolidBrush(_color);
                    g.FillRectangle(b, new Rectangle(0, 0, 200, 150));

                    this.picColorBoard.Image = bmp;
                }
                catch
                {
                    labelMsg.Text = "**请输入有效的十六进制码**";
                }
            }
            else
            {
                labelMsg.Text = "**请输入有效的十六进制码**";
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnCreate.PerformClick();
                this.txtInput.Focus();
            }
        }
    }
}
