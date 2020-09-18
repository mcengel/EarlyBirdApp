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

        public Task<List<Player>> GetPlayersAsync()
        {
            return _database.Table<Player>().ToListAsync();
        }

        public Task<int> SavePlayersAsync(Player person)
        {
            return _database.InsertAsync(person);
        }
    }
}
