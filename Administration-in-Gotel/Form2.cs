using System;
using System.Windows.Forms;

namespace Administration_in_Gotel
{
   public partial class Form2:Form
   {
      public bool State { get; set; }
      public Form2( )
      {

         InitializeComponent( );
      }

      private void OK_Click(object sender,EventArgs e)
      {
         State = true;
         Close( );
      }      

      private void NO_Click(object sender,EventArgs e)
      {
         Close( );
      }
   }
}
