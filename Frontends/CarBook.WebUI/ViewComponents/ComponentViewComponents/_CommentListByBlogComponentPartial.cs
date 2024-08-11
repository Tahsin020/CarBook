using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.ComponentViewComponents;

public class _CommentListByBlogComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
