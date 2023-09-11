using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Classes;

public class HDD : Storage, IUSB
{
    public double UsbSpeed { get; set; }
    public double TotalSize { get; set; }

    public double GetStorageSize()
    {
        return TotalSize;
    }

    public override int Copy(double fileSize)
    {
        double timeRequired = fileSize / (UsbSpeed * 1024);
        return (int)Math.Ceiling(timeRequired);
    }

    public  override double FreeMemory()
    {
        return TotalSize;
    }

    public override void PrintDeviceInfo()
    {
        Console.WriteLine($"Media Name: {MediaName}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"USB Speed: {UsbSpeed} MB/s");
        Console.WriteLine($"Total Size: {TotalSize} GB");
    }

    public HDD(string mediaName, string model, double usbSpeed, double totalSize)
    {
        MediaName = mediaName;
        Model = model;
        UsbSpeed = usbSpeed;
        TotalSize = totalSize;
    }
}