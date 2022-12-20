using System;

namespace HolidayApp
{
    public class Program
    {
        static int CityMenu()
        {
            int city;
            Console.WriteLine("Cities avaiable for booking are: ");
            Console.WriteLine("1. Paris");
            Console.WriteLine("2. Madrid");
            Console.WriteLine("3. Amsterdam");
            Console.WriteLine("4. Bonn");
            Console.WriteLine("Please enter 1, 2, 3, 4");

            city = Convert.ToInt32(Console.ReadLine());
            return city;
        }

        public static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int houseNo;
            string postCode;
            string customerID;
            int city;
            int numberOfNights;
            string travelInsurance;
            int travelCost = 0;
            int accomodationCost;
            int insurance = 0;
            int totalCost;
            int option;

            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your second name");
            lastName = Console.ReadLine();

            Console.WriteLine("Please input your house number.");
            houseNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input your post code");
            postCode = Console.ReadLine();

            customerID = lastName + "_" + houseNo + "_" + postCode;
            Console.WriteLine("Your customer ID is " + customerID);

            city = CityMenu();
            /*Console.WriteLine("Cities avaiable for booking are: ");
            Console.WriteLine("1. Paris");
            Console.WriteLine("2. Madrid");
            Console.WriteLine("3. Amsterdam");
            Console.WriteLine("4. Bonn");
            Console.WriteLine("Please enter 1, 2, 3, 4");
            */
            city = Convert.ToInt32(Console.ReadLine());

            switch(city)
            {
                case 1:
                    Console.WriteLine("The travel cost is £80");
                    travelCost = 80;
                    break;
                case 2:
                    Console.WriteLine("The travel cost is £150");
                    travelCost = 150;
                    break;
                case 3:
                    Console.WriteLine("The travel cost is £90");
                    travelCost = 90;
                    break;
                case 4:
                    Console.WriteLine("The travel cost is £120");
                    travelCost = 120;
                    break;
                default:
                    Console.WriteLine("Please choose a correct city, Paris, Madrid, Amsterdam, Bonn!");
                    break;
            }
            
            Console.WriteLine("Please input the number of nights you will be staying for");
            numberOfNights = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like travel insurance?");
            travelInsurance = Console.ReadLine();

            if (travelInsurance == "y")
            {
                insurance = numberOfNights * 3;
            }
            else if (travelInsurance == "n")
            {
                insurance = 0;
            }
            else
            {
                Console.WriteLine("Please enter either y or n!");
            }
            accomodationCost = numberOfNights * 40;
            Console.WriteLine("Your accomdation cost is " + accomodationCost);

            totalCost = travelCost + accomodationCost + insurance;
            Console.WriteLine("This is your total cost " + totalCost);

        }
    }
}

