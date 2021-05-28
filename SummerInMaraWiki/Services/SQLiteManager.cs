using SQLite;
using SummerInMaraWiki.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SummerInMaraWiki.Services
{
    public class SQLiteManager
    {
        public SQLiteManager()
        {
            Database = new SQLiteAsyncConnection(MetaData.DatabasePath, MetaData.DatabaseFlags);
            Init();
        }

        public static SQLiteAsyncConnection Database;

        private async void Init()
        {
            await Database.CreateTableAsync<Character>();
            await Database.CreateTableAsync<Item>();
        }
    }
}
