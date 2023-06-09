﻿// <auto-generated />
using System;
using ASPNETCoreTemplate.IoC.SeedWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPNETCoreTemplate.IoC.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASPNETCoreTemplate.Core.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("created_at");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("refresh_token");

                    b.Property<DateTime?>("RefreshTokenExpiration")
                        .HasColumnType("datetime2")
                        .HasColumnName("refresh_token_expiration");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("updated_at");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("p_k_users");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("i_x_users_email");

                    b.HasIndex("RefreshToken")
                        .IsUnique()
                        .HasDatabaseName("i_x_users_refresh_token")
                        .HasFilter("[refresh_token] IS NOT NULL");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("i_x_users_username");

                    b.ToTable("users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
