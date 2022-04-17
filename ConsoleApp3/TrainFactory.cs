namespace ConsoleApp2;

public class TrainFactory : ITransferMethodFactory
{
    public TransferMethodBase GetTransferMethod()
    {
        return new Train();
    }
}