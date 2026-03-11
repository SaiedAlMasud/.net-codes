using System;
using System.Collections.Generic;

namespace ValidationPractice.EF.Tables;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Cgpa { get; set; }

    public int? Roll { get; set; }

    public string? Name { get; set; }
}
