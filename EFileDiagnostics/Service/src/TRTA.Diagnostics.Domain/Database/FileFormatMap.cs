using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain.Database
{
    class FileFormatMap : ClassMap<FileFormat>
    {
        public FileFormatMap()
        {
            //Schema("brms");
            Table("FileFormat");

            Id(x => x.Id).Column("Id");
            Map(x => x.FormatType);
        }
    }
}
