/*
 * Второй уровень наследования
 */
public class Laptop : Computer, IMyCloneable<Laptop>
{
    public int BatteryCapacity { get; set; }
    public double Weight { get; set; }

    public Laptop(string brand, string model, string processor, int ramSize, int batteryCapacity, double weight)
        : base(brand, model, processor, ramSize)
    {
        BatteryCapacity = batteryCapacity;
        Weight = weight;
    }

    // Переопределение метода копирования
    public override Laptop Clone() => new(this);

    // Копирование
    protected Laptop(Laptop source) : base(source)
    {
        BatteryCapacity = source.BatteryCapacity;
        Weight = source.Weight;
    }


    public override string ToString() => $"{base.ToString()}, Battery: {BatteryCapacity}mAh, Weight: {Weight}kg";
}



