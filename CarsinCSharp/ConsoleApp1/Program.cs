
// Show the main menu

using ClassLibrary1;

int userInput = 0;
List <Car> cars = new List<Car>();



while (userInput != 4)
{
    Console.WriteLine("Welcome to Seth's Dealership");
    Console.WriteLine("");
    Console.WriteLine("------------------------------");
    Console.WriteLine("1. Add a new car");
    Console.WriteLine("2. List all cars");
    Console.WriteLine("3. Remove a car");
    Console.WriteLine("4. Exit");

    string usersInput = "";
    try
    {
        usersInput = Console.ReadLine();
        userInput = int.Parse(usersInput);
    }
    catch (Exception ex)
    {
    }
    switch (userInput)
    {
        case 0:
            break;
        case 1:
            Console.WriteLine("Add a new car");
            string make, model, color;
            int year;
            Console.WriteLine("Enter the make.");
                make = Console.ReadLine();
            Console.WriteLine("Enter the model.");
                model = Console.ReadLine();
            Console.WriteLine("Enter the color.");
                color = Console.ReadLine();
            Console.WriteLine("Enter the year.");
                year = int.Parse(Console.ReadLine());
            Car newCar = new Car(make, model, year, color);
            cars.Add(newCar);
            break;
        case 2:
            Console.WriteLine("List all cars");
            foreach (var car in cars)
            {
                car.DisplayInfo();
            }
            break;
        case 3:
            Console.WriteLine("Remove a car");
            break;
    }
}