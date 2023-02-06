//Daniel Kim, Anthony Le, Brian Weideli
//CPS 3330*03

int num;
do
{
    Console.WriteLine("Will you provide 2 or 3 numbers?:");
    num = Convert.ToInt16(Console.ReadLine());

    if (num != 2 && num != 3)
    {
        Console.WriteLine("Enter 2 or 3!");
    }
} while (num != 2 && num != 3);
 
Console.WriteLine("Enter a value for 'a' and press enter:");
int a = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter a value for 'b' and press enter:");
int b = Convert.ToInt16(Console.ReadLine());

if (num == 3)
{
    Console.WriteLine("Enter a value for 'c' and press enter:");
    int c = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Provided integers: {0}, {1}, and {2} the product is {3}", a, b, c, Product.Product.MyProduct(a, b, c));
}
else
{
    Console.WriteLine("Provided integers: {0}, and {1} the product is {2}", a, b, Product.Product.MyProduct(a, b));
}