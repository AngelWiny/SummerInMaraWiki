using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SummerInMaraWiki.Models
{
    public class Character
    {
        [PrimaryKey]
        public string Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
    }
}
