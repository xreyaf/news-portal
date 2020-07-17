using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewsPortalWebApi.Data_Access.EFCore;
using System;
using System.Linq;

namespace NewsPortalWebApi.Data_Access.Models
{
    /// <summary>
    /// Заполнятор бд 
    /// </summary>
    public class SampleData
    {
        /// <summary>
        /// Метод для запуска процедуры заполнения бд
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new NewsPortalWebApiContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<NewsPortalWebApiContext>>());
            if (context.News.Any())
            {
                return;
            }

            context.Authors.Add(new Author
            {
                Id = new Guid("b7ba7363-0c9f-4584-b661-51a09dd3ed66"),
                Name = "Первый автор"
            });

            context.Authors.Add(new Author
            {
                Id = new Guid("c7dad1a6-fcfb-4147-95af-72d13c796ca1"),
                Name = "Второй автор",
            });

            context.News.Add(new News
            {
                Id = new Guid(),
                Title = "Новость №1",
                Description = "Краткое описание",
                MainText = "Основной текст статьи",
                Relevancy = true,
                CreationDateTime = DateTime.Now,
                ChangingDateTime = DateTime.Now,
                NewsImage = null,
                AuthorId = Guid.Parse("b7ba7363-0c9f-4584-b661-51a09dd3ed66")
            });
            context.News.Add(new News
            {
                Id = new Guid(),
                Title = "Новость №2",
                Description = "Краткое описание новости №2",
                MainText = "Основной текст статьи",
                Relevancy = true,
                CreationDateTime = DateTime.Now,
                ChangingDateTime = DateTime.Now,
                NewsImage = null,
                AuthorId = Guid.Parse("c7dad1a6-fcfb-4147-95af-72d13c796ca1")
            });
            context.News.Add(new News
            {
                Id = new Guid(),
                Title = "Новость №3",
                Description = "Краткое описание новости №3",
                MainText = "Основной текст статьи",
                Relevancy = true,
                CreationDateTime = DateTime.Now,
                ChangingDateTime = DateTime.Now,
                NewsImage = null,
                AuthorId = Guid.Parse("c7dad1a6-fcfb-4147-95af-72d13c796ca1")
            });
            context.SaveChanges();
        }
    }
}

