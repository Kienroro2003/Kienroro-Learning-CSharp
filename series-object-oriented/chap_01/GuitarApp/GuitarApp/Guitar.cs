namespace GuitarApp
{
    public class Guitar
    {
        private string serialNumber, builder, model, type, backWood, topWood;
        private double price;
        public Guitar(string serialNumber, double price,
            string builder, string model, string type,
            string backWood, string topWood) {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }
    }
}