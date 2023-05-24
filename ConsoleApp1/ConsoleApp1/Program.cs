using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.repository;
using ConsoleApp1.models;
using ConsoleApp1.entitis;

namespace ConsoleApp1
{
    class Program
    {
        public static void form()
        {
            Console.WriteLine("hi and welcome");
            Console.WriteLine("1.see the user lists");
            Console.WriteLine("2.adding users");
            Console.WriteLine("3.removing user");
            Console.WriteLine("4.exit");
        }
        
        static void Main(string[] args)
        {
            int status;
            FileStorage files = new FileStorage();
            UserRepository users = new UserRepository(files);
            do
            {
                
                form();
                status = int.Parse(Console.ReadLine());

                switch (status){

                    case 1:
                        users.GetAllUserList();
                        break;
                    case 2:
                        Console.WriteLine("please write your name");
                        string name = Console.ReadLine();

                        Console.WriteLine("please write your phonenumber");
                        string phonenumber = Console.ReadLine();

                        Console.WriteLine("please write your birthday with this format dd/mm/yyyy");
                        string birth = Console.ReadLine();

                        users.AddUser(name , phonenumber , birth);
                        break;
                    case 3:
                        Console.WriteLine("please enter the ID you want to remove");
                        int id = int.Parse (Console.ReadLine());
                        users.RemoveUser(id);
                        break;
                    case 4:
                        continue;
                    default:
                        break;

                        

                }
                

            } while (status != 4);

            

        }

        
    }
    
}


