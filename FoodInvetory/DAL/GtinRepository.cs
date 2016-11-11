using FoodInvetory.Interfaces.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FoodInvetory.Models;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using Dapper;

namespace FoodInvetory.DAL
{
    public class GtinRepository : IGtinRepository
    {
        private IDbConnection _db = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public bool DeleteGtin(string gtin)
        {
            throw new NotImplementedException();
        }

        public List<Gtin> GetGtins(int amount, string sort)
        {
            throw new NotImplementedException();
        }

        public Gtin GetSingleGtin(string gtin)
        {
            string sql = @"
                select * from gtin
                left join brand on gtin.bsin = brand.bsin
                where gtin.gtin_cd = @gtin_cd
            ";

            var results = this._db.Query<Gtin, Brand, Gtin>(sql, (gtin, brand) => { gtin.Brand = brand; return gtin; }, new { gtin_cd = code }, null, true, "bsin");


            return results.First();
        }

        public bool InsertGtin(Gtin newGtin)
        {
            int rowsAffected = this._db.Execute(@"INSERT gtin([gtin_cd],[gtin_nm]) values (@Gtin_CD, @Gtin_NM)", new { Gtin_CD = newGtin.GTIN_CD, Gtin_NM = newGtin.GTIN_NM});

            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateGtin(Gtin gtin)
        {
            throw new NotImplementedException();
        }
    }
}