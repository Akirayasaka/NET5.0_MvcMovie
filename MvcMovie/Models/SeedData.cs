using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMovie.Models
{
  public class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using(
        //連線到DB
        var context = new MvcMovieContext(
          serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
      {
        if (context.Movie.Any())
        {
          // 假如DB內有任何資料則跳出，不會新增
          return;
        }

        context.Movie.AddRange(
            new Movie
            {
              Title = "When Harry Met Sally",
              ReleaseDate = DateTime.Parse("1989-2-12"),
              Genre = "Romantic Comedy",
              Price = 7.99M
            },
            new Movie
            {
              Title = "Ghostbusters",
              ReleaseDate = DateTime.Parse("1984-3-13"),
              Genre = "Comedy",
              Price = 8.99M
            },
            new Movie
            {
              Title = "Ghostbuster 2",
              ReleaseDate = DateTime.Parse("1986-2-23"),
              Genre = "Comedy",
              Price = 9.99M
            },
            new Movie
            {
              Title = "Rio Bravo",
              ReleaseDate = DateTime.Parse("1959-4-15"),
              Genre = "Western",
              Price = 3.99M
            }
          );
        context.SaveChanges();
      }
    }
  }
}
