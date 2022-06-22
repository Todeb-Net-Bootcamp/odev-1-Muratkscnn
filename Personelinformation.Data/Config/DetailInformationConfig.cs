using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Data.Config
{
    public class DetailInformationConfig : IEntityTypeConfiguration<DetailInformation>
    {
        public void Configure(EntityTypeBuilder<DetailInformation> builder)
        {
            builder.HasData(

                new DetailInformation() { DetailInformationID = 1, FatherName = "Mehmet", MotherName = "Ayşe", BirthPlace = "Kilis" },
                new DetailInformation() { DetailInformationID = 2, FatherName = "Ahmet", MotherName = "Aslı", BirthPlace = "İstanbul" },
                new DetailInformation() { DetailInformationID = 3, FatherName = "Hasan", MotherName = "Müge", BirthPlace = "Rize" }


                );
        }
    }
}
