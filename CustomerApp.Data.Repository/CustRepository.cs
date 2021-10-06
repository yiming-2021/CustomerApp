using System;
using System.Collections.Generic;
using System.Text;
using CustomerApp.Data.Model;

namespace CustomerApp.Data.Repository
{
    public class CustRepository : IRepository<Cust>
    {
        DbContext db;
        public CustRepository()
        {
            db = new DbContext();
        }
        public int Delete(int id)
        {
            string cmd = "delete from Cust where id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);
            return db.Execute(cmd, parameters);

        }

        public IEnumerable<Cust> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cust GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Cust item)
        {
            string cmd = "Insert into Cust values (@FirstName, @LastName, @Mobile, @EmailId, @City, @State)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@FirsNname", item.FirstName);
            parameters.Add("@LastName", item.LastName);
            parameters.Add("@Mobile", item.Mobile);
            parameters.Add("@EmailId", item.EmailId);
            parameters.Add("@City", item.City);
            parameters.Add("@State", item.State);

            return db.Execute(cmd, parameters);
        }

        public int Update(Cust item)
        {
            string cmd = "update Cust set FirstName = @FirstName, LastName = @LastName, Mobile = @Mobile, EmailId = @EmailId, City = @City, State = @State where id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@FirsNname", item.FirstName);
            parameters.Add("@LastName", item.LastName);
            parameters.Add("@Mobile", item.Mobile);
            parameters.Add("@EmailId", item.EmailId);
            parameters.Add("@City", item.City);
            parameters.Add("@State", item.State);

            return db.Execute(cmd, parameters);
        }
    }
}
