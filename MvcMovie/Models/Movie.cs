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
    [Display(Name = "標題")]
    public string Title { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "上映日期")]
    public DateTime ReleaseDate { get; set; }
    [Display(Name = "類型")]
    public string Genre { get; set; }
    [Display(Name = "價格")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
  }
}
