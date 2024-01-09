using System;
using System.Collections.Generic;

namespace EmployApi.Models;

public partial class Company
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? EstablishedYear { get; set; }

    public string? ServicesOffered { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
