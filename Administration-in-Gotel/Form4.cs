using System;
using System.Windows.Forms;

namespace Administration_in_Gotel
{
   public partial class Form4:Form
   {
      public Form4( )
      {
         InitializeComponent( );
      }

      private void Pusha_Click(object sender,EventArgs e)
      {
         if(MessageTextBox.Text != "" && maskedTextBox.Text != "(   )    -")
         {
            if(MessageTextBox.Text != "")
            {
               if(maskedTextBox.Text == "(   )    -")
                  MessageBox.Show("Не введено номер телфона");
            }
            else
               MessageBox.Show("Не введено текст");
         }
         MessageBox.Show("Сообщение отправлено на номер " + maskedTextBox.Text,"",MessageBoxButtons.OK);
         Close( );
      }

      private void CancelButt_Click(object sender,EventArgs e)
      {
         if(MessageTextBox.Text != "" || maskedTextBox.Text != "(   )    -")
         {
            if(MessageBox.Show("Вы уверены что хотите выйти \n Если вы вийдете, сообщение не сохраниться","Выход",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
               Close( );
         }
         else
            Close( );
      }
   }
}
