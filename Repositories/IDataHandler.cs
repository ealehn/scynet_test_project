
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Project.Handler
{
    interface IDataHandler{
        IEnumerable<Item> GetItems();
        IEnumerable<Item> GetAllItems();

        Item GetItem(Guid id);

        void AddItem(Item item);
        
    }
}