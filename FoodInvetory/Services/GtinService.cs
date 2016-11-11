using Dapper;
using FoodInvetory.Data;
using FoodInvetory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodInvetory.Services
{
    public class GtinService
    {
        private Connector connector;

        public GtinService(Connector c)
        {
            this.connector = c;
        }

        public Gtin GetSingle(string code)
        {
            var conn = this.connector.GetConnection();

            string sql = @"
                select * from gtin
                left join brand on gtin.bsin = brand.bsin
                where gtin.gtin_cd = @gtin_cd
            ";

            var results = conn.Query<Gtin, Brand, Gtin>(sql, (gtin, brand) => { gtin.Brand = brand; return gtin; }, new { gtin_cd = code }, null, true, "bsin");


            return results.First();
        }
    }
}