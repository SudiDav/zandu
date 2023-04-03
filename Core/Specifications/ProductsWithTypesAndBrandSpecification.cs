using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications;

public class ProductsWithTypesAndBrandSpecification: BaseSpecification<Product>
{
    public ProductsWithTypesAndBrandSpecification()
    {
        AddIncludes(x => x.ProductType);
        AddIncludes(x => x.ProductBrand);
    }

    public ProductsWithTypesAndBrandSpecification(int id) : 
        base(x => x.Id == id)
    {
        AddIncludes(x => x.ProductType);
        AddIncludes(x => x.ProductBrand);
    }
}