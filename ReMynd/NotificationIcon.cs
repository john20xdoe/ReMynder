/*
 * Created by SharpDevelop.
 * User: Zerotonin
 * Date: 7/23/2016
 * Time: 10:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using ReMynder.Core;
using ReMynder.Models;


namespace ReMynd
{
	public sealed class NotificationIcon
	{
		private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
		private MainForm mainForm;
		
		#region Initialize icon and menu and mainform
		public NotificationIcon()
		{			
			notifyIcon = new NotifyIcon();
			notificationMenu = new ContextMenu(InitializeMenu());
			
			notifyIcon.DoubleClick += IconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
			notifyIcon.ContextMenu = notificationMenu;
		}
		
		private MenuItem[] InitializeMenu()
		{
			MenuItem[] menu = new MenuItem[] {
				new MenuItem("Open App", menuMainFormClick), 
				new MenuItem("About", menuAboutClick),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}
		private void InitializeMainForm()
		{
			// TODO add configs?
			mainForm = new MainForm();
			mainForm.Closed += MainForm_Closed; //subscribe to the Closed event
			mainForm.Show();
		}
		#endregion
		
		
		#region Event Handlers
		private void menuAboutClick(object sender, EventArgs e)
		{
			MessageBox.Show("ReMynd is an app for scheduling notifications during your workflow.","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		private void menuExitClick(object sender, EventArgs e)
		{
			var x = MessageBox.Show("This will exit ReMynd. Confirm?","Confirm Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question,
			                MessageBoxDefaultButton.Button2);
			if (x == DialogResult.Yes) 
				Application.Exit();
		}
		
		private void menuMainFormClick(object sender, EventArgs e)
		{
			InitializeMainForm();
		}
		
		private void MainForm_Closed(object sender, EventArgs e)
		{
			
			//MainForm mf = (MainForm) sender;
    		//MessageBox.Show(mf.Name);
    		Notify("ReMynd is still running in the taskbar.","Minimized",5000);
		}
		
		private void IconDoubleClick(object sender, EventArgs e)
		{
			InitializeMainForm();
		}
		#endregion
		
		#region notifier actions
		/// <summary>
		/// Actions by the notification icon
		/// </summary>
		/// <param name="args"></param>
		private void Notify(string msg, string title,int durationInMs)
		{
			//notifyIcon.Visible = true;

    		if (title != null)
    		{
        		notifyIcon.BalloonTipTitle = title;
    		}

		    if (msg != null)
    		{
        		notifyIcon.BalloonTipText = msg;
    		}
		    notifyIcon.ShowBalloonTip((durationInMs != 0 ? durationInMs : 5000));
		}
		#endregion
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			bool isFirstInstance;
			// Please use a unique name for the mutex to prevent conflicts with other programs
			using (Mutex mtx = new Mutex(true, "ReMynd", out isFirstInstance)) {
				if (isFirstInstance) {
					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Visible = true;
					Application.Run();
					notificationIcon.notifyIcon.Dispose();
				} else {
					// The application is already running
					// TODO: Display message box or change focus to existing application instance
				}
			} // releases the Mutex
		}
		#endregion
	}
}
