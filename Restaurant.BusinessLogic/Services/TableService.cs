using Restaurant.BusinessLogic.Interfaces;
using Restaurant.Models;
using Restaurant.Repos;
using Restaurant.Repository.Interfaces;

namespace Restaurant.BusinessLogic.Services
{
    public class TableService : ITableService
    {
        private readonly ITables _tables;

        public TableService(ITables tables)
        {
            _tables = tables;
        }

        public Table GetTableById(int id)
        {
            Table table = _tables.GetTableById(id);
            return table;
        }
        public Table GetTableByCapacity(int capacity)
        {
            Table table = _tables.GetTableByCapacity(capacity);
            return table;
        }
        public void AddTables()
        {
            _tables.AddTables();
        }

    }
}
