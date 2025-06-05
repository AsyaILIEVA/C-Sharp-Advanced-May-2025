namespace SpeedRacing;
public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Car> cars = new Dictionary<string, Car>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string model = data[0];
            double fuelAmount = double.Parse(data[1]), fuelConsumption = double.Parse(data[2]);

            Car car = new Car(model, fuelAmount, fuelConsumption);
            cars[car.Model] = car;
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string model = data[1];
            double distance = double.Parse(data[2]);

            Car car = cars[model];
            if(!car.Drive(distance))
                Console.WriteLine("Insufficient fuel for the drive"); 
        }

        foreach(Car car in cars.Values)
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");


    }
}