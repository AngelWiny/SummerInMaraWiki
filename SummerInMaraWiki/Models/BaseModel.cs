using System;
using System.Collections.Generic;
using System.Text;

namespace SummerInMaraWiki.Models
{
    public class BaseModel
    {
        public BaseModel(int id, string name, string picture)
        {
            Id = id;
            Name = name;
            Picture = picture;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
    }
}
