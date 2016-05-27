using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public interface IHomeController
    {
        ActionResult About();
        ActionResult Gallery();
        ActionResult Index();
        ActionResult Menu();
        ActionResult Partners();
    }
}