﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using dbbase;

namespace SendPisResult.DAL
{
    public static class DbHelper
    {
        public static DataTable GetTable(string strSql)
        {
            dbbase.odbcdb aa = new odbcdb("DSN=pathnet;UID=pathnet;PWD=4s3c2a1p", "", "");
            DataSet ds = aa.GetDataSet(strSql.ToString(), "dt1");
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return new DataTable();
        }
    }
}
