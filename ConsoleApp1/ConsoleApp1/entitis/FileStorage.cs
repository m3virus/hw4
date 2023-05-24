using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp1.models;

namespace ConsoleApp1.entitis
{
    public class FileStorage
    {
        string address = @"\hw4\ConsoleApp1\FileDataStorage.csv";

        public List<users> load()
        {
            try
            {
                FileStream FileOpener = new FileStream(address, FileMode.OpenOrCreate);
                StreamReader FileReader = new StreamReader(FileOpener);

                List <users> UserList= new List<users>();

                string line = "";
                while ((line = FileReader.ReadLine()) != null)
                {
                    string [] UserInformation =  line.Split(',');
                    users user = new users();
                    user.ID = int.Parse(UserInformation[0]);
                    user.Name = UserInformation[1];
                    user.PhoneNumber = UserInformation[2];
                    user.Birthday = DateTime.Parse(UserInformation[3]);
                    user.entry = DateTime.Parse(UserInformation[4]);

                    UserList.Add(user);


                }
                FileReader.Close();
                FileOpener.Close();
                return UserList;
            }
            catch (Exception)
            {

                Console.WriteLine("you cant load the file please try it again later");
                return null;
            }
            

        }


        public bool save(users user)
        {
            try
            {
                FileStream FileOpener = new FileStream(address, FileMode.OpenOrCreate);

                FileOpener.Close();
                string builder = user.ToString();
                File.AppendAllText(address, builder+"\n");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool save(List<users> user)
        {
            try
            {
                FileStream FileOpener = new FileStream(address, FileMode.Create);
                FileOpener.Close();
                foreach (users i in user)
                {
                    string builder = i.ToString();
                    File.AppendAllText(address, builder + "\n");
                }
                
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
