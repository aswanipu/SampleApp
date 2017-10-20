using SampleApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Data
{
   public class PersonDatabase
    {
        readonly SQLiteAsyncConnection database;
        public PersonDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Person>().Wait();
        }
        public Task<List<Person>> GetPeopleAsync()
        {
            return database.Table<Person>().ToListAsync();
        }
        public Task<int> SavePersonAsync(Person item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<List<Person>> GetPersonAsync(int id)
        {
            return database.Table<Person>().Where(i => i.ID == id).ToListAsync();
        }
        public Task<List<Person>> GetConditionPeopleAsync(string ch)

        {
            return database.Table<Person>().Where(q=>q.Name== ch).ToListAsync();
        }
        public Task<int> DeletePersonAsync(Person item)
        {
            return database.DeleteAsync(item);
        }


    }
}
