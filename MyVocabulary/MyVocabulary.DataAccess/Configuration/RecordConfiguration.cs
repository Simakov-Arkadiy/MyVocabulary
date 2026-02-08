using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyVocabulary.DataAccess.Antites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.DataAccess.Configuration
{
    internal class RecordConfiguration : IEntityTypeConfiguration<RecordEntity>
    {
        public void Configure(EntityTypeBuilder<RecordEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
