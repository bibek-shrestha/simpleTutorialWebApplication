﻿namespace SimpleTutorialWebApplication.Models;

public class CityDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int NumberOfPointsOfInterest
    {
        get{
            return this.PointOfInterests.Count;
        }
    }

    public ICollection<PointOfInterestDto> PointOfInterests{ get; set; } = new List<PointOfInterestDto>();

}
