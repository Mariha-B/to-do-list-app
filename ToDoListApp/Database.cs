using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            Console.WriteLine($"Database path: {dbPath}");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ToDoItem>().Wait();
        }

        public Task<List<ToDoItem>>GetItemsAsync()
        {  
             return _database.Table<ToDoItem>().ToListAsync();
            
        }

        public Task<int> SaveItemAsync(ToDoItem item)
        {
            return _database.InsertAsync(item);
        }

        public Task<int> UpdateItemAsync(ToDoItem item)
        {
            return _database.UpdateAsync(item);
        }

        public Task<int> DeleteItemAsync(ToDoItem item)
        {
            return _database.DeleteAsync(item);
        }
    }
}
