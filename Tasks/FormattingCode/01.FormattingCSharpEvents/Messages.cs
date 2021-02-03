using System;
using System.Collections.Generic;
using System.Text;

namespace _01.FormattingCSharpEvents
{
	static class Messages
	{
		public static void EventAdded()
		{
			Program.output.Append("Event added\n");
		}

		public static void EventDeleted(int x)
		{
			if (x == 0)
			{
				NoEventsFound();
			}
			else
			{
				Program.output.AppendFormat("{0} events deleted\n", x);
			}
		}

		public static void NoEventsFound()
		{
			Program.output.Append("No events found\n");
		}

		public static void PrintEvent(Event eventToPrint)
		{
			if (eventToPrint != null)
			{
				Program.output.Append(eventToPrint + "\n");
			}
		}
	}
}
