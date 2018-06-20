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
    public partial class CircleCb : CheckBox
    {
        public CircleCb()
        {
            InitializeComponent();
        }

        private Color borderColor;
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        private Color background;
        public Color Background
        {
            get { return background; }
            set { background = value; }
        }

        private Color tickColor;
        public Color TickColor
        {
            get { return tickColor; }
            set { tickColor = value; }
        }

        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; }
        }

        public void CircularCheckbox(bool IsChecked)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

            this.IsChecked = IsChecked;
            Background = Color.White;
            BorderColor = Color.Black;
            TickColor = Color.Green;
        }

    //    public void CircularCheckbox()
    //    : this(false)
    //{ }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rc = this.ClientRectangle;
            Graphics g = e.Graphics;
            StringFormat sf = new StringFormat();
            Font f = new Font("Arial", (float)rc.Height * 0.5f, FontStyle.Bold, GraphicsUnit.Pixel);

            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.FillEllipse(new SolidBrush(Background), rc.Left + 1.5f, rc.Top + 1.5f, rc.Width - 4.0f, rc.Height - 4.0f);
            g.DrawEllipse(new Pen(new SolidBrush(BorderColor), 3.0f), rc.Left + 1.5f, rc.Top + 1.5f, rc.Width - 4.0f, rc.Height - 4.0f);

            if (IsChecked)
                g.DrawString("\u2713", f, new SolidBrush(tickColor), rc, sf);

        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            IsChecked = IsChecked ? false : true;

            Invalidate();
        }
    }
}

