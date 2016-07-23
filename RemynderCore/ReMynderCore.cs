/*
 * Created by SharpDevelop.
 * User: Zerotonin
 * Date: 7/23/2016
 * Time: 11:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using ReMynder.Models;

namespace ReMynder.Core
{
	/// <summary>
	/// A static class for controlling the entire application state. This is also used to persist the reminders.
	/// </summary>
	public sealed class ReMynderCore
	{
		private static ReMynderCore instance = new ReMynderCore();
		private ICollection<Reminder> ReminderList;
		
		public static ReMynderCore Instance {
			get {
				return instance;
			}
		}
		
		
		private ReMynderCore()
		{
			ReminderList = new List<Reminder>(); //or we can retrieve this from persistence
		}
		
		public void Reminder(Reminder rem)
		{
			ReminderList.Add(rem);
		}
		public ICollection<Reminder> Reminders()
		{
			return new List<Reminder>(ReminderList);
		}
		public ICollection<Reminder> GetDueRemindersBy(DateTime time)
		{
			//(Math.Abs((dt1 - dt2).TotalSeconds) <= 1)
			List<Reminder> dueRems = ReminderList.Where(r => (Math.Abs((r.Trigger - time).TotalSeconds) <= 1) && !r.Closed).ToList();
			return dueRems;
		}
		
		
	}
}
