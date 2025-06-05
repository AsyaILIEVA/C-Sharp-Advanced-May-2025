namespace RawData;
public class Program
{
    static void Main(string[] args)
    {
       int n = int.Parse(Console.ReadLine());
        Car[] cars = new Car[n];

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string model = data[0];
            Engine engine = new Engine { Speed = int.Parse(data[1]), Power = int.Parse(data[2])};
            Cargo cargo = new Cargo { Weight = int.Parse(data[3]), Type = data[4] };
            Tire[] tires = new Tire[4]
            {
                new Tire {Pressure = double.Parse(data[5]), Age = int.Parse(data[6]) },
                new Tire {Pressure = double.Parse(data[7]), Age = int.Parse(data[8]) },
                new Tire {Pressure = double.Parse(data[9]), Age = int.Parse(data[10]) },
                new Tire {Pressure = double.Parse(data[11]), Age = int.Parse(data[12]) },
            };
            cars[i] = new Car { Model = model, Engine = engine, Cargo = cargo, Tires = tires };
        }
        string command = Console.ReadLine();

        Func<Car, bool> condition;
        if (command == "fragile")
            condition = c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1);
        else if (command == "flammable")
            condition = c => c.Cargo.Type == "flammable" && c.Engine.Power > 250;
        else
            condition = _ => false;

        foreach (Car car in cars.Where(condition))
            Console.WriteLine(car.Model);
    
    }
}