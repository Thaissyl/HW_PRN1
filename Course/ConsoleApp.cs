using System.Threading.Channels;

namespace ConsoleApp
{
    public class Course
    {
        public Course()
        {
        }

        public Course(int id, string name, DateTime startDate)
        {
            Id = id;
            Name = name;   
            StartDate = startDate;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public void Input()
        {
            Console.Write("ID: ");
            int.TryParse(Console.ReadLine(), out int id);
            Id = id;

            Console.Write("Name: ");
            Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Start Date(yyyy-MM-dd): ");
            if(DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
            {
                StartDate = startDate;
            } else
            {
                Console.WriteLine("Invalid date. Using today's date instead.");
                return;
            }
        }

        public override string? ToString() => $"ID:{Id} - Name:{Name} - Start Date:{StartDate}";
    }

    public class OnlineCourse : Course {

        public string LinkMeet { get; set; }

        public OnlineCourse() { }
        public OnlineCourse(int Id, string name, DateTime StartDate, string linkMeet) : base(Id, name, StartDate ) 
        {
            LinkMeet = linkMeet;
        }
        public void Input()
        {
            base.Input();
            Console.Write("Nhap Link Meet:");
            LinkMeet = Console.ReadLine() ?? string.Empty;
        }
        public override string? ToString() => base.ToString() + $" Link Meet:{LinkMeet}";
    }
}
