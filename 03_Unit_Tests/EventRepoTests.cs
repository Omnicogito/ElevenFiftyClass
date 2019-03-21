using System;
using System.Collections.Generic;
using _03_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Unit_Tests
{
    [TestClass]
    public class EventRepoTests
    {
        [TestMethod]
        public void AddEventToListShouldBeEqual()
        {
            EventRepository eventRepository = new EventRepository();

            Event @event1 = new Event();
            Event @event2 = new Event();
            Event @event3 = new Event();

            eventRepository.AddNewEvent(@event1);
            eventRepository.AddNewEvent(@event2);
            eventRepository.AddNewEvent(@event3);

            int actual = eventRepository.ListAllEvents().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumOfAllEvents()
        {
            EventRepository eventRepository = new EventRepository();
            

            Event @event1 = new Event(EventType.Concert, 45, "12/12/12", 45000m, 1000m);
            Event @event2 = new Event(EventType.Concert, 60, "11/11/11", 60000m, 1000m);
            Event @event3 = new Event(EventType.Bowling, 25, "10/10/10", 2500m, 100m);

            eventRepository.AddNewEvent(@event1);
            eventRepository.AddNewEvent(@event2);
            eventRepository.AddNewEvent(@event3);

            List<Event> events = eventRepository.ListAllEvents();

            decimal actual = eventRepository.SumOfAllEvents(events);
            decimal expected = 107500m;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SumOfSpecifiedEvents()
        {
            EventRepository eventRepository = new EventRepository();


            Event @event1 = new Event(EventType.Concert, 45, "12/12/12", 45000m, 1000m);
            Event @event2 = new Event(EventType.Concert, 60, "11/11/11", 60000m, 1000m);
            Event @event3 = new Event(EventType.Bowling, 25, "10/10/10", 2500m, 100m);

            eventRepository.AddNewEvent(@event1);
            eventRepository.AddNewEvent(@event2);
            eventRepository.AddNewEvent(@event3);

            List<Event> events = eventRepository.ListAllEvents();

            decimal actual = eventRepository.SumOfSpecifiedEvents(events, EventType.Bowling);
            decimal expected = 2500m;

            Assert.AreEqual(expected, actual);

        }
    }
}
