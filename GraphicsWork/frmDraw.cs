using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsWork
{
    public partial class frmDraw : Form
    {
        Graphics g;
        bool mouseDown;
        Point startPoint, lastPoint;
        Tools checkedTool;

        enum Tools
        {
            Pencil, Line, Rectangle, Ellipse
        }

        public frmDraw()
        {
            InitializeComponent();
        }

        private void frmDraw_Load(object sender, EventArgs e)
        {
            mouseDown = false;
            g = this.CreateGraphics();

            NewToolStripMenuItem_Click(sender, e);
            tsbPencil_Click(sender, e);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                startPoint = lastPoint = new Point(e.X, e.Y);
            }
        }

        private void frmDraw_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void frmDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                switch (checkedTool)
                {
                    case Tools.Pencil:
                        break;
                    case Tools.Line:
                        break;
                    case Tools.Rectangle:
                        break;
                    case Tools.Ellipse:
                        break;
                }
            }
        }

        private void clearToolbar(ToolStripButton button, Tools tools)
        {
            tsbPencil.CheckState = CheckState.Unchecked;
            tsbLine.CheckState = CheckState.Unchecked;
            tsbRectangle.CheckState = CheckState.Unchecked;
            tsbEllipse.CheckState = CheckState.Unchecked;
            button.CheckState = CheckState.Checked;
            checkedTool = tools;
        }

        private void tsbPencil_Click(object sender, EventArgs e)
        {
            clearToolbar(tsbPencil, Tools.Pencil);
        }

        private void tsbLine_Click(object sender, EventArgs e)
        {
            clearToolbar(tsbLine, Tools.Line);
        }

        private void tsbRectangle_Click(object sender, EventArgs e)
        {
            clearToolbar(tsbRectangle, Tools.Rectangle);
        }

        private void tsbEllipse_Click(object sender, EventArgs e)
        {
            clearToolbar(tsbEllipse, Tools.Ellipse);
        }
    }
}
