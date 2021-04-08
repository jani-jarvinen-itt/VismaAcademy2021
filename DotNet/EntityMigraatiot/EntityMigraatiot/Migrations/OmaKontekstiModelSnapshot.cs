﻿// <auto-generated />
using EntityMigraatiot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityMigraatiot.Migrations
{
    [DbContext(typeof(OmaKonteksti))]
    partial class OmaKontekstiModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityMigraatiot.Tehtävä", b =>
                {
                    b.Property<int>("TehtäväId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Otsikko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Valmis")
                        .HasColumnType("bit");

                    b.HasKey("TehtäväId");

                    b.ToTable("Tehtävät");
                });
#pragma warning restore 612, 618
        }
    }
}