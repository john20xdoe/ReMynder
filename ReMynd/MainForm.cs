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
using ReMynder.Core;
using ReMynder.Models;

namespace ReMynder
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
			
			
			
		}
		
		protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadReminders();
        }

		
		private void MainForm_FormClose(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true; //cancel the dispose
		}
		
		
		void dtTimeValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void txtReminderTextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void btnSetClick(object sender, EventArgs e)
		{
			ReMynderCore.Instance.Reminder(new Reminder()
			{
				Message = txtReminder.Text,
				Trigger = dtTime.Value,
				Closed = false
			});
			LoadReminders();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		private void LoadReminders()
		{
			dataGridView1.DataSource = ReMynderCore.Instance.Reminders();
		}
	}
}
