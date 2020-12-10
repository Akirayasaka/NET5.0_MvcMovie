using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
  public class Movie
  {
    public int Id { get; set; }
    /// <summary>
    /// 標題
    /// </summary>
    [Display(Name = "標題")]
    public string Title { get; set; }
    /// <summary>
    /// 上映日期
    /// </summary>
    [DataType(DataType.Date)]
    [Display(Name = "上映日期")]
    public DateTime ReleaseDate { get; set; }
    /// <summary>
    /// 類型
    /// </summary>
    [Display(Name = "類型")]
    public string Genre { get; set; }
    /// <summary>
    /// 價格
    /// </summary>
    [Display(Name = "價格")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
  }
}
