using System;
using CarFactory;

namespace CarFactory.Parts
{
    // VW Polo karosszéria konkrét osztálya
    public class VWPoloCarrosserie : Carrosserie
    {
        public override string Model
        {
            get { return "Polo carrosserie"; }
            set { model = value; }
        }

        public override void Diagnose()
        {
            try
            {
                if (Model != "Polo carrosserie") { throw new Exception(); }
            }
            catch (Exception)
            {
                AlarmSystem.Instance.AlarmOn();
                AlarmSystem.Instance.AlarmOff();
            }
        }
    }

    // VW Polo kormánymű konkrét osztálya
    public class VWPoloSteeringGear : SteeringGear
    {
        public override string Model
        {
            get { return "Polo steering gear"; }
            set { model = value; }
        }

        public override void Diagnose()
        {
            try
            {
                if (Model != "Polo steering gear") { throw new Exception(); }
            }
            catch (Exception)
            {
                AlarmSystem.Instance.AlarmOn();
                AlarmSystem.Instance.AlarmOff();
            }
        }
    }

    // VW Polo motor konkrét osztálya
    public class VWPoloEngine : Engine
    {
        public override string Model
        {
            get { return "Polo engine"; }
            set { model = value; }
        }

        public override void Diagnose()
        {
            try
            {
                if (Model != "Polo engine") { throw new Exception(); }
            }
            catch (Exception)
            {
                AlarmSystem.Instance.AlarmOn();
                AlarmSystem.Instance.AlarmOff();
            }
        }
    }
}
