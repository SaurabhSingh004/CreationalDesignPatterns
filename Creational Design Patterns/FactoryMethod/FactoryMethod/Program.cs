namespace Factory_Method
{
    public interface Burger
    {
        void prepare();

    }
    public class BeefBurger : Burger
    {
        public void prepare()
        {
            // Prepare Beef Burger
            Console.WriteLine("Preparing Beef Burger...");
        }

    }
    public class VeggieBurger : Burger
    {
        public void prepare()
        {
            // Prepare Beef Burger
            Console.WriteLine("Preparing Veggie Burger...");
        }

    }
    public abstract class Restaurant
    {

        public void orderBurger()
        {
            Console.WriteLine("Ordering Burger...");
            Burger burger = createBurger();
            burger.prepare();
        }

        public abstract Burger createBurger();
    }
    public class BeefBurgerRestaurant : Restaurant
    {
        public override Burger createBurger()
        {
            Console.WriteLine("Creating Beef Burger...");
            return new BeefBurger();
        }

    }
    public class VeggieBurgerRestaurant : Restaurant
    {

        public override Burger createBurger()
        {
            Console.WriteLine("Creating Veggie Burger...");
            return new VeggieBurger();
        }

    }
    public class MainProgram
    {
        static void Main(string[] args)
        {
            Restaurant beefResto = new BeefBurgerRestaurant();
            beefResto.orderBurger();

            Console.WriteLine("=====================================");

            Restaurant veggieResto = new VeggieBurgerRestaurant();
            veggieResto.orderBurger();
        }

    }
}