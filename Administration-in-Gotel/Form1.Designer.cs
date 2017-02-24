namespace Administration_in_Gotel
{
   partial class GeneralForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
         this.ClearButt = new System.Windows.Forms.Button();
         this.DeleteButt = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.SaveButt = new System.Windows.Forms.Button();
         this.Anketa = new System.Windows.Forms.Button();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.ourContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.feedBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.ourContactsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.feedBackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.calculToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.textBoxColor3 = new System.Windows.Forms.Button();
         this.textBoxColor2 = new System.Windows.Forms.Button();
         this.textBoxColor1 = new System.Windows.Forms.Button();
         this.textBoxFont3 = new System.Windows.Forms.Button();
         this.textBoxFont2 = new System.Windows.Forms.Button();
         this.textBoxFont1 = new System.Windows.Forms.Button();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
         this.кожуховаАлінаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.щукаБогданToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.кожуховаАлінаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
         this.fontDialog1 = new System.Windows.Forms.FontDialog();
         this.FormFont4 = new System.Windows.Forms.Button();
         this.colorDialog1 = new System.Windows.Forms.ColorDialog();
         this.FormColor1 = new System.Windows.Forms.Button();
         this.Registartion_Butt = new System.Windows.Forms.Button();
         this.menuStrip1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // ClearButt
         // 
         this.ClearButt.Location = new System.Drawing.Point(295, 83);
         this.ClearButt.Name = "ClearButt";
         this.ClearButt.Size = new System.Drawing.Size(64, 23);
         this.ClearButt.TabIndex = 5;
         this.ClearButt.Tag = "Clear text ";
         this.ClearButt.Text = "Clear";
         this.ClearButt.UseVisualStyleBackColor = true;
         this.ClearButt.Click += new System.EventHandler(this.ClearButt_Click);
         // 
         // DeleteButt
         // 
         this.DeleteButt.Location = new System.Drawing.Point(295, 25);
         this.DeleteButt.Name = "DeleteButt";
         this.DeleteButt.Size = new System.Drawing.Size(64, 23);
         this.DeleteButt.TabIndex = 3;
         this.DeleteButt.Tag = "Delete All text";
         this.DeleteButt.Text = "Delete";
         this.DeleteButt.UseVisualStyleBackColor = true;
         this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(27, 28);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(196, 20);
         this.textBox1.TabIndex = 0;
         this.textBox1.Tag = "Some Text";
         this.textBox1.Text = "Какойто текст";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(27, 54);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(196, 20);
         this.textBox2.TabIndex = 1;
         this.textBox2.Tag = "Some Text";
         this.textBox2.Text = "Какойто текст";
         // 
         // SaveButt
         // 
         this.SaveButt.Location = new System.Drawing.Point(295, 54);
         this.SaveButt.Name = "SaveButt";
         this.SaveButt.Size = new System.Drawing.Size(64, 23);
         this.SaveButt.TabIndex = 4;
         this.SaveButt.Tag = "Save text";
         this.SaveButt.Text = "Save";
         this.SaveButt.UseVisualStyleBackColor = true;
         this.SaveButt.Click += new System.EventHandler(this.SaveButt_Click);
         // 
         // Anketa
         // 
         this.Anketa.Location = new System.Drawing.Point(466, 27);
         this.Anketa.Name = "Anketa";
         this.Anketa.Size = new System.Drawing.Size(86, 31);
         this.Anketa.TabIndex = 2;
         this.Anketa.Tag = "Анкета для регистрации";
         this.Anketa.Text = "Sign In";
         this.Anketa.UseVisualStyleBackColor = true;
         this.Anketa.Click += new System.EventHandler(this.Anketa_Click);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ourContactsToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(561, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // ourContactsToolStripMenuItem
         // 
         this.ourContactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedBackToolStripMenuItem});
         this.ourContactsToolStripMenuItem.Name = "ourContactsToolStripMenuItem";
         this.ourContactsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.ourContactsToolStripMenuItem.Text = "File";
         // 
         // feedBackToolStripMenuItem
         // 
         this.feedBackToolStripMenuItem.Name = "feedBackToolStripMenuItem";
         this.feedBackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
         this.feedBackToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
         this.feedBackToolStripMenuItem.Text = "Exit";
         this.feedBackToolStripMenuItem.Click += new System.EventHandler(this.feedBackToolStripMenuItem_Click);
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ourContactsToolStripMenuItem1,
            this.feedBackToolStripMenuItem1,
            this.calculToolStripMenuItem});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.helpToolStripMenuItem.Text = "Help";
         // 
         // ourContactsToolStripMenuItem1
         // 
         this.ourContactsToolStripMenuItem1.Name = "ourContactsToolStripMenuItem1";
         this.ourContactsToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
         this.ourContactsToolStripMenuItem1.Text = "Our Contacts";
         this.ourContactsToolStripMenuItem1.Click += new System.EventHandler(this.ourContactsToolStripMenuItem1_Click);
         // 
         // feedBackToolStripMenuItem1
         // 
         this.feedBackToolStripMenuItem1.Name = "feedBackToolStripMenuItem1";
         this.feedBackToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
         this.feedBackToolStripMenuItem1.Text = "Feed Back";
         this.feedBackToolStripMenuItem1.Click += new System.EventHandler(this.feedBackToolStripMenuItem1_Click);
         // 
         // calculToolStripMenuItem
         // 
         this.calculToolStripMenuItem.Name = "calculToolStripMenuItem";
         this.calculToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
         this.calculToolStripMenuItem.Text = "Calcul";
         this.calculToolStripMenuItem.Click += new System.EventHandler(this.calculToolStripMenuItem_Click);
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(27, 80);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(196, 20);
         this.textBox3.TabIndex = 2;
         this.textBox3.Tag = "Some Text";
         this.textBox3.Text = "Какойто текст";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.textBoxColor3);
         this.groupBox1.Controls.Add(this.textBoxColor2);
         this.groupBox1.Controls.Add(this.textBoxColor1);
         this.groupBox1.Controls.Add(this.textBoxFont3);
         this.groupBox1.Controls.Add(this.textBoxFont2);
         this.groupBox1.Controls.Add(this.textBoxFont1);
         this.groupBox1.Controls.Add(this.textBox1);
         this.groupBox1.Controls.Add(this.textBox3);
         this.groupBox1.Controls.Add(this.SaveButt);
         this.groupBox1.Controls.Add(this.textBox2);
         this.groupBox1.Controls.Add(this.DeleteButt);
         this.groupBox1.Controls.Add(this.ClearButt);
         this.groupBox1.Location = new System.Drawing.Point(12, 29);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(365, 144);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         // 
         // textBoxColor3
         // 
         this.textBoxColor3.Location = new System.Drawing.Point(253, 79);
         this.textBoxColor3.Name = "textBoxColor3";
         this.textBoxColor3.Size = new System.Drawing.Size(24, 20);
         this.textBoxColor3.TabIndex = 15;
         this.textBoxColor3.Tag = "Set Text BackColor";
         this.textBoxColor3.Text = "C";
         this.textBoxColor3.UseVisualStyleBackColor = true;
         this.textBoxColor3.Click += new System.EventHandler(this.TextBoxColour_Click);
         // 
         // textBoxColor2
         // 
         this.textBoxColor2.Location = new System.Drawing.Point(253, 53);
         this.textBoxColor2.Name = "textBoxColor2";
         this.textBoxColor2.Size = new System.Drawing.Size(24, 20);
         this.textBoxColor2.TabIndex = 10;
         this.textBoxColor2.Tag = "Set Text BackColor";
         this.textBoxColor2.Text = "C";
         this.textBoxColor2.UseVisualStyleBackColor = true;
         this.textBoxColor2.Click += new System.EventHandler(this.TextBoxColour_Click);
         // 
         // textBoxColor1
         // 
         this.textBoxColor1.Location = new System.Drawing.Point(253, 28);
         this.textBoxColor1.Name = "textBoxColor1";
         this.textBoxColor1.Size = new System.Drawing.Size(24, 20);
         this.textBoxColor1.TabIndex = 9;
         this.textBoxColor1.Tag = "Set Text BackColor";
         this.textBoxColor1.Text = "C";
         this.textBoxColor1.UseVisualStyleBackColor = true;
         this.textBoxColor1.Click += new System.EventHandler(this.TextBoxColour_Click);
         // 
         // textBoxFont3
         // 
         this.textBoxFont3.Location = new System.Drawing.Point(230, 79);
         this.textBoxFont3.Name = "textBoxFont3";
         this.textBoxFont3.Size = new System.Drawing.Size(24, 20);
         this.textBoxFont3.TabIndex = 8;
         this.textBoxFont3.Tag = "Set text font ";
         this.textBoxFont3.Text = "...";
         this.textBoxFont3.UseVisualStyleBackColor = true;
         this.textBoxFont3.Click += new System.EventHandler(this.Font_Click);
         // 
         // textBoxFont2
         // 
         this.textBoxFont2.Location = new System.Drawing.Point(230, 53);
         this.textBoxFont2.Name = "textBoxFont2";
         this.textBoxFont2.Size = new System.Drawing.Size(24, 20);
         this.textBoxFont2.TabIndex = 7;
         this.textBoxFont2.Tag = "Set text font ";
         this.textBoxFont2.Text = "...";
         this.textBoxFont2.UseVisualStyleBackColor = true;
         this.textBoxFont2.Click += new System.EventHandler(this.Font_Click);
         // 
         // textBoxFont1
         // 
         this.textBoxFont1.Location = new System.Drawing.Point(230, 28);
         this.textBoxFont1.Name = "textBoxFont1";
         this.textBoxFont1.Size = new System.Drawing.Size(24, 20);
         this.textBoxFont1.TabIndex = 6;
         this.textBoxFont1.Tag = "Set text font ";
         this.textBoxFont1.Text = "...";
         this.textBoxFont1.UseVisualStyleBackColor = true;
         this.textBoxFont1.Click += new System.EventHandler(this.Font_Click);
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
         this.statusStrip1.Location = new System.Drawing.Point(0, 195);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(561, 22);
         this.statusStrip1.TabIndex = 14;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.AutoToolTip = true;
         this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
         this.toolStripStatusLabel1.Text = "Caps Lock ON ";
         this.toolStripStatusLabel1.ToolTipText = "СapsLock Status";
         // 
         // toolStripStatusLabel2
         // 
         this.toolStripStatusLabel2.AutoToolTip = true;
         this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
         this.toolStripStatusLabel2.Size = new System.Drawing.Size(81, 17);
         this.toolStripStatusLabel2.Text = "numLock ON ";
         this.toolStripStatusLabel2.ToolTipText = "numLockStatus";
         // 
         // toolStripSplitButton1
         // 
         this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кожуховаАлінаToolStripMenuItem1,
            this.щукаБогданToolStripMenuItem,
            this.кожуховаАлінаToolStripMenuItem});
         this.toolStripSplitButton1.Image = global::Administration_in_Gotel.Properties.Resources.avaBogdan;
         this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripSplitButton1.Name = "toolStripSplitButton1";
         this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
         this.toolStripSplitButton1.Text = "toolStripSplitButton1";
         // 
         // кожуховаАлінаToolStripMenuItem1
         // 
         this.кожуховаАлінаToolStripMenuItem1.Image = global::Administration_in_Gotel.Properties.Resources.avaAlina;
         this.кожуховаАлінаToolStripMenuItem1.Name = "кожуховаАлінаToolStripMenuItem1";
         this.кожуховаАлінаToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
         this.кожуховаАлінаToolStripMenuItem1.Text = "Кожухова Аліна";
         // 
         // щукаБогданToolStripMenuItem
         // 
         this.щукаБогданToolStripMenuItem.Image = global::Administration_in_Gotel.Properties.Resources.avaBogdan;
         this.щукаБогданToolStripMenuItem.Name = "щукаБогданToolStripMenuItem";
         this.щукаБогданToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
         this.щукаБогданToolStripMenuItem.Text = "Щука Богдан";
         // 
         // кожуховаАлінаToolStripMenuItem
         // 
         this.кожуховаАлінаToolStripMenuItem.Image = global::Administration_in_Gotel.Properties.Resources.avaKirill;
         this.кожуховаАлінаToolStripMenuItem.Name = "кожуховаАлінаToolStripMenuItem";
         this.кожуховаАлінаToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
         this.кожуховаАлінаToolStripMenuItem.Text = "Андрієць Кирило";
         // 
         // toolStripStatusLabel3
         // 
         this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
         this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
         // 
         // toolStripStatusLabel4
         // 
         this.toolStripStatusLabel4.AutoSize = false;
         this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
         this.toolStripStatusLabel4.Size = new System.Drawing.Size(348, 17);
         this.toolStripStatusLabel4.Spring = true;
         // 
         // timer1
         // 
         this.timer1.Interval = 200;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // notifyIcon1
         // 
         this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
         this.notifyIcon1.Text = "Приложние свернуто";
         this.notifyIcon1.Visible = true;
         this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
         // 
         // fontDialog1
         // 
         this.fontDialog1.ShowColor = true;
         // 
         // FormFont4
         // 
         this.FormFont4.Location = new System.Drawing.Point(489, 139);
         this.FormFont4.Name = "FormFont4";
         this.FormFont4.Size = new System.Drawing.Size(24, 20);
         this.FormFont4.TabIndex = 9;
         this.FormFont4.Tag = "Set text font ";
         this.FormFont4.Text = "...";
         this.FormFont4.UseVisualStyleBackColor = true;
         this.FormFont4.Click += new System.EventHandler(this.button4_Click);
         // 
         // colorDialog1
         // 
         this.colorDialog1.AnyColor = true;
         // 
         // FormColor1
         // 
         this.FormColor1.Location = new System.Drawing.Point(515, 139);
         this.FormColor1.Name = "FormColor1";
         this.FormColor1.Size = new System.Drawing.Size(24, 20);
         this.FormColor1.TabIndex = 16;
         this.FormColor1.Tag = "Set Form BackColor";
         this.FormColor1.Text = "C";
         this.FormColor1.UseVisualStyleBackColor = true;
         this.FormColor1.Click += new System.EventHandler(this.FormColor1_Click);
         // 
         // Registartion_Butt
         // 
         this.Registartion_Butt.Location = new System.Drawing.Point(466, 64);
         this.Registartion_Butt.Name = "Registartion_Butt";
         this.Registartion_Butt.Size = new System.Drawing.Size(86, 31);
         this.Registartion_Butt.TabIndex = 17;
         this.Registartion_Butt.Tag = "Анкета для регистрации";
         this.Registartion_Butt.Text = "Registartion ";
         this.Registartion_Butt.UseVisualStyleBackColor = true;
         this.Registartion_Butt.Click += new System.EventHandler(this.button1_Click);
         // 
         // GeneralForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.AutoScroll = true;
         this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
         this.ClientSize = new System.Drawing.Size(561, 217);
         this.Controls.Add(this.Registartion_Butt);
         this.Controls.Add(this.FormColor1);
         this.Controls.Add(this.FormFont4);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.Anketa);
         this.Controls.Add(this.menuStrip1);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.HelpButton = true;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.Name = "GeneralForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Очень длинное название нуу очень длинное название ";
         this.Resize += new System.EventHandler(this.GeneralForm_Resize);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }


      #endregion

      private System.Windows.Forms.Button ClearButt;
      private System.Windows.Forms.Button DeleteButt;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Button SaveButt;
      private System.Windows.Forms.Button Anketa;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem ourContactsToolStripMenuItem;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ToolStripMenuItem feedBackToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem ourContactsToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem feedBackToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem calculToolStripMenuItem;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
      private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
      private System.Windows.Forms.ToolStripMenuItem кожуховаАлінаToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem щукаБогданToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem кожуховаАлінаToolStripMenuItem;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
      private System.Windows.Forms.NotifyIcon notifyIcon1;
      private System.Windows.Forms.Button textBoxFont3;
      private System.Windows.Forms.Button textBoxFont2;
      private System.Windows.Forms.Button textBoxFont1;
      private System.Windows.Forms.FontDialog fontDialog1;
      private System.Windows.Forms.Button FormFont4;
      private System.Windows.Forms.ColorDialog colorDialog1;
      private System.Windows.Forms.Button textBoxColor3;
      private System.Windows.Forms.Button textBoxColor2;
      private System.Windows.Forms.Button textBoxColor1;
      private System.Windows.Forms.Button FormColor1;
      private System.Windows.Forms.Button Registartion_Butt;
   }
}

