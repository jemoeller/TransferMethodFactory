namespace ConsoleApp2;

public class PlaneFactory : ITransferMethodFactory
{
    public TransferMethodBase GetTransferMethod()
    {
        return new Plane();
    }
}