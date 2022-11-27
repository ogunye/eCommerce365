namespace product.Shared.DataTransferObjects
{
    public record ProductCategoryDto 
    {
        public int Id { get; init;}
        public string? CategoryName { get; init;}
        public string? CategoryDescription { get; init;}
    }
}
