using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMS.BL;
using System.IO;

namespace TRMS.DL
{
    class UserDL
    {
        static private List<User> NewUsers = new List<User>();
        static private List<Employee> NewEmployee = new List<Employee>();
        
        public static List<User> getUsersList()
        {
            return NewUsers;
        }
        public static List<Employee> getEmployeeList()
        {
            return NewEmployee;
        }
        static User userObj = new User();
        static Employee empObj = new Employee();
        public static void addNewEmployee(Employee emp)
        {
            NewEmployee.Add(emp);
        }
        public static void deleteUser(User name)
        {
            NewUsers.Remove((name));
        }
        public static User findUser(string name)
        {
            foreach (User u in NewUsers)
            {
                if (name == u.getUsername())
                {
                    return u;
                }
            }
            return null;
        }
    

        public static void addNewUser(User x)
        {
            NewUsers.Add(x);
        }
        public static string isValidUser(string username,string password)
        {
            for (int i = 0; i < NewUsers.Count; i++)
            {
                if (username == NewUsers[i].getUsername() && password == NewUsers[i].getPassword())
                {
                    return NewUsers[i].getRole();
                }
            }

            for (int i = 0; i < NewEmployee.Count; i++)
            {
                if (username == NewEmployee[i].getUsername() && password == NewEmployee[i].getPassword())
                {
                    return NewEmployee[i].getRole();
                }
            }
            
            return null;
            
        }
        public static void addAdmin()
        {
            User test = new User("admin", "123", "Admin");
            addNewUser(test);
        }
        public static bool isValidEMAIL(string text)
        {
            int atIndex = -1, dotIndex = -1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    atIndex = i;
                    break;
                }
            }
            if (atIndex != -1)
            {
                for (int i = atIndex; i < text.Length; i++)
                {
                    if (text[i] == '.')
                    {
                        dotIndex = i;
                        break;
                    }
                }
            }
            if (atIndex != -1 && dotIndex != -1)
            {
                return true;
            }
            return false;
        }

        //  F I L E     H A N D L I N G
        public static void storeUser()
        {
            StreamWriter file = new StreamWriter("Users.txt");
            foreach (var v in NewUsers)
            {
                file.WriteLine(v.getUsername() + "," + v.getPassword() + "," + v.getRole());
            }
            file.Flush();
            file.Close();
        }
        public static void loadUser()
        {
           // NewUsers = new List<User>();
            StreamReader file = new StreamReader("Users.txt");
            String line;
            while ((line = file.ReadLine()) != null)
            {
                if (line != "") break;
                string[] record = line.Split(',');
                User temp = new User(record[0], record[1], record[2]);
                NewUsers.Add(temp);
            }
            file.Close();
        }


    }
}

