namespace ConsoleApp2;

public interface ITransferMethodBase
{
    double CalculateCost(double distance);
    
    double CostMultiplier { get; }

    string GetTransferMethodName();
    
}