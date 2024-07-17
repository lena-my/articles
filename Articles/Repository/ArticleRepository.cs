using Articles.Models;

namespace Articles.Repository;

public class ArticleRepository
{
    private static List<Article> _articles = new List<Article>();

    //CREATE
    public static void CreateArticle(string title, string contents)
    {
        var idArticle = _articles.Max(a => a.Id);
        var newArticle = new Article()
        {
            Id = idArticle,
            Title = title,
            Contents = contents
        };
        _articles.Add(newArticle);

    }
    
    //READ
    public static List<Article> GetArticles()
    {
        return _articles;
    }
    
    //READ BY ID
    public static Article? GetArticleById(int idArticle)
    {
        var article = _articles.Find(a => a.Id == idArticle);
        return article;
    }
    
    //UPDATE
    public static void UpdateArticle(int idArticle, string title, string contents)
    {
        Article? articleToUpdate = GetArticleById(idArticle);
        if (articleToUpdate != null)
        {
            articleToUpdate.Title = title;
            articleToUpdate.Contents = contents;
        }
        else
        {
            Console.WriteLine("Article not found.");
        }

    }
    
    //DELETE
    public static void RemoveArticle(int idArticle)
    {
        Article articleToRemove = GetArticleById(idArticle);
        _articles.Remove(articleToRemove);
    }
}