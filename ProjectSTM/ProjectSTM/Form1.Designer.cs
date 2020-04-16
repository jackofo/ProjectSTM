namespace ProjectSTM
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comPortsCB = new System.Windows.Forms.ComboBox();
			this.baudRateCB = new System.Windows.Forms.ComboBox();
			this.dataBitsCB = new System.Windows.Forms.ComboBox();
			this.stopBitsCB = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.parityCB = new System.Windows.Forms.ComboBox();
			this.consoleBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label1.Location = new System.Drawing.Point(6, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "COM";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label2.Location = new System.Drawing.Point(6, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "BAUD RATE";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label3.Location = new System.Drawing.Point(6, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "DATA BITS";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label4.Location = new System.Drawing.Point(6, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "STOP BITS";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comPortsCB
			// 
			this.comPortsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comPortsCB.FormattingEnabled = true;
			this.comPortsCB.Location = new System.Drawing.Point(110, 31);
			this.comPortsCB.Name = "comPortsCB";
			this.comPortsCB.Size = new System.Drawing.Size(121, 24);
			this.comPortsCB.Sorted = true;
			this.comPortsCB.TabIndex = 5;
			// 
			// baudRateCB
			// 
			this.baudRateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.baudRateCB.FormattingEnabled = true;
			this.baudRateCB.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
			this.baudRateCB.Location = new System.Drawing.Point(110, 61);
			this.baudRateCB.Name = "baudRateCB";
			this.baudRateCB.Size = new System.Drawing.Size(121, 24);
			this.baudRateCB.Sorted = true;
			this.baudRateCB.TabIndex = 6;
			// 
			// dataBitsCB
			// 
			this.dataBitsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dataBitsCB.FormattingEnabled = true;
			this.dataBitsCB.Items.AddRange(new object[] {
            "8",
            "9"});
			this.dataBitsCB.Location = new System.Drawing.Point(110, 91);
			this.dataBitsCB.Name = "dataBitsCB";
			this.dataBitsCB.Size = new System.Drawing.Size(121, 24);
			this.dataBitsCB.Sorted = true;
			this.dataBitsCB.TabIndex = 7;
			// 
			// stopBitsCB
			// 
			this.stopBitsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stopBitsCB.FormattingEnabled = true;
			this.stopBitsCB.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
			this.stopBitsCB.Location = new System.Drawing.Point(110, 122);
			this.stopBitsCB.Name = "stopBitsCB";
			this.stopBitsCB.Size = new System.Drawing.Size(121, 24);
			this.stopBitsCB.Sorted = true;
			this.stopBitsCB.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label5.Location = new System.Drawing.Point(6, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "PARITY";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// parityCB
			// 
			this.parityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.parityCB.FormattingEnabled = true;
			this.parityCB.Items.AddRange(new object[] {
            "Even",
            "None",
            "Odd"});
			this.parityCB.Location = new System.Drawing.Point(110, 152);
			this.parityCB.Name = "parityCB";
			this.parityCB.Size = new System.Drawing.Size(121, 24);
			this.parityCB.Sorted = true;
			this.parityCB.TabIndex = 10;
			// 
			// consoleBox
			// 
			this.consoleBox.BackColor = System.Drawing.Color.Black;
			this.consoleBox.Font = new System.Drawing.Font("Consolas", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.consoleBox.ForeColor = System.Drawing.Color.White;
			this.consoleBox.Location = new System.Drawing.Point(436, 12);
			this.consoleBox.Multiline = true;
			this.consoleBox.Name = "consoleBox";
			this.consoleBox.ReadOnly = true;
			this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.consoleBox.Size = new System.Drawing.Size(352, 426);
			this.consoleBox.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(225, 31);
			this.button1.TabIndex = 12;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.parityCB);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.stopBitsCB);
			this.groupBox1.Controls.Add(this.dataBitsCB);
			this.groupBox1.Controls.Add(this.baudRateCB);
			this.groupBox1.Controls.Add(this.comPortsCB);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 219);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connection Settings";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(406, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(24, 24);
			this.button2.TabIndex = 14;
			this.button2.Text = "<";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Gray;
			this.label6.ForeColor = System.Drawing.Color.GreenYellow;
			this.label6.Location = new System.Drawing.Point(51, 30);
			this.label6.MinimumSize = new System.Drawing.Size(50, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 50);
			this.label6.TabIndex = 15;
			this.label6.Text = "  ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Gray;
			this.label7.ForeColor = System.Drawing.Color.GreenYellow;
			this.label7.Location = new System.Drawing.Point(107, 30);
			this.label7.MinimumSize = new System.Drawing.Size(50, 50);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 50);
			this.label7.TabIndex = 16;
			this.label7.Text = "  ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Gray;
			this.label8.ForeColor = System.Drawing.Color.GreenYellow;
			this.label8.Location = new System.Drawing.Point(165, 30);
			this.label8.MinimumSize = new System.Drawing.Size(50, 50);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 50);
			this.label8.TabIndex = 17;
			this.label8.Text = "  ";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Gray;
			this.label9.ForeColor = System.Drawing.Color.GreenYellow;
			this.label9.Location = new System.Drawing.Point(165, 89);
			this.label9.MinimumSize = new System.Drawing.Size(50, 50);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 50);
			this.label9.TabIndex = 20;
			this.label9.Text = "  ";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Gray;
			this.label10.ForeColor = System.Drawing.Color.GreenYellow;
			this.label10.Location = new System.Drawing.Point(107, 89);
			this.label10.MinimumSize = new System.Drawing.Size(50, 50);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(50, 50);
			this.label10.TabIndex = 19;
			this.label10.Text = "  ";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Gray;
			this.label11.ForeColor = System.Drawing.Color.GreenYellow;
			this.label11.Location = new System.Drawing.Point(51, 89);
			this.label11.MinimumSize = new System.Drawing.Size(50, 50);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(50, 50);
			this.label11.TabIndex = 18;
			this.label11.Text = "  ";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Gray;
			this.label12.ForeColor = System.Drawing.Color.GreenYellow;
			this.label12.Location = new System.Drawing.Point(165, 147);
			this.label12.MinimumSize = new System.Drawing.Size(50, 50);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 50);
			this.label12.TabIndex = 23;
			this.label12.Text = "  ";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Gray;
			this.label13.ForeColor = System.Drawing.Color.GreenYellow;
			this.label13.Location = new System.Drawing.Point(107, 147);
			this.label13.MinimumSize = new System.Drawing.Size(50, 50);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(50, 50);
			this.label13.TabIndex = 22;
			this.label13.Text = "  ";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Gray;
			this.label14.ForeColor = System.Drawing.Color.GreenYellow;
			this.label14.Location = new System.Drawing.Point(51, 147);
			this.label14.MinimumSize = new System.Drawing.Size(50, 50);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(50, 50);
			this.label14.TabIndex = 21;
			this.label14.Text = "  ";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(280, 258);
			this.tabControl1.TabIndex = 24;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(272, 229);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Connection";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(272, 229);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Game";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.consoleBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "ProjectSTM";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comPortsCB;
		private System.Windows.Forms.ComboBox baudRateCB;
		private System.Windows.Forms.ComboBox dataBitsCB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox parityCB;
		private System.Windows.Forms.TextBox consoleBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox stopBitsCB;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
	}
}

