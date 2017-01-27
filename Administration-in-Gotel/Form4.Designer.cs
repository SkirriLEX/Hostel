namespace Administration_in_Gotel
{
   partial class Form4
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
         this.MessageTextBox = new System.Windows.Forms.TextBox();
         this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
         this.Push = new System.Windows.Forms.Button();
         this.CancelButt = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // MessageTextBox
         // 
         this.MessageTextBox.Location = new System.Drawing.Point(26, 31);
         this.MessageTextBox.Multiline = true;
         this.MessageTextBox.Name = "MessageTextBox";
         this.MessageTextBox.Size = new System.Drawing.Size(389, 234);
         this.MessageTextBox.TabIndex = 0;
         // 
         // maskedTextBox
         // 
         this.maskedTextBox.Location = new System.Drawing.Point(253, 287);
         this.maskedTextBox.Mask = "(999) 000-0000";
         this.maskedTextBox.Name = "maskedTextBox";
         this.maskedTextBox.Size = new System.Drawing.Size(86, 20);
         this.maskedTextBox.TabIndex = 2;
         // 
         // Push
         // 
         this.Push.Location = new System.Drawing.Point(26, 284);
         this.Push.Name = "Push";
         this.Push.Size = new System.Drawing.Size(75, 23);
         this.Push.TabIndex = 3;
         this.Push.Text = "Push";
         this.Push.UseVisualStyleBackColor = true;
         this.Push.Click += new System.EventHandler(this.Pusha_Click);
         // 
         // CancelButt
         // 
         this.CancelButt.Location = new System.Drawing.Point(26, 314);
         this.CancelButt.Name = "CancelButt";
         this.CancelButt.Size = new System.Drawing.Size(75, 23);
         this.CancelButt.TabIndex = 4;
         this.CancelButt.Text = "Cancel";
         this.CancelButt.UseVisualStyleBackColor = true;
         this.CancelButt.Click += new System.EventHandler(this.CancelButt_Click);
         // 
         // Form4
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(459, 354);
         this.Controls.Add(this.CancelButt);
         this.Controls.Add(this.Push);
         this.Controls.Add(this.maskedTextBox);
         this.Controls.Add(this.MessageTextBox);
         this.Name = "Form4";
         this.Text = "Form4";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox MessageTextBox;
      private System.Windows.Forms.MaskedTextBox maskedTextBox;
      private System.Windows.Forms.Button Push;
      private System.Windows.Forms.Button CancelButt;
   }
}