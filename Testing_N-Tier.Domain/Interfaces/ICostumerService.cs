using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_N_Tier.Domain.Models;

namespace Testing_N_Tier.Domain.Interfaces
{
    public interface ICostumerService
    {
        List<Costumer> GetByNames();
    }
}
