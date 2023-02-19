using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BusinessLogic.Interfaces
{
    public interface ITableService
    {
        Table GetTableById(int id);
        Table GetTableByCapacity(int capacity);
        void AddTables();
    }
}
