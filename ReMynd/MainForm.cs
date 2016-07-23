/*
 * Created by SharpDevelop.
 * User: Zerotonin
 * Date: 7/23/2016
 * Time: 10:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReMynd
{
	/// <summary>
	/// Description of Form1.
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
		
		private void MainForm_FormClose(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true; //cancel the dispose
		}
		
		
		void dtTimeValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtReminderTextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void btnSetClick(object sender, EventArgs e)
		{
			
		}
	}
}
