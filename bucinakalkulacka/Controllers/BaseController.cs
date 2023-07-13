using Microsoft.AspNetCore.Mvc;
using bucinakalkulacka.components;

namespace bucinakalkulacka.Controllers
{
    public class BaseController : Controller
    {
        public ErrorProvider errorProvider = new();
        public Content content = ContentSingleton.GetInstance();
        public Counter counter = new Counter(ContentSingleton.GetInstance().CelaCisla);
    }
}
