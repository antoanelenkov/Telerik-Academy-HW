namespace _01.FormatCSharpCode
{
    using System;
    using System.Linq;
    using System.Text;

    public class EventCreator : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public EventCreator(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                // possible data validation
                this.date = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                // possible data validation
                this.title = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                // possible data validation
                this.location = value;
            }
        }

        public int CompareTo(object compareObj)
        {
            EventCreator otherEvent = compareObj as EventCreator;

            if (this == null)
            {
                if (otherEvent == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else if (otherEvent == null)
            {
                return 1;
            }
            else
            {
                int byDate = this.date.CompareTo(otherEvent.date);
                int byTitle = this.title.CompareTo(otherEvent.title);
                int byLocation = this.location.CompareTo(otherEvent.location);

                if (byDate == 0)
                {
                    if (byTitle == 0)
                    {
                        return byLocation;
                    }
                    else
                    {
                        return byTitle;
                    }
                }
                else
                {
                    return byDate;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            result.AppendFormat(" | {0}", this.title);

            if (this.location != null && this.location != string.Empty)
            {
                result.AppendFormat(" | {0}", this.location);
            }

            return result.ToString();
        }
    }
}
