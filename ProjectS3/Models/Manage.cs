using System;
using System.Collections.Generic;

namespace ProjectS3.Models;

public partial class Manage
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public int? Age { get; set; }

    public string? WorkExperience { get; set; }

    public int? StaticId { get; set; }

    public int? AccountId { get; set; }

    public int? PageId { get; set; }
}
