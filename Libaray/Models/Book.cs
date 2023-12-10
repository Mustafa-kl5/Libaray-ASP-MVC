using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libaray.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public decimal? Price { get; set; }

    public int? CategoryId { get; set; }

    public string? ImagePath { get; set; }
    [NotMapped]
    public IFormFile? ImageFile { get; set; }
    public DateOnly? PublicationYear { get; set; }

    public virtual Category? Category { get; set; }
}
