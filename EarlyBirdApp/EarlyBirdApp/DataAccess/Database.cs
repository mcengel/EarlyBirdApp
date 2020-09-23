using System.Collections.Generic;
using System.Threading.Tasks;
using EarlyBirdApp.Entities;
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
            _database.CreateTableAsync<Team>().Wait();
            _database.CreateTableAsync<Match>().Wait();
            _database.CreateTableAsync<Game>().Wait();
            _database.CreateTableAsync<GameMatchList>().Wait();
            _database.CreateTableAsync<PlayerGameList>().Wait();
        }
        public SQLiteAsyncConnection GetSQLiteConnection()
        {
            return this._database;
        }
    }
}
