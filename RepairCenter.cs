using System;
using System.Collections.Generic;

public class RepairCenter
{
    private List<HomeAppliance> devices =
        new List<HomeAppliance>();

    public void AddDevice(HomeAppliance device)
    {
        devices.Add(device);
    }

    public void DisplayDevices()
    {
        foreach (HomeAppliance device in devices)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Customer: "
                              + device.CustomerName);

            Console.WriteLine("Serial Number: "
                              + device.SerialNumber);

            Console.WriteLine("Status: "
                              + device.RepairStatus);

            Console.WriteLine("Repair Cost: "
                              + device.CalculateRepairCost());
        }
    }
}
