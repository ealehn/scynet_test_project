
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Project.Handler
{
    public class DataHandler : IDataHandler{


        List<Item> items = new List<Item>();

        public IEnumerable<Item> GetItems(){
            
            items = new List<Item>(){
                new Item{id = Guid.NewGuid(),name="Item 1", quantity= 4, net_amount=10, gross_amount =15,description="Malaria Test 1", item_category="lab 1",item_unit = "Small", tax=0.21, discount=0.10},
                new Item{id = Guid.NewGuid(),name="Item 2" ,quantity= 5, net_amount=20, gross_amount =30,description="Fever Test 1", item_category="lab 2",item_unit = "Medium", tax=0.31, discount=0.15},
                new Item{id = Guid.NewGuid(),name="Item 3", quantity= 6, net_amount=30, gross_amount =45,description="Covid Test 1", item_category="lab 3",item_unit = "Large", tax=0.41, discount=0.20},
            };

            return items;
        }

        public IEnumerable<Item> GetAllItems(){
            if(items.Count <= 1){
                GetItems();
            }
            return items;
        }

        public Item GetItem(Guid id)
        {
           Item gotten_item =  items.Find(p=> p.id == id);
            return gotten_item;
        }

        public void AddItem(Item item){
            Item new_item = item;
            items.Add(item);
        }
    }
}