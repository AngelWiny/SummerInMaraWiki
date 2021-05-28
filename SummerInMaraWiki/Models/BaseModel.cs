using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SummerInMaraWiki.Models
{
    public class BaseModel
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
    }
}
