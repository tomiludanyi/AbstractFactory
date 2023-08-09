namespace CarFactory.Parts
{
    public abstract class Carrosserie
    {
        protected string model;
        public abstract void Diagnose();
        public abstract string Model { get; set; }
    }
}