namespace Administration_in_Gotel
{
   partial class OurContacts
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if(disposing && (components != null))
         {
            components.Dispose( );
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent( )
      {
         this.components = new System.ComponentModel.Container();
         this.TelephoneTBox = new System.Windows.Forms.Label();
         this.MailTBox = new System.Windows.Forms.Label();
         this.tlTipInf = new System.Windows.Forms.ToolTip(this.components);
         this.SuspendLayout();
         // 
         // TelephoneTBox
         // 
         this.TelephoneTBox.AutoSize = true;
         this.TelephoneTBox.Location = new System.Drawing.Point(12, 9);
         this.TelephoneTBox.Name = "TelephoneTBox";
         this.TelephoneTBox.Size = new System.Drawing.Size(130, 13);
         this.TelephoneTBox.TabIndex = 0;
         this.TelephoneTBox.Text = "Telephone: (095)3428673";
         this.TelephoneTBox.Click += new System.EventHandler(this.TelephoneTBox_Click);
         // 
         // MailTBox
         // 
         this.MailTBox.AutoSize = true;
         this.MailTBox.Location = new System.Drawing.Point(12, 31);
         this.MailTBox.Name = "MailTBox";
         this.MailTBox.Size = new System.Drawing.Size(153, 13);
         this.MailTBox.TabIndex = 1;
         this.MailTBox.Text = "Mail: Germanovich@gmail.com";
         this.MailTBox.Click += new System.EventHandler(this.MailTBox_Click);
         // 
         // OurContacts
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(185, 56);
         this.Controls.Add(this.MailTBox);
         this.Controls.Add(this.TelephoneTBox);
         this.Name = "OurContacts";
         this.Text = "OurContacts";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label TelephoneTBox;
      private System.Windows.Forms.Label MailTBox;
      private System.Windows.Forms.ToolTip tlTipInf;
   }
}