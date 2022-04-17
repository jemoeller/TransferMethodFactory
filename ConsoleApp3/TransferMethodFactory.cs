namespace ConsoleApp2;

public abstract class TransferMethodFactory
{
    public static ITransferMethodFactory Create(TransferMethodCategories type)
    {
        var factoryString = $"{typeof(TransferMethodCategories).Namespace}.{type.ToString()}Factory";
        var factoryType = Type.GetType(factoryString);

        return (ITransferMethodFactory) Activator.CreateInstance(factoryType);
    }
}