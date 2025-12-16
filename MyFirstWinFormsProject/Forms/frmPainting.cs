using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmPainting : Form
    {
        public frmPainting()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color black = Color.FromArgb(255,0,0,0);

            Pen pen = new Pen(black);

            pen.Width= 10;

            // pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 100, 100, 100, 200);
            e.Graphics.DrawRectangle(pen, 200, 200, 300, 300);
            e.Graphics.DrawEllipse(pen, 200, 50, 100, 100);

        }
    }
}
