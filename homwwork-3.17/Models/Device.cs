/*
 * Базовый класс 
 */
public abstract class Device : IMyCloneable<Device>, ICloneable
{
    public string Brand { get; set; }
    public string Model { get; set; }

    protected Device(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    // Копирование
    protected Device(Device source)
    {
        ArgumentNullException.ThrowIfNull(source);

        Brand = source.Brand;
        Model = source.Model;
    }

    // Абстрактный метод из IMyCloneable
    public abstract Device Clone();

    // Реализация стандартного ICloneable через кастомный метод
    object ICloneable.Clone() => Clone();

    public override string ToString() => $"Brand: {Brand}, Model: {Model}";
}



