﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MVC_Shekru_WebApplication.Models;

public partial class DesignationGrade
{
    public int GradeIdRef { get; set; }

    public string GradeName { get; set; }

    public int? DesignationIdRef { get; set; }

    public bool? IsActive { get; set; }

    public virtual Designation DesignationIdRefNavigation { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}