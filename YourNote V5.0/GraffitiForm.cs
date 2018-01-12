using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNote
{
    public partial class GraffitiForm : Form
    {
        private bool isDown = false;
        private Point prept;
        private Point movept;
        private Color bColor = SystemColors.Window;
        private Color lineColor = Color.Green;
        private System.Collections.Generic.Queue<Object> pQueue = new Queue<Object>();
        public GraffitiForm()
        {
            InitializeComponent();
            this.BackColor = bColor;
            //this.MouseDown += new MouseEventHandler(GraffitiForm_MouseDown);
            //this.MouseMove += new MouseEventHandler(GraffitiForm_MouseMove);
            //this.Paint += new PaintEventHandler(GraffitiForm_Paint);

        }
        void DrawLine(Color clr, Point pBegin, Point pEnd)
        {
            Graphics gr = CreateGraphics();
            gr.DrawLine(new Pen(clr), pBegin, pEnd);
        }
        void DrawRectangle(Color clr, Point pLeftTop, Size sSize)
        {
            Graphics gr = CreateGraphics();
            if (sSize.Width < 0)
            {
                pLeftTop.X += sSize.Width;
                sSize.Width = -sSize.Width;

            }
            if (sSize.Height < 0)
            {
                pLeftTop.Y += sSize.Height;
                sSize.Height = -sSize.Height;

            }
            gr.DrawRectangle(new Pen(clr), pLeftTop.X, pLeftTop.Y, sSize.Width, sSize.Height);
            gr.Dispose();

        }

        private void GraffitiForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.rectangleRadioButton.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (isDown)
                    {
                        this.Invalidate();
                        Point pNow = new Point(e.X, e.Y);
                        DrawRectangle(lineColor, this.prept, new Size(pNow.X - this.prept.X, pNow.Y - this.prept.Y));
                        this.movept = pNow;
                        pQueue.Enqueue(new Rectangle(this.prept.X, this.prept.Y, pNow.X - this.prept.X, pNow.Y - this.prept.Y));
                        //DrawLine(lineColor, this.prept, pNow);
                        this.prept = pNow;
                        isDown = false;
                    }
                    else
                    {
                        this.prept = new Point(e.X, e.Y);
                        isDown = true;

                    }
                    //this.pQueue.Enqueue(this.prept);


                }
                if (e.Button == MouseButtons.Right)
                {
                    isDown = false;
                    //DrawLine(this.bColor, this.prept, this.movept);
                }
            }
            if (this.lineRadioButton.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (isDown)
                    {
                        this.Invalidate();
                        Point pNow = new Point(e.X, e.Y);
                        DrawLine(lineColor, this.prept, pNow);
                        this.prept = pNow;
                        this.movept = pNow;
                    }
                    else
                    {
                        this.prept = new Point(e.X, e.Y);
                        isDown = true;
                    }
                    this.pQueue.Enqueue(this.prept);
                }
                if (e.Button == MouseButtons.Right)
                {
                    isDown = false;
                    DrawLine(this.bColor, this.prept, this.movept);
                }
            }
        }

        private void GraffitiForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.rectangleRadioButton.Checked)
            {
                if (this.isDown)
                {
                    DrawRectangle(bColor, this.prept, new Size(this.movept.X - this.prept.X, movept.Y - this.prept.Y));
                    //DrawLine(bColor, this.prept, this.movept);
                    this.movept = new Point(e.X, e.Y);
                    //DrawLine(lineColor, this.prept, this.movept);
                    DrawRectangle(lineColor, this.prept, new Size(this.movept.X - this.prept.X, movept.Y - this.prept.Y));

                }
            }
            if (this.lineRadioButton.Checked)
            {
                if (this.isDown)
                {
                    DrawLine(bColor, this.prept, this.movept);
                    this.movept = new Point(e.X, e.Y);
                    DrawLine(lineColor, this.prept, this.movept);
                }
            }
        }
      private void  drawHRulers(Graphics gr, Pen pen, Brush brush)
        {
            const int xOffset = 0;
            const int yOffset = 0;
            StringFormat strfmt = new StringFormat();
            strfmt.Alignment = StringAlignment.Center;
            for (int i = 1; i < gr.VisibleClipBounds.Width; i++)
            {
                if (i % 10 == 0)
                {
                    gr.DrawLine(pen, new PointF(xOffset + i, yOffset), new PointF(xOffset + i, yOffset + 2));
                    gr.DrawString((i / 10).ToString(), Font, brush, new PointF(xOffset + i, yOffset + 2), strfmt);
                }
                else if (i % 5 == 0)
                {
                    gr.DrawLine(pen, new PointF(xOffset + i, yOffset), new PointF(xOffset + i, yOffset + 1));
                }
                else
                {
                    gr.DrawLine(pen, new PointF(xOffset + i, yOffset), new PointF(xOffset + i, yOffset + 0.5f));
                }
            }
        }
        private void drawRulers()
        {
            Graphics gr = CreateGraphics();
            Pen pen = new Pen(Color.Red, 0.25f);
            Brush brush = new SolidBrush(Color.Red);
            gr.PageUnit = GraphicsUnit.Millimeter;
            gr.PageScale = 1f;
            drawHRulers(gr, pen, brush);
            gr.Dispose();
        }
       

        private void GraffitiForm_Paint(object sender, PaintEventArgs e)
        {
            drawRulers();
            if (this.pQueue.Count == 0)  return; 
            object pfirst = this.pQueue.Peek();
            foreach (object p in this.pQueue)
            {
                if (p is Point)
                {
                    if (pfirst is Point)
                    {
                        DrawLine(this.lineColor, (Point)pfirst, (Point)p);
                    }
                    pfirst = p;
                }
                if (p is Rectangle)
                {
                    Rectangle rect = (Rectangle)p;
                    DrawRectangle(this.lineColor, new Point(rect.X, rect.Y), rect.Size);
                }
                if (p is Model.PointImage)
                {
                    Model.PointImage pi = (Model.PointImage)p;
                        drawImage(pi.Pic,pi.Rect);
                }
            }
        }
        private void drawImage(Image img, Rectangle rect)
        {
            Graphics gr = CreateGraphics();
            gr.DrawImage(img, rect);
            gr.Dispose();
        }
        private void insertPicbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageDialog = new OpenFileDialog();
            openImageDialog.Filter = "图片|*.jpg";
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openImageDialog.FileName);
                Graphics gr = CreateGraphics();
                Rectangle rect = Rectangle.Ceiling(gr.VisibleClipBounds);
                foreach (object p in this.pQueue)
                {
                    if (p is Rectangle)
                        rect = (Rectangle)p;

                }
                gr.DrawImage(img, rect);
                Model.PointImage pi = new Model.PointImage();
                pi.Pic = img;
                pi.Rect = rect;
                pQueue.Enqueue(pi);
                
            }
        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lineToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            rectangleToolStripButton.Checked = !this.lineToolStripButton.Checked;
            this.lineRadioButton.Checked = lineToolStripButton.Checked;
            this.rectangleRadioButton.Checked = rectangleToolStripButton.Checked;
        }

        private void rectangleToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            this.lineToolStripButton.Checked = !rectangleToolStripButton.Checked;
            this.lineRadioButton.Checked = lineToolStripButton.Checked;
            this.rectangleRadioButton.Checked = rectangleToolStripButton.Checked;
        }

        private void GraffitiForm_Load(object sender, EventArgs e)
        {

        }

     
        


    }
}
