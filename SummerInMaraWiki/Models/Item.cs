using System;
using System.Collections.Generic;
using System.Text;

namespace SummerInMaraWiki.Models
{
    public class Item : BaseModel
    {
        public Item(int id, string name, string picture) : base(id, name, picture)
        {

        }
    }
}
