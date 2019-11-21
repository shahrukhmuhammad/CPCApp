using CPC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPC
{
    public class Common
    {
        public string GetNextCode(string tableName)
        {
            try
            {
                using (var context = new SOSTechCPCEntities())
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

        //public List<CPCDenomination> GetAllDenominationDropdown()
        //{
        //    try
        //    {
        //        using (var context = new SOSTechCPCEntities())
        //        {
        //            return context.CPCDenominations.OrderBy(x => x.Id).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<CustomSelectList> GetAllDenominationDropdown()
        {
            try
            {
                using (var context = new SOSTechCPCEntities())
                {
                    var ls = context.CPCDenominations.OrderBy(x=> x.DenominationTitle).ToList();
                    return ls.Select(x => new CustomSelectList { Value = x.Id.ToString(), Text = x.DenominationTitle.ToString() }).ToList();
                }
            }
            catch (Exception ex)
            {
                //throw ex;
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

    public enum AnnexureStatus {
        Inprocess = 1,
        Completed = 2
    }
}
