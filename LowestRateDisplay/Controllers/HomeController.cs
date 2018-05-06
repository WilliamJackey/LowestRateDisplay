using System.Web.Mvc;
using MCAP.Nova.LowestRateDisplay.Models;

namespace LowestRateDisplay.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult search(searchModel search)
        {
            // first time, we don't input any field, so just return without data
            if(search == null || search.Criteria == null)
            {
                return View();
            }
            localhost.LowestRate lowestRate = new localhost.LowestRate();
            searchModel model = new searchModel();
            var szResult = lowestRate.calculateLowestRate(search.Criteria.StartDeate, search.Criteria.EndDeate);
            model.Result = szResult;
            return View(model);
        }
    }
}