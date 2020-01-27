using Staff.BLDAL.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff.BLDAL.BusinessLogic
{
    public class StaffBLL
    {
        public static Staff.BLDAL.DTO.Staff Staff_Select(Staff.BLDAL.DTO.Staff _StaffLine)
        {
            Staff.BLDAL.DTO.Staff StaffLine = new Staff.BLDAL.DTO.Staff();
            try
            {
                StaffDAL IO = new StaffDAL();
                SqlDataReader myReader = IO.Staff_Select(_StaffLine);
                while (myReader.Read())
                {
                    if (myReader["StaffID"] != DBNull.Value)
                    {
                        StaffLine.StaffID = (int)myReader["StaffID"];
                    }
                    if (myReader["LastName"] != DBNull.Value)
                    {
                        StaffLine.LastName = (string)myReader["LastName"];
                    }
                    if (myReader["MiddleName"] != DBNull.Value)
                    {
                        StaffLine.MiddleName = (string)myReader["MiddleName"];
                    }
                    if (myReader["FirstName"] != DBNull.Value)
                    {
                        StaffLine.FirstName = (string)myReader["FirstName"];
                    }
                    if (myReader["Gender"] != DBNull.Value)
                    {
                        StaffLine.Gender = (string)myReader["Gender"];
                    }
                    if (myReader["Position"] != DBNull.Value)
                    {
                        StaffLine.Position = (string)myReader["Position"];
                    }
                    if (myReader["HiredDate"] != DBNull.Value)
                    {
                        StaffLine.HiredDate = (string)myReader["HiredDate"];
                    }
                    if (myReader["Salary"] != DBNull.Value)
                    {
                        StaffLine.Salary = (string)myReader["Salary"];
                    }
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                return new Staff.BLDAL.DTO.Staff();
            }
            return StaffLine;
        }

        /// <summary>
        /// Saves a record to the Staff table.
        /// </summary>
        public static bool Staff_Insert(Staff.BLDAL.DTO.Staff _StaffLine)
        {
            StaffDAL IO = new StaffDAL();
            return IO.Staff_Insert(_StaffLine);

        }


        /// <summary>
        /// Updates a record to the Staff table.
        /// </summary>
        public static bool Staff_Update(Staff.BLDAL.DTO.Staff _StaffLine)
        {
            StaffDAL IO = new StaffDAL();
            return IO.Staff_Update(_StaffLine);

        }


        /// <summary>
        /// Deletes a record from the Staff table by its primary key.
        /// </summary>
        public static bool Staff_Delete(Staff.BLDAL.DTO.Staff _StaffLine)
        {
            StaffDAL IO = new StaffDAL();

            return IO.Staff_Delete(_StaffLine);

        }


        ///// <summary>
        ///// Saves a record to the Staff table.
        ///// </summary>
        //public static bool Staff_InsertUpdate(Staff  _StaffLine)
        //{
        //		  StaffDAL  IO = new StaffDAL();
        //	 return IO.Staff_InsertUpdate(  _StaffLine);

        //}



        /// <summary>
        /// Select a record to the Staff table.
        /// </summary>
        public static List<DTO.Staff> Staff_SelectList()
        {
            List<Staff.BLDAL.DTO.Staff> StaffList = new List<Staff.BLDAL.DTO.Staff>();
            try
            {
                StaffDAL IO = new StaffDAL();
                SqlDataReader myReader = IO.Staff_SelectList();
                while (myReader.Read())
                {

                    Staff.BLDAL.DTO.Staff StaffLine = new Staff.BLDAL.DTO.Staff();
                    if (myReader["StaffID"] != DBNull.Value)
                    {
                        StaffLine.StaffID = (int)myReader["StaffID"];
                    }
                    if (myReader["LastName"] != DBNull.Value)
                    {
                        StaffLine.LastName = (string)myReader["CompanyName"];
                    }
                    if (myReader["MiddleName"] != DBNull.Value)
                    {
                        StaffLine.MiddleName = (string)myReader["Address"];
                    }
                    if (myReader["FirstName"] != DBNull.Value)
                    {
                        StaffLine.FirstName = (string)myReader["FirstName"];
                    }
                    if (myReader["Gender"] != DBNull.Value)
                    {
                        StaffLine.Gender = (string)myReader["Gender"];
                    }
                    if (myReader["Position"] != DBNull.Value)
                    {
                        StaffLine.Position = (string)myReader["Position"];
                    }
                    if (myReader["HiredDate"] != DBNull.Value)
                    {
                        StaffLine.HiredDate = (string)myReader["HiredDate"];
                    }
                    if (myReader["Salary"] != DBNull.Value)
                    {
                        StaffLine.Salary = (string)myReader["Salary"];
                    }
                    StaffList.Add(StaffLine);

                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                return new List<Staff.BLDAL.DTO.Staff>();
            }
            return StaffList;


        }


        public static List<DTO.Staff> Staff_Search_SelectList(Staff.BLDAL.DTO.Staff _StaffLine)
        {
            List<Staff.BLDAL.DTO.Staff> StaffList = new List<Staff.BLDAL.DTO.Staff>();
            try
            {
                StaffDAL IO = new StaffDAL();
                SqlDataReader myReader = IO.Staff_Search_SelectList(_StaffLine);
                while (myReader.Read())
                {

                    Staff.BLDAL.DTO.Staff StaffLine = new Staff.BLDAL.DTO.Staff();
                    if (myReader["StaffID"] != DBNull.Value)
                    {
                        StaffLine.StaffID = (int)myReader["StaffID"];
                    }
                    if (myReader["LastName"] != DBNull.Value)
                    {
                        StaffLine.LastName = (string)myReader["CompanyName"];
                    }
                    if (myReader["MiddleName"] != DBNull.Value)
                    {
                        StaffLine.MiddleName = (string)myReader["Address"];
                    }
                    if (myReader["FirstName"] != DBNull.Value)
                    {
                        StaffLine.FirstName = (string)myReader["FirstName"];
                    }
                    if (myReader["Gender"] != DBNull.Value)
                    {
                        StaffLine.Gender = (string)myReader["Gender"];
                    }
                    if (myReader["Position"] != DBNull.Value)
                    {
                        StaffLine.Position = (string)myReader["Position"];
                    }
                    if (myReader["HiredDate"] != DBNull.Value)
                    {
                        StaffLine.HiredDate = (string)myReader["HiredDate"];
                    }
                    if (myReader["Salary"] != DBNull.Value)
                    {
                        StaffLine.Salary = (string)myReader["Salary"];
                    }
                    StaffList.Add(StaffLine);

                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                return new List<Staff.BLDAL.DTO.Staff>();
            }
            return StaffList;


        }
    }
}
