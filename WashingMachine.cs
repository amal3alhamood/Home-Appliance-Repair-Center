public class WashingMachine : HomeAppliance
{
    public WashingMachine(string serialNumber,
                          string customerName,
                          double baseRepairCost)
        : base(serialNumber, customerName, baseRepairCost)
    {
    }

    public override double CalculateRepairCost()
    {
        return BaseRepairCost + 75;
    }
}
