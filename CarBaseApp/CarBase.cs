namespace CarBaseApp
{
    partial class CarBase
    {
        private int fuel, carQuantity;
        private string carBaseName;
        private double avarageVolume;

        public int Fuel { get { return fuel; } set { fuel = value; } }
        public int CarQuantity { get { return carQuantity; } set { carQuantity = value; } }
        public string CarBaseName { get { return carBaseName; } set { carBaseName = value; } }
        public double AvarageVolume { get { return avarageVolume; } set { avarageVolume = value; } }
        public static int GeneralFuel { get; set; } = 0;
        public static int GeneralCarQuantity { get; set; } = 0;
        public static double GeneralAverageVolume { get; set; } = 0;

        public CarBase(int fuel, int carQuantity, string carBaseName)
        {
            Fuel = fuel;
            CarQuantity = carQuantity;
            CarBaseName = carBaseName;
        }
        public CarBase()
        { }
    }
}
