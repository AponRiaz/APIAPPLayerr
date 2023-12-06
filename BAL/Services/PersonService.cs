using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class PersonService
    {
        public static string GetName(int id)
        {
            id += 100;
            var data = PersonRepo.GetName(id);  
            return data;

           
        }


    }

}
