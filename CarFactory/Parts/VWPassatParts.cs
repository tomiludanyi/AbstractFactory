using System;
using CarFactory;

namespace CarFactory.Parts
{
    // VW Passat karosszéria konkrét osztálya
    public class VWPassatCarrosserie : Carrosserie
    {
        public override string Model
        {
            get { return "Passat carrosserie"; }
            set { model = value; }
        }

        public override void Diagnose()
        {
            try
            {
                if (Model != "Passat carrosserie") { throw new Exception(); }
            }
            catch (Exception)
            {
                AlarmSystem.Instance.AlarmOn();
                AlarmSystem.Instance.AlarmOff();
            }
        }
    }

    // VW Passat kormánymű konkrét osztálya
    public class VWPassatSteeringGear : SteeringGear
    {
        public override string Model
        {
            get { return "Passat steering gear"; }
            set { model = value; }
        }

        public override void Diagnose()
        {
            try
            {
                if (Model != "Passat steering gear") { throw new Exception(); }
            }
            catch (Exception)
            {
                AlarmSystem.Instance.AlarmOn();
                AlarmSystem.Instance.AlarmOff();
            }
        }
    }

    // VW Passat motor konkrét osztálya
    public class VWPassatEngine : Engine
    {
        public override string Model
        {
            get { return "Passat engine"; }
            set { model = value; }
        }

        public override void Diagnose()
        {
            try
            {
                if (Model != "Passat engine") { throw new Exception(); }
            }
            catch (Exception)
            {
                AlarmSystem.Instance.AlarmOn();
                AlarmSystem.Instance.AlarmOff();
            }
        }
    }
}
