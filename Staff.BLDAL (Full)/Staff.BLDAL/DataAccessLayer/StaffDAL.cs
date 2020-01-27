using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff.BLDAL.DataAccessLayer
{
    public class StaffDAL : DBHelper
    {
        public SqlConnection _sqlConn;

        public StaffDAL()
        {
            _sqlConn = base._basesqlConn;

        }



        /// <summary>
        /// Selects a record from the Staff table by its primary key.
        /// </summary>
        public SqlDataReader Staff_Select(Staff.BLDAL.DTO.Staff StaffLine)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "usp_Staff_Select";
            sqlCmd.Connection = this._sqlConn;
            sqlCmd.Parameters.AddWithValue("@StaffID", StaffLine.StaffID);
            if (this._sqlConn.State == ConnectionState.Closed)
            {
                this._sqlConn.Open();
            }
            SqlDataReader rd = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            return rd;
        }

        /// <summary>
        /// Saves a record to the Staff table.
        /// </summary>
        public bool Staff_Insert(Staff.BLDAL.DTO.Staff StaffLine)
        {
            bool status = false;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "usp_Staff_Insert";
                sqlCmd.Connection = this._sqlConn;
                sqlCmd.Parameters.AddWithValue("@LastName", ((StaffLine.LastName != null) ? (object)StaffLine.LastName : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@MiddleName", StaffLine.MiddleName);
                sqlCmd.Parameters.AddWithValue("@FirstName", ((StaffLine.FirstName != null) ? (object)StaffLine.FirstName : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@Gender", ((StaffLine.Gender != null) ? (object)StaffLine.Gender : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@Position", ((StaffLine.Position != null) ? (object)StaffLine.Position : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@HiredDate", ((StaffLine.HiredDate != null) ? (object)StaffLine.HiredDate : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@Salary", ((StaffLine.Salary != null) ? (object)StaffLine.Salary : DBNull.Value));
                if (this._sqlConn.State == ConnectionState.Closed)
                {
                    this._sqlConn.Open();
                }
                int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
                if (numberOfRecordsAffected > 0)
                {
                    status = true;
                }
                this._sqlConn.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                status = false;
            }
            return status;
        }

        /// <summary>
        /// Saves a record to the Staff table.
        /// </summary>
        public bool Staff_Update(Staff.BLDAL.DTO.Staff StaffLine)
        {
            bool status = false;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "usp_Staff_Update";
                sqlCmd.Connection = this._sqlConn;
                sqlCmd.Parameters.AddWithValue("@LastName", ((StaffLine.LastName != null) ? (object)StaffLine.LastName : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@MiddleName", StaffLine.MiddleName);
                sqlCmd.Parameters.AddWithValue("@FirstName", ((StaffLine.FirstName != null) ? (object)StaffLine.FirstName : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@Gender", ((StaffLine.Gender != null) ? (object)StaffLine.Gender : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@Position", ((StaffLine.Position != null) ? (object)StaffLine.Position : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@HiredDate", ((StaffLine.HiredDate != null) ? (object)StaffLine.HiredDate : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@Salary", ((StaffLine.Salary != null) ? (object)StaffLine.Salary : DBNull.Value));
                if (this._sqlConn.State == ConnectionState.Closed)
                {
                    this._sqlConn.Open();
                }
                int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
                if (numberOfRecordsAffected > 0)
                {
                    status = true;
                }
                this._sqlConn.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                status = false;
            }
            return status;
        }

        /// <summary>
        /// Deletes a record from the Staff table by its primary key.
        /// </summary>
        public bool Staff_Delete(Staff.BLDAL.DTO.Staff StaffLine)
        {
            bool status = false;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "usp_Staff_Delete";
                sqlCmd.Connection = this._sqlConn;
                sqlCmd.Parameters.AddWithValue("@StaffID", StaffLine.StaffID);
                if (this._sqlConn.State == ConnectionState.Closed)
                {
                    this._sqlConn.Open();
                }
                int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
                if (numberOfRecordsAffected > 0)
                {
                    status = true;
                }
                this._sqlConn.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                status = false;
            }
            return status;
        }


        ///// <summary>
        ///// Saves a record to the Staff table.
        ///// </summary>
        // public bool Staff_InsertUpdate(Staff  StaffLine)
        // {
        //	 bool status = false;
        //	 try
        //	 {
        //		 SqlCommand sqlCmd = new SqlCommand();
        //		 sqlCmd.CommandType = CommandType.StoredProcedure;
        //		 sqlCmd.CommandText = "usp_Staff_InsertUpdate";
        //		 sqlCmd.Connection = this._sqlConn;
        //		 sqlCmd.Parameters.AddWithValue("@StaffID", StaffLine.supplierID);
        //		 sqlCmd.Parameters.AddWithValue("@CompanyName", StaffLine.companyName);
        //		 sqlCmd.Parameters.AddWithValue("@Address", ((StaffLine.address != null) ? (object)StaffLine.address : DBNull.Value));
        //		 sqlCmd.Parameters.AddWithValue("@City", ((StaffLine.city != null) ? (object)StaffLine.city : DBNull.Value));
        //		 sqlCmd.Parameters.AddWithValue("@Region", ((StaffLine.region != null) ? (object)StaffLine.region : DBNull.Value));
        //		 sqlCmd.Parameters.AddWithValue("@PostalCode", ((StaffLine.postalCode != null) ? (object)StaffLine.postalCode : DBNull.Value));
        //		 sqlCmd.Parameters.AddWithValue("@Country", ((StaffLine.country != null) ? (object)StaffLine.country : DBNull.Value));
        //		 if (this._sqlConn.State == ConnectionState.Closed)
        //		 {
        //			 this._sqlConn.Open();
        //		 }
        //		 int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
        //		 if (numberOfRecordsAffected > 0)
        //		 {
        //		 status = true;
        //		 }
        //		 this._sqlConn.Close();
        //	}
        //	 catch (Exception ex)
        //	 {
        //		 if (ConfigurationManager.AppSettings["RethrowErrors"]  == "true")     {     throw ex;   }  status = false;
        //	 }
        //	 return status;
        // }

        /// <summary>
        /// Selects a record from the Staff table by its primary key.
        /// </summary>
        public SqlDataReader Staff_SelectList()
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "usp_Staff_SelectList";
            sqlCmd.Connection = this._sqlConn;
            if (this._sqlConn.State == ConnectionState.Closed)
            {
                this._sqlConn.Open();
            }
            SqlDataReader rd = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            return rd;
        }


        public SqlDataReader Staff_Search_SelectList(DTO.Staff StaffLine)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "usp_Staff_Search_SelectList";
            sqlCmd.Parameters.AddWithValue("@companyName", ((StaffLine.LastName != null) ? (object)StaffLine.LastName : DBNull.Value));
            sqlCmd.Connection = this._sqlConn;
            if (this._sqlConn.State == ConnectionState.Closed)
            {
                this._sqlConn.Open();
            }
            SqlDataReader rd = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            return rd;
        }



    }
}
