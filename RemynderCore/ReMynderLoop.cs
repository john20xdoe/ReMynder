/*
* Created by SharpDevelop.
* User: Zerotonin
* Date: 7/23/2016
* Time: 9:52 PM
* 
* To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;
using System.Threading.Tasks;

namespace ReMynder.Core
{
/// <summary>
/// Description of ReMynderLoop.
/// </summary>
	public class ReMynderLoop	
	{
	
		private bool allowMonitor;
		private int delayInSeconds;
		const int DEFAULT_DELAY = 1;
		public ReMynderLoop()
		{
			allowMonitor = true;
			delayInSeconds = DEFAULT_DELAY;
		}
		async Task Delay()
		{
		    await Task.Delay(delayInSeconds * 1000);
		} 
		public void StartMonitorReminders()
		{
			allowMonitor = true;
			MonitorLoop();
		}
		public void StopMonitoringReminders()
		{
			allowMonitor = false;
		}
		private async void MonitorLoop()
		{
			while (allowMonitor)
			{
				foreach (var r in ReMynderCore.Instance.Reminders())
				{
					// TODO show a popup remynder
					// Use a Action<T> to queue reminders?
				}
				await Delay();
			}	
		}
	}
}

