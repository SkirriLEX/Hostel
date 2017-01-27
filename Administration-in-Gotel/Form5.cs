using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration_in_Gotel
{
   public partial class Form5:Form
   {
      public int result { get; set; }
      public Form5( )
      {
         InitializeComponent( );
      }

      private void calc_Click(object sender,EventArgs e)
      {
         result = (Convert.ToInt32(CountBox.Text) * Convert.ToInt32(NumberBox.Text));
         ResultBox.Text = Convert.ToString(result);
      }

      private void ExitButt_Click(object sender,EventArgs e)
      {
         Close( );
      }
   }
}
