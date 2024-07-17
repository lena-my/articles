using Articles.Models;
using Articles.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Articles.Controllers;

public class ArticleController : Controller
{
    // GET
    public IActionResult List()
    {
        var articles= ArticleRepository.GetArticles();
        return View(articles);
    }
    
    public IActionResult AddArticle(string title, string contents)
    {
        ArticleRepository.CreateArticle(title, contents);
        return View();
    }
}