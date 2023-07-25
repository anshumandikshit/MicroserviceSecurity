using Product.API.Dtos;
using System.Collections;



namespace Product.API.MockData
{
    public class ProductMockDatas
    {


        public List<ProductsDto> GetProductData()
        {
            return new List<ProductsDto>()
            {
                new ProductsDto()
                {
                    ProdcutId =1,
                    ProductName="Product1",
                    ProductPrice=10,
                },
                new ProductsDto()
                {
                    ProdcutId =2,
                    ProductName="Product2",
                    ProductPrice=20,
                },
                new ProductsDto()
                {
                    ProdcutId =3,
                    ProductName="Product3",
                    ProductPrice=30,
                }
            };
        }
    }
}
