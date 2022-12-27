using System;

namespace userPASWORDtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            string select = "";
            User[] users = new User[0];

            do
            {
                Console.WriteLine("- 1. User əlavə et");
                Console.WriteLine(" - 2. Userlara bax");
                Console.WriteLine(" - 3. Userlar üzrə axtarış et");

                select = Console.ReadLine();
                if (select == "1")
                {
                    string Username;
                    string password;
                    do
                    {
                        check = true;
                        Console.WriteLine("Username'ni daxil et uznulugu minimum 6, maximum uzunlug 25):");
                        Username = Console.ReadLine();
                        Console.WriteLine("Passwordu daxil et uzunlugu minimum 8, maximum uzunlug 25):");
                        password = Console.ReadLine();
                        if (Username.Length < 6 || Username.Length > 25)
                        {
                            check = false;
                        }
                        if (password.Length < 8 || password.Length > 25)
                        {
                            check = false;
                        }
                        if (!Conditions(password))
                        {
                            check = false;
                        }


                    } 
                    while (!check);

                    User user1 = new User(Username, password);
                    AddUser(ref users, user1);

                }
                else if (select=="2")
                {
                    DateTime userDate = new DateTime();
                    userDate = new DateTime(2022, 12, 27);
                    for (int i = 0; i < users.Length; i++)
                    {
                        Console.WriteLine(users[i].GetInfo());
                        Console.WriteLine(userDate.ToString("yyyy - MM - dd"));
                    }
                }

                else if (select=="3")
                {
                    Console.Write("Axtarish deyerini daxil edin:");
                    var search = Console.ReadLine();
                    for (int i = 0; i < users.Length; i++)
                    {
                        if (users[i].UserName.ToLower().Contains(search.ToLower()))
                        {
                            Console.WriteLine(users[i].GetInfo());
                        }
                    }
                }



            }
            while (select!="0");

        }

        static void AddUser(ref User[] users, User user)
        {
            User[] newArr = new User[0];
            Array.Resize(ref newArr, newArr.Length + 1);
            for (int i = 0; i < users.Length; i++)
            {
                newArr[i] = users[i];
            }
            newArr[newArr.Length - 1] = user;
            users = newArr;
        }

        static bool HasDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool HasUpper(string word)

        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsUpper(word[i]))
                {
                    return true;
                }
            }
            return false;


        }

        static bool HasLower(string word)

        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLower(word[i]))
                {
                    return true;
                }
            }
            return false;

        }
        static bool Conditions(string word)
        {
            if (HasUpper(word) && HasUpper(word) && HasDigit(word))
            {
                return true;
            }
            return false;
        }
    }
}