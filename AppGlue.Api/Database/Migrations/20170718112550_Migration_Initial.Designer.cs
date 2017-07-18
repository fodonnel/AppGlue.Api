using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AppGlue.Api.Database;

namespace AppGlue.Api.Database.Migrations
{
    [DbContext(typeof(AppGlueDbContext))]
    [Migration("20170718112550_Migration_Initial")]
    partial class Migration_Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppGlue.Api.Database.Entities.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BiosDate");

                    b.Property<string>("BiosVersion")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Manufacturer")
                        .HasMaxLength(50);

                    b.Property<long?>("MemoryInKb");

                    b.Property<string>("Model")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Notes");

                    b.Property<string>("Processor")
                        .HasMaxLength(50);

                    b.Property<string>("SerialNumber")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Computers");
                });
        }
    }
}
