using System.Web.Mvc;
using MCAP.Nova.LowestRateDisplay.Models;

namespace LowestRateDisplay.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Search(SearchModel search)
        {
            // first time, we don't input any field, so just return without data
            if(search == null || search.Criteria == null)
            {
                return View();
            }
            localhost.LowestRate lowestRate = new localhost.LowestRate();
            SearchModel model = new SearchModel();
            var szResult = lowestRate.CalculateLowestRate(search.Criteria.StartDeate, search.Criteria.EndDeate);
            model.Result = szResult;
            return View(model);
        }
    }
}