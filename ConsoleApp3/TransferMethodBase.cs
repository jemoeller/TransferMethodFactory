namespace ConsoleApp2;

public abstract class TransferMethodBase : ITransferMethodBase
{
    public double CalculateCost(double distance)
    {
        if (CostMultiplier == 0)
        {
            throw new Exception($"CostMultiplier property has not been assigned for __{GetTransferMethodName()}__");
        }
        return distance * CostMultiplier;
    }

    public abstract double CostMultiplier { get; }
    
    public string GetTransferMethodName()
    {
        return GetType().Name;
    }
}