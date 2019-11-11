using ATMR.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMR
{
    public class Common
    {
        public string GetNextCode(string tableName)
        {
            try
            {
                using (var context = new SOSTechATMREntities())
                {
                    return context.Database.SqlQuery<string>("exec SP_GetMaxCodeByTableName @TableName", new SqlParameter("TableName", tableName)).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                //new Logger().LogError(ex);
                return null;
            }
        }

    }

    public class CustomSelectList
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public string Details { get; set; }
    }
}
