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
    public class PurchaseController : TableController<Purchase>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            planshetContext context = new planshetContext();
            DomainManager = new EntityDomainManager<Purchase>(context, Request);
        }

        // GET tables/Purchase
        public IQueryable<Purchase> GetAllPurchases()
        {
            return Query();
        }

        // GET tables/Purchase/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Purchase> GetPurchase(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Purchase/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Purchase> PatchPurchase(string id, Delta<Purchase> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Purchase
        public async Task<IHttpActionResult> PostPurchase(Purchase item)
        {
            Purchase current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Purchase/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeletePurchase(string id)
        {
            return DeleteAsync(id);
        }
    }
}