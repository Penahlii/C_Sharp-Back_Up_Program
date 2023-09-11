using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Classes;

public class Flash : Storage, IUSB
{
    public double UsbSpeed { get; set; }
    public double MemorySize { get; set; }

    public double GetStorageSize()
    {
        return MemorySize;
    }

    public override int Copy(double fileSize)
    {
        double timeRequired = fileSize / (UsbSpeed * 1024); 
        return (int)Math.Ceiling(timeRequired);
    }

    public override double FreeMemory()
    {
        return MemorySize;
    }

    public override void PrintDeviceInfo()
    {
        Console.WriteLine($"Media Name: {MediaName}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"USB Speed: {UsbSpeed} MB/s");
        Console.WriteLine($"Memory Size: {MemorySize} GB");
    }

    public Flash(string mediaName, string model, double usbSpeed, double memorySize)
    {
        MediaName = mediaName;
        Model = model;
        UsbSpeed = usbSpeed;
        MemorySize = memorySize;
    }
}