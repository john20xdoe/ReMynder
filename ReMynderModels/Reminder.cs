/*
 * Created by SharpDevelop.
 * User: Zerotonin
 * Date: 7/23/2016
 * Time: 11:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ReMynder.Models
{
	/// <summary>
	/// A basic ReMynd reminder template. (A time trigger and a message)
	/// </summary>
	public class Reminder
	{
		private long Id {get;set;}
		public DateTime Trigger { get; set; }
		public string Message {get;set;}
		public bool Closed { get; set;}
		// TODO add interval for repettiive reminders		
					
		public void Close()
		{
			this.Closed = true;
		}
		
		public Reminder()
		{
			this.Closed = false;
		}
	}
}
