using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using NoteBook.Modle;

namespace NoteBook.DAL
{
    class NoteBookContext:DbContext
    {
        public NoteBookContext() : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.business), true)
        {

        }

        public virtual  DbSet<UserModle> Users { get; set; }
    }
}
