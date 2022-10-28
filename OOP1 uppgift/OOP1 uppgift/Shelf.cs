using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1uppgift
{
    public class Shelf
    {
        
        private string Cost;
        private string ID;

        public string getCost()
        {
            return Cost;
        }

       
    }


    public class Product
    {
        public Product(string name, decimal price, Catgory category)
        {
            Price = price;
            CategoryType = category;
            Name = Name;
        }

        public Catgory CategoryType
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }

    
    public class BasketItem
    {
        public Product Product
        {
            get;
            set;
        }

        public BasketItem(int quantity, Product product)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal Price
        {
            get
            {
                return Product.Price;
            }
        }

        public int Quantity
        {
            get;
            private set;
        }

        public decimal ItemTax
        {
            get
            {
                return (Price * (Product.CategoryType.TaxPercentage / 100));
            }
        }

        public decimal TaxTotal
        {
            get
            {
                return ItemTax * Quantity;
            }
        }

        public decimal LineTotal
        {
            get
            {
                return ((Quantity * Price) + TaxTotal);
            }
        }
    }
    public class CategoryA : Catgory
    {
        private const decimal _TaxPercentage = 10M;
        private const decimal _Price = 100M;
        private const string _ItemType = "CategoryA";
        public CategoryA() : base(_TaxPercentage, _ItemType)
        {
        }
    }
    public class CategoryB : Catgory
    {
        private const decimal _TaxPercentage = 20M;

        private const string _ItemType = "CategoryB";
        public CategoryB() : base(_TaxPercentage, _ItemType)
        {
        }
    }

    public class CategoryC : Catgory
    {
        private const decimal _TaxPercentage = 0M;

        private const string _ItemType = "CategoryC";
        public CategoryC() : base(_TaxPercentage, _ItemType)
        {
        }
    }

    public class Catgory
    {
        public Catgory(decimal taxPercentage, string catgeoryType)
        {
            TaxPercentage = taxPercentage;
            CategoryType = catgeoryType;
        }

        public decimal TaxPercentage
        {
            get;
            set;
        }

        public string CategoryType
        {
            get;
            set;
        }
    }

}
