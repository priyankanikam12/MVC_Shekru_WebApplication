﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Shekru_WebApplication.Models;

public partial class Employee
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Firstname is required")]
    public string Firstname { get; set; }

    [Required(ErrorMessage = "Lastname is required")]
    public string Lastname { get; set; }

    [Required(ErrorMessage = "EmailAddress is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", ErrorMessage = "Email address must be a valid gmail address.")]
    public string EmailAddress { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^[2-9]{1}[0-9]{2}-[0-9]{3}-[0-9]{4}$", ErrorMessage = "Please enter a valid USA mobile phone number in the format ###-###-####")]
    public string Phonenumber { get; set; }

    [Required(ErrorMessage = "Designation is required")]
    public int DesignationIdRef { get; set; }

    [Required(ErrorMessage = "Grade is required")]
    public int GradeIdRef { get; set; }

    public virtual Designation DesignationIdRefNavigation { get; set; }

    public virtual DesignationGrade GradeIdRefNavigation { get; set; }
}