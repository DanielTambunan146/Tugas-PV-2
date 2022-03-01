/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/1/2022
 * Time: 4:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LatihanPV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Insert = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.Nama = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Insert
			// 
			this.Insert.Location = new System.Drawing.Point(92, 188);
			this.Insert.Name = "Insert";
			this.Insert.Size = new System.Drawing.Size(116, 49);
			this.Insert.TabIndex = 0;
			this.Insert.Text = "Insert";
			this.Insert.UseVisualStyleBackColor = true;
			this.Insert.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(92, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(243, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(92, 101);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(242, 69);
			this.listBox1.TabIndex = 2;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// Nama
			// 
			this.Nama.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Nama.Location = new System.Drawing.Point(92, 9);
			this.Nama.Name = "Nama";
			this.Nama.Size = new System.Drawing.Size(137, 25);
			this.Nama.TabIndex = 3;
			this.Nama.Text = "Masukkan Nama:";
			this.Nama.Click += new System.EventHandler(this.NamaClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(253, 191);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 45);
			this.button1.TabIndex = 4;
			this.button1.Text = "Hapus";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 272);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Nama);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Insert);
			this.Name = "MainForm";
			this.Text = "LatihanPV";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label Nama;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Insert;
	}
}
