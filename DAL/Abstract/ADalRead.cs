using Entity;
using System.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstract;
using DAL.Concrete;
using DAL;
using DAL.Abstract;

namespace DAL.Abstract
{
    public abstract class ADalRead<TEntity> : IDalRead<TEntity> where TEntity : IEntity //, new()
    {
        protected const string QUERY_NOT_FOUND = "Query not found {0}";
        public const string EMPTY_DATA_READER = "Empty DataReader by Query {0}";
        protected const string DATABASE_READING_ERROR = "Database Reading Error";
        //
        protected IDictionary<ESqlQueries, string> sqlQueries;

        public ADalRead()
        {
            sqlQueries = new Dictionary<ESqlQueries, string>();
            InitReadQueries();
        }

        private void InitReadQueries()
        {
            sqlQueries.Add(ESqlQueries.GET_BY_ID, "SELECT * FROM " + GetTableName() + " WHERE id = {0};"); // ...+ nameof(TEntity) +... // if table name correspond class name
            sqlQueries.Add(ESqlQueries.GET_BY_LOGIN, "SELECT * FROM " + GetTableName() + " WHERE login = '{0}';");
            sqlQueries.Add(ESqlQueries.GET_BY_NAME, "SELECT * FROM " + GetTableName() + " WHERE name = '{0}';");
            sqlQueries.Add(ESqlQueries.GET_BY_FIELD, "SELECT * FROM " + GetTableName() + " WHERE {0} = '{1}';");
            sqlQueries.Add(ESqlQueries.GET_ALL, "SELECT * FROM " + GetTableName() + ";");
        }

        protected abstract string GetTableName();

        protected abstract TEntity CreateInstance(ICollection<string> args);

        // Read
        private IList<TEntity> GetQueryResult(string query, ESqlQueries sqlQueries)
        {
            IList<TEntity> all = new List<TEntity>();
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            IList<string> queryResult;
            //
            if (query == null)
            {
                // TODO Develop Custom Exception
                throw new Exception(string.Format(QUERY_NOT_FOUND, Enum.GetName(typeof(ESqlQueries), sqlQueries)));
            }
            try
            {
                connection = ConnectionManager.Get().GetConnection();
                command = new SqlCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    queryResult = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        queryResult.Add(reader[i].ToString());
                    }
                    all.Add(CreateInstance(queryResult));
                }

            }
            catch (Exception e)
            {
                // TODO DEvelop Custom Exception
                throw new Exception(DATABASE_READING_ERROR, e);
            }
            finally
            {
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Open))
                {
                    connection.Close();
                }
            }
            if (all.Count == 0)
            {
                throw new Exception(string.Format(EMPTY_DATA_READER, query));
            }
            return all;
        }

        public TEntity GetById(int id)
        {
            //return new TEntity();
            return GetQueryResult(string.Format(
                sqlQueries[ESqlQueries.GET_BY_ID], id.ToString()),
                ESqlQueries.GET_BY_ID).First();
        }

        public TEntity GetByLogin(string login)
        {
            return GetQueryResult(string.Format(
                sqlQueries[ESqlQueries.GET_BY_LOGIN], login),
                ESqlQueries.GET_BY_LOGIN).First();
        }

        public TEntity GetByName(string name)
        {
            return GetQueryResult(string.Format(
                sqlQueries[ESqlQueries.GET_BY_NAME], name),
                ESqlQueries.GET_BY_NAME).First();
        }

        public IList<TEntity> GetByFieldName(string fieldName, string text)
        {
            return GetQueryResult(string.Format(
                sqlQueries[ESqlQueries.GET_BY_FIELD], fieldName, text),
                ESqlQueries.GET_BY_FIELD);
        }

        public IList<TEntity> GetAll()
        {
            return GetQueryResult(
                sqlQueries[ESqlQueries.GET_ALL],
                ESqlQueries.GET_ALL);
        }
    }
}
