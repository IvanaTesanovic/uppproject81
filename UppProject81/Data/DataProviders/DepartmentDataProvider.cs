using Data.Entities;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataProviders
{
    public class DepartmentDataProvider
    {
        public List<Department> GetAll()
        {
            using (var database = new Database("UppDb"))
            {
                try
                {
                    var departments = database.Fetch<Department>();
                    return departments;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
