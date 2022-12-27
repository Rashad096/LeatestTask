using System;
using System.Collections.Generic;
using System.Text;

namespace userPASWORDtask
{
    internal class User
    {
        public User(string username, string pasword)
        {
            _userName = username;
            _pasword = pasword;
        }

        private string _userName;
        private string _pasword;

        public string UserName
        {
            get => _userName;
            set
            {
                if (value.Length >= 6 || value.Length <= 25)
                {
                    _userName = value;
                }
            }


        }

        public string Pasword
        {
            get => _pasword;
            set
            {
                if (value.Length >= 6 || value.Length <= 25)
                {
                    if (Conditions(value))
                    {
                        _pasword = value;
                    }
                }
            }
        }
        

             public bool HasDigit(string word)
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

        public bool HasUpper(string word) 
        
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

        public bool HasLower(string word)

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

        public bool Conditions(string word) 
        {
            if (HasUpper(word) && HasUpper(word) && HasDigit(word))
            {
                return true;
            }
            return false;
        }

        public string GetInfo()
        {
            return $"Username:{UserName}";
        }

    }

}
