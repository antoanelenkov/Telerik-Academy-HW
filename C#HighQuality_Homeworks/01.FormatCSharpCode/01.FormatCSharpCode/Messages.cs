namespace _01.FormatCSharpCode
{
    using System;
    using System.Linq;
    using System.Text;

    public static class Messages
    {
        private static readonly StringBuilder output = new StringBuilder();

        public static StringBuilder Output
        {
            get
            {
                return output;
            }
        }

        public static void EventAdded()
        {
            Output.AppendLine("Event added");
        }

        public static void EventDeleted(int targetEvent)
        {
            if (targetEvent == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendLine(string.Format("{0} events deleted", targetEvent));
            }
        }

        public static void NoEventsFound()
        {
            Output.AppendLine("No events found");
        }

        public static void PrintEvent(EventCreator eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.AppendLine(eventToPrint.ToString());
            }
        }
    }
}
