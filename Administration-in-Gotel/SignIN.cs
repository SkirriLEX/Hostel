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
   public partial class SignIN:Form
   {
      public SignIN( )
      {
         InitializeComponent( );
      }
      private void Cancel_Butt_Click(object sender,EventArgs e)
      {
         if(MessageBox.Show("Вы уверены что хотите выйти","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            Close( );
      }

      private void Enter_Butt_Click(object sender,EventArgs e)
      {

      }
   }
}
