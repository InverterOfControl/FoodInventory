using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodInvetory.Models
{
    public class Brand
    {
        public string BSIN { get; set; }
        public string BRAND_NM { get; set; }
        public int BRAND_TYPE_CD { get; set; }
        public string BRAND_LINK { get; set; }
    }
}


/*
 CREATE TABLE dummy (
	`BSIN` VARCHAR(6) NOT NULL,
	`BRAND_NM` VARCHAR(255) NOT NULL,
	`BRAND_TYPE_CD` INT(11) NOT NULL DEFAULT '1',
	`BRAND_LINK` VARCHAR(255) NULL DEFAULT NULL
)
     */
