using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Mainning.MyPhotoControls
{
    [DefaultEvent("Click")]
    [DefaultProperty("Image")]
    [ToolboxBitmap(typeof(ScrollablePicturePox), "ScrollablePictureBox.bmp")]
    public class ScrollablePicturePox : PictureBox
    {
        private bool _allowScrollBars = true;
        [Browsable(true)]
        [Category("Layout")]
        [DefaultValue(true)]
        [Description("Gets or sets whether the control can display scroll bars")]
        public bool AllowScrollBars
        {
            get { return _allowScrollBars; }
            set
            {
                if (_allowScrollBars != value)
                {
                    _allowScrollBars = value;
                    Invalidate();
                }
            }
        }

        [Category("Action")]
        [Description("Occurs when a scoll bar is shown anf =d then image is scrolled")]
        public event ScrollEventHandler Scroll;
        protected virtual void OnScroll(ScrollEventArgs e)
        {
            if (Scroll != null)
                Scroll(this, e);
        }
        private HScrollBar _hbar = new HScrollBar();
        private VScrollBar _vbar = new VScrollBar();
        private Control _vbarContainer = new Control();

        private HScrollBar Hbar
        {
            get { return _hbar; }
        }
        private VScrollBar Vbar
        {
            get { return _vbar; }
        }
        private Control VContainer
        {
            get { return _vbarContainer; }
        }

        public new Image Image
        {
            get { return base.Image; }
            set
            {
                base.Image = value;
                ResetScrollBars();
            }
        }

        public ScrollablePicturePox()
        {
            // Initialize hoizontal scroll bar
            Hbar.Visible = false;
            Hbar.Dock = DockStyle.Bottom;
            Hbar.Minimum = 0;
            Hbar.Maximum = 1000;
            Hbar.Scroll += HandleScroll;

            // Invitialize vertical scroll bar container
            VContainer.Visible = false;
            VContainer.Width = Vbar.Width;
            VContainer.Height = Height;
            VContainer.Dock = DockStyle.Right;

            // Invitialize vertical scroll bar
            Vbar.Top = 0;
            Vbar.Left = 0;
            Vbar.Height = VContainer.Height - Hbar.Height;
            Vbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Vbar.Minimum = 0;
            Vbar.Maximum = 1000;
            Vbar.Scroll += HandleScroll;

            VContainer.Controls.Add(Vbar);

            Controls.Add(Hbar);
            Controls.Add(VContainer);

            DoubleBuffered = true;
        }

        private void HandleScroll(object sender, ScrollEventArgs e)
        {
            Refresh();
            OnScroll(e);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (Image != null && (Hbar.Visible || VContainer.Visible))
                DrawImage(pe.Graphics);
        }

        private void DrawImage(Graphics g)
        {
            Rectangle targerRect = new Rectangle(0, 0,
                                                 Math.Min(Right - Vbar.Width, Image. Width),
                                                 Math.Min(Bottom - Hbar.Height, Image.Height));
            Rectangle sourceRect = new Rectangle(Hbar.Value, Vbar.Value,
                                                 Math.Min(Right - Vbar.Width, Image.Width),
                                                 Math.Min(Bottom - Hbar.Height, Image.Height));

            if (SizeMode == PictureBoxSizeMode.CenterImage)
            {
                Point p = new Point(0, 0);

                if (Right - Vbar.Width > Image.Width)
                    p.X = Math.Max((ClientSize.Width - targerRect.Width) / 2, 0);
                if (Bottom - Hbar.Height > Image.Height)
                    p.Y = Math.Max((ClientSize.Height - targerRect.Height) / 2, 0);

                targerRect.Offset(p);
            }
            g.DrawImage(Image, targerRect, sourceRect, GraphicsUnit.Pixel);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (ScrollingActive())
            {
                AdjustScrollBars();
                Refresh();
            }
        }

        private bool ScrollingActive()
        {
            if (Image == null || AllowScrollBars == false
                || SizeMode != PictureBoxSizeMode.CenterImage
                && SizeMode != PictureBoxSizeMode.Normal)
            {
                Hbar.Visible = false;
                VContainer.Visible = false;
            }
            else
            {
                Hbar.Visible = Image.Width >= ClientSize.Width - Vbar.Width;
                VContainer.Visible = Image.Height >= ClientSize.Height - Hbar.Height;
            }
            return (Hbar.Visible || VContainer.Visible);
        }

        private void AdjustScrollBars()
        {
            if (Hbar.Visible)
            {
                int max = Image.Width - ClientSize.Width;
                Hbar.LargeChange = Math.Max(max / 10, 1);
                Hbar.SmallChange = Math.Max(max / 20, 1);

                Hbar.Maximum = max + Hbar.LargeChange;
                if (Vbar.Visible)
                    Hbar.Maximum += Vbar.Width;
            }
            if (VContainer.Visible)
            {
                if (Hbar.Visible)
                    Vbar.Height = Height;

                int max = Image.Height - ClientSize.Height;
                Vbar.LargeChange = Math.Max(max / 10, 1);
                Vbar.SmallChange = Math.Max(max / 20, 1);

                Vbar.Maximum = max + Vbar.LargeChange;
                if (Hbar.Visible)
                    Vbar.Maximum += Hbar.Height;
            }
        }

        protected override void OnSizeModeChanged(EventArgs e)
        {
            base.OnSizeModeChanged(e);
            ResetScrollBars();
        }

        private void ResetScrollBars()
        {
            Hbar.Value = 0;
            Vbar.Value = 0;
            if (Image != null && ScrollingActive())
            {
                AdjustScrollBars();
                if (SizeMode == PictureBoxSizeMode.CenterImage)
                {
                    Hbar.Value = Math.Abs(Image.Width / 2 - ClientSize.Width / 2);
                    Vbar.Value = Math.Abs(Image.Height / 2 - ClientSize.Height / 2);
                }
            }
        }
    }
}



