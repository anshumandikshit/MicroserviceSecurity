using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Identity.Web.Resource;
using Product.API.MockData;
using Product.API.Dtos;

namespace Product.API.Controllers
{
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public static readonly string[] requiredScopes = new string[] { "ProductsAPI.ScopedForOrdersService" };
        private static readonly List<ProductsDto> _productDetails = new ProductMockDatas().GetProductData();
        
        [HttpGet()]
        public ActionResult<IEnumerable<ProductsDto>> GetProductsData()
        {
            return Ok(_productDetails);
        }

        [HttpGet("{productId}")]
        public ActionResult<ProductsDto> GetProductsDataById(int productId)
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(requiredScopes);
            return Ok(_productDetails.Where(x => x.ProdcutId == productId).First());
        }
    }
}
