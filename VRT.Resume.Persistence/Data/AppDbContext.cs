﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using VRT.Resume.Domain.Entities;
using VRT.Resume.Persistence.Data.Configurations;
#nullable disable

namespace VRT.Resume.Persistence.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Degree> Degree { get; set; }

    public virtual DbSet<EducationField> EducationField { get; set; }

    public virtual DbSet<Person> Person { get; set; }

    public virtual DbSet<PersonContact> PersonContact { get; set; }

    public virtual DbSet<PersonEducation> PersonEducation { get; set; }

    public virtual DbSet<PersonExperience> PersonExperience { get; set; }

    public virtual DbSet<PersonExperienceDuty> PersonExperienceDuty { get; set; }

    public virtual DbSet<PersonExperienceDutySkill> PersonExperienceDutySkill { get; set; }

    public virtual DbSet<PersonImage> PersonImage { get; set; }

    public virtual DbSet<PersonResume> PersonResume { get; set; }

    public virtual DbSet<PersonSkill> PersonSkill { get; set; }

    public virtual DbSet<ResumePersonSkill> ResumePersonSkill { get; set; }

    public virtual DbSet<School> School { get; set; }

    public virtual DbSet<SkillType> SkillType { get; set; }

    public virtual DbSet<UserPerson> UserPerson { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_100_CI_AI");

            modelBuilder.ApplyConfiguration(new Configurations.DegreeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.EducationFieldConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonContactConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonEducationConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonExperienceConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonExperienceDutyConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonExperienceDutySkillConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonImageConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonResumeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonSkillConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ResumePersonSkillConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SchoolConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SkillTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserPersonConfiguration());
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
