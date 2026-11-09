using System;

class Program
{
    static void Main(string[] args)
    {
        RepairCenter center = new RepairCenter();

        Refrigerator fridge =
            new Refrigerator("REF001",
                             "Ahmed",
                             200);

        WashingMachine washer =
            new WashingMachine("WAS001",
                               "Sara",
                               150);

        AirConditioner air =
            new AirConditioner("AIR001",
                               "Mohammed",
                               300);

        fridge.RepairCompleted += ShowMessage;
        washer.RepairCompleted += ShowMessage;
        air.RepairCompleted += ShowMessage;

        center.AddDevice(fridge);
        center.AddDevice(washer);
        center.AddDevice(air);

        fridge.StartRepair();
        fridge.CompleteRepair();

        center.DisplayDevices();

        Console.WriteLine();
        Console.WriteLine("Total Devices: "
                          + HomeAppliance.TotalDevices);

        Console.ReadKey();
    }

    static void ShowMessage(object sender,
                            string message)
    {
        Console.WriteLine(message);
    }
}
