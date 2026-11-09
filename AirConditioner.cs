public class AirConditioner : HomeAppliance
{
    public AirConditioner(string serialNumber,
                          string customerName,
                          double baseRepairCost)
        : base(serialNumber, customerName, baseRepairCost)
    {
    }

    public override double CalculateRepairCost()
    {
        return BaseRepairCost + 100;
    }
}
