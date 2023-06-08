using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_N_Tier.Domain.Interfaces;
using Testing_N_Tier.Domain.Models;

namespace Testing_N_Tier.DAL
{
    public class CostumerRepository : ICostumerRepository
    {
        // Here we will inject ApplicationDbContext
        public IEnumerable<Costumer> GetAll()
        {
            throw new NotImplementedException();
            // _db.Costumers- here will will get all the costumers from db
        }
    }
}
