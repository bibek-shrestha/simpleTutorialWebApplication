﻿using System.ComponentModel.DataAnnotations;

namespace SimpleTutorialWebApplication.Models;

public class PointOfInterestCreationDto
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? Description { get; set; }
}
