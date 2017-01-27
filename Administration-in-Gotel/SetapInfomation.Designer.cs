namespace Administration_in_Gotel
{
   partial class SetapInfomation
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
         this.Mail = new System.Windows.Forms.Label();
         this.Рassword = new System.Windows.Forms.Label();
         this.RepeatРassword = new System.Windows.Forms.Label();
         this.TboxMail = new System.Windows.Forms.TextBox();
         this.TboxPass = new System.Windows.Forms.TextBox();
         this.ClearButt = new System.Windows.Forms.Button();
         this.Set = new System.Windows.Forms.Button();
         this.CancelButt = new System.Windows.Forms.Button();
         this.TboxRPass = new System.Windows.Forms.TextBox();
         this.tTipInfCorectInput = new System.Windows.Forms.ToolTip(this.components);
         this.SuspendLayout();
         // 
         // Mail
         // 
         this.Mail.AutoSize = true;
         this.Mail.Location = new System.Drawing.Point(28, 20);
         this.Mail.Name = "Mail";
         this.Mail.Size = new System.Drawing.Size(26, 13);
         this.Mail.TabIndex = 3;
         this.Mail.Text = "Mail";
         this.Mail.Click += new System.EventHandler(this.Easy_Click);
         // 
         // Рassword
         // 
         this.Рassword.AutoSize = true;
         this.Рassword.Location = new System.Drawing.Point(28, 42);
         this.Рassword.Name = "Рassword";
         this.Рassword.Size = new System.Drawing.Size(53, 13);
         this.Рassword.TabIndex = 1;
         this.Рassword.Text = "Password";
         this.Рassword.Click += new System.EventHandler(this.Easy_Click);
         // 
         // RepeatРassword
         // 
         this.RepeatРassword.AutoSize = true;
         this.RepeatРassword.Location = new System.Drawing.Point(28, 64);
         this.RepeatРassword.Name = "RepeatРassword";
         this.RepeatРassword.Size = new System.Drawing.Size(91, 13);
         this.RepeatРassword.TabIndex = 2;
         this.RepeatРassword.Text = "Repeat Рassword";
         this.RepeatРassword.Click += new System.EventHandler(this.Easy_Click);
         // 
         // TboxMail
         // 
         this.TboxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TboxMail.ForeColor = System.Drawing.Color.Black;
         this.TboxMail.Location = new System.Drawing.Point(160, 17);
         this.TboxMail.Name = "TboxMail";
         this.TboxMail.Size = new System.Drawing.Size(100, 20);
         this.TboxMail.TabIndex = 0;
         this.TboxMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TboxMail_KeyPress);
         // 
         // TboxPass
         // 
         this.TboxPass.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TboxPass.ForeColor = System.Drawing.Color.Black;
         this.TboxPass.Location = new System.Drawing.Point(160, 39);
         this.TboxPass.MaxLength = 256;
         this.TboxPass.Name = "TboxPass";
         this.TboxPass.PasswordChar = '*';
         this.TboxPass.Size = new System.Drawing.Size(100, 21);
         this.TboxPass.TabIndex = 1;
         this.TboxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TboxPass_KeyPress);
         // 
         // ClearButt
         // 
         this.ClearButt.Location = new System.Drawing.Point(335, 14);
         this.ClearButt.Name = "ClearButt";
         this.ClearButt.Size = new System.Drawing.Size(75, 23);
         this.ClearButt.TabIndex = 3;
         this.ClearButt.Text = "Clear";
         this.ClearButt.UseVisualStyleBackColor = true;
         this.ClearButt.Click += new System.EventHandler(this.ClearButt_Click);
         // 
         // Set
         // 
         this.Set.Location = new System.Drawing.Point(335, 36);
         this.Set.Name = "Set";
         this.Set.Size = new System.Drawing.Size(75, 23);
         this.Set.TabIndex = 4;
         this.Set.Text = "Set";
         this.Set.UseVisualStyleBackColor = true;
         this.Set.Click += new System.EventHandler(this.Set_Click);
         // 
         // CancelButt
         // 
         this.CancelButt.Location = new System.Drawing.Point(335, 58);
         this.CancelButt.Name = "CancelButt";
         this.CancelButt.Size = new System.Drawing.Size(75, 23);
         this.CancelButt.TabIndex = 5;
         this.CancelButt.Text = "Cancel";
         this.CancelButt.UseVisualStyleBackColor = true;
         this.CancelButt.Click += new System.EventHandler(this.CancelButt_Click);
         // 
         // TboxRPass
         // 
         this.TboxRPass.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TboxRPass.ForeColor = System.Drawing.Color.Black;
         this.TboxRPass.Location = new System.Drawing.Point(160, 61);
         this.TboxRPass.MaxLength = 256;
         this.TboxRPass.Name = "TboxRPass";
         this.TboxRPass.PasswordChar = '*';
         this.TboxRPass.Size = new System.Drawing.Size(100, 21);
         this.TboxRPass.TabIndex = 2;
         this.TboxRPass.WordWrap = false;
         this.TboxRPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TboxPass_KeyPress);
         // 
         // SetapInfomation
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(435, 97);
         this.Controls.Add(this.TboxRPass);
         this.Controls.Add(this.CancelButt);
         this.Controls.Add(this.Set);
         this.Controls.Add(this.ClearButt);
         this.Controls.Add(this.TboxPass);
         this.Controls.Add(this.TboxMail);
         this.Controls.Add(this.Mail);
         this.Controls.Add(this.RepeatРassword);
         this.Controls.Add(this.Рassword);
         this.Name = "SetapInfomation";
         this.Text = "SetapInfomation";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label Mail;
      private System.Windows.Forms.Label Рassword;
      private System.Windows.Forms.Label RepeatРassword;
      private System.Windows.Forms.TextBox TboxMail;
      private System.Windows.Forms.TextBox TboxPass;
      private System.Windows.Forms.Button ClearButt;
      private System.Windows.Forms.Button Set;
      private System.Windows.Forms.Button CancelButt;
      private System.Windows.Forms.TextBox TboxRPass;
      private System.Windows.Forms.ToolTip tTipInfCorectInput;
   }
}