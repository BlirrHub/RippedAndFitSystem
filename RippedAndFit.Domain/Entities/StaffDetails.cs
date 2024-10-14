﻿using RippedAndFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RippedAndFit.Domain.Entities;

public class StaffDetails
{
    [Key]
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    public required DateOnly DateOfBirth { get; set; }
    public required int Age { get; set; }
    public required Genders Gender { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    [ForeignKey("Staff")]
    public int StaffId { get; set; }
}
