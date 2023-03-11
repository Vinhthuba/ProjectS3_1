using System;
using System.Collections.Generic;

namespace ProjectS3.Models;

public partial class Static
{
    public int Id { get; set; }

    public string? StaticName { get; set; }

    public string? StaticNotification { get; set; }

    public string? Interviewer { get; set; }

    public DateTime? InterviewTime { get; set; }
}
