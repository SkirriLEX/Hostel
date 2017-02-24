namespace Administration_in_Gotel
{
   partial class SignIN
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
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.Mail_label = new System.Windows.Forms.Label();
         this.Password_label = new System.Windows.Forms.Label();
         this.Enter_Butt = new System.Windows.Forms.Button();
         this.Cancel_Butt = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(87, 12);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(124, 20);
         this.textBox1.TabIndex = 0;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(87, 38);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(124, 20);
         this.textBox2.TabIndex = 1;
         // 
         // Mail_label
         // 
         this.Mail_label.AutoSize = true;
         this.Mail_label.Location = new System.Drawing.Point(21, 15);
         this.Mail_label.Name = "Mail_label";
         this.Mail_label.Size = new System.Drawing.Size(26, 13);
         this.Mail_label.TabIndex = 2;
         this.Mail_label.Text = "Mail";
         // 
         // Password_label
         // 
         this.Password_label.AutoSize = true;
         this.Password_label.Location = new System.Drawing.Point(21, 40);
         this.Password_label.Name = "Password_label";
         this.Password_label.Size = new System.Drawing.Size(53, 13);
         this.Password_label.TabIndex = 3;
         this.Password_label.Text = "Password";
         // 
         // Enter_Butt
         // 
         this.Enter_Butt.Location = new System.Drawing.Point(217, 10);
         this.Enter_Butt.Name = "Enter_Butt";
         this.Enter_Butt.Size = new System.Drawing.Size(75, 23);
         this.Enter_Butt.TabIndex = 4;
         this.Enter_Butt.Text = "Enter";
         this.Enter_Butt.UseVisualStyleBackColor = true;
         this.Enter_Butt.Click += new System.EventHandler(this.Enter_Butt_Click);
         // 
         // Cancel_Butt
         // 
         this.Cancel_Butt.Location = new System.Drawing.Point(217, 35);
         this.Cancel_Butt.Name = "Cancel_Butt";
         this.Cancel_Butt.Size = new System.Drawing.Size(75, 23);
         this.Cancel_Butt.TabIndex = 5;
         this.Cancel_Butt.Text = "Cancel";
         this.Cancel_Butt.UseVisualStyleBackColor = true;
         this.Cancel_Butt.Click += new System.EventHandler(this.Cancel_Butt_Click);
         // 
         // SignIN
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(298, 68);
         this.Controls.Add(this.Cancel_Butt);
         this.Controls.Add(this.Enter_Butt);
         this.Controls.Add(this.Password_label);
         this.Controls.Add(this.Mail_label);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "SignIN";
         this.Text = "SignIN";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label Mail_label;
      private System.Windows.Forms.Label Password_label;
      private System.Windows.Forms.Button Enter_Butt;
      private System.Windows.Forms.Button Cancel_Butt;
   }
}