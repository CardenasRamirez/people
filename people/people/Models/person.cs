using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace people.Models
{
    [Table("Tbl_People")]
    class person
    {
        [PrimaryKey, AutoIncrement]
        public int Id{ get; set;}

        [MaxLength(50)]
        public string Name { get; set; }
    }
   
}
