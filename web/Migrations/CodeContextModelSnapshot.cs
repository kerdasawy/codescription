﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using core;

namespace web.Migrations
{
    [DbContext(typeof(CodeContext))]
    partial class CodeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("core.CodeDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CodeTypeId");

                    b.HasIndex("ModuleId");

                    b.ToTable("CodeDescription");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            Code = "Error-System-1000",
                            CodeTypeId = 1,
                            Description = "the field required to be entered",
                            Message = "RequiredField",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1001,
                            Code = "Error-System-1001",
                            CodeTypeId = 1,
                            Description = "authentication needed before use ",
                            Message = "Unauthorized",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1002,
                            Code = "Error-System-1002",
                            CodeTypeId = 1,
                            Description = "Already used value like used email   ",
                            Message = "AlreadyExist",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1004,
                            Code = "Error-UserProfile-1004",
                            CodeTypeId = 1,
                            Description = "the user trail ended and some action can't be activated",
                            Message = "UserTrialEnded",
                            ModuleId = 2
                        },
                        new
                        {
                            Id = 1005,
                            Code = "Error-System-1005",
                            CodeTypeId = 1,
                            Description = "the value not found to use like any  forgery key   or validation code",
                            Message = "NotExist",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1006,
                            Code = "Error-System-1006",
                            CodeTypeId = 1,
                            Description = "the link of activation email link or password reset link in expired",
                            Message = "ExpiredLink",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1007,
                            Code = "Error-System-1007",
                            CodeTypeId = 1,
                            Description = "The link used before",
                            Message = "UsedLink",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1008,
                            Code = "Error-System-1008",
                            CodeTypeId = 1,
                            Description = "miss use of values or some logic is incorrect",
                            Message = "InvaildField",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1017,
                            Code = "Error-System-1017",
                            CodeTypeId = 1,
                            Description = "the user email not verified and can't continue the process",
                            Message = "UserUnverfiedEmail",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1009,
                            Code = "Warning-System-1009",
                            CodeTypeId = 2,
                            Description = "",
                            Message = "PasswordWeak",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1010,
                            Code = "Warning-System-1010",
                            CodeTypeId = 2,
                            Description = "",
                            Message = "PasswordMeduim",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1011,
                            Code = "Warning-System-1011",
                            CodeTypeId = 2,
                            Description = "",
                            Message = "PasswordStrong",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1012,
                            Code = "Warning-System-1012",
                            CodeTypeId = 2,
                            Description = "",
                            Message = "EmailVerifitionLinkShouldBeResent",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1013,
                            Code = "Status-System-1013",
                            CodeTypeId = 3,
                            Description = "the operation is completed like reset password or verified email done",
                            Message = "Success",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1014,
                            Code = "Status-System-1014",
                            CodeTypeId = 3,
                            Description = "the operation is uncompleted review errors",
                            Message = "Failed",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1015,
                            Code = "Status-System-1015",
                            CodeTypeId = 3,
                            Description = "the operation is saved on system",
                            Message = "Saved",
                            ModuleId = 1
                        },
                        new
                        {
                            Id = 1016,
                            Code = "Status-System-1016",
                            CodeTypeId = 3,
                            Description = "the operation is unsaved on system review errors",
                            Message = "Unsaved",
                            ModuleId = 1
                        });
                });

            modelBuilder.Entity("core.CodeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CodeType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "#fb6fed",
                            Description = "Error in operation or user input invalid.",
                            Name = "Error"
                        },
                        new
                        {
                            Id = 2,
                            Color = "#f9fba2",
                            Description = "Warning in operation or user input has issue.",
                            Name = "Warning"
                        },
                        new
                        {
                            Id = 3,
                            Color = "#c4c4c4",
                            Description = "Operation Status and info.",
                            Name = "Status"
                        });
                });

            modelBuilder.Entity("core.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Module");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "General code for all system wide",
                            Name = "System"
                        },
                        new
                        {
                            Id = 2,
                            Description = "UserProfile  service  ",
                            Name = "UserProfile"
                        });
                });

            modelBuilder.Entity("core.CodeDescription", b =>
                {
                    b.HasOne("core.CodeType", "Type")
                        .WithMany("CodeDescriptions")
                        .HasForeignKey("CodeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("core.Module", "Module")
                        .WithMany("CodeDescriptions")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("core.CodeType", b =>
                {
                    b.Navigation("CodeDescriptions");
                });

            modelBuilder.Entity("core.Module", b =>
                {
                    b.Navigation("CodeDescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
