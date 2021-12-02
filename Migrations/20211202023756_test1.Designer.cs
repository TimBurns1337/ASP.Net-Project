﻿// <auto-generated />
using ASP.Net_project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.Net_project.Migrations
{
    [DbContext(typeof(ComputerContext))]
    [Migration("20211202023756_test1")]
    partial class test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP.Net_project.Models.Case", b =>
                {
                    b.Property<int>("CaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CasePrice")
                        .HasColumnType("float");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CaseId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("ASP.Net_project.Models.Cooling", b =>
                {
                    b.Property<int>("CoolingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoolingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CoolingPrice")
                        .HasColumnType("float");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoolingId");

                    b.ToTable("Coolings");
                });

            modelBuilder.Entity("ASP.Net_project.Models.Cpu", b =>
                {
                    b.Property<int>("CpuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CpuPrice")
                        .HasColumnType("float");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CpuId");

                    b.ToTable("Cpus");
                });

            modelBuilder.Entity("ASP.Net_project.Models.GamingPC", b =>
                {
                    b.Property<int>("GamingPCId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Componets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GamingPCId");

                    b.ToTable("GamingPcs");
                });

            modelBuilder.Entity("ASP.Net_project.Models.Gpu", b =>
                {
                    b.Property<int>("GpuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GpuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GpuPrice")
                        .HasColumnType("float");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GpuId");

                    b.ToTable("Gpus");
                });

            modelBuilder.Entity("ASP.Net_project.Models.Hdd", b =>
                {
                    b.Property<int>("HddId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HddName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HddPrice")
                        .HasColumnType("float");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HddId");

                    b.ToTable("Hdds");
                });

            modelBuilder.Entity("ASP.Net_project.Models.MotherBoard", b =>
                {
                    b.Property<int>("MotherBoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherBoardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MotherBoardPrice")
                        .HasColumnType("float");

                    b.HasKey("MotherBoardId");

                    b.ToTable("MotherBoards");
                });

            modelBuilder.Entity("ASP.Net_project.Models.Power", b =>
                {
                    b.Property<int>("PowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PowerPrice")
                        .HasColumnType("float");

                    b.HasKey("PowerId");

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("ASP.Net_project.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardExpDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ComputerId")
                        .HasColumnType("int");

                    b.Property<int>("CvcNo")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PurchaseId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("ASP.Net_project.Models.Ram", b =>
                {
                    b.Property<int>("RamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RamPrice")
                        .HasColumnType("float");

                    b.HasKey("RamId");

                    b.ToTable("Rams");
                });
#pragma warning restore 612, 618
        }
    }
}
