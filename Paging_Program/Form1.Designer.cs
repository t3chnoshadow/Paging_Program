namespace Paging_Program
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AccessSequanceButton = new System.Windows.Forms.Button();
            this.AccessSequanceListBox = new System.Windows.Forms.ListBox();
            this.ASLLB = new System.Windows.Forms.Label();
            this.ASUD = new System.Windows.Forms.NumericUpDown();
            this.SetSizeButton = new System.Windows.Forms.Button();
            this.SetValButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numHDD = new System.Windows.Forms.NumericUpDown();
            this.lsbPages = new System.Windows.Forms.ListBox();
            this.btnGetPages = new System.Windows.Forms.Button();
            this.ASCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Pb_clock = new System.Windows.Forms.PictureBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblF0 = new System.Windows.Forms.Label();
            this.lblF3 = new System.Windows.Forms.Label();
            this.lblF6 = new System.Windows.Forms.Label();
            this.lblF9 = new System.Windows.Forms.Label();
            this.lblF1 = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.lblF4 = new System.Windows.Forms.Label();
            this.lblF5 = new System.Windows.Forms.Label();
            this.lblF7 = new System.Windows.Forms.Label();
            this.lblF8 = new System.Windows.Forms.Label();
            this.lblF10 = new System.Windows.Forms.Label();
            this.lblF11 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ASUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_clock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Access Sequance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buffer with 12 Frames";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "HDD";
            // 
            // AccessSequanceButton
            // 
            this.AccessSequanceButton.Location = new System.Drawing.Point(29, 347);
            this.AccessSequanceButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AccessSequanceButton.Name = "AccessSequanceButton";
            this.AccessSequanceButton.Size = new System.Drawing.Size(124, 48);
            this.AccessSequanceButton.TabIndex = 4;
            this.AccessSequanceButton.Text = "Create random access Squance";
            this.AccessSequanceButton.UseVisualStyleBackColor = true;
            this.AccessSequanceButton.Click += new System.EventHandler(this.AccessSequanceButton_Click);
            // 
            // AccessSequanceListBox
            // 
            this.AccessSequanceListBox.FormattingEnabled = true;
            this.AccessSequanceListBox.Location = new System.Drawing.Point(29, 155);
            this.AccessSequanceListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AccessSequanceListBox.Name = "AccessSequanceListBox";
            this.AccessSequanceListBox.Size = new System.Drawing.Size(60, 186);
            this.AccessSequanceListBox.TabIndex = 5;
            // 
            // ASLLB
            // 
            this.ASLLB.AutoSize = true;
            this.ASLLB.Location = new System.Drawing.Point(27, 80);
            this.ASLLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ASLLB.Name = "ASLLB";
            this.ASLLB.Size = new System.Drawing.Size(130, 13);
            this.ASLLB.TabIndex = 7;
            this.ASLLB.Text = "Access Sequance Length";
            // 
            // ASUD
            // 
            this.ASUD.Location = new System.Drawing.Point(29, 97);
            this.ASUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ASUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ASUD.Name = "ASUD";
            this.ASUD.Size = new System.Drawing.Size(124, 20);
            this.ASUD.TabIndex = 9;
            this.ASUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SetSizeButton
            // 
            this.SetSizeButton.Location = new System.Drawing.Point(29, 119);
            this.SetSizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SetSizeButton.Name = "SetSizeButton";
            this.SetSizeButton.Size = new System.Drawing.Size(124, 30);
            this.SetSizeButton.TabIndex = 10;
            this.SetSizeButton.Text = "Set Size";
            this.SetSizeButton.UseVisualStyleBackColor = true;
            this.SetSizeButton.Click += new System.EventHandler(this.SetSizeButton_Click);
            // 
            // SetValButton
            // 
            this.SetValButton.Location = new System.Drawing.Point(93, 177);
            this.SetValButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SetValButton.Name = "SetValButton";
            this.SetValButton.Size = new System.Drawing.Size(61, 54);
            this.SetValButton.TabIndex = 11;
            this.SetValButton.Text = "Set Val";
            this.SetValButton.UseVisualStyleBackColor = true;
            this.SetValButton.Click += new System.EventHandler(this.SetValButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of pages in harddrrive ";
            // 
            // numHDD
            // 
            this.numHDD.Location = new System.Drawing.Point(494, 97);
            this.numHDD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numHDD.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.numHDD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHDD.Name = "numHDD";
            this.numHDD.Size = new System.Drawing.Size(124, 20);
            this.numHDD.TabIndex = 13;
            this.numHDD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lsbPages
            // 
            this.lsbPages.FormattingEnabled = true;
            this.lsbPages.Location = new System.Drawing.Point(526, 119);
            this.lsbPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbPages.Name = "lsbPages";
            this.lsbPages.Size = new System.Drawing.Size(60, 225);
            this.lsbPages.TabIndex = 14;
            // 
            // btnGetPages
            // 
            this.btnGetPages.Location = new System.Drawing.Point(494, 347);
            this.btnGetPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetPages.Name = "btnGetPages";
            this.btnGetPages.Size = new System.Drawing.Size(124, 48);
            this.btnGetPages.TabIndex = 15;
            this.btnGetPages.Text = "Get pages from HDD";
            this.btnGetPages.UseVisualStyleBackColor = true;
            this.btnGetPages.Click += new System.EventHandler(this.btnGetPages_Click);
            // 
            // ASCB
            // 
            this.ASCB.FormattingEnabled = true;
            this.ASCB.Location = new System.Drawing.Point(93, 155);
            this.ASCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ASCB.Name = "ASCB";
            this.ASCB.Size = new System.Drawing.Size(62, 21);
            this.ASCB.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pb_clock
            // 
            this.Pb_clock.Location = new System.Drawing.Point(235, 137);
            this.Pb_clock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pb_clock.Name = "Pb_clock";
            this.Pb_clock.Size = new System.Drawing.Size(202, 203);
            this.Pb_clock.TabIndex = 18;
            this.Pb_clock.TabStop = false;
            this.Pb_clock.Click += new System.EventHandler(this.Pb_clock_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(260, 397);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(150, 48);
            this.btn_Start.TabIndex = 19;
            this.btn_Start.Text = "Start Paging Replacement";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblF0
            // 
            this.lblF0.AutoSize = true;
            this.lblF0.Location = new System.Drawing.Point(316, 119);
            this.lblF0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF0.Name = "lblF0";
            this.lblF0.Size = new System.Drawing.Size(36, 13);
            this.lblF0.TabIndex = 20;
            this.lblF0.Text = "Empty";
            // 
            // lblF3
            // 
            this.lblF3.AutoSize = true;
            this.lblF3.Location = new System.Drawing.Point(433, 232);
            this.lblF3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF3.Name = "lblF3";
            this.lblF3.Size = new System.Drawing.Size(36, 13);
            this.lblF3.TabIndex = 21;
            this.lblF3.Text = "Empty";
            // 
            // lblF6
            // 
            this.lblF6.AutoSize = true;
            this.lblF6.Location = new System.Drawing.Point(316, 347);
            this.lblF6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF6.Name = "lblF6";
            this.lblF6.Size = new System.Drawing.Size(36, 13);
            this.lblF6.TabIndex = 22;
            this.lblF6.Text = "Empty";
            // 
            // lblF9
            // 
            this.lblF9.AutoSize = true;
            this.lblF9.Location = new System.Drawing.Point(195, 232);
            this.lblF9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF9.Name = "lblF9";
            this.lblF9.Size = new System.Drawing.Size(36, 13);
            this.lblF9.TabIndex = 23;
            this.lblF9.Text = "Empty";
            // 
            // lblF1
            // 
            this.lblF1.AutoSize = true;
            this.lblF1.Location = new System.Drawing.Point(374, 128);
            this.lblF1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(36, 13);
            this.lblF1.TabIndex = 24;
            this.lblF1.Text = "Empty";
            // 
            // lblF2
            // 
            this.lblF2.AutoSize = true;
            this.lblF2.Location = new System.Drawing.Point(433, 177);
            this.lblF2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(36, 13);
            this.lblF2.TabIndex = 25;
            this.lblF2.Text = "Empty";
            // 
            // lblF4
            // 
            this.lblF4.AutoSize = true;
            this.lblF4.Location = new System.Drawing.Point(433, 281);
            this.lblF4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF4.Name = "lblF4";
            this.lblF4.Size = new System.Drawing.Size(36, 13);
            this.lblF4.TabIndex = 26;
            this.lblF4.Text = "Empty";
            // 
            // lblF5
            // 
            this.lblF5.AutoSize = true;
            this.lblF5.Location = new System.Drawing.Point(382, 343);
            this.lblF5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF5.Name = "lblF5";
            this.lblF5.Size = new System.Drawing.Size(36, 13);
            this.lblF5.TabIndex = 27;
            this.lblF5.Text = "Empty";
            // 
            // lblF7
            // 
            this.lblF7.AutoSize = true;
            this.lblF7.Location = new System.Drawing.Point(257, 343);
            this.lblF7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF7.Name = "lblF7";
            this.lblF7.Size = new System.Drawing.Size(36, 13);
            this.lblF7.TabIndex = 28;
            this.lblF7.Text = "Empty";
            // 
            // lblF8
            // 
            this.lblF8.AutoSize = true;
            this.lblF8.Location = new System.Drawing.Point(207, 289);
            this.lblF8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF8.Name = "lblF8";
            this.lblF8.Size = new System.Drawing.Size(36, 13);
            this.lblF8.TabIndex = 29;
            this.lblF8.Text = "Empty";
            // 
            // lblF10
            // 
            this.lblF10.AutoSize = true;
            this.lblF10.Location = new System.Drawing.Point(207, 177);
            this.lblF10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF10.Name = "lblF10";
            this.lblF10.Size = new System.Drawing.Size(36, 13);
            this.lblF10.TabIndex = 30;
            this.lblF10.Text = "Empty";
            // 
            // lblF11
            // 
            this.lblF11.AutoSize = true;
            this.lblF11.Location = new System.Drawing.Point(257, 128);
            this.lblF11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF11.Name = "lblF11";
            this.lblF11.Size = new System.Drawing.Size(36, 13);
            this.lblF11.TabIndex = 31;
            this.lblF11.Text = "Empty";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(664, 97);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 264);
            this.listBox1.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 455);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblF11);
            this.Controls.Add(this.lblF10);
            this.Controls.Add(this.lblF8);
            this.Controls.Add(this.lblF7);
            this.Controls.Add(this.lblF5);
            this.Controls.Add(this.lblF4);
            this.Controls.Add(this.lblF2);
            this.Controls.Add(this.lblF1);
            this.Controls.Add(this.lblF9);
            this.Controls.Add(this.lblF6);
            this.Controls.Add(this.lblF3);
            this.Controls.Add(this.lblF0);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.Pb_clock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ASCB);
            this.Controls.Add(this.btnGetPages);
            this.Controls.Add(this.lsbPages);
            this.Controls.Add(this.numHDD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SetValButton);
            this.Controls.Add(this.SetSizeButton);
            this.Controls.Add(this.ASUD);
            this.Controls.Add(this.ASLLB);
            this.Controls.Add(this.AccessSequanceListBox);
            this.Controls.Add(this.AccessSequanceButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ASUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_clock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AccessSequanceButton;
        private System.Windows.Forms.ListBox AccessSequanceListBox;
        private System.Windows.Forms.Label ASLLB;
        private System.Windows.Forms.NumericUpDown ASUD;
        private System.Windows.Forms.Button SetSizeButton;
        private System.Windows.Forms.Button SetValButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numHDD;
        private System.Windows.Forms.ListBox lsbPages;
        private System.Windows.Forms.Button btnGetPages;
        private System.Windows.Forms.ComboBox ASCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Pb_clock;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblF0;
        private System.Windows.Forms.Label lblF3;
        private System.Windows.Forms.Label lblF6;
        private System.Windows.Forms.Label lblF9;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.Label lblF4;
        private System.Windows.Forms.Label lblF5;
        private System.Windows.Forms.Label lblF7;
        private System.Windows.Forms.Label lblF8;
        private System.Windows.Forms.Label lblF10;
        private System.Windows.Forms.Label lblF11;
        private System.Windows.Forms.ListBox listBox1;
    }
}

