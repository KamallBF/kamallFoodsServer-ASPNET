﻿// <auto-generated />
using System;
using Kamall_foods_server_aspNetCore.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kamall_foods_server_aspNetCore.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220106205621_MigrationV4")]
    partial class MigrationV4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.BusinessHour", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(767)");

                    b.Property<DateTime>("ClosingHour")
                        .HasColumnType("datetime");

                    b.Property<string>("Day")
                        .HasColumnType("text");

                    b.Property<DateTime>("OpeningHour")
                        .HasColumnType("datetime");

                    b.Property<string>("RestaurantID")
                        .HasColumnType("varchar(767)");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("BusinessHour");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.Entities.Restaurant.RestaurantType", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("RestaurantID")
                        .HasColumnType("varchar(767)");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("RestaurantTypes");

                    b.HasData(
                        new
                        {
                            ID = "981632cd-8f63-4d07-adce-aad9b4a45ba5",
                            Name = "AFRICAN"
                        },
                        new
                        {
                            ID = "f8ffe47a-a5ea-488b-902d-30658e5c94a7",
                            Name = "EUROPEAN"
                        },
                        new
                        {
                            ID = "8a035158-60c8-4335-935a-1e852f459a6f",
                            Name = "FAST-FOOD"
                        },
                        new
                        {
                            ID = "90bcc333-1e1a-4a0e-bb80-aef829f0f92d",
                            Name = "CHINESE"
                        },
                        new
                        {
                            ID = "d4a3df78-337f-4942-b4ec-067cf8298d77",
                            Name = "INDIAN"
                        },
                        new
                        {
                            ID = "1c6f64d5-0d33-4e49-a9d5-143c1c0fbf7d",
                            Name = "CAFE"
                        });
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(4000)");

                    b.Property<string>("RestaurantID")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("TypeID")
                        .HasColumnType("varchar(767)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("price")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("TypeID");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.FoodType", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("FoodTypes");

                    b.HasData(
                        new
                        {
                            ID = "3d5e14b9-5da7-4a26-a320-f4f254641440",
                            Name = "Burger"
                        },
                        new
                        {
                            ID = "ca250579-0fa5-4883-b6b6-65c259f2b875",
                            Name = "Salade"
                        },
                        new
                        {
                            ID = "f39d1f6c-2498-4a6d-b6f1-b87d8927bf48",
                            Name = "Tacos"
                        },
                        new
                        {
                            ID = "c6b1b954-90f7-41f7-96d2-77b3c71db8cc",
                            Name = "Hamburger"
                        },
                        new
                        {
                            ID = "07f274f4-8ac6-4ccf-a8fe-35b334aef522",
                            Name = "Couscous"
                        },
                        new
                        {
                            ID = "e367ba1a-2d33-4a95-9e1a-45731df8219a",
                            Name = "Pizza"
                        },
                        new
                        {
                            ID = "ff6913dc-5f41-4a3f-b102-8add34729f89",
                            Name = "Kebab"
                        },
                        new
                        {
                            ID = "867f6b76-3c53-465f-8f4c-38f7f9a4b02f",
                            Name = "Cake"
                        },
                        new
                        {
                            ID = "5afb6bc2-808f-4077-ab88-0565a60506d8",
                            Name = "Sandwich"
                        },
                        new
                        {
                            ID = "b61ad9df-74d8-460b-9c16-b4b7af56671a",
                            Name = "Dessert"
                        },
                        new
                        {
                            ID = "6932709e-d514-4e22-b850-820d4cb6144b",
                            Name = "Fruits"
                        },
                        new
                        {
                            ID = "a5a6c279-c8a8-4508-abc8-7717148209db",
                            Name = "Viande"
                        },
                        new
                        {
                            ID = "e309f16c-0c4a-489c-aaa3-f13fc57c383b",
                            Name = "Poulet"
                        },
                        new
                        {
                            ID = "cf818423-da1f-478f-880f-5f7d3991f82e",
                            Name = "Snacks"
                        },
                        new
                        {
                            ID = "204d43d3-405c-4a4f-a2bf-9f616c0d3251",
                            Name = "Jus"
                        },
                        new
                        {
                            ID = "1531c8ab-a477-40f0-a22c-a53ed343dae4",
                            Name = "Alcool"
                        },
                        new
                        {
                            ID = "bac590d8-bfdb-4f02-8fb6-c62974586af2",
                            Name = "Vin"
                        },
                        new
                        {
                            ID = "476fe5e6-b791-4050-bcd8-7771b77cff28",
                            Name = "Champagne"
                        },
                        new
                        {
                            ID = "2398f7f0-4e1a-49de-bef0-e89931d82da9",
                            Name = "Whisky"
                        });
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.Person.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("AccountValidationToken")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Firstname")
                        .HasColumnType("text");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<double>("Longitude")
                        .HasColumnType("double");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(4000)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.Restaurant", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(4000)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.DeliveryUser", b =>
                {
                    b.HasBaseType("Kamall_foods_server_aspNetCore.Data.Models.Person.Person");

                    b.Property<int>("ratings")
                        .HasColumnType("int");

                    b.ToTable("DeliveryUsers");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.RestaurantAdmin", b =>
                {
                    b.HasBaseType("Kamall_foods_server_aspNetCore.Data.Models.Person.Person");

                    b.Property<string>("RestaurantId")
                        .HasColumnType("varchar(767)");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("RestaurantAdmins");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.User", b =>
                {
                    b.HasBaseType("Kamall_foods_server_aspNetCore.Data.Models.Person.Person");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("DeliveryAdresses")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.BusinessHour", b =>
                {
                    b.HasOne("Kamall_foods_server_aspNetCore.Data.Models.Restaurant", null)
                        .WithMany("OpeningHours")
                        .HasForeignKey("RestaurantID");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.Entities.Restaurant.RestaurantType", b =>
                {
                    b.HasOne("Kamall_foods_server_aspNetCore.Data.Models.Restaurant", null)
                        .WithMany("Types")
                        .HasForeignKey("RestaurantID");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.Food", b =>
                {
                    b.HasOne("Kamall_foods_server_aspNetCore.Data.Models.Restaurant", null)
                        .WithMany("Foods")
                        .HasForeignKey("RestaurantID");

                    b.HasOne("Kamall_foods_server_aspNetCore.Data.Models.FoodType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.DeliveryUser", b =>
                {
                    b.HasOne("Kamall_foods_server_aspNetCore.Data.Models.Person.Person", null)
                        .WithOne()
                        .HasForeignKey("Kamall_foods_server_aspNetCore.Data.Models.DeliveryUser", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.RestaurantAdmin", b =>
                {
                    b.HasOne("Kamall_foods_server_aspNetCore.Data.Models.Person.Person", null)
                        .WithOne()
                        .HasForeignKey("Kamall_foods_server_aspNetCore.Data.Models.RestaurantAdmin", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kamall_foods_server_aspNetCore.Data.Models.Restaurant", "Restaurant")
                        .WithOne("Owner")
                        .HasForeignKey("Kamall_foods_server_aspNetCore.Data.Models.RestaurantAdmin", "RestaurantId");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.User", b =>
                {
                    b.HasOne("Kamall_foods_server_aspNetCore.Data.Models.Person.Person", null)
                        .WithOne()
                        .HasForeignKey("Kamall_foods_server_aspNetCore.Data.Models.User", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.Restaurant", b =>
                {
                    b.Navigation("Foods");

                    b.Navigation("OpeningHours");

                    b.Navigation("Owner");

                    b.Navigation("Types");
                });
#pragma warning restore 612, 618
        }
    }
}
