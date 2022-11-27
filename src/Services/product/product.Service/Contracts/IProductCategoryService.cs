using product.Shared.DataTransferObjects;

namespace product.Service.Contracts
{
    public interface IProductCategoryService
    {
        IEnumerable<ProductCategoryDto> GetAllProductCategory(bool trackChanges);
        ProductCategoryDto GetProductCategory(int Id, bool trackChanges);
    }
}
