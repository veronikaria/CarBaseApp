using System;

namespace CarBaseApp
{
    partial class CarBase
    {
        private void countGeneralValues()
        {
            AvarageVolume = Math.Round((double)Fuel / (double)CarQuantity, 2);
            GeneralFuel += Fuel;
            GeneralCarQuantity += CarQuantity;
        }
        public static void outputGeneralAvarageVolume()
        {
            GeneralAverageVolume = Math.Round((double)GeneralFuel / (double)GeneralCarQuantity, 2);
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("|\t" + "\t|\t" + GeneralFuel + "\t|\t " + GeneralCarQuantity + " \t|\t " + GeneralAverageVolume + "\t|");
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("-----------------------------------------------------------------");
        }
        public static void tableOutput()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("|   Название    |  Топливо(кг)  |  Кол-во машин | Средняя растр.|");
            Console.WriteLine("|   автобазы    |               |               |    топлива    |");
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("----------------------------------------------------------------");
        }
        public void carBaseOutput()
        {
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("|\t" + CarBaseName + "\t|\t" + Fuel + "\t|\t" + CarQuantity + "\t|\t" + AvarageVolume + "\t|");
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
