//@CodeCopy
//MdStart

namespace BikeShop.Logic
{
    public interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
//MdEnd
