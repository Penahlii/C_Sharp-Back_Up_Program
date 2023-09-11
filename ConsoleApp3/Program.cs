using ClassLibrary1;
using ClassLibrary1.Classes;
using ClassLibrary1.Interfaces;

Storage flashDrive = new Flash("Flash Drive", "SanDisk", 100, 32);
Storage dvdDisk = new DVD("DVD Disk", "Sony", 20, "Single-sided");
Storage externalHDD = new HDD("External HDD", "Seagate", 50, 500);

Storage[] devices = { flashDrive, dvdDisk, externalHDD };

foreach (var device in devices)
{
    device.PrintDeviceInfo();
    Console.WriteLine($"Free Memory: {device.FreeMemory()} GB");
    double fileSizeGB = 565 * 780 / 1024;
    int copyTime = device.Copy(fileSizeGB);
    Console.WriteLine($"Time Required to Copy: {copyTime} hours\n");
}