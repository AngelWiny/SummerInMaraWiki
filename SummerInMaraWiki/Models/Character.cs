using System;
using System.Collections.Generic;
using System.Text;

namespace SummerInMaraWiki.Models
{
    public class Character : BaseModel
    {
        public Character(int id, string name, string picture) : base(id, name, picture)
        {

        }

        internal static Character FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
