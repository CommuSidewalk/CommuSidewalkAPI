using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CommuSidewalkAPI.Models;

public partial class SidewalkContext : DbContext
{
    public SidewalkContext()
    {
    }

    public SidewalkContext(DbContextOptions<SidewalkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<InfoL2> InfoL2s { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InfoL2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("info_l2_pk");

            entity.ToTable("info_l2");

            entity.Property(e => e.Id).HasColumnName("_id");
            entity.Property(e => e.Checker).HasColumnName("checker");
            entity.Property(e => e.CountyName).HasColumnName("countyName");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.DataTime).HasColumnName("dataTime");
            entity.Property(e => e.ImgName).HasColumnName("imgName");
            entity.Property(e => e.ImgUrl).HasColumnName("imgUrl");
            entity.Property(e => e.Label).HasColumnName("label");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lng).HasColumnName("lng");
            entity.Property(e => e.Marker).HasColumnName("marker");
            entity.Property(e => e.Occupation).HasColumnName("occupation");
            entity.Property(e => e.Protective).HasColumnName("protective");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.RankA1).HasColumnName("rankA1");
            entity.Property(e => e.RankB1).HasColumnName("rankB1");
            entity.Property(e => e.RankC1).HasColumnName("rankC1");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.RiskRate).HasColumnName("riskRate");
            entity.Property(e => e.Sidewalk).HasColumnName("sidewalk");
            entity.Property(e => e.TownName).HasColumnName("townName");
            entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");
            entity.Property(e => e.Uploader).HasColumnName("uploader");
            entity.Property(e => e.VillCode).HasColumnName("villCode");
            entity.Property(e => e.VillName).HasColumnName("villName");
            entity.Property(e => e.WalkRisk).HasColumnName("walkRisk");
            entity.Property(e => e.Wheelchair).HasColumnName("wheelchair");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
