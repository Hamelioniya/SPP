using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class StandartFont : FontOfText
    {
        public StandartFont()
        {
            this.textColor = System.Drawing.Color.Black;
            this.textFont = new Font("Tahoma", 8);
        }
    }
}
