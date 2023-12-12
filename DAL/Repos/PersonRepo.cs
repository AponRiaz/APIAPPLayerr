using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PersonRepo
    {
        public static String GetName(int id)
        {
            return id == 120 ? "Apon" : "Not found";
        }
    }
}
