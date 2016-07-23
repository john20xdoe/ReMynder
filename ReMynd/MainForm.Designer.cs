/*
 * Created by SharpDevelop.
 * User: Zerotonin
 * Date: 7/23/2016
 * Time: 10:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ReMynder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dtTime = new System.Windows.Forms.DateTimePicker();
			this.txtReminder = new System.Windows.Forms.TextBox();
			this.btnSet = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dtTime
			// 
			this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtTime.Location = new System.Drawing.Point(21, 12);
			this.dtTime.Name = "dtTime";
			this.dtTime.Size = new System.Drawing.Size(200, 20);
			this.dtTime.TabIndex = 0;
			this.dtTime.ValueChanged += new System.EventHandler(this.dtTimeValueChanged);
			// 
			// txtReminder
			// 
			this.txtReminder.Location = new System.Drawing.Point(241, 12);
			this.txtReminder.Name = "txtReminder";
			this.txtReminder.Size = new System.Drawing.Size(176, 20);
			this.txtReminder.TabIndex = 1;
			this.txtReminder.TextChanged += new System.EventHandler(this.txtReminderTextChanged);
			// 
			// btnSet
			// 
			this.btnSet.Location = new System.Drawing.Point(440, 12);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(75, 23);
			this.btnSet.TabIndex = 2;
			this.btnSet.Text = "Set";
			this.btnSet.UseVisualStyleBackColor = true;
			this.btnSet.Click += new System.EventHandler(this.btnSetClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(21, 50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(785, 266);
			this.dataGridView1.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 328);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSet);
			this.Controls.Add(this.txtReminder);
			this.Controls.Add(this.dtTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.TextBox txtReminder;
		private System.Windows.Forms.DateTimePicker dtTime;
	}
}
