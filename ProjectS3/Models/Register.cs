using System;
using System.Collections.Generic;

namespace ProjectS3.Models;

public partial class Register
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public int? Phone { get; set; }

    public string? Password { get; set; }
}
