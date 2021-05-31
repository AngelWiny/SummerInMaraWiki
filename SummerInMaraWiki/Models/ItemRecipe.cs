using System;
using System.Collections.Generic;
using System.Text;

namespace SummerInMaraWiki.Models
{
    public class ItemRecipe
    {
        public int ItemId { get; set; }
        public int IngredientId { get; set; }
        public int IngredientAmount { get; set; }
    }
}
