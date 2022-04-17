namespace ConsoleApp2;

public class CarFactory : ITransferMethodFactory
{
    public TransferMethodBase GetTransferMethod()
    {
        return new Car();
    }
}

