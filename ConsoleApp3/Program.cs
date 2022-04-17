namespace ConsoleApp2;

/*
 * Three steps to adding another TransferMethod:
 * First    -> add class of desired TransferMethod that inherits from TransferMethodBase
 * Second   -> add enum to TransferMethodCategory with the same name as the TransferMethod
 * Third    -> add factory which extends TransferMethodFactory and name it <TransferMethod>Factory
 * DONE! there is no need to change any code in the client or anywhere else, which means it upholds the open-closed principle.
 */

public class ClientProgram
{
    public static double? ClientMethod(string transportMethod, double distance)
    {
        TransferMethodCategories type;

        var parseResult = Enum.TryParse(transportMethod, out type);

        if (!parseResult) throw new Exception("Unsupported transportMethod");

        var calculator = new VacationCostCalculator()
        {
            DistanceToDestination = distance
        };

        return calculator.CostOfVacation(type);
        
    }

    public static void Main()
    {
        Console.WriteLine(ClientMethod("plan", 100));
    }

}
