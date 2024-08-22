/*string value1 = " a B";
string value2 = "A b ";

value1 = value1.Trim();
value2 = value2.Trim();

Console.WriteLine(value1);
Console.WriteLine(value2);

Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1); 

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100:50)}");


Random coinFlip = new Random();
String result = coinFlip.Next(1,2) == 0 ? "Heads":"Tail";
Console.WriteLine(result);
Console.WriteLine($"Result is: {(coinFlip.Next(1,2) == 0 ? "Heads":"Tail")}");
*/


//business rules
//creating variable to store user input

Console.WriteLine("Enter Your Designation: ");
        string designation = Console.ReadLine();
        designation = designation.ToLower();
        
        Console.WriteLine("Enter Your Access level: ");
        int accessLevel = Convert.ToInt32(Console.ReadLine());

        if (designation == "admin")
        {
            if (accessLevel > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else // No condition needed here
            {
                Console.WriteLine("Welcome, Admin user.");
            }
        }
        else if (designation == "manager")
        {
            if (accessLevel >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else // No condition needed here
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }







