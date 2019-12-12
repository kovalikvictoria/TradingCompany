using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public enum ESqlQueries
    {
        INSERT,
        GET_BY_ID,
        GET_BY_LOGIN,
        GET_BY_NAME,
        GET_BY_FIELD,
        GET_ALL,
        UPDATE_BY_ID,
        UPDATE_BY_FIELD,
        DELETE_BY_ID,
        DELETE_BY_FIELD,
        DELETE
    }
}
