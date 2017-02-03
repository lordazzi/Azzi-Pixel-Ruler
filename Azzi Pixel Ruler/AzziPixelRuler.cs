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
        public Orientation orientacao = Orientation.VERTICAL;
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
            this.alternarOrientacao();
        }

        public void alternarOrientacao()
        {
            if (this.orientacao == Orientation.HORIZONTAL)
            {
                this.orientacao = Orientation.VERTICAL;
                this.Width = this.defaultWidth;
                HorizontalBackground.Visible = false;
                VerticalBackground.Visible = true;

                //
                LinhaMarcador.Size = new Size(60, 1);
            }

            else if (this.orientacao == Orientation.VERTICAL)
            {
                this.orientacao = Orientation.HORIZONTAL;
                this.Height = this.defaultHeight;
                HorizontalBackground.Visible = true;
                VerticalBackground.Visible = false;

                //
                LinhaMarcador.Size = new Size(1, 60);
            }

            this.atualizarMarcador();
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

            if (this.orientacao == Orientation.HORIZONTAL)
            {
                int w = Cursor.Position.X - this.Location.X;
                this.Width = (w <= 50 ? 50 : w) + 25;
                HorizontalBackground.Width = this.Width + this.defaultImageMargin;
                qtdMarcacoesNecessarias = HorizontalBackground.Width / 100;
            }

            else if (this.orientacao == Orientation.VERTICAL)
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
                    MarcacaoLabel label = new MarcacaoLabel(this.orientacao, i);
                    label.MouseClick += new MouseEventHandler(this.AzziPixelRuler_MouseClick);
                    label.MouseDown += new MouseEventHandler(this.Offset_MouseDown);
                    this.marcacoes.Add(label);
                    this.Controls.Add(label);
                }
            }

            this.atualizarMarcador();
        }

        private void atualizarMarcador()
        {
            int paraOnde = 0;

            if (this.orientacao == Orientation.HORIZONTAL)
            {
                paraOnde = Cursor.Position.X - this.Location.X;
                if ((paraOnde - this.defaultImageMargin + 1) < 0)
                    paraOnde = this.defaultImageMargin - 1;

                //
                LinhaMarcador.Location = new Point(paraOnde, 0);
                ContextoLabelMarcador.Location = new Point(paraOnde - 9, 17);
                LabelMarcador.Location = new Point(paraOnde - 7, 21);
            }

            else if (this.orientacao == Orientation.VERTICAL)
            {
                paraOnde = Cursor.Position.Y - this.Location.Y;
                if ((paraOnde - this.defaultImageMargin + 1) < 0)
                    paraOnde = this.defaultImageMargin - 1;

                //
                LinhaMarcador.Location = new Point(0, paraOnde);
                ContextoLabelMarcador.Location = new Point(13, paraOnde - 7);
                LabelMarcador.Location = new Point(15, paraOnde - 3);
            }

            LabelMarcador.Text = (paraOnde - this.defaultImageMargin + 1).ToString();
        }

        private void AzziPixelRuler_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.alternarOrientacao();
            }
        }

        private void Offset_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            MouseEventArgs evt = new MouseEventArgs(e.Button, e.Clicks, e.Location.X + control.Location.X, e.Location.Y + control.Location.Y, e.Delta);
            this.AzziPixelRuler_MouseDown(this, evt);
        }
    }
}
