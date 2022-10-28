using OOP1uppgift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_uppgift
{
    internal class Store
    {

        public void ChooseItems()
        {

            Console.WriteLine("Fyll i information om produkten");
            Basket basket = new Basket();
            Boolean _continue = true;
            while (_continue)
            {

                Console.WriteLine("Skriv namn på produkten");
                var productCode = Console.ReadLine();

                Console.WriteLine("Skriv från vilken Katogori A,B,C ");
                var itemType = Console.ReadLine();

                Console.WriteLine("Skriv antal");
                int productQuantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv priset på produkten");
                int price = Convert.ToInt32(Console.ReadLine());

                basket.AddItem(productCode, itemType.ToString(), productQuantity, price);
                Console.WriteLine("Vill du lägga till fler produkter? Y/N");
                _continue = Console.ReadLine().ToUpper() == "Y";

            }

            Console.WriteLine(string.Format("Totala beloppet med moms:{0}", basket.GoodsTotal));
            Console.ReadLine();

        }
    

    }

}

