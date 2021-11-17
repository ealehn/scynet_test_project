using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Project.Entities;
using Project.Handler;

namespace Project.Controllers{

    [Route("[controller]")]
    public class ItemsController
    {
        private readonly IDataHandler _idatahandler;

        private ItemsController(IDataHandler idatahandler){
            this._idatahandler = idatahandler;
        }

        public IEnumerable<Item> GetItems()
        {
           return _idatahandler.GetItems();
        }
        
    }

}
