using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Administration_in_Gotel
{
   public partial class GeneralForm:Form
   {
      public GeneralForm( )
      {
         InitializeComponent( );
         toolStripStatusLabel3.Text = "PC Name: "+ Environment.UserName;
         timer1.Start( );
         foreach(TextBox Obj in GetAll(this,typeof(TextBox)))
         {
            Obj.MouseEnter += Tip;
            Obj.MouseLeave += Obj_MouseLeave;
         }
         foreach(Button Obj in GetAll(this,typeof(Button)))
         {
            Obj.MouseEnter += Tip;
            Obj.MouseLeave += Obj_MouseLeave;
         }
      }
      private void Obj_MouseLeave(object sender,EventArgs e)
      {
         toolStripStatusLabel4.Text = "";
      }
      public IEnumerable<Control> GetAll(Control control,Type type)
      {
         var controls = control.Controls.Cast<Control>();

         return controls.SelectMany(ctrl => GetAll(ctrl,type))
                                   .Concat(controls)
                                   .Where(c => c.GetType( ) == type);
      }      
      private void ClearAllTextBoxes(Form f)
      {
         foreach(object Odj in f.Controls)
            if(Odj is TextBox)
               (Odj as TextBox).Text = " ";
      }
      private void ClearButt_Click(object sender,EventArgs e)
      {
         Form2 Fr2 = new Form2();
         this.Hide( );
         Fr2.ShowDialog( );
         if(Fr2.State == true)
            ClearAllTextBoxes(this);
         this.Show( );
      }
      private void DeleteButt_Click(object sender,EventArgs e)
      {
         Form3 Fr3 = new Form3();
         Fr3.ShowDialog( );
         if(Fr3.state == true)
            ClearAllTextBoxes(this);
      }
      private void SaveButt_Click(object sender,EventArgs e)
      {
         MessageBox.Show("Сохранить?","Сохранение",MessageBoxButtons.YesNo,MessageBoxIcon.Question);           
      }
      private void Anketa_Click(object sender,EventArgs e)
      {
         SetapInfomation Setinf = new SetapInfomation();
         Setinf.ShowDialog( );
      }
      private void ourContactsToolStripMenuItem1_Click(object sender,EventArgs e)
      {
         OurContacts OC = new OurContacts();
         OC.ShowDialog( );
      }
      private void feedBackToolStripMenuItem1_Click(object sender,EventArgs e)
      {
         Form4 FeedBack = new Form4();
         FeedBack.ShowDialog( );
      }
      private void calculToolStripMenuItem_Click(object sender,EventArgs e)
      {
         Form5 calculator = new Form5();
         calculator.ShowDialog( );
      }
      private void feedBackToolStripMenuItem_Click(object sender,EventArgs e)
      {
         if(MessageBox.Show("Вы уверены что хотите выйти","Выход",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            Close( );
      }
      private void Form1_Scroll(object sender,ScrollEventArgs e)
      {
         Console.WriteLine("scrolling");
      }
      private void timer1_Tick(object sender,EventArgs e)
      {
         this.Text = this.Text.Remove(0,1) + this.Text[0];
         toolStripStatusLabel1.Text = toolStripStatusLabel1.Text.Replace(Control.IsKeyLocked(Keys.CapsLock) ? "OFF" : "ON ",Control.IsKeyLocked(Keys.CapsLock) ? "ON " : "OFF");
         toolStripStatusLabel2.Text = toolStripStatusLabel1.Text.Replace(Control.IsKeyLocked(Keys.NumLock) ? "OFF" : "ON ",Control.IsKeyLocked(Keys.NumLock) ? "ON " : "OFF");
      }
      private void Tip(object sender, EventArgs e)
      {
         toolStripStatusLabel4.Text = ((Control)sender).Tag ==null?"": ((Control)sender).Tag+"";
      }
      private void GeneralForm_Resize(object sender,EventArgs e)
      {
         if(WindowState == FormWindowState.Minimized)
         {
            Hide( );

            notifyIcon1.BalloonTipTitle = "Программа была спрятана";
            notifyIcon1.BalloonTipText = "Обратите внимание что программа была спрятана в трей и продолжит свою работу.";
            notifyIcon1.ShowBalloonTip(1000);
         }
      }
      private void notifyIcon1_DoubleClick(object sender,EventArgs e)
      {
         Show( );
         WindowState = FormWindowState.Normal;
      }
      private void Font_Click(object sender,EventArgs e)
      {
         var t = (Control)sender;
         string name = ((Control)sender).Name.Replace("Font","");
         fontDialog1.Font = t.Parent.Controls[name].Font;
         fontDialog1.Color = t.Parent.Controls[name].ForeColor;
         if(fontDialog1.ShowDialog( ) != DialogResult.Cancel)
         {
            t.Parent.Controls[name].Font = fontDialog1.Font;
            t.Parent.Controls[name].ForeColor = fontDialog1.Color;
         }
      }
      private void button4_Click(object sender,EventArgs e)
      {
         fontDialog1.Font = this.Font;
         fontDialog1.Color = this.ForeColor;

         if(fontDialog1.ShowDialog( ) != DialogResult.Cancel)
         {
            this.Font = fontDialog1.Font;
            this.ForeColor = fontDialog1.Color;
         }
      }
      private void TextBoxColour_Click(object sender,EventArgs e)
      {
         var t = (Control)sender;
         string name = ((Control)sender).Name.Replace("Color","");
         colorDialog1.Color = t.Parent.Controls[name].BackColor;
         if (colorDialog1.ShowDialog() != DialogResult.Cancel)
         {
            t.Parent.Controls[name].BackColor = colorDialog1.Color;
         }
      }
      private void FormColor1_Click(object sender,EventArgs e)
      {
         colorDialog1.Color = this.BackColor;
         if(colorDialog1.ShowDialog( ) != DialogResult.Cancel)
         {
            this.BackColor = colorDialog1.Color;
         }
      }

      private void textBox2_TextChanged(object sender,EventArgs e)
      {

      }
   }
}
