using System;
using System.Collections.Generic;

namespace ProjectS3.Models;

public partial class Page
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public double? Wage { get; set; }

    public byte[]? Image { get; set; }

    public int? DateCreate { get; set; }

    public DateTime? Modification { get; set; }

    public string? Company { get; set; }

    public string? JobDescription { get; set; }

    public string? Vacancy { get; set; }

    public string? Address { get; set; }

    public int? DateSubmitted { get; set; }

    public string? Tag { get; set; }

    public int? CategoryId { get; set; }
}
