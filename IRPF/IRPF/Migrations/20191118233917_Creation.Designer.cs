﻿// <auto-generated />
using IRPF.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IRPF.Migrations
{
    [DbContext(typeof(IrpfContext))]
    [Migration("20191118233917_Creation")]
    partial class Creation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IRPF.Models.Declaration", b =>
                {
                    b.Property<int>("DeclarationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date");

                    b.Property<int>("Dependents");

                    b.Property<double>("Incomme");

                    b.Property<double>("SocialSecurity");

                    b.Property<bool>("Status");

                    b.Property<int>("UserID");

                    b.HasKey("DeclarationId");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Declarations");
                });

            modelBuilder.Entity("IRPF.Models.Deduction", b =>
                {
                    b.Property<int>("DeductionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeclarationID");

                    b.Property<double>("Value");

                    b.HasKey("DeductionID");

                    b.HasIndex("DeclarationID");

                    b.ToTable("Deductions");
                });

            modelBuilder.Entity("IRPF.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Cpf");

                    b.Property<string>("Name");

                    b.Property<int>("NumberDep");

                    b.Property<double>("Prev");

                    b.Property<double>("TotalIncome");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IRPF.Models.Declaration", b =>
                {
                    b.HasOne("IRPF.Models.User", "User")
                        .WithOne("Declaration")
                        .HasForeignKey("IRPF.Models.Declaration", "UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IRPF.Models.Deduction", b =>
                {
                    b.HasOne("IRPF.Models.Declaration", "Declaration")
                        .WithMany("Deducoes")
                        .HasForeignKey("DeclarationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
