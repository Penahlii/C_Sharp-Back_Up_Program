namespace ClassLibrary1.Classes;

public abstract class Storage
{
    public string MediaName { get; set; }
    public string Model { get; set; }
    double UsbSpeed { get; set; }

    public abstract void PrintDeviceInfo();

    public abstract int Copy(double fileSize);
    public abstract double FreeMemory();
}