using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PersonnWPF
{
    class DataAcess
    {   
         public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Persondb")))
            {
                var output = connection.Query<Person>($"select * from Person where LastName = '{lastName}'").ToList();
                return output;
            }
        }
    }
}
