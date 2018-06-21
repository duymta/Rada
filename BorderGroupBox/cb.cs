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
    public partial class cb : CheckBox
    {
        public cb()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.Clear(this.BackColor);
            //this.AutoSize = true;
           

            Pen bd = new Pen(Color.LightSeaGreen, 2);
            Point pt = new Point(pe.ClipRectangle.Left+1 , pe.ClipRectangle.Top+1);
            Rectangle rect = new Rectangle(pt, new Size(15, 15));
           
           pe.Graphics.DrawRectangle(bd,rect);
            if (this.Checked)
            {
                using (Font wing = new Font("Wingdings", 12f))
                    pe.Graphics.DrawString("ü", wing, Brushes.LightSeaGreen, rect);
            }

           // //roudercorner
           // int bor = 2;
           // int start = 1;
           // int end = 17;
           // //bd=20
           // //start:50,50    150,150
           //// Pen bd = new Pen(Color.Green, bor);
           // Rectangle rect1 = new Rectangle(start + bor / 2, start + bor / 2, bor, bor);
           // Rectangle rect2 = new Rectangle(start + bor / 2, end - bor * 3 / 2, bor, bor);
           // Rectangle rect3 = new Rectangle(end - bor * 3 / 2, end - bor * 3 / 2, bor, bor);
           // Rectangle rect4 = new Rectangle(end - bor * 3 / 2, start + bor / 2, bor, bor);
           // pe.Graphics.DrawArc(bd, rect1, 180, 90);

           // //left
           // pe.Graphics.DrawLine(bd, start + bor / 2, start + bor, start + bor / 2, end - bor);
           // //buttom
           // pe.Graphics.DrawLine(bd, start + bor, end - bor / 2, end - bor, end - bor / 2);

           // pe.Graphics.DrawArc(bd, rect2, 90, 90);
           // pe.Graphics.DrawArc(bd, rect3, 0, 90);
           // pe.Graphics.DrawArc(bd, rect4, 270, 90);
           // //right
           // pe.Graphics.DrawLine(bd, end - bor / 2, end - bor, end - bor / 2, start + bor);
           // //top
           // pe.Graphics.DrawLine(bd, start + bor, start + bor / 2, end - bor, start + bor / 2);





            pe.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 20, 0);

           

        }
    }
}
