using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Phone
    {
        private List<ShopingPhone> items = new List<ShopingPhone>();
        public int AddToCart(ShopingPhone phone)
        {
            bool found = false;
            foreach (ShopingPhone i in items)
            {
                if(i.Productdetail.Product_id == phone.Productdetail.Product_id)
                {
                    i.Quantity += phone.Quantity;
                    found = true;
                }
            };
            if (!found)
            {
                items.Add(phone);
            }
            return items.Count;
        }
        public decimal getTotal()
        {
            decimal total = 0;
            foreach(ShopingPhone i in items)
            {
                total += (int)i.Productdetail.Product_money * i.Quantity;
            }
            return total;
        }
        public List<ShopingPhone> getAlltems()
        {
            return items;
         }
    }
    
   
}