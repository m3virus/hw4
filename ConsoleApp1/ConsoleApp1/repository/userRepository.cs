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
        users user;
        public List<users> AddUser(string name, string phonenumber, DateTime birthday)
        {
            user.ID = id;
            id++;
            user.Name = Console.ReadLine();
            user.PhoneNumber = Console.ReadLine();
            user.Birthday = DateTime.Parse(Console.ReadLine());
            user.entry = DateTime.Now;
            throw new NotImplementedException();
        }

        public List<users> RemoveUser(int Id)
        {
            throw new NotImplementedException();
        }



        // adduser(name , phone , birth) -> users , id , entry -> files.save()
        // removeuser -> files.load() -> remove user from list -> files.save(list)


    }
}
