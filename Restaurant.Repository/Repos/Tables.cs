using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;
using Restaurant.Models;
using Restaurant.Repository;
using Restaurant.Repository.Interfaces;

namespace Restaurant.Repos
{
    public class Tables : Repositories<Tables>, ITables
    {

        private readonly RestaurantDbContext _dbContext;

        public Tables(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Table> tables = new List<Table>
        {
            new Table(1, 1, false),
            new Table(2, 2, false),
            new Table(3, 2, false),
            new Table(4, 2, false),
            new Table(5, 4, false),
            new Table(6, 4, false),
            new Table(7, 6, false),
            new Table(8, 6, false),
            new Table(9, 8, false),
            new Table(10, 10, false),

        };
        public Table GetTableById(int id)
        {
            Table table = _dbContext.Tables.Where<Table>(x => x.Id == id).FirstOrDefault();
            return table;
        }

        public Table GetTableByCapacity(int capacity)
        {
            Table table = _dbContext.Tables.Where<Table>(x => x.SeatingCapacity == capacity).FirstOrDefault();
            return table;
        }
        public void AddTables()
        {
            foreach( var item in _dbContext.Tables)
            {
                _dbContext.Remove(item);
            }
            _dbContext.SaveChanges();

            for (int i = 0; i < tables.Count;)
            {
                
                _dbContext.Tables.Add(tables.ElementAt(i));
                _dbContext.SaveChanges();
                i++;
            }
            
        }
    }
}
