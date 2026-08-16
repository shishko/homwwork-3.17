/*
 * Первый уровень наследования
 */
public class Computer : Device, IMyCloneable<Computer>
{
    public string Processor { get; set; }
    public int RamSize { get; set; }

    public Computer(string brand, string model, string processor, int ramSize)
        : base(brand, model)
    {
        Processor = processor;
        RamSize = ramSize;
    }

    // Переопределение метода копирования
    public override Computer Clone() => new(this);

    // Копирование
    protected Computer(Computer source) : base(source)
    {
        Processor = source.Processor;
        RamSize = source.RamSize;
    }


    public override string ToString() => $"{base.ToString()}, CPU: {Processor}, RAM: {RamSize}GB";
}



