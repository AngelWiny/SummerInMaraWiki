using System;
using System.IO;

namespace SummerInMaraWiki
{
    public static class MetaData
    {
        private const string DatabaseFilename = "SummerInMaraSQLite.db3";

        public const SQLite.SQLiteOpenFlags DatabaseFlags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DatabaseFilename);
    }
}
