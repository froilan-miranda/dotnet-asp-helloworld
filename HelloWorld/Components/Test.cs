using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Components;

public class Test: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}