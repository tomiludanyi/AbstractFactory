using CarFactory.Parts;

namespace CarFactory
{
    // Egy autót reprezentáló osztály, mely tárol 3 féle alkatrészt.
    public class Car
    {

        #region Properties
        public Carrosserie Carrosserie { get; set; }
        public SteeringGear SteeringGear { get; set; }
        public Engine Engine { get; set; }
        #endregion

        public Car(Carrosserie carrosserie, SteeringGear steeringGear, Engine engine)
        {
            Carrosserie = carrosserie;
            SteeringGear = steeringGear;
            Engine = engine;
        }
    }
}
