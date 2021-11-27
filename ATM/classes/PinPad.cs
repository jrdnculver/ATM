using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public class PinPad
    {

        public StringBuilder assignButton(StringBuilder build, string number)
        {
            StringBuilder text = build;

            text.Append(number);

            return text;
        }
        

        public void stringClear()
        {
            changepin.pinAccessOne.Clear();
        }
    }
}
