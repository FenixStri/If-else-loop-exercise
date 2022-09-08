// MIS3033 001 EX1
// Fenix Strickland 113437176
// add GitHub collaborator xinglong.ju@ou.edu

const double cogs = 79.99;
const double gears = 250.00;
double count = 0;
double sum = 0;
double btwcount = 0;

//Console.WriteLine($"Please input number of cogs in Order {count}");
//double cogsAmt = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Please input number of cogs in Order {count}");
//double gearsAmt = Convert.ToDouble(Console.ReadLine());

//double subtotal = (cogs * cogsAmt) + (gears * gearsAmt);

//if (subtotal >= 600 || subtotal <= 1000)
//{
//    Console.WriteLine($"The subtotal of order {count} is {subtotal} and IS between $600.00 and $1,000.00");
//}
//else
//{
//    Console.WriteLine($"The subtotal of order {count} is {subtotal} and IS NOT between $600.00 and $1,000.00");
//}
Console.WriteLine("Do you want to input another order? (yes/no):");
string userInput = Console.ReadLine();

if (userInput == "Yes" || userInput == "yes")
{
    do
    {
        count++;
        Console.WriteLine($"Please input number of cogs in Order {count}");
        double cogAmt = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Please input number of gears in Order {count}");
        double gearAmt = Convert.ToDouble(Console.ReadLine());

        double substotal = (cogs * cogAmt) + (gears * gearAmt);

        if (substotal >= 600 && substotal <= 1000)
        {
            Console.WriteLine($"The subtotal of order {count} is {substotal:c2} and IS between $600.00 and $1,000.00");
            btwcount++;
        }
        else
        {
            Console.WriteLine($"The subtotal of order {count} is {substotal:c2} and IS NOT between $600.00 and $1,000.00");
        }
        
        sum = sum + substotal;

        Console.WriteLine("Do you want to input another order? (yes/no):");
        userInput = Console.ReadLine();


    } while (userInput == "Yes" || userInput == "yes");
}
else if (userInput == "No" || userInput == "no")
{
    Console.WriteLine("");

}
else
{
    Console.WriteLine("ERROR 404 NOT FOUND");
    
}
double avg = sum / count;
Console.WriteLine($"The total number of orders is {count}");
Console.WriteLine($"The sum of subtotals is {sum:c2}");
Console.WriteLine($"The average subtotal of the orders is {avg:c2}");
Console.WriteLine($"The number of orders with subtotals between $600.00 and $1,000.00 is {btwcount}");










Console.ReadLine();