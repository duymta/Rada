using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Pen bd = new Pen(Color.LightSeaGreen, 2);
            Point pt = new Point(pe.ClipRectangle.Left+1 , pe.ClipRectangle.Top);
            Rectangle rect = new Rectangle(pt, new Size(17, 17));
            pe.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 20, 0);
            if (this.Checked)
            {
                using (Font wing = new Font("Wingdings", 12f))
                    pe.Graphics.DrawString("ü", wing, Brushes.LightSeaGreen, rect);
            }
            pe.Graphics.DrawRectangle(bd, rect);
        }
    }
}
