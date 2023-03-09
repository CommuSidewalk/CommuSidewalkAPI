using System;
using System.Collections.Generic;

namespace CommuSidewalkAPI.Models;

public partial class InfoL2
{
    public int? ImgName { get; set; }

    public double? Lat { get; set; }

    public double? Lng { get; set; }

    public string? DataTime { get; set; }

    public string? Remark { get; set; }

    public string? Uploader { get; set; }

    public string? Marker { get; set; }

    public string? Checker { get; set; }

    public string? Label { get; set; }

    public string? CreatedAt { get; set; }

    public string? UpdatedAt { get; set; }

    public string? Sidewalk { get; set; }

    public string? Protective { get; set; }

    public string? Wheelchair { get; set; }

    public string? Occupation { get; set; }

    public string? WalkRisk { get; set; }

    public string? RiskRate { get; set; }

    public string? Purpose { get; set; }

    public string? ImgUrl { get; set; }

    public string Id { get; set; } = null!;

    public double? RankA1 { get; set; }

    public double? RankB1 { get; set; }

    public double? RankC1 { get; set; }

    public string? CountyName { get; set; }

    public string? TownName { get; set; }

    public string? VillName { get; set; }

    public string? VillCode { get; set; }
}
