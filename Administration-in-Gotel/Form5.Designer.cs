namespace Administration_in_Gotel
{
   partial class Form5
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
         this.CountBox = new System.Windows.Forms.TextBox();
         this.NumberBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.calc = new System.Windows.Forms.Button();
         this.ResultBox = new System.Windows.Forms.TextBox();
         this.ExitButt = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // CountBox
         // 
         this.CountBox.Location = new System.Drawing.Point(12, 27);
         this.CountBox.Name = "CountBox";
         this.CountBox.Size = new System.Drawing.Size(100, 20);
         this.CountBox.TabIndex = 0;
         // 
         // NumberBox
         // 
         this.NumberBox.Location = new System.Drawing.Point(143, 27);
         this.NumberBox.Name = "NumberBox";
         this.NumberBox.Size = new System.Drawing.Size(100, 20);
         this.NumberBox.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(24, 11);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(76, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Кількість днів";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(149, 11);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(90, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Вартість номеру";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label3.Location = new System.Drawing.Point(119, 33);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(15, 20);
         this.label3.TabIndex = 4;
         this.label3.Text = "*";
         // 
         // calc
         // 
         this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
         this.calc.Location = new System.Drawing.Point(12, 62);
         this.calc.Name = "calc";
         this.calc.Size = new System.Drawing.Size(75, 23);
         this.calc.TabIndex = 5;
         this.calc.Text = "Обрахувати";
         this.calc.UseVisualStyleBackColor = true;
         this.calc.Click += new System.EventHandler(this.calc_Click);
         // 
         // ResultBox
         // 
         this.ResultBox.Location = new System.Drawing.Point(93, 64);
         this.ResultBox.Name = "ResultBox";
         this.ResultBox.Size = new System.Drawing.Size(100, 20);
         this.ResultBox.TabIndex = 6;
         // 
         // ExitButt
         // 
         this.ExitButt.Location = new System.Drawing.Point(235, 62);
         this.ExitButt.Name = "ExitButt";
         this.ExitButt.Size = new System.Drawing.Size(26, 23);
         this.ExitButt.TabIndex = 7;
         this.ExitButt.Text = "exit";
         this.ExitButt.UseVisualStyleBackColor = true;
         this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
         // 
         // Form5
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 110);
         this.Controls.Add(this.ExitButt);
         this.Controls.Add(this.ResultBox);
         this.Controls.Add(this.calc);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.NumberBox);
         this.Controls.Add(this.CountBox);
         this.Name = "Form5";
         this.Text = "Calculator";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox CountBox;
      private System.Windows.Forms.TextBox NumberBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button calc;
      private System.Windows.Forms.TextBox ResultBox;
      private System.Windows.Forms.Button ExitButt;
   }
}