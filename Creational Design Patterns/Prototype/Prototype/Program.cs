namespace PrototypeDemo
{
    public abstract class Vehicle
    {

        private  String brand;
        private  String model;
        private String color;

        public Vehicle(String brand, String model, String color)
            {
                this.brand = brand;
                this.model = model;
                this.color = color;
            }

        protected Vehicle(Vehicle vehicle)
        {
            this.brand = vehicle.brand;
            this.model = vehicle.model;
            this.color = vehicle.color;
        }
        public String getbrand()
        {
            return brand;
        }
        public String getModel()
        {
            return model;
        }
        public abstract Vehicle clone();

    }

    public class Car : Vehicle
    {

        private int topSpeed;

        public Car(String brand, String model, String color, int topSpeed):base(brand, model, color)
        { 
            this.topSpeed = topSpeed;
        }

        private Car(Car car):base(car)
        {   this.topSpeed = car.topSpeed;
        }

        public override Car clone()
        {
            return new Car(this);
        }

    }

    public class Bus : Vehicle
    {

        private int doors;

        public Bus(String brand, String model, String color, int doors):base(brand, model, color)
        {
            this.doors = doors;
        }

        private Bus(Bus bus):base(bus)
        {
            this.doors = bus.doors;
        }

         public override Bus clone()
         {
            return new Bus(this);
         }

    }
    public class VehicleCache
    {

        private  Dictionary<String, Vehicle> cache = new Dictionary<String, Vehicle>();

        public VehicleCache()
        {
            Car car = new Car("Bugatti", "Chiron", "Blue", 261);
            Bus bus = new Bus("Mercedes", "Setra", "White", 48);

            cache.Add("Bugatti Chiron", car);
            cache.Add("Mercedes Setra", bus);
        }

        public Vehicle get(String key)
        {
            if (cache.TryGetValue("dog", out Vehicle value))
            {
                return value.clone();
            }
            else
                return null;
            
        }

        public void put(List<Vehicle> vehicles)
        {
            foreach(Vehicle v in vehicles)
            {
                cache.Add(v.getbrand() + " " + v.getModel(), v);

            }
        }

    }

    public class MainApp
    {

        
        public static void Main(String[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle vehiclescar = new Car("car_brand", "car_model", "car_color", 300);
            Vehicle vehiclesbus = new Bus("bus_brand", "bus_model", "bus_color", 8);
            vehicles.Add(vehiclescar);
            vehicles.Add(vehiclesbus);

            List<Vehicle> copyList = new List<Vehicle>();
            foreach (Vehicle vehicle in vehicles)
            {
                copyList.Add(vehicle.clone());
            }

            foreach(Vehicle v in copyList)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("=======================================");

            VehicleCache registry = new VehicleCache();
            registry.put(vehicles);
            Console.WriteLine(registry.get("car_brand car_model"));

        }

    }
}