Car car1 = new Car("Ford", "Mondeo", 6.1, 65);
Console.WriteLine(car1.Brand);
car1.Tank(40);
Console.WriteLine(car1.CurrentFuelLevel);
car1.Tank(40);
Console.WriteLine(car1.CurrentFuelLevel);

Console.WriteLine(car1.Odometer);
car1.Drive(500);
Console.WriteLine(car1.Odometer);
Console.WriteLine(car1.CurrentFuelLevel);

car1.Drive(1000);
Console.WriteLine(car1.Odometer);
Console.WriteLine(car1.CurrentFuelLevel);

public class Car
{
    private string _brand;
    private string _model;
    private double _fuelConsumption;
    private int _tankCapacity;

    private double _currentFuelLevel;
    private double _odometer;

    public string Brand => _brand;
    public string Model => _model;
    public double FuelConsumption => _fuelConsumption;
    public int TankCapacity => _tankCapacity;
    public int CurrentFuelLevel => (int)_currentFuelLevel;
    public int Odometer => (int)_odometer;

    public void Drive(int distance)
    {
        if (distance < 0)
            throw new ArgumentException("The distance cannot be negative");

        var maximumDistance = _currentFuelLevel / _fuelConsumption * 100;

        if (distance <= maximumDistance)
        {
            _odometer += distance;
            _currentFuelLevel -= distance * _fuelConsumption / 100;
        }
        else
        {
            _odometer += maximumDistance;
            _currentFuelLevel = 0;
        }
    }

    public void Tank(int addedFuel)
    {
        if (addedFuel < 0)
            throw new ArgumentException("Added Fuel must not be negative");

        _currentFuelLevel += addedFuel;

        if (_currentFuelLevel > _tankCapacity)
            _currentFuelLevel = _tankCapacity;
    }

    public Car(string brand, string model, double fuelConsumption, int tankCapacity)
    {
        if (string.IsNullOrWhiteSpace(brand))
            throw new ArgumentNullException(nameof(brand), "The brand cannot be empty you moron!!");

        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentNullException(nameof(model), "The model cannot be empty you moron!!");

        if(fuelConsumption <=0)
            throw new ArgumentException(nameof(fuelConsumption), "The fuel consumption must be positive you moron!!");

        if (tankCapacity <= 0)
            throw new ArgumentException(nameof(tankCapacity), "The tank capacity must be positive you moron!!");

        _brand = brand;
        _model = model;
        _fuelConsumption = fuelConsumption;
        _tankCapacity = tankCapacity;
    }
}










//Student spyStudent = new Student("Mata", "Hari");
//Console.WriteLine(spyStudent.FirstName);
//Console.WriteLine(spyStudent.LastName);

//spyStudent.FirstName = "     ";
//spyStudent.LastName = null;
//Console.WriteLine(spyStudent.FirstName);
//Console.WriteLine(spyStudent.LastName);

//Console.WriteLine(spyStudent.LastName.Length);


////this class is not properly encapsulated. Anyone can break it, for example
////assingng null to FirstName or LastName
//public class Student
//{
//    public Student(string firstName, string lastName)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//    }

//    public string FirstName;
//    public string LastName;
//}