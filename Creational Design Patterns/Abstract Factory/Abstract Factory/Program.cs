namespace AbstractFactoryDemo
{
    public interface Product
    {
        void assemble();
    }
    public interface Gpu : Product
    {
        // You can add GPU specific behaviors here
    }
    public interface Monitor : Product
    {
        // You can add GPU specific behaviors here
    }
    public abstract class Company
    {

        public abstract Gpu createGpu();
        public abstract Monitor createMonitor();

    }
    public class MsiManufacturer: Company
    {

        public override Gpu createGpu()
        {
            return new MsiGpu();
        }

        public override Monitor createMonitor()
        {
            return new MsiMonitor();
        }

    }
    public class AsusManufacturer : Company
    {
        public override Gpu createGpu()
        {
            return new AsusGpu();
        }

        public override Monitor createMonitor()
        {
            return new AsusMonitor();
        }

    }

    public class AsusGpu : Gpu
    {
        public void assemble()
        {
            Console.WriteLine("Assembling ASUS GPU");
        }

    }
    public class MsiGpu : Gpu
    {
        public void assemble()
        {
            Console.WriteLine("Assembling MSI GPU");
        }

    }
    public class MsiMonitor : Monitor
    {
        public void assemble()
        {
            Console.WriteLine("Assembling MSI Monitor");
        }

    }
    public class AsusMonitor : Monitor
    {
        public void assemble()
        {
            Console.WriteLine("Assembling Asus Monitor");
        }

    }
    public class MainApp
    {
        public static void Main(String[] args)
        {

            Company msi = new MsiManufacturer();
            Gpu msiGpu = msi.createGpu();
            Monitor msiMonitor = msi.createMonitor();
            msiGpu.assemble();
            msiMonitor.assemble();

            Company asus = new AsusManufacturer();
            Gpu asusGpu = asus.createGpu();
            Monitor asusMonitor = asus.createMonitor();
            asusGpu.assemble();
            asusMonitor.assemble();
        }

    }

}