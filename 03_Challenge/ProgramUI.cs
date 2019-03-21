using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    class ProgramUI
    {
        //Initializing Repository and Local List
        EventRepository EventRepository = new EventRepository();
        List<Event> events = new List<Event>();

        //Start of "Program"
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n  Welcome to Komodo Outings!!");
            Console.ReadLine();
            Console.Clear();

            //While isRunning is true loop will keep running. 
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Please select from the options below: \n" +
                    "1. Add Event\n" +
                    "2. View Events\n" +
                    "3. Total Cost of All Events\n" +
                    "4. Cost of Specified Type of Events\n" +
                    "5. Exit Program");

                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        AddNewEvent();
                        break;
                    case 2:
                        ViewAllEvents();
                        break;
                    case 3:
                        TotalCostofEvents();
                        break;
                    case 4:
                        CostofSpecifiedEvents();
                        break;
                    case 5:
                        isRunning = false;
                        break;
                }

            }
        }

        private void AddNewEvent()
        {
            Console.WriteLine("Please select Event type, using 1 - 4:\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert\n");
            //Parsing to Int Value
            int menu = int.Parse(Console.ReadLine());
            //Initializing EventType Variable, switch sets variable value.
            EventType eventType = new EventType();
            switch (menu)
            {
                case 1:
                    eventType = EventType.Golf;
                    break;
                case 2:
                    eventType = EventType.Bowling;
                    break;
                case 3:
                    eventType = EventType.Amusement_Park;
                    break;
                case 4:
                    eventType = EventType.Concert;
                    break;

            }
            
            Console.WriteLine("How many people attended: ");
            //Creates and sets value for variable numberOfPeople
            int numberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("What was the Date of the Event: ");
            //Creates and sets value for variable dateOfEvent
            //string dateOfEvent = Console.ReadLine();
            string line = Console.ReadLine();
            DateTime dt;
            //After creating a new DateTime variable dt, we send what came out from ReadLine, through a While loop which tries to Parse the string into a DateTime variable, if it fails, it tells the user invalid entry, and waits for user input which goes into the string variable to be evaluated again.
            while (!DateTime.TryParseExact(line, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                Console.WriteLine("Invalid date, please retry");
                line = Console.ReadLine();
            }

            Console.WriteLine("What was the total cost of the event: ");
            //Creating two variables, one to catch the Console Input and another to hold Decimal value once special 
            string result = Console.ReadLine();
            string costEvent = result.Replace("$", "");
            decimal costEventDec = decimal.Parse(costEvent);
            //Dividing Total Cost of the Event by the Number of people who attended and setting answer to Cost per Person.
            decimal costPerPerson = costEventDec / numberOfPeople;
            //Invoking Constructor for Event Class, setting all variable to create a new instance of this class.
            Event @event = new Event(eventType, numberOfPeople, dt, costEventDec, costPerPerson);
            //Sending new Instance of Event to List
            EventRepository.AddNewEvent(@event);
            //Delaying return to Main Menu
            Console.WriteLine("Your event has been added");
            Console.ReadLine();
        }

        private void ViewAllEvents()
        {
            //Pulling list and filling local list with it.
            events = EventRepository.ListAllEvents();
            //Running through List and for each instance of Event printing all properties.
            foreach (Event @event in events)
            {
                Console.WriteLine($"Event Type: {@event.EventType}\nNumber who Attended:{@event.NumberOfPeople}\nDate of the Event: {@event.DateOfEvent.ToString("d")}\nTotal Cost: {@event.CostOfEvent.ToString("C2")}\nCost per Person {@event.CostPerPerson.ToString("C2")}\n");
            }
            Console.ReadLine();
        }

        private void TotalCostofEvents()
        {
            //Initializing variable and setting its initial value.
            decimal total = 0m;
            //Pulling list and filling local list with it.
            events = EventRepository.ListAllEvents();
            //Sending list to the Sum Method and collecting return in previously created variable
            total = EventRepository.SumOfAllEvents(events);
            //Sending feedback to User.
            Console.WriteLine($"The total spent on Events is {total.ToString("C2")}");
            Console.ReadLine();

        }

        private void CostofSpecifiedEvents()
        {
            //Initializing variable and setting its initial value.
            decimal total = 0m;
            //Pulling list and filling local list with it.
            events = EventRepository.ListAllEvents();
            //Requesting Type declaration for Event Class
            Console.WriteLine("Please select Type of Event you would like the cost of using 1-4:\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert\n");
            int menu = int.Parse(Console.ReadLine());
            EventType eventType = new EventType();
            switch (menu)
            {
                case 1:
                    eventType = EventType.Golf;
                    break;
                case 2:
                    eventType = EventType.Bowling;
                    break;
                case 3:
                    eventType = EventType.Amusement_Park;
                    break;
                case 4:
                    eventType = EventType.Concert;
                    break;
            }
            //Sending the list of events, and event type the user selects to my method which searches for the desired instances adds all cost of specified type.
            total = EventRepository.SumOfSpecifiedEvents(events, eventType);
            Console.WriteLine($"The total spent on {eventType} is {total.ToString("C2")}");
            Console.ReadLine();
        }
    }
}
