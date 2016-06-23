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
        Graphics g, _g;
        bool mouseDown;
        Point startPoint, lastPoint;
        Tools checkedTool;

        Rectangle myRectangle;
        Pen myPen;
        Color nowColor;

        Bitmap bmpImage;
        string fileName;

        enum Tools
        {
            Pencil, Line, Rectangle, Ellipse, Eraser
        }

        public frmDraw()
        {
            InitializeComponent();
        }

        private int getSize()
        {
            return int.Parse(tstxtSize.Text);
        }

        private void changeColor(Color newColor)
        {
            nowColor = newColor;
            myPen = new Pen(nowColor, getSize());
        }

        private void updateTitle()
        {
            this.Text = "C#自制绘图 - " + fileName;
        }

        private void frmDraw_Load(object sender, EventArgs e)
        {
            myRectangle = new Rectangle();
            myRectangle.Width = this.Width;
            myRectangle.Height = this.Height;

            mouseDown = false;
            g = this.CreateGraphics();

            changeColor(Color.FromArgb(0, 0, 0)); // 初始为黑色

            NewToolStripMenuItem_Click(sender, e);
            tsbPencil_Click(sender, e);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "新绘图.bmp";
            updateTitle();

            g.Clear(this.BackColor);

            bmpImage = new Bitmap(this.Width, this.Height);
            _g = Graphics.FromImage(bmpImage);
            _g.Clear(this.BackColor);

        }

        private void ReloadImage()
        {
            g.Clear(this.BackColor);
            g.DrawImage(bmpImage, myRectangle);
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
            Point nowPoint = new Point(e.X, e.Y);
            switch (checkedTool)
            {
                case Tools.Line:
                    _g.DrawLine(myPen, startPoint, nowPoint);
                    break;
                case Tools.Rectangle:
                    _g.DrawRectangle(myPen, startPoint.X, startPoint.Y,
                        nowPoint.X - startPoint.X, nowPoint.Y - startPoint.Y);
                    break;
                case Tools.Ellipse:
                    _g.DrawEllipse(myPen, startPoint.X, startPoint.Y,
                        nowPoint.X - startPoint.X, nowPoint.Y - startPoint.Y);
                    break;
            }
            ReloadImage();
        }

        private void frmDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point nowPoint = new Point(e.X, e.Y);
                switch (checkedTool)
                {
                    case Tools.Pencil:
                    case Tools.Eraser:
                        g.DrawLine(myPen, lastPoint, nowPoint);
                        _g.DrawLine(myPen, lastPoint, nowPoint);
                        lastPoint.X = e.X; lastPoint.Y = e.Y;
                        break;
                    case Tools.Line:
                        ReloadImage();
                        g.DrawLine(myPen, startPoint, nowPoint);
                        break;
                    case Tools.Rectangle:
                        ReloadImage();
                        g.DrawRectangle(myPen, startPoint.X, startPoint.Y, 
                            nowPoint.X - startPoint.X, nowPoint.Y - startPoint.Y);
                        break;
                    case Tools.Ellipse:
                        ReloadImage();
                        g.DrawEllipse(myPen, startPoint.X, startPoint.Y, 
                            nowPoint.X - startPoint.X, nowPoint.Y - startPoint.Y);
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

            if (tools == Tools.Eraser)
                myPen = new Pen(this.BackColor, getSize() + 2);
            else
                myPen = new Pen(nowColor, getSize());
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

        private void tsbEraser_Click(object sender, EventArgs e)
        {
            clearToolbar(tsbEraser, Tools.Eraser);
        }
    }
}
