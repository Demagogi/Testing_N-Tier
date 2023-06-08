using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_N_Tier.Domain.Interfaces;
using Testing_N_Tier.Domain.Models;

namespace Testin_N_Tier.Application
{
    public class CostumerService : ICostumerService
    {
        private readonly ICostumerRepository _repo; // this layer should not depent on Dal, so this is the way to do it
        public CostumerService(ICostumerRepository repo)
        {
            _repo = repo;
        }
        public List<Costumer> GetByNames()
        {
            var costumers = _repo.GetAll();
            var processed = new List<Costumer>();
            foreach (var costumer in costumers)
            {
                if (costumer.Name.StartsWith("g"))
                {
                    processed.Add(costumer);
                }
            }
            return processed;
        }
    }
}
