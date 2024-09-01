﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Uttaraonline.DBConfig;

#nullable disable

namespace Uttaraonline.Migrations
{
    [DbContext(typeof(DBContextProduction))]
    [Migration("20240719171611_Rolemastechange1")]
    partial class Rolemastechange1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Uttaraonline.Models.tbl_ClientDomainsDetails", b =>
                {
                    b.Property<int>("DomainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DomainId"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("DomainDetails")
                        .HasColumnType("int");

                    b.Property<string>("DomainName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiaryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HostingId")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerAdmin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Validity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DomainId");

                    b.ToTable("tbl_ClientDomainDetails", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_ClientHostingDetails", b =>
                {
                    b.Property<int>("HostingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HostingId"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("ExpiaryDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HostingDetails")
                        .HasColumnType("int");

                    b.Property<string>("HostingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerAdmin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Validity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HostingId");

                    b.ToTable("tbl_ClientHostingDetails", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_ClientMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClientId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<string>("ClientBuiisnessEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrimarContactAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimarContactCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimarContactCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimarContactState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_ClientMaster", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_DomainsDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CGST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MSRP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outlet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SGST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wholesale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameServer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameServer2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameServer3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameServer4")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_DomainDetails", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_HostingDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessToCpannel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccessToFTP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Backup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CGST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmailAccount")
                        .HasColumnType("int");

                    b.Property<string>("MSRP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MonthlyBandwidth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outlet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SGST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Storage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wholesale")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_HostingDetails", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_Logger", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogId"));

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Eventdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Excepction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrackingCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LogId");

                    b.ToTable("tbl_Logger", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_NavSubMenu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("fa_class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("navid")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_NavSubMenu", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_Navigation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("fa_class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_Navigation", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_RoleMaster", b =>
                {
                    b.Property<int>("Roleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Roleid"));

                    b.Property<bool?>("AdminDashboard")
                        .HasColumnType("bit");

                    b.Property<bool?>("AdminRoleManager")
                        .HasColumnType("bit");

                    b.Property<bool?>("AdminUserCreation")
                        .HasColumnType("bit");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<bool?>("ClientRoleManager")
                        .HasColumnType("bit");

                    b.Property<bool?>("ClientUserCreation")
                        .HasColumnType("bit");

                    b.HasKey("Roleid");

                    b.ToTable("tbl_RoleMaster", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_ServiceTypeMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ServiceTypeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ServiceTypeDescription");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ServiceTypeName");

                    b.HasKey("Id");

                    b.ToTable("tbl_ServiceTypeMaster", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_ServicesMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ServiceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ServiceDescription");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ServiceName");

                    b.Property<int>("ServiceType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tbl_ServicesMaster", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_UserMaster", b =>
                {
                    b.Property<int>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Uid"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("AuditTail")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uid");

                    b.ToTable("tbl_UserMaster", "dbo");
                });

            modelBuilder.Entity("Uttaraonline.Models.tbl_UserRoleMapping", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Roleid")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_UserRoleMapping", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
