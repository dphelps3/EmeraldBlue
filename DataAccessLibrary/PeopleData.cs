using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _db;

        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "SELECT * FROM dbo.People";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"INSERT INTO dbo.People (FirstName, LastName, EmailAddress)
                           VALUES (@FirstName, @LastName, @EmailAddress);";

            return _db.SaveData(sql, person);
        }
    }
}
