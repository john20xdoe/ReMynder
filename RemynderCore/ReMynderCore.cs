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
	/// A barebones template for controlling the entire application state. This is also used to persist the reminders.
	/// </summary>
	public sealed class ReMynderCore
	{
		private static ReMynderCore instance = new ReMynderCore();
		private static IEnumerable<Reminder> reminderList = Enumerable.Empty<Reminder>();
		
		public static ReMynderCore Instance {
			get {
				return instance;
			}
		}
		
		
		private ReMynderCore()
		{
			
		}
	}
}
