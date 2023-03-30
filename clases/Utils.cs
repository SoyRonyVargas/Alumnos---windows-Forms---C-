using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdq.clases
{
    internal class Utils
    {
        public static void showDialog( string msg )
        {
            string message = msg;
            
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            
            MessageBox.Show( message, "", buttons);
        }
    }
}
