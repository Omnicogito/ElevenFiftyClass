using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public enum EventType { Golf, Bowling, Amusement_Park, Concert }

    public class Event
    {
        public EventType EventType { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime DateOfEvent { get; set; }
        public decimal CostOfEvent { get; set; }
        public decimal CostPerPerson { get; set; }
        
        public Event() { }
        public Event(EventType eventType, int numberOfPeople, DateTime dateOfEvent, decimal costofEvent, decimal costPerPerson)
        {
            EventType = eventType;
            NumberOfPeople = numberOfPeople;
            DateOfEvent = dateOfEvent;
            CostOfEvent = costofEvent;
            CostPerPerson = costPerPerson;
        }
    }
}
