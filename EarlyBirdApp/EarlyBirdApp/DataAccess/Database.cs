using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace EarlyBirdApp.DataAccess
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Player>().Wait();
        }
        public SQLiteAsyncConnection GetSQLiteConnection()
        {
            return this._database;
        }
    }
}
