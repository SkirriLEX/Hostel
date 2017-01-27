using System;
using System.Windows.Forms;

namespace Administration_in_Gotel
{
   public partial class OurContacts:Form
   {
      public OurContacts( )
      {
         InitializeComponent( );
         tlTipInf.SetToolTip(TelephoneTBox,"Чтобы скопировать текст, нажмите на него, и он занесется в буфер обмена");
         tlTipInf.SetToolTip(MailTBox,"Чтобы скопировать текст, нажмите на него, и он занесется в буфер обмена");
      }
      [STAThread]

      private void MailTBox_Click(object sender,EventArgs e)
      {
         Clipboard.Clear( );
         Clipboard.SetText("Germanovich@gmail.com");
      }

      private void TelephoneTBox_Click(object sender,EventArgs e)
      {
         Clipboard.Clear( );
         Clipboard.SetText("(095)3428673");
      }
   }
}
