using System;

public abstract class HomeAppliance : IServiceable
{
    private string serialNumber;
    private string customerName;

    public static int TotalDevices { get; private set; }

    public string SerialNumber
    {
        get { return serialNumber; }
        set { serialNumber = value; }
    }

    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }

    public string RepairStatus { get; set; }

    public double BaseRepairCost { get; set; }

    public delegate void RepairCompletedHandler(object sender, string message);

    public event RepairCompletedHandler RepairCompleted;

    public HomeAppliance(string serialNumber,
                         string customerName,
                         double baseRepairCost)
    {
        SerialNumber = serialNumber;
        CustomerName = customerName;
        BaseRepairCost = baseRepairCost;
        RepairStatus = "Pending";

        TotalDevices++;
    }

    public abstract double CalculateRepairCost();

    public void StartRepair()
    {
        RepairStatus = "In Progress";
    }

    public void CompleteRepair()
    {
        RepairStatus = "Completed";

        if (RepairCompleted != null)
        {
            RepairCompleted(this,
                "Repair completed for device: " + SerialNumber);
        }
    }
}
