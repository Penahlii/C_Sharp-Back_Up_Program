using ClassLibrary1.Interfaces;
using System.Reflection;

namespace ClassLibrary1.Classes;

public class DVD : Storage, IUSB
{
    public double UsbSpeed { get; set; }
    public string Type { get; set; }

    public double GetStorageSize()
    {
        switch (Type)
        {
            case "Single-sided":
                return 4.7;
            case "Double-sided":
                return 9.0;
            default:
                return 0;
        }
    }

    public override int Copy(double fileSize)
    {
        double timeRequired = fileSize / (UsbSpeed * 1024);
        return (int)Math.Ceiling(timeRequired);
    }

    public override double FreeMemory()
    {
        return GetStorageSize();
    }

    public override void PrintDeviceInfo()
    {
        Console.WriteLine($"Media Name: {MediaName}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"USB Speed: {UsbSpeed} MB/s");
        Console.WriteLine($"Type: {Type}");
    }

    public DVD(string mediaName, string model, double usbSpeed, string type)
    {
        MediaName = mediaName;
        Model = model;
        UsbSpeed = usbSpeed;
        Type = type;
    }
}