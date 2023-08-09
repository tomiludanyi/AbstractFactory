using System;
using System.Collections.Generic;
using CarFactory.Factories;
using CarFactory.Parts;

namespace CarFactory
{
    /*
    Az osztálynak a SetFactory művelet segítségével át kell adni egy
    factory implementációt (pl.: VWPoloFactory) amit a carfactory nevű tagváltozóban eltárol.
    Az alkatrészek létrehozására az InitParts műveletben ezt a factory-t használja az osztály
    a new operátor helyett. Az autó össszeszereléséért a BuildCar metódus felelős, mely által
    visszaadott autó objektumokat a ManufactureCars metódus teszi egy listába.
    A Client használatára a Program osztály mutat példát.
     */
    class Client
    {
        private Carrosserie carrosserie;
        private SteeringGear steeringGear;
        private Engine engine;
        private ICarFactory carFactory;

        public void SetFactory(ICarFactory factory)
        {
            carFactory = factory;
        }

        public void InitParts()
        {
            carrosserie = carFactory.ManufactureCarrosserie();
            steeringGear = carFactory.ManufactureSteeringGear();
            engine = carFactory.ManufactureEngine();
        }

        public Car BuildCar(Carrosserie c, SteeringGear s, Engine e)
        {
            c.Diagnose();
            s.Diagnose();
            e.Diagnose();
            Console.WriteLine($"{c.Model} {s.Model} {e.Model}");
            return new Car(c, s, e);
        }

        public List<Car> ManufactureCars(int count)
        {
            List<Car> cars = new();
            for (int i = 0; i < count; i++)
            {
                cars.Add(BuildCar(this.carrosserie, this.steeringGear, this.engine));
            }
            return cars;
        }
    }

    class Program
    {
        static void Main()
        {
            Client client = new();
            ICarFactory carFactory;

            // Golf gyártás
            carFactory = new VWGolfFactory();
            client.SetFactory(carFactory);
            client.InitParts();
            client.ManufactureCars(1);

            // Polo gyártás
            carFactory = new VWPoloFactory();
            client.SetFactory(carFactory);
            client.InitParts();
            client.ManufactureCars(1);
        }
    }
}
