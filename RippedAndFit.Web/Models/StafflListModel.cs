﻿using RippedAndFit.Domain.Entities;

namespace RippedAndFit.Web.Models;

public class StafflListModel
{
    public required List<Users> Users { get; set; }
    public required List<StaffDetails> StaffDetails { get; set; }
}
