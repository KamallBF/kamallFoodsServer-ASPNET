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
    [Migration("20220516113134_MigrationV       5")]
    partial class MigrationV5
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
                            ID = "5de3e181-802e-4327-9668-0dc9c2005ecf",
                            Name = "AFRICAN"
                        },
                        new
                        {
                            ID = "8dc3c431-488e-4fcc-8706-845ef12aae45",
                            Name = "EUROPEAN"
                        },
                        new
                        {
                            ID = "33192253-4046-4ad8-b709-80c24b8a9c6b",
                            Name = "FAST-FOOD"
                        },
                        new
                        {
                            ID = "7233fcb5-89bc-42b0-98f2-08b8710b8b8d",
                            Name = "CHINESE"
                        },
                        new
                        {
                            ID = "be3a3f53-1656-4622-b90c-183f76398d59",
                            Name = "INDIAN"
                        },
                        new
                        {
                            ID = "f3c5d4c5-9166-4366-ac41-ad3d7452eecc",
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
                            ID = "74f8a1cf-f778-47d1-a73a-6726a3773456",
                            Name = "Burger"
                        },
                        new
                        {
                            ID = "e26bd97d-42ec-4437-9749-c32657d39465",
                            Name = "Salade"
                        },
                        new
                        {
                            ID = "a015897e-548f-4794-937f-ee5cb3352343",
                            Name = "Tacos"
                        },
                        new
                        {
                            ID = "11d257c5-f315-4683-91c3-c6a7852ce7e4",
                            Name = "Hamburger"
                        },
                        new
                        {
                            ID = "87c72dbc-8584-4645-a1d4-b707b60b6440",
                            Name = "Couscous"
                        },
                        new
                        {
                            ID = "7b78bafe-e880-4833-8b5c-8bc6804ae521",
                            Name = "Pizza"
                        },
                        new
                        {
                            ID = "f9f33105-4860-4267-8271-399ed05c7f88",
                            Name = "Kebab"
                        },
                        new
                        {
                            ID = "cd0e3efa-29ba-4b42-ba45-61d3af5a4651",
                            Name = "Cake"
                        },
                        new
                        {
                            ID = "dee36cce-c394-49da-a63b-b1cd35fcd158",
                            Name = "Sandwich"
                        },
                        new
                        {
                            ID = "1d62a758-aa6f-4447-a079-9621a8d52c31",
                            Name = "Dessert"
                        },
                        new
                        {
                            ID = "ae7f2d04-f33a-484c-a6a5-2946298b197d",
                            Name = "Fruits"
                        },
                        new
                        {
                            ID = "e159f085-94bc-4c10-8b94-12dd8a96e670",
                            Name = "Viande"
                        },
                        new
                        {
                            ID = "625626c3-faad-4174-801b-ff28165a9263",
                            Name = "Poulet"
                        },
                        new
                        {
                            ID = "6d5896e0-0254-41a9-ade8-9a01b6f255f2",
                            Name = "Snacks"
                        },
                        new
                        {
                            ID = "3215b019-cdb9-4e49-9041-4198abf402bf",
                            Name = "Jus"
                        },
                        new
                        {
                            ID = "1ffbf709-645a-4cd3-8c6f-451c132df3e3",
                            Name = "Alcool"
                        },
                        new
                        {
                            ID = "9f34d056-9735-4fb4-8da8-e74a078d42fd",
                            Name = "Vin"
                        },
                        new
                        {
                            ID = "ba80da75-0fd9-4980-bc9f-add553c15c85",
                            Name = "Champagne"
                        },
                        new
                        {
                            ID = "2d91d9d3-6e5c-418f-b838-34724320065c",
                            Name = "Whisky"
                        });
                });

            modelBuilder.Entity("Kamall_foods_server_aspNetCore.Data.Models.Person.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("AccountValidationToken")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

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

                    b.Property<string>("DeliveryAdresses")
                        .HasColumnType("text");

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
