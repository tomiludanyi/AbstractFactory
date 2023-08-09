using CarFactory.Parts;

namespace CarFactory.Factories
{
     /*
     Abstract Factory  interfész.
     Mindegyik művelete egy a művelet nevének megfelelő vezérlőt gyárt.
     Mindegyik művelet visszatérési típusa az adott vezérlő
     absztrakt ős típusa.
     */
    interface ICarFactory
    {
        Carrosserie ManufactureCarrosserie();
        SteeringGear ManufactureSteeringGear();
        Engine ManufactureEngine();
    }
}
