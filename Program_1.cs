using System;

public class Program_1 
{

    public static void Main() 
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        Console.WriteLine(daysUntilExpiration);

        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!\r\nRenew now and save 20%!");
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine("Your subscription expires in _ days.\r\nRenew now and save 10%!");
        }
        else
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
    }

}