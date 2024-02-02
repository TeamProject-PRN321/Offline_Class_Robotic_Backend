using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO
{
    public class AccountDao
    {
        private static AccountDao instance = null;
        private static ApplicationDBContext dBContext = null;

        public AccountDao()
        {
            dBContext = new ApplicationDBContext();
        }

        public static AccountDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDao();
                }
                return instance;
            }
        }

    }
}
