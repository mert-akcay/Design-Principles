namespace SOLID.Dependency_Inversion;
internal class Car
{
    public interface ICar
    {
        void Start();
        void Stop();
    }

    public class Sedan : ICar
    {
        public void Start()
        {
            Console.WriteLine("Sedan started");
        }

        public void Stop()
        {
            Console.WriteLine("Sedan stopped.");
        }
    }

    public class Hatchback : ICar
    {
        public void Start()
        {
            Console.WriteLine("Hatchback started");
        }

        public void Stop()
        {
            Console.WriteLine("Hatchback stopped.");
        }
    }


    public class CarController
    {
        ICar car;

        public CarController(ICar car)
        {
            this.car = car;
        }

        public void Start()
        {
            car.Start();
        }

        public void Stop()
        {
            car.Stop();
        }
    }
}
