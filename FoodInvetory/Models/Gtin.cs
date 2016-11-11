using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodInvetory.Models
{
    public class Gtin
    {
        public string GTIN_CD { get; set; }
        public int GTIN_LEVEL_CD { get; set; }
        public string GCP_CD { get; set; }
        public string BSIN { get; set; }
        public string GPC_S_CD { get; set; }
        public string GPC_F_CD { get; set; }
        public string GPC_C_CD { get; set; }
        public string GPC_B_CD { get; set; }
        public string GTIN_NM { get; set; }
        public string PRODUCT_LINE { get; set; }
        public double M_G { get; set; }
        public double M_OZ { get; set; }
        public double M_ML { get; set; }
        public double M_FLOZ { get; set; }
        public double M_ABV { get; set; }
        public double M_ABW { get; set; }
        public int PKG_UNIT { get; set; }
        public int PKG_TYPE_CD { get; set; }
        public string REF_CD { get; set; }
        public string SOURCE { get; set; }
        public int IMG { get; set; }

        public Brand Brand { get; set; }
    }
}

/*
 CREATE TABLE dummy (
	 { get; set; }GTIN_CD { get; set; } VARCHAR(13) NOT NULL,
	 { get; set; }GTIN_LEVEL_CD { get; set; } INT(11) NOT NULL DEFAULT '1',
	 { get; set; }GCP_CD { get; set; } VARCHAR(13) NULL DEFAULT NULL,
	 { get; set; }BSIN { get; set; } VARCHAR(6) NULL DEFAULT NULL,
	 { get; set; }GPC_S_CD { get; set; } VARCHAR(8) NULL DEFAULT NULL,
	 { get; set; }GPC_F_CD { get; set; } VARCHAR(8) NULL DEFAULT NULL,
	 { get; set; }GPC_C_CD { get; set; } VARCHAR(8) NULL DEFAULT NULL,
	 { get; set; }GPC_B_CD { get; set; } VARCHAR(8) NULL DEFAULT NULL,
	 { get; set; }GTIN_NM { get; set; } VARCHAR(255) NULL DEFAULT NULL,
	 { get; set; }PRODUCT_LINE { get; set; } VARCHAR(255) NULL DEFAULT NULL,
	 { get; set; }M_G { get; set; } FLOAT NULL DEFAULT NULL COMMENT 'gramme',
	 { get; set; }M_OZ { get; set; } FLOAT NULL DEFAULT NULL COMMENT 'oz.',
	 { get; set; }M_ML { get; set; } FLOAT NULL DEFAULT NULL COMMENT 'ml',
	 { get; set; }M_FLOZ { get; set; } FLOAT NULL DEFAULT NULL COMMENT 'fl.oz.',
	 { get; set; }M_ABV { get; set; } FLOAT NULL DEFAULT NULL,
	 { get; set; }M_ABW { get; set; } FLOAT NULL DEFAULT NULL,
	 { get; set; }PKG_UNIT { get; set; } INT(11) NOT NULL DEFAULT '1' COMMENT 'Number of items in the product',
	 { get; set; }PKG_TYPE_CD { get; set; } INT(11) NULL DEFAULT NULL,
	 { get; set; }REF_CD { get; set; } VARCHAR(255) NULL DEFAULT NULL,
	 { get; set; }SOURCE { get; set; } VARCHAR(255) NOT NULL,
	 { get; set; }IMG { get; set; } INT(1) NULL DEFAULT NULL
)
     */
