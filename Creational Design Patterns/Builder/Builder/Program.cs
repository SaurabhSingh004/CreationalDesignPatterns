namespace BuilderDemo
{

    interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    }
    class Car : IBuilder
    {
        private string brandName;
        private Product product;
        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void StartUpOperations()
        {
            //Starting with brandname
            product.Add(string.Format("Car Model name :{0}", this.brandName));
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }
        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("2 Headlights are added");
        }
        public void EndOperations()
        {
            //Nothing in this case
        }
        public Product GetVehicle()
        {
            return product;
        }
    }
    
    class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;
        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void StartUpOperations()
        {
            //Starting with brandname
            product.Add(string.Format("Motorcycle Model name :{0}", this.brandName));
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }
        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("1 Headlights are added");
        }
        public void EndOperations()
        {
            //Nothing in this case
        }
        public Product GetVehicle()
        {
            return product;
        }
    }
    class Director
    {
        IBuilder builder;
        // A series of steps-in real life, steps are complex.
        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
    class Product
    {

        private List<string> parts;
        public Product()
        {
            parts = new List<string>();
        }
        public void Add(string part)
        {
            //Adding parts
            parts.Add(part);
        }
        public void Show()
        {
            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder carbuilder = new Car("Ford");
            IBuilder motorcyclebuilder = new MotorCycle("Splendor");
            
            // making Car
            director.Construct(carbuilder);
            Product carProduct = carbuilder.GetVehicle();
            carProduct.Show();

            // making Motorcycle
            director.Construct(motorcyclebuilder);
            Product MotorCycleProduct = motorcyclebuilder.GetVehicle();
            MotorCycleProduct.Show();

        }
    }
}