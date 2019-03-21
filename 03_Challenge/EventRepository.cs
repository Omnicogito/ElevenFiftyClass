using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class EventRepository
    {
        List<Event> _events = new List<Event>();
        Event @event = new Event();


        public void AddNewEvent(Event anevent)
        {
            _events.Add(anevent);
        }

        public List<Event> ListAllEvents()
        {
            return _events;
        }

        public decimal SumOfAllEvents(List<Event> events)
        {
            decimal sum = 0m;
            foreach(Event @event in events)
            {
                sum += @event.CostOfEvent;
            }
            return sum;

        }

        public decimal SumOfSpecifiedEvents(List<Event> events, EventType eventType)
        {
            decimal sum = 0m;
            List<Event> localevents = events;
            
            var specifiedEvents = localevents.Where(p => p.EventType == eventType);

            foreach(Event @event in specifiedEvents)
            {
                sum += @event.CostOfEvent;
            }

            return sum;
        }
    }
}
