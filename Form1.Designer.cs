﻿namespace 设备维修预约系统
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("华文行楷", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(290, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(372, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "设备维修预约系统";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(275, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "账户:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(279, 322);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "密码:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(396, 208);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(286, 35);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(396, 322);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(286, 35);
			this.textBox2.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(283, 448);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 51);
			this.button1.TabIndex = 5;
			this.button1.Text = "登录";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(561, 448);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(139, 51);
			this.button2.TabIndex = 6;
			this.button2.Text = "注册";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(298, 391);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(89, 28);
			this.radioButton1.TabIndex = 7;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "客户";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(430, 391);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(137, 28);
			this.radioButton2.TabIndex = 8;
			this.radioButton2.Text = "维修人员";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(587, 391);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(113, 28);
			this.radioButton3.TabIndex = 9;
			this.radioButton3.Text = "管理员";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 670);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
	}
}

