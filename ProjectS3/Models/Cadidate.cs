using System;
using System.Collections.Generic;

namespace ProjectS3.Models;

public partial class Cadidate
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public int? Age { get; set; }

    public string? City { get; set; }

    public string? Residence { get; set; }

    public int? Phone { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Vacancy { get; set; }

    public int? StaticId { get; set; }

    public int? LiteracyId { get; set; }

    public int? PageId { get; set; }
}
