using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libaray.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? ImagePath { get; set; }
    [NotMapped]
    public IFormFile? ImageFile { get; set; }
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
