using CarFactory.Parts;

namespace CarFactory.Factories
{
    // Az ICarFactory VW Polo implementációja, VW Polo alkatrészeket gyárt
    class VWPoloFactory : ICarFactory
    {
        public Carrosserie ManufactureCarrosserie() { return new VWPoloCarrosserie(); }
        public SteeringGear ManufactureSteeringGear() { return new VWPoloSteeringGear(); }
        public Engine ManufactureEngine() { return new VWPoloEngine(); }
    }
}