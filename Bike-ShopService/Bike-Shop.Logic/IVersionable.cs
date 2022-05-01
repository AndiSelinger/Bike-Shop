//@CodeCopy
//MdStart

namespace Bike-Shop.Logic
{
    public interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
//MdEnd
