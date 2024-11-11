using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int price = 80;
        int finalPrice = 0;

        Console.Write("Enter destination (domestic or international): ");
        string destination = Console.ReadLine().ToLower();

        // Menghitung harga dasar berdasarkan tujuan
        if (destination == "domestic")
        {
            price += 30;
        }
        else if (destination == "international")
        {
            price += 650;
        }
        else
        {
            Console.WriteLine("Spelling error detected in destination input!");
        }

        Console.WriteLine($"Ticket Price: {price}");

        // Melanjutkan perhitungan berdasarkan input pengguna
        Console.Write("Enter bag weight: ");
        int bagWeight = int.Parse(Console.ReadLine());
        if (bagWeight > 19)
        {
            price += 35;
        }

        finalPrice = price;

        // Menampilkan biaya per perjalanan
        Console.WriteLine("\n==== Trip Details ====");
        Console.WriteLine($"Base Trip Cost: ${price - (bagWeight > 19 ? 35 : 0)}");
        if (bagWeight > 19)
        {
            Console.WriteLine("Bag Weight Charge: $35");
        }
        Console.WriteLine($"Destination Charge: {(destination == "domestic" ? "$30" : "$650")}");

        // Menampilkan harga total
        Console.WriteLine($"\nTotal Ticket Price: ${finalPrice}");

        // Opsi tambahan: Makanan
        Console.Write("Would you like to add a meal for an additional $50? (yes or no): ");
        string addMeal = Console.ReadLine().ToLower();
        if (addMeal == "yes")
        {
            finalPrice += 50;
            Console.WriteLine("Meal service added. Total updated.");
        }

        // Opsi tambahan: Asuransi
        Console.Write("Would you like to add travel insurance for $100? (yes or no): ");
        string addInsurance = Console.ReadLine().ToLower();
        if (addInsurance == "yes")
        {
            finalPrice += 100;
            Console.WriteLine("Travel insurance added. Total updated.");
        }

        // Opsi tambahan: Mobil
        Console.Write("Would you like to add a car for the trip at an extra $350? (yes or no): ");
        string addCars = Console.ReadLine().ToLower();
        if (addCars == "yes")
        {
            finalPrice += 200;
            Console.WriteLine("Trip cars added. Total updated.");
        }

        // Menampilkan ringkasan akhir
        Console.WriteLine("\n==== Final Ticket Summary ====");
        Console.WriteLine($"Final Ticket Price: ${finalPrice}");
        Console.WriteLine("Thank you for using our ticketing service!");
    }
}

