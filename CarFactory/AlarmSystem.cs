using System;

namespace CarFactory
{
     // A központi riasztórendszer Singleton osztálya.
    class AlarmSystem
    {
        private static AlarmSystem instance = null;
        public static AlarmSystem Instance
        {
            get
            {
                if (instance == null)
                    instance = new AlarmSystem();
                return instance;
            }
        }
        private AlarmSystem() { }
        // Ez a metódus felelős hiba esetén annak konzolra írására.
        public void AlarmOn()
        {            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hibás alkatrész");
        }
        public void AlarmOff()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
