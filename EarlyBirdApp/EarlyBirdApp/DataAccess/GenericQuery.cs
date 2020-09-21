using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EarlyBirdApp.DataAccess
{
    public class GenericQuery<TEntity> where TEntity : new() 
    {
        SQLiteAsyncConnection _database;
        public GenericQuery(SQLiteAsyncConnection _database)
        {
            this._database = _database;
        }
        public Task<List<TEntity>> GetDataAsync()
        {
            return _database.Table<TEntity>().ToListAsync();
        }

        public Task<int> SaveDataAsync(TEntity entity)
        {
            return _database.InsertAsync(entity);
        }
    }
}
