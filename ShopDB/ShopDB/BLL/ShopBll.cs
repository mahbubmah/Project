﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDB.DLL.DAO;
using ShopDB.DLL.Gateway;

namespace ShopDB.BLL
{
    class ShopBll
    {
        private ShopGateway aShopGateway;
        private Shop aShop;
        
        private List<Shop> asShops; 
        
        public string SaveProduct(Shop asShop)
        {
           

            string msg1 = ProductNameIsValid(asShop);
            
            
            
            return msg1;
        }

        private string ProductNameIsValid(Shop aaShop)
        {
            aShopGateway = new ShopGateway();
            int length = (aaShop.ProductCode).Length;
            if (length==3)
            {

                if (length >= 5)
                {
                    if (length >= 10)
                    {
                        return aShopGateway.SaveProduct(aaShop);

                    }
                    return "Plese input 5-10 charecter for product name";

                }
                
                return aShopGateway.SaveProduct(aaShop);

                
            }
            return "Plese input three charecter for product code. ";
        }
        public List<Shop> GetAllProduct()
        {
            ShopGateway asShopGateway=new ShopGateway();
            return asShopGateway.GetAllProduct();
        }
        
         
    }
}
