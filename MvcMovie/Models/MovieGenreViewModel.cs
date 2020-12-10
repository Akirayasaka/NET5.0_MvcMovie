using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
  public class MovieGenreViewModel
  {
    /// <summary>
    /// 電影清單
    /// </summary>
    public List<Movie> Movies { get; set; }
    /// <summary>
    /// 包含內容類型清單，可以讓使用者從清單中選取內容類型
    /// </summary>
    public SelectList Genres { get; set; }
    /// <summary>
    /// 包含所選取內容類型的 MovieGenre
    /// </summary>
    public string MovieGenre { get; set; }
    /// <summary>
    /// 使用者在搜尋欄位中輸入的文字
    /// </summary>
    public string SearchString { get; set; }
  }
}
