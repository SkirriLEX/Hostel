namespace Administration_in_Gotel
{
   partial class Form3
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
         this.OKbutt = new System.Windows.Forms.Button();
         this.CancelButt = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // OKbutt
         // 
         this.OKbutt.Location = new System.Drawing.Point(12, 72);
         this.OKbutt.Name = "OKbutt";
         this.OKbutt.Size = new System.Drawing.Size(75, 23);
         this.OKbutt.TabIndex = 4;
         this.OKbutt.Text = "OK";
         this.OKbutt.UseVisualStyleBackColor = true;
         this.OKbutt.Click += new System.EventHandler(this.OKbutt_Click);
         // 
         // CancelButt
         // 
         this.CancelButt.Location = new System.Drawing.Point(104, 72);
         this.CancelButt.Name = "CancelButt";
         this.CancelButt.Size = new System.Drawing.Size(75, 23);
         this.CancelButt.TabIndex = 5;
         this.CancelButt.Text = "Cancel";
         this.CancelButt.UseVisualStyleBackColor = true;
         this.CancelButt.Click += new System.EventHandler(this.CancelButt_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(14, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(173, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Удалить все значение в форме?";
         // 
         // Form3
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(199, 107);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.CancelButt);
         this.Controls.Add(this.OKbutt);
         this.Name = "Form3";
         this.Text = "Form3";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button OKbutt;
      private System.Windows.Forms.Button CancelButt;
      private System.Windows.Forms.Label label1;
   }
}