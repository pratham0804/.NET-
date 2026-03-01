using System;
using System.Collections.Generic;

namespace EFCORE.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Credits { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
