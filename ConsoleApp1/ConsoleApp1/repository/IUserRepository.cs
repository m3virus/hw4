using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.entitis;
using ConsoleApp1.models;

namespace ConsoleApp1.repository
{
    public interface IUserRepository
    {
         List<users> AddUser(string name, string phonenumber, DateTime birthday);
         List<users> RemoveUser(int Id);


    }
}
