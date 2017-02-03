using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Azzi_Pixel_Ruler
{
    public class MarcacaoLabel : Label
    {
        public MarcacaoLabel(Orientation orientation, int i)
        {
            this.ForeColor = Color.White;
            int currentPosition = (i + 1) * 100;
            this.Text = currentPosition.ToString();
            this.Font = new Font("Microsoft Sans Serif", 6);           

            if (orientation == Orientation.HORIZONTAL)
            {
                this.Location = new Point(currentPosition + 7, 20);
            }

            else if (orientation == Orientation.VERTICAL)
            {
                this.Location = new Point(15, currentPosition + 9);
            }
            
        }
    }
}
