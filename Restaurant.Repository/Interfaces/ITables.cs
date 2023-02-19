using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Repository.Interfaces
{
    public interface ITables
    {
        Table GetTableById(int id);
        Table GetTableByCapacity(int capacity);
        void AddTables();

    }
}
