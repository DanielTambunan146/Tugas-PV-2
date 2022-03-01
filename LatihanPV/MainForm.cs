/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/1/2022
 * Time: 4:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LatihanPV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(textBox1.Text);
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void NamaClick(object sender, EventArgs e)
		{
			
		}
	}
}
