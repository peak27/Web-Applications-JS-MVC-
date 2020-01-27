using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff.BLDAL.DataAccessLayer
{
    public class DBHelper
    {
        #region Fields

        public SqlConnection _basesqlConn;

        #endregion

        #region Constructors

        public DBHelper()
        {
            try
            {
                this._basesqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["StaffConn"].ConnectionString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
