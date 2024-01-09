using System;
using System.Collections.Generic;

namespace EmployApi.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? Salary { get; set; }

    public string? Department { get; set; }

    public int? JoiningYear { get; set; }

    public int? CompanyId { get; set; }

    public virtual Company? Company { get; set; }
}
