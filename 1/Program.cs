Console.WriteLine("Введите число");
string number = Convert.ToString(Console.ReadLine());

void polindrom  (string number)
{
    if(number[0] == number[4] || number [1] == number [3])
    {
        Console.WriteLine($"Число {number} полиндром");
    }    
    else
    Console.WriteLine($"Число {number} не полиндром");
}
polindrom(number);