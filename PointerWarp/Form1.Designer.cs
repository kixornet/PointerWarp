namespace PointerWarp
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
			this.button_warpToggle = new System.Windows.Forms.Button();
			this.textBox_warpRange = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox_onTop = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_warpToggle
			// 
			this.button_warpToggle.Location = new System.Drawing.Point(6, 24);
			this.button_warpToggle.Name = "button_warpToggle";
			this.button_warpToggle.Size = new System.Drawing.Size(58, 23);
			this.button_warpToggle.TabIndex = 0;
			this.button_warpToggle.Text = "Engage";
			this.button_warpToggle.UseVisualStyleBackColor = true;
			this.button_warpToggle.Click += new System.EventHandler(this.button_warpToggle_Click);
			// 
			// textBox_warpRange
			// 
			this.textBox_warpRange.Location = new System.Drawing.Point(181, 22);
			this.textBox_warpRange.Name = "textBox_warpRange";
			this.textBox_warpRange.Size = new System.Drawing.Size(36, 20);
			this.textBox_warpRange.TabIndex = 2;
			this.textBox_warpRange.TextChanged += new System.EventHandler(this.textBox_warpRange_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Toggle: Shift+Backspace x2";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(165, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Warp range";
			// 
			// checkBox_onTop
			// 
			this.checkBox_onTop.AutoSize = true;
			this.checkBox_onTop.Checked = true;
			this.checkBox_onTop.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_onTop.Location = new System.Drawing.Point(70, 27);
			this.checkBox_onTop.Name = "checkBox_onTop";
			this.checkBox_onTop.Size = new System.Drawing.Size(92, 17);
			this.checkBox_onTop.TabIndex = 1;
			this.checkBox_onTop.Text = "Always on top";
			this.checkBox_onTop.UseVisualStyleBackColor = true;
			this.checkBox_onTop.CheckedChanged += new System.EventHandler(this.checkBox_onTop_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.label3.Location = new System.Drawing.Point(223, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "%";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(245, 52);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.checkBox_onTop);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_warpRange);
			this.Controls.Add(this.button_warpToggle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "PointerWarp";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox_warpRange;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox_onTop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_warpToggle;
	}
}

