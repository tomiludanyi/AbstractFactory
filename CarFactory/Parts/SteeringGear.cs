namespace CarFactory.Parts
{
    // Kormánymű absztrakt ős
    public abstract class SteeringGear
    {
        protected string model;
        public abstract void Diagnose();
        public abstract string Model { get; set; }
    }
}