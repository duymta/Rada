using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorderGroupBox
{
    public partial class groupx : System.Windows.Forms.GroupBox
    {
        public groupx()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            base.OnPaint(pe);
            Brush textBrush = new SolidBrush(BackColor);
            Brush borderBrush = new SolidBrush(BackColor);
            // Pen borderPen = new Pen(borderBrush);
            Pen borderPen = new Pen(Color.White, 3);
            Pen borderPen1 = new Pen(Color.White, 3);
            Pen borderPen3 = new Pen(Color.White, 4);

            SizeF strSize =g.MeasureString(this.Text, this.Font);
            Rectangle rect = new Rectangle(this.ClientRectangle.X,
                                           this.ClientRectangle.Y + (int)(strSize.Height / 2),
                                           this.ClientRectangle.Width - 1,
                                           this.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Clear text and border
            g.Clear(this.BackColor);

            // Draw text
            // g.DrawString(this.Text, this.Font, textBrush, this.Padding.Left, 0);
            g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.Padding.Left,0);

            // Drawing Border
            //Left
            g.DrawLine(borderPen3, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            //Right
            g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Bottom
            g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Top1
            g.DrawLine(borderPen1, new Point(rect.X, rect.Y), new Point(rect.X + this.Padding.Left, rect.Y));
            //Top2
            g.DrawLine(borderPen1, new Point(rect.X + this.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));

            //Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            ////GraphicsPath GraphPath = new GraphicsPath();
            //g.DrawArc(borderPen,Rect.X, Rect.Y, 2, 2, 180, 225);
            //g.DrawArc(borderPen,Rect.X + Rect.Width - 2, Rect.Y, 2, 2, 270, 90);
            //g.DrawArc(borderPen,Rect.X + Rect.Width - 2, Rect.Y + Rect.Height - 2, 2, 2, 0, 90);
            //g.DrawArc(borderPen,Rect.X, Rect.Y + Rect.Height - 2, 2, 2, 135, 180);
            ////this.Region = new Region(GraphPath);
        }
    
    }
}
