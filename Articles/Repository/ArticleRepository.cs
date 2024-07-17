using Articles.Models;

namespace Articles.Repository;

public static class ArticleRepository
{
    private static List<Article> _articles = new List<Article>()
    {
        new Article()
        {
            Id = 1,
            Title = "Lorem ipsum dolor sit amet",
            Contents = "Malesuada fames ac turpis egestas maecenas pharetra convallis posuere morbi. Ut tellus elementum sagittis vitae et. Dolor magna eget est lorem. Nulla facilisi etiam dignissim diam. Quis lectus nulla at volutpat diam. Eget sit amet tellus cras adipiscing enim. Fusce id velit ut tortor. Integer vitae justo eget magna. Sed lectus vestibulum mattis ullamcorper velit. "
        },
        new Article()
        {
            Id = 2,
            Title = "Nulla pharetra diam sit amet nisl",
            Contents = "Mauris pharetra et ultrices neque ornare. Turpis nunc eget lorem dolor. Malesuada proin libero nunc consequat. Pretium viverra suspendisse potenti nullam. Amet nulla facilisi morbi tempus iaculis. Egestas fringilla phasellus faucibus scelerisque eleifend donec pretium. Ornare arcu dui vivamus arcu felis bibendum ut tristique. "
        }
    };

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