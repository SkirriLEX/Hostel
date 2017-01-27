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
   public partial class SetapInfomation:Form
   {
      string Smail = "Sl@gmail.com";
      string Spass = "1234";
      public SetapInfomation( )
      {
         InitializeComponent( );
         tTipInfCorectInput.SetToolTip(TboxMail,Smail);
         tTipInfCorectInput.SetToolTip(Mail,Smail);
         tTipInfCorectInput.SetToolTip(TboxPass,Spass);
         tTipInfCorectInput.SetToolTip(Рassword,Spass);
         tTipInfCorectInput.SetToolTip(TboxRPass,Spass);
         tTipInfCorectInput.SetToolTip(RepeatРassword,Spass);
      }

      private void ClearButt_Click(object sender,EventArgs e)
      {
         TboxMail.Text = "";
         TboxPass.Text = "";
         TboxRPass.Text = "";
      }

      private void CancelButt_Click(object sender,EventArgs e)
      {
         if(MessageBox.Show("Вы уверены что хотите выйти","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            Close( );
      }

      private void Set_Click(object sender,EventArgs e)
      {
         int firstSymbol = TboxMail.Text.IndexOf("@");
         int secoundSymbol = TboxMail.Text.LastIndexOf(".");
         if(firstSymbol < 0 && secoundSymbol < 0 && secoundSymbol < firstSymbol + 3)
         {
            TboxMail.ForeColor = Color.IndianRed;
            MessageBox.Show("не верно веден емейл");
         }
         else
         {
            if(TboxPass.Text==TboxRPass.Text)
            {
               if(TboxMail.Text == Smail && TboxPass.Text == Spass)
               {
                  MessageBox.Show("Данный введени правельно","анкета");
                  Close( );
               }
               else
                  MessageBox.Show("Наведите мишкой на поле (ToolTip)");
            }
            else
            {
               TboxRPass.ForeColor = Color.IndianRed;
               MessageBox.Show("Пароли не совпадают");
            }
         }

      }

      private void TboxPass_KeyPress(object sender,KeyPressEventArgs e)
      {
         if(TboxRPass.ForeColor == Color.IndianRed)
            TboxRPass.ForeColor = Color.Black;
         if((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
            e.Handled = true;
      }

      private void TboxMail_KeyPress(object sender,KeyPressEventArgs e)
      {
         if(TboxMail.ForeColor == Color.IndianRed)
            TboxMail.ForeColor = Color.Black;
      }

      private void Easy_Click(object sender,EventArgs e)
      {
         TboxMail.Text = Smail;
         TboxRPass.Text = TboxPass.Text = Spass;
      }
   }
}
