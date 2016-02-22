using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAL;
using PA.DAL.PaDataSetTableAdapters;
using PA.BLL.DTO;

namespace PA.BLL
{
    class UserBLL
    {
        private UsersTableAdapter userAdapter = null;

        protected UsersTableAdapter Adapter
        {
            get
            {
                if (userAdapter == null)
                    userAdapter = new UsersTableAdapter();

                return userAdapter;
            
            }
        }

        public PaDataSet.UsersDataTable GetUsers()
        {
            return Adapter.GetData();
        }

        public PaDataSet.UsersDataTable GetUserById(Guid userId)
        {
            return Adapter.GetUserById(userId);
        }

        public string GetUsernameById(Guid userId)
        {
            string strUsername = "";

            PaDataSet.UsersDataTable userDtTable = GetUserById(userId);

            if(userDtTable.Rows.Count>0)
            {
                strUsername = userDtTable.Rows[0]["UserName"].ToString();
            }

            return strUsername;
        }
    }
}
