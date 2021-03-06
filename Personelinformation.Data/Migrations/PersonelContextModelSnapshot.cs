// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Personelinformation.Data.Concrete.EfCore;

namespace Personelinformation.Data.Migrations
{
    [DbContext(typeof(PersonelContext))]
    partial class PersonelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Personelinformation.Entity.DetailInformation", b =>
                {
                    b.Property<int>("DetailInformationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("TEXT");

                    b.Property<string>("FatherName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MotherName")
                        .HasColumnType("TEXT");

                    b.HasKey("DetailInformationID");

                    b.ToTable("DetailInformations");

                    b.HasData(
                        new
                        {
                            DetailInformationID = 1,
                            BirthPlace = "Kilis",
                            FatherName = "Mehmet",
                            MotherName = "Ayşe"
                        },
                        new
                        {
                            DetailInformationID = 2,
                            BirthPlace = "İstanbul",
                            FatherName = "Ahmet",
                            MotherName = "Aslı"
                        },
                        new
                        {
                            DetailInformationID = 3,
                            BirthPlace = "Rize",
                            FatherName = "Hasan",
                            MotherName = "Müge"
                        });
                });

            modelBuilder.Entity("Personelinformation.Entity.Information", b =>
                {
                    b.Property<int>("InformationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DetailInformationID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonelInformationID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonelName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonelSurname")
                        .HasColumnType("TEXT");

                    b.HasKey("InformationID");

                    b.HasIndex("DetailInformationID");

                    b.HasIndex("PersonelInformationID");

                    b.ToTable("Informations");

                    b.HasData(
                        new
                        {
                            InformationID = 1,
                            DetailInformationID = 1,
                            PersonelInformationID = 1,
                            PersonelName = "Murat",
                            PersonelSurname = "Kuşcan"
                        },
                        new
                        {
                            InformationID = 2,
                            DetailInformationID = 2,
                            PersonelInformationID = 2,
                            PersonelName = "Adnan",
                            PersonelSurname = "Derkan"
                        },
                        new
                        {
                            InformationID = 3,
                            DetailInformationID = 3,
                            PersonelInformationID = 3,
                            PersonelName = "Esra",
                            PersonelSurname = "Kurt"
                        });
                });

            modelBuilder.Entity("Personelinformation.Entity.PersonelInformation", b =>
                {
                    b.Property<int>("PersonelInformationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AileSiraNo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CiltNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonelInformationID");

                    b.ToTable("PersonelInformations");

                    b.HasData(
                        new
                        {
                            PersonelInformationID = 1,
                            AileSiraNo = 302,
                            CiltNo = 13,
                            Title = "Mühendis"
                        },
                        new
                        {
                            PersonelInformationID = 2,
                            AileSiraNo = 407,
                            CiltNo = 25,
                            Title = "Yazılımcı"
                        },
                        new
                        {
                            PersonelInformationID = 3,
                            AileSiraNo = 123,
                            CiltNo = 32,
                            Title = "Satış Danışmanı"
                        });
                });

            modelBuilder.Entity("Personelinformation.Entity.Information", b =>
                {
                    b.HasOne("Personelinformation.Entity.DetailInformation", "DetailInformation")
                        .WithMany()
                        .HasForeignKey("DetailInformationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Personelinformation.Entity.PersonelInformation", "PersonelInformation")
                        .WithMany()
                        .HasForeignKey("PersonelInformationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetailInformation");

                    b.Navigation("PersonelInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
