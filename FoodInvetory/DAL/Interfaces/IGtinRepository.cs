using FoodInvetory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodInvetory.Interfaces.DAL
{
    interface IGtinRepository
    {
        List<Gtin> GetGtins(int amount, string sort);

        Gtin GetSingleGtin(string gtin);

        bool InsertGtin(Gtin newGtin);

        bool DeleteGtin(string gtin);

        bool UpdateGtin(Gtin gtin);
    }
}
