using System;
using System.Windows.Forms;

namespace Administration_in_Gotel
{
   public partial class Form3:Form
   {
      public bool state { get; set; }
      public Form3( )
      {
         InitializeComponent( );
      }

      private void OKbutt_Click(object sender,EventArgs e)
      {
         state = true;
         Close( );
      }

      private void CancelButt_Click(object sender,EventArgs e)
      {
         Close( );
      }
   }
}
