using ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Course> courses = new();
        List<OnlineCourse> onlineCourses = new();
        bool flag = true;
        
        while (flag)
        {
            Console.WriteLine("1. Course");
            Console.WriteLine("2. OnlineCourse");
            Console.WriteLine("3. Tìm khóa học theo khoảng ngày bắt đầu");
            Console.WriteLine("4. Sắp xếp Course theo Name (Title)");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Console.Write("Number of course:");
                    int.TryParse(Console.ReadLine(), out int numb1);
                    for (int i = 0; i < numb1; i++)
                    {
                        Console.WriteLine($"Enter info of course #{i + 1}:");
                        Course c = new();
                        c.Input();
                        courses.Add(c);
                    }
                    foreach (Course c in courses)
                    {
                        Console.WriteLine(c.ToString());
                    }
                    Console.WriteLine("-------------------------------");
                    break;
                case "2":
                    Console.Write("Number of Online course:");
                    int.TryParse(Console.ReadLine(), out int numb2);
                    for (int i = 0; i < numb2; i++)
                    {
                        Console.WriteLine($"Enter info of online course #{i + 1}:");
                        OnlineCourse oc = new ();
                        oc.Input();
                        onlineCourses.Add(oc);
                    }
                    foreach (OnlineCourse oc in onlineCourses)
                    {
                        Console.WriteLine(oc.ToString());
                    }
                    Console.WriteLine("-------------------------------");
                    break;
                case "3":
                    Console.Write("Nhập ngày bắt đầu (from - yyyy-MM-dd): ");
                    DateTime.TryParse(Console.ReadLine(), out DateTime fromDate);
                    Console.Write("Nhập ngày kết thúc (to - yyyy-MM-dd): ");
                    DateTime.TryParse(Console.ReadLine(), out DateTime toDate);

                    var matchedCourse = courses.Where(c => c.StartDate >= fromDate &&
                    c.StartDate <= toDate).ToList();
                    foreach (var course in matchedCourse)
                    {
                        Console.WriteLine(course.ToString());
                    }
                    Console.WriteLine("-------------------------------");
                    break;
                case "4": 
                    courses.Sort((a, b) =>  a.Name.CompareTo(b.Name));
                    foreach (var c in courses)
                    {
                        Console.WriteLine(c.ToString());
                    }
                    Console.WriteLine("-------------------------------");
                    break;
                case "0":
                    flag = false;
                    Console.WriteLine("-------------------------------");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    Console.WriteLine("-------------------------------");
                    break;
            }
        }
    }
}