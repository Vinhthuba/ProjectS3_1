using System;
using System.Collections.Generic;

namespace ProjectS3.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? Levers { get; set; }

    public double? Following { get; set; }

    public string? Title { get; set; }

    public string? SchemaMarkup { get; set; }
}
