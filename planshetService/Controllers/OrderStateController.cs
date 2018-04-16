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
    public class OrderStateController : TableController<OrderState>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            planshetContext context = new planshetContext();
            DomainManager = new EntityDomainManager<OrderState>(context, Request);
        }

        // GET tables/OrderState
        public IQueryable<OrderState> GetAllOrderStates()
        {
            return Query();
        }

        // GET tables/OrderState/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<OrderState> GetOrderState(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/OrderState/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<OrderState> PatchOrderState(string id, Delta<OrderState> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/OrderState
        public async Task<IHttpActionResult> PostOrderState(OrderState item)
        {
            OrderState current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/OrderState/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteOrderState(string id)
        {
            return DeleteAsync(id);
        }
    }
}