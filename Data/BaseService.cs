using SQLite;

namespace Data
{
    public abstract class BaseService<T> where T : new()
    {
        protected SQLiteAsyncConnection _dbConnection;

        public BaseService()
        {
            SetUpDb();
        }

        private void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpenseDB.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);

                _dbConnection.CreateTableAsync<T>().Wait();
            }
        }

        public async Task<int> InsertAsync(T entity)
        {
            return await _dbConnection.InsertAsync(entity);
        }

        public async Task<int> UpdateAsync(T entity)
        {
            return await _dbConnection.UpdateAsync(entity);
        }

        public async Task<int> DeleteAsync(T entity)
        {
            return await _dbConnection.DeleteAsync(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbConnection.Table<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbConnection.FindAsync<T>(id);
        }
    }
}
