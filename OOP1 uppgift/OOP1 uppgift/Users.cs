using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1uppgift
{
    public class Users  
    {
        public string username;
        public string password;
        

        public Users (string username, string password)
        {
            this.username = username;
            this.password = password;
            
        }

    }

    

    public class Basket
    {
        public List<BasketItem> BasketItems
        {
            get;
            set;
        }

        public Basket()
        {
            BasketItems = new List<BasketItem>();
        }

        public decimal GoodsTotal
        {
            get
            {
                return BasketItems.Sum(x => x.LineTotal);
            }
        }

        public void AddItem(string productCode, string itemType, int quantity, decimal price)
        {
            var basketItem = GetItem(productCode, itemType, quantity, price);
            if (basketItem != null)
            {
                BasketItems.Add(basketItem);
            }
        }

        private BasketItem GetItem(string productCode, string itemType, int quantity, decimal price)
        {
            Catgory catgory = null;
            if (itemType.ToUpper() == "A")
            {
                catgory = new CategoryA();
            }
            else if (itemType.ToUpper() == "B")
            {
                catgory = new CategoryB();
            }
            else if (itemType.ToUpper() == "C")
            {
                catgory = new CategoryC();
            }
            else
            {
                return null;
            }

            var product = new Product(productCode, price, catgory);
            return new BasketItem(quantity, product);
        }
    }


}
