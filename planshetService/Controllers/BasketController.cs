using Microsoft.Azure.Mobile.Server;
using planshetService.DataObjects;
using planshetService.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;

namespace planshetService.Controllers
{
    public class BasketController : TableController<Basket>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            planshetContext context = new planshetContext();
            DomainManager = new EntityDomainManager<Basket>(context, Request);
        }

        // GET tables/Basket
        public IQueryable<Basket> GetAllBaskets()
        {
            return Query();
        }

        // GET tables/Basket/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Basket> GetBasket(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Basket/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Basket> PatchBasket(string id, Delta<Basket> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Basket
        public async Task<IHttpActionResult> PostBasket(Basket item)
        {
            Basket current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Basket/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteBasket(string id)
        {
            return DeleteAsync(id);
        }
    }
}