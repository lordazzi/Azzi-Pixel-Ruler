using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azzi_Pixel_Ruler
{
    public partial class AzziPixelRuler : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Orientation orientation = Orientation.VERTICAL;
        public int defaultImageMargin = 15;
        public List<MarcacaoLabel> marcacoes = new List<MarcacaoLabel>();

        // http://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // http://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private int defaultHeight = 60;
        private int defaultWidth = 60;

        public AzziPixelRuler()
        {
            InitializeComponent();
            this.Height = this.defaultHeight;
            this.Width = this.defaultWidth;
            HorizontalBackground.Location = new Point(this.defaultImageMargin, HorizontalBackground.Location.Y);
            VerticalBackground.Location = new Point(VerticalBackground.Location.X, this.defaultImageMargin);
            this.toggleOrientation();
        }

        public void toggleOrientation()
        {
            if (this.orientation == Orientation.HORIZONTAL)
            {
                this.orientation = Orientation.VERTICAL;
                this.Width = this.defaultWidth;
                HorizontalBackground.Visible = false;
                VerticalBackground.Visible = true;
            }

            else if (this.orientation == Orientation.VERTICAL)
            {
                this.orientation = Orientation.HORIZONTAL;
                this.Height = this.defaultHeight;
                HorizontalBackground.Visible = true;
                VerticalBackground.Visible = false;
            }
        }

        private void AzziPixelRuler_MouseDown(object sender, MouseEventArgs e)
        {
            // http://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MouseMovementListener_Tick(object sender, EventArgs e)
        {
            int qtdMarcacoesNecessarias = 0;

            if (this.orientation == Orientation.HORIZONTAL)
            {
                int w = Cursor.Position.X - this.Location.X;
                this.Width = (w <= 50 ? 50 : w) + 25;
                HorizontalBackground.Width = this.Width + this.defaultImageMargin;
                qtdMarcacoesNecessarias = HorizontalBackground.Width / 100;
            }

            else if (this.orientation == Orientation.VERTICAL)
            {
                int h = Cursor.Position.Y - this.Location.Y;
                this.Height = (h <= 50 ? 50 : h) + 25;
                VerticalBackground.Height = this.Height + this.defaultImageMargin;
                qtdMarcacoesNecessarias = VerticalBackground.Height / 100;
            }

            if (qtdMarcacoesNecessarias != this.marcacoes.Count)
            {
                for (int j = 0; j < this.marcacoes.Count; j++)
                    this.Controls.Remove(this.marcacoes.ElementAt(j));
                
                this.marcacoes = new List<MarcacaoLabel>();
                for (int i = 0; i < qtdMarcacoesNecessarias; i++)
                {
                    MarcacaoLabel label = new MarcacaoLabel(this.orientation, i);
                    this.marcacoes.Add(label);
                    this.Controls.Add(label);
                }
            }
        }

        private void AzziPixelRuler_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.toggleOrientation();
            }
        }
        
        private void VerticalBackground_MouseClick(object sender, MouseEventArgs e)
        {
            this.AzziPixelRuler_MouseClick(this, e);
        }

        private void HorizontalBackground_MouseClick(object sender, MouseEventArgs e)
        {
            this.AzziPixelRuler_MouseClick(this, e);
        }

        private void VerticalBackground_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs evt = new MouseEventArgs(e.Button, e.Clicks, e.Location.X, e.Location.Y + this.defaultImageMargin, e.Delta);
            this.AzziPixelRuler_MouseDown(this, evt);
        }

        private void HorizontalBackground_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs evt = new MouseEventArgs(e.Button, e.Clicks, e.Location.X + this.defaultImageMargin, e.Location.Y, e.Delta);
            this.AzziPixelRuler_MouseDown(this, evt);
        }
    }
}
