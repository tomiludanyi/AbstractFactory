namespace CarFactory.Parts
{
    // Motor absztrakt ős
    public abstract class Engine
    {
        protected string model;
        public abstract void Diagnose();
        public abstract string Model { get; set; }
    }
}