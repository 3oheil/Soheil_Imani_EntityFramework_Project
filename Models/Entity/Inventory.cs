﻿namespace Soheil_Imani_EntityFramework_Project.Models.Entity
{
    public class Inventory
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int StockQuantity { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
