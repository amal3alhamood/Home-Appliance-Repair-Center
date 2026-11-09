public class Refrigerator : HomeAppliance
{
    public Refrigerator(string serialNumber,
                        string customerName,
                        double baseRepairCost)
        : base(serialNumber, customerName, baseRepairCost)
    {
    }

    public override double CalculateRepairCost()
    {
        return BaseRepairCost + 50;
    }
}
