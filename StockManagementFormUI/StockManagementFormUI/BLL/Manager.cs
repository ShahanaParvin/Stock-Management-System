using System;
using System.Data;
using StockManagementFormUI.Model;
using StockManagementInfoApp.DAL;

namespace StockManagementFormUI.BLL
{
     public class Manager
    {

         Repository _repository = new Repository();
        public bool Add(Person person)
        {
            if (person.CategoryName.Length==null)
            {
                throw new Exception("Fill Up the form");
                
            }
           
            bool toServer = _repository.Add(person);
            return toServer;
        }

       

        public bool CompanyAdd(Person person)
        {
            if (person.CompanyName.Length==null)
            {
                throw new Exception("Entry the Company Name");
            }
            bool isServer = _repository.companyAdd(person);
            return isServer;
        }

        public bool Update(Person person)
        {
            bool isUpdate = _repository.update(person);
            return isUpdate;
        }




        public bool CompanyUpdate(Person person)
        {
            bool isUpdate = _repository.Companyupdate(person);
            return isUpdate;
        }



        public System.Data.DataTable query(Person person)
        {
            DataTable dt = new DataTable();
            dt = _repository.query(person);
            return dt;

        }
    }
}
