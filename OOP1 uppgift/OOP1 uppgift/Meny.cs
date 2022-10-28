using OOP1_uppgift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1uppgift
{
    internal class Meny    
    {

        public void LoginOperation()
        {

            Cart cart = new Cart();
            
            var arrUsers = new Users[]
            {
                new Users("tomas","samsung"),
                new Users("stefan","pasle"),
                new Users("dimitar","jovanov")
                
            };
            var arrAdmin = new Admin[] 
            {
               
            };


        Start:
            Console.WriteLine("Skriv 1 för logga in");
            Console.WriteLine("Skriv 2 för regestrera ny användare");
            Console.WriteLine("skriv 3 för att logga in som Admin");
            var input = Console.ReadLine();


            bool successfull = false;
            while (!successfull)
            {

                if (input == "1")
                {
                    Console.WriteLine("Skriv användarnamn:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Skriv Lösenord:");
                    var password = Console.ReadLine();


                    foreach (Users user in arrUsers)
                    {
                        if (username == user.username && password == user.password)
                        {
                            Console.WriteLine("Du är nu inloggad !!!");
                            Console.ReadLine();
                            successfull = true;
                            

                            Store store = new Store();
                            store.ChooseItems();

                        }
                       
                    }

                   

                    if (!successfull)
                    {
                        Console.WriteLine("Ditt Användarnamn eller Lösenord var felaktigt, försök igen !!!");
                    }

                }

                else if (input == "2")
                {

                    Console.WriteLine("Skriv användarnamn:");
                    var username = Console.ReadLine();

                    Console.WriteLine("Skriv Lösenord:");
                    var password = Console.ReadLine();


                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users(username, password);
                    successfull = true;
                    goto Start;

                }
                else if (input == "3")
                {

                    Console.WriteLine("Skriv Användarnamn");
                    var username = Console.ReadLine();

                    Console.WriteLine("Skriv Lösenord");
                    var password = Console.ReadLine();

                    foreach (Admin admin in arrAdmin)
                    {
                        if (username == admin.username && password == admin.password)
                        {
                            Console.WriteLine("Du är nu inloggad som Admin !!!");
                            Console.ReadLine();
                            successfull = true;


                            Store store = new Store();
                            store.ChooseItems();

                        }
                    }

                }
                else
                {
                    Console.WriteLine("Försök igen !!!");
                    break;


                }
            }
            Console.Clear();
            Console.WriteLine("Hej");
            Console.WriteLine("Detta är slutet på programmet");
            Console.WriteLine("");

            while (true)
            {



                int inp = Convert.ToInt32(Console.ReadLine());
                if (inp == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You chose option 1");
                }
                else if (inp == 2)
                {
                    Console.Clear();
                    Console.WriteLine("You chose option 2");
                }
                else if (inp == 3)
                {
                    Console.Clear();
                    Console.WriteLine("You chose option 3");
                }
                else if (inp == 4)
                {
                    break;
                }
            }

        }

    }
}
