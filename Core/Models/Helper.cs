using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class Helper
    {
        public static bool CheckFirstLetter(this string name, string surname)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                return false;
            }
            if (name.Length < 3 || surname.Length < 3)
            {
                return false;
            }

            return char.IsUpper(name[0]) && char.IsUpper(surname[0]);
        }

        public static bool CheckClassRoomName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false ;
            }

            if (name.Length!=5)
            {
                return false ;
            }

            return char.IsUpper(name[0]) && char.IsUpper(name[1])&& char.IsDigit(name[2])&& char.IsDigit(name[3])&& char.IsDigit(name[4]);
        }
       
    }
}
