using CarFactory.Parts;

namespace CarFactory.Factories
{
    // Az ICarFactory VW Golf implementációja, VW Golf alkatrészeket gyárt
    class VWGolfFactory : ICarFactory
    {
        public Carrosserie ManufactureCarrosserie() { return new VWGolfCarrosserie(); }
        public SteeringGear ManufactureSteeringGear() { return new VWGolfSteeringGear(); }
        public Engine ManufactureEngine() { return new VWGolfEngine(); }
    }
}