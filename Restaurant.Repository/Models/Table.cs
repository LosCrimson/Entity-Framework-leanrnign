using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Table
    {
        public int Id { get; set;}
        public int TableNumber { get; set; }
        public int SeatingCapacity { get; set; }
        public bool Occupied { get; set; }

        public Table(int tableNumber, int seatingCapacity, bool occupied) 
        {
            TableNumber = tableNumber;
            SeatingCapacity = seatingCapacity;
            Occupied = occupied;
        }
    }
}
