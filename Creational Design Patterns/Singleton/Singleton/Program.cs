namespace SingletonDemo
{
    public class Singleton
    {
        private static int counter = 0;
        private static Singleton instance=null;
        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
        
        private Singleton()
        {
            
                counter++;
                Console.WriteLine("Counter Value " + counter.ToString());            
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton sg=Singleton.GetInstance();
            sg.PrintDetails("from sg");
            Singleton sg1 = Singleton.GetInstance();
            sg1.PrintDetails("from sg1");
            
            Console.ReadLine();
        }
    }
}