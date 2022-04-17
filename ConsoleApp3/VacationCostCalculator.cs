namespace ConsoleApp2;

public class VacationCostCalculator
{
    public double DistanceToDestination { get; set; }

    public double CostOfVacation(TransferMethodCategories transferMethodCategory)
    {
        var factory = TransferMethodFactory.Create(transferMethodCategory);

        var res = factory.GetTransferMethod();

        var som = res.CostMultiplier;

        return res.CalculateCost(DistanceToDestination);
    }
}