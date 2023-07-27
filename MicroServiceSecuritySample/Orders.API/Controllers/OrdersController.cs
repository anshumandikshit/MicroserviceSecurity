using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using Orders.API.Dtos;

namespace Orders.API.Controllers
{
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        public static readonly string[] requiredScopes = new string[] { "Orders.All" };

        public OrdersController()
        {
                
        }


        [HttpGet(Name = "")]
        public ActionResult<IEnumerable<OrdersDto>> GetOrders()
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(requiredScopes);
            return CreateMockData();
        }

        
        private static List<OrdersDto> CreateMockData()
        {
            return new List<OrdersDto>
        {
            new OrdersDto
            {
                Id= 1,
                Name="Order1",
                Products= new List<ProductsDto>(){
                    new ProductsDto()
                    {
                        ProdcutId= 1,
                        ProductName="produc1",
                        ProductPrice=30
                    }
                }
            }
        };

        }
    }

    
}
