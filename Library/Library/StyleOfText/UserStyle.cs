using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class UserStyle : FontOfText
    {
        public UserStyle()
        {
            this.textColor = System.Drawing.Color.CadetBlue;
            this.textFont = new System.Drawing.Font("Book Antiqua", 10, System.Drawing.FontStyle.Bold);
        }
    }
}
