namespace Administration_in_Gotel
{
   partial class Form2
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
         this.OK = new System.Windows.Forms.Button();
         this.NO = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // OK
         // 
         this.OK.Location = new System.Drawing.Point(12, 12);
         this.OK.Name = "OK";
         this.OK.Size = new System.Drawing.Size(35, 23);
         this.OK.TabIndex = 0;
         this.OK.Text = "OK";
         this.OK.UseVisualStyleBackColor = true;
         this.OK.Click += new System.EventHandler(this.OK_Click);
         // 
         // NO
         // 
         this.NO.Location = new System.Drawing.Point(77, 12);
         this.NO.Name = "NO";
         this.NO.Size = new System.Drawing.Size(35, 23);
         this.NO.TabIndex = 1;
         this.NO.Text = "NO";
         this.NO.UseVisualStyleBackColor = true;
         this.NO.Click += new System.EventHandler(this.NO_Click);
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(120, 54);
         this.Controls.Add(this.NO);
         this.Controls.Add(this.OK);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form2";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button OK;
      private System.Windows.Forms.Button NO;
   }
}