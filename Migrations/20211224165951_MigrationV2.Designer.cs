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
    [Migration("20211224165951_MigrationV2")]
    partial class MigrationV2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

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
                            ID = "530c1e45-386a-4f69-8b5e-a622501d9a3d",
                            Name = "AFRICAN"
                        },
                        new
                        {
                            ID = "b09ed667-95d7-429f-9188-b22aa3821f47",
                            Name = "EUROPEAN"
                        },
                        new
                        {
                            ID = "9968f0a2-ba3f-458d-b447-563292c75bb3",
                            Name = "FAST-FOOD"
                        },
                        new
                        {
                            ID = "2ee3a2fb-b586-4fc4-aa77-b9245c4a9dcd",
                            Name = "CHINESE"
                        },
                        new
                        {
                            ID = "094f95c1-15a9-4b73-8c4d-6a62da310a7c",
                            Name = "INDIAN"
                        },
                        new
                        {
                            ID = "33c24893-564c-47a7-ae57-6530d01bd39f",
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
                            ID = "16412381-b6cd-4520-a680-89346b58e1bf",
                            Name = "Burger"
                        },
                        new
                        {
                            ID = "6b05e004-064a-4908-ba86-d5183af4c066",
                            Name = "Salade"
                        },
                        new
                        {
                            ID = "9c708a91-ad6a-4d5a-a3e3-ed6dd6ea1c23",
                            Name = "Tacos"
                        },
                        new
                        {
                            ID = "84204c5a-f5af-4353-aabc-f095eecb1237",
                            Name = "Hamburger"
                        },
                        new
                        {
                            ID = "ea662319-e48e-45ba-b0e5-043951ef2962",
                            Name = "Couscous"
                        },
                        new
                        {
                            ID = "c7edb43a-07d3-4adf-80b3-e050ca6dcbfe",
                            Name = "Pizza"
                        },
                        new
                        {
                            ID = "89ef60dd-8fcf-40ca-b050-aaed7468f59f",
                            Name = "Kebab"
                        },
                        new
                        {
                            ID = "68dcd26f-a205-452d-97d2-2ddaaf0c88cd",
                            Name = "Cake"
                        },
                        new
                        {
                            ID = "8601defd-adfe-413f-84da-bb32c793c7b9",
                            Name = "Sandwich"
                        },
                        new
                        {
                            ID = "35630f60-0175-4875-be5b-981cd6cffbfc",
                            Name = "Dessert"
                        },
                        new
                        {
                            ID = "348e0c47-ce0e-4b11-9621-bbfe3ac3b6a5",
                            Name = "Fruits"
                        },
                        new
                        {
                            ID = "cef693d6-5112-4ffc-96a4-61390468d9ab",
                            Name = "Viande"
                        },
                        new
                        {
                            ID = "264f058e-6dda-4556-86c4-953c324ecd16",
                            Name = "Poulet"
                        },
                        new
                        {
                            ID = "b160b91d-0c18-4c3c-8b86-bb8b5aa67f4e",
                            Name = "Snacks"
                        },
                        new
                        {
                            ID = "c7018b87-9e55-474a-88e9-1264925ebf05",
                            Name = "Jus"
                        },
                        new
                        {
                            ID = "3e903ddb-c9fb-4565-9a09-8f81070abc12",
                            Name = "Alcool"
                        },
                        new
                        {
                            ID = "1c4804ce-8f22-4db2-abf9-a1ef35b5ac6c",
                            Name = "Vin"
                        },
                        new
                        {
                            ID = "69c39e1a-e7ef-4b41-9bc0-ae68b39e061a",
                            Name = "Champagne"
                        },
                        new
                        {
                            ID = "e2db1d36-e2a0-45de-ab1b-1882f1e5dc31",
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

                    b.Navigation("Owner");

                    b.Navigation("Types");
                });
#pragma warning restore 612, 618
        }
    }
}
