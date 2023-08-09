using CarFactory.Parts;

namespace CarFactory.Factories
{
    // Az ICarFactory VW Passat implementációja, VW Golf alkatrészeket gyárt
    class VWPassatFactory : ICarFactory
    {
        public Carrosserie ManufactureCarrosserie() { return new VWPassatCarrosserie(); }
        public SteeringGear ManufactureSteeringGear() { return new VWPassatSteeringGear(); }
        public Engine ManufactureEngine() { return new VWPassatEngine(); }
    }
}