using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.entitis;
using ConsoleApp1.models;

namespace ConsoleApp1.repository
{
    public class UserRepository : IUserRepository
    {
        static int id = 1;
        
        FileStorage files;
        public UserRepository(FileStorage values)
        {
            files = values;
        }
        users user = new users();
        public void AddUser(string name, string phonenumber, DateTime birthday)
        {
            user.ID = id;
            id++;
            user.Name = Console.ReadLine();
            user.PhoneNumber = Console.ReadLine();
            user.Birthday = DateTime.Parse(Console.ReadLine());
            user.entry = DateTime.Now;
            files.save(user);

        }

        public void RemoveUser(int Id)
        {
            List<users> user = files.load();

            foreach (users find in user)
            {
                if (find.ID == Id)
                {
                    user.Remove(find);
                    break;
                }
            }
            files.save(user);
        }

        



        // adduser(name , phone , birth) -> users , id , entry -> files.save()
        // removeuser -> files.load() -> remove user from list -> files.save(list)


    }
}
