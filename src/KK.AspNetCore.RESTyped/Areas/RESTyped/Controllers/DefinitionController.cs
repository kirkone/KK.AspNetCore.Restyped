namespace KK.AspNetCore.RESTyped.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ApiExplorer;

    public class DefinitionController : Controller
    {
        private readonly IApiDescriptionGroupCollectionProvider _apiExplorer;
        public DefinitionController(IApiDescriptionGroupCollectionProvider apiExplorer)
        {
            _apiExplorer = apiExplorer;
        }

        public IActionResult Index()
        {
            return View(_apiExplorer);
        }
    }
}