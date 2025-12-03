using Project15_Inheritance.Models;

namespace Project15_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        // Manager manager1 = new()
        // {
        //     FirstName = "Ali",
        //     LastName = "Can",
        //     RegNumber = 32432
        // };
        // manager1.Department = "Satış";
        // manager1.ShowData();
        // manager1.SetMeeting();

        Developer developer1 = new()
        {
            FirstName = "Merve",
            LastName = "Kabakçı",
            Lang = "JavaScript",
            RegNumber = 33333
        };

        developer1.ShowData();
        developer1.WriteCode();
    }
}
