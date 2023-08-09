using System;

namespace CarFactory.Parts
{
    // VW Golf karosszéria konkrét osztálya
    public class VWGolfCarrosserie : Carrosserie
    {
        public override string Model
        {
            get { return "Golf carrosseri"; }
            set { model = value; }
        }

        public override void Diagnose()
        {
            try
            {
                if (Model != "Golf carrosserie") { throw new Exception(); }
            }
            catch (Exception)
            {
                AlarmSystem.Instance.AlarmOn();
                AlarmSystem.Instance.AlarmOff();
            }
        }
    }

    // VW Golf kormánymű konkrét osztálya
    public class VWGolfSteeringGear : SteeringGear
    {
        public override string Model
        {
            get { return "Golf steering gear"; }
            set { model = value; }
        }

        public override void Diagnose()
        {
            try
            {
                if (Model != "Golf steering gear") { throw new Exception(); }
            }
            catch (Exception)
            {
                AlarmSystem.Instance.AlarmOn();
                AlarmSystem.Instance.AlarmOff();
            }
        }
    }

    // VW Golf motor konkrét osztálya
    public class VWGolfEngine : Engine
    {
        public override string Model
        {
            get { return "Golf engine"; }
            set { model = value; }
        }

        public override void Diagnose()
        {
            try
            {
                if (Model != "Golf engine") { throw new Exception(); }
            }
            catch (Exception)
            {
                AlarmSystem.Instance.AlarmOn();
                AlarmSystem.Instance.AlarmOff();
            }
        }
    }
}
