using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Collections;

/// <summary>
/// 数据库操作类
/// </summary>
public class DBOP
{
    #region 私有变量
    private Database db;
    private DbProviderFactory dbpf = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["UCDB"].ProviderName.ToString());
    private DbTransaction dbTrans;
    private DbConnection dbConn;
    private bool inTrans = false;
    #endregion

    #region 构造函数
    public DBOP()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
    }
    #endregion

    #region 私有方法
    private void OpenDB()
    {
        if (!inTrans) db = DatabaseFactory.CreateDatabase("UCDB");
    }

    private void SetCmdParams(DbCommand dbc, DbParameter[] dbParams)
    {
        if (db != null)
        {
            for (int i = 0; i < dbParams.Length; i++)
            {
                db.AddInParameter(dbc, dbParams[i].ParameterName, dbParams[i].DbType, dbParams[i].Value);
            }
        }
    }
    #endregion

    #region Return Parameter
    public DbParameter SetParam(string ParamName, DbType dbType, object Value)
    {
        //db = DatabaseFactory.CreateDatabase("AK56");
        DbParameter dbp = dbpf.CreateParameter();
        
        dbp.ParameterName = ParamName;
        dbp.Direction = ParameterDirection.Input;
        dbp.DbType = dbType;
        if (Value == null)
        {
            dbp.Value = DBNull.Value;
        }
        else
        {
            dbp.Value = Value;
        }
        return dbp;
    }
    #endregion

    #region Return DataSet
    /// <summary>
    /// 根据SQL语句返回DataSet
    /// </summary>
    /// <param name="sqlCmd">SQL语句</param>
    /// <returns>数据集</returns>
    public DataSet GetDataSet(string sqlCmd)
    {
        OpenDB();
        DataSet ds = null;
        DbCommand dbCommand = db.GetSqlStringCommand(sqlCmd);
        ds = this.ExecuteDataSet(dbCommand);
        return ds;
    }
    
    /// <summary>
    /// 根据SQL语句和参数数组返回DataSet
    /// </summary>
    /// <param name="sqlCmd">带参数的SQL语句</param>
    /// <param name="dbParams">参数数组</param>
    /// <returns>数据集</returns>
    public DataSet GetDataSetWithParams(string sqlCmd, DbParameter[] dbParams)
    {
        OpenDB();
        DataSet ds = null;
        DbCommand dbCommand = db.GetSqlStringCommand(sqlCmd);
        SetCmdParams(dbCommand, dbParams);
        ds = this.ExecuteDataSet(dbCommand);
        return ds;
    }

    /// <summary>
    /// 根据存储过程名字返回DataSet
    /// </summary>
    /// <param name="spName">存储过程名字</param>
    /// <returns>数据集</returns>
    public DataSet GetDataSetFromSP(string spName)
    {
        OpenDB();
        DataSet ds = null;
        DbCommand dbCommand = db.GetStoredProcCommand(spName);
        ds =  this.ExecuteDataSet(dbCommand);
        return ds;
    }

    /// <summary>
    /// 根据带参数的存储过程返回数据集
    /// </summary>
    /// <param name="spName">存储过程名字</param>
    /// <param name="dbParams">存储过程参数数组</param>
    /// <returns></returns>
    public DataSet GetDataSetFromSPWithParams(string spName, DbParameter[] dbParams)
    {
        OpenDB();
        DataSet ds = null;
        DbCommand dbCommand = db.GetStoredProcCommand(spName, dbParams);
        ds = this.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region Return Single Value
    /// <summary>
    /// 根据SQL语句返回单一值
    /// </summary>
    /// <param name="sqlCmd">SQL语句</param>
    /// <returns>Object</returns>
    public object GetSingleValue(string sqlCmd)
    {
        OpenDB();
        DbCommand dbc = db.GetSqlStringCommand(sqlCmd);
        return this.ExecuteScalar(dbc);
    }

    /// <summary>
    /// 根据带参数的SQL语句返回单一值
    /// </summary>
    /// <param name="sqlCmd">SQL语句</param>
    /// <param name="dbParams">对应的参数数组</param>
    /// <returns>Object</returns>
    public object GetSingleValueWithParams(string sqlCmd, DbParameter[] dbParams)
    {
        OpenDB();
        DbCommand dbc = db.GetSqlStringCommand(sqlCmd);
        SetCmdParams(dbc, dbParams);
        return this.ExecuteScalar(dbc);
    }
    
    /// <summary>
    /// 根据存储过程名字返回单一值
    /// </summary>
    /// <param name="spName">存储过程名字</param>
    /// <returns>Object</returns>
    public object GetSingleValueFromSP(string spName)
    {
        OpenDB();
        DbCommand dbc = db.GetStoredProcCommand(spName);
        return this.ExecuteScalar(dbc);
    }
    
    /// <summary>
    /// 根据带参数的存储过程名字返回单一值
    /// </summary>
    /// <param name="spName">存储过程名字</param>
    /// <param name="dbParams">对应的参数数组</param>
    /// <returns>Object</returns>
    public object GetSingleValueFromSPWithParams(string spName, DbParameter[] dbParams)
    {
        OpenDB();
        DbCommand dbc = db.GetStoredProcCommand(spName, dbParams);
        return this.ExecuteScalar(dbc);
    }
    #endregion

    #region ExecNonQuery
    /// <summary>
    /// 执行SQL语句
    /// </summary>
    /// <param name="sqlCmd">SQL语句</param>
    /// <returns>影响的行数</returns>
    public int ExecNonQuery(string sqlCmd)
    {
        OpenDB();

        DbCommand dbCommand = db.GetSqlStringCommand(sqlCmd);
        return this.ExecuteNonQuery(dbCommand);
    }

    /// <summary>
    /// 执行带参数的SQL语句
    /// </summary>
    /// <param name="sqlCmd">SQL语句</param>
    /// <param name="dbParams">对应的参数数组</param>
    /// <returns>影响的行数</returns>
    public int ExecNonQueryWithParams(string sqlCmd, DbParameter[] dbParams)
    {
        OpenDB();
        
        DbCommand dbCommand = db.GetSqlStringCommand(sqlCmd);
        SetCmdParams(dbCommand, dbParams);
        return this.ExecuteNonQuery(dbCommand);
    }

    /// <summary>
    /// 执行存储过程
    /// </summary>
    /// <param name="spName">存储过程名称</param>
    /// <returns>影响的行数</returns>
    public int ExecNonQueryWithFromSP(string spName)
    {
        OpenDB();

        DbCommand dbCommand = db.GetStoredProcCommand(spName);
        return this.ExecuteNonQuery(dbCommand);
    }

    /// <summary>
    /// 执行带参数的存储过程
    /// </summary>
    /// <param name="spName">存储过程名称</param>
    /// <param name="dbParams">参数数组</param>
    /// <returns>影响的行数</returns>
    public int ExecNonQueryWithFromSP(string spName, DbParameter[] dbParams)
    {
        OpenDB();

        DbCommand dbCommand = db.GetStoredProcCommand(spName, dbParams);
        return this.ExecuteNonQuery(dbCommand);
    }
    #endregion

    #region Return DataReader
    //When call following four functions, class will return an IDataReader
    //Caller need to call method CloseDataReader() to close the reader right after using the datareader
    //Or caller can use "using (IDataReader dr = dbop.GetDataReader("Select * from Z_Test")) {} without closing the datareader
    public IDataReader GetDataReader(string sqlCmd)
    {
        OpenDB();
        DbCommand dbCommand = db.GetSqlStringCommand(sqlCmd);
        return this.ExecuteReader(dbCommand);
                        
    }


    public IDataReader GetDataReaderWithParams(string sqlCmd, DbParameter[] dbParams)
    {
        OpenDB();
        DbCommand dbCommand = db.GetSqlStringCommand(sqlCmd);
        SetCmdParams(dbCommand, dbParams);
        return this.ExecuteReader(dbCommand);
    }


    public IDataReader GetDataReaderFromSP(string spName)
    {
        DbCommand dbCommand = db.GetStoredProcCommand(spName);
        return this.ExecuteReader(dbCommand);
    }


    public IDataReader GetDataReaderFromSPWithParams(string spName,DbParameter[] dbParams)
    {
        DbCommand dbCommand = db.GetStoredProcCommand(spName, dbParams);
        return this.ExecuteReader(dbCommand);
    }


    public void CloseDataReader(IDataReader dr)
    {
        if (!dr.IsClosed)
        {
            dr.Close();
        }
    }
    #endregion

    #region Execute Multi SQL command
    /// Execute Multi SQL command;
    /// 
    /// Parameter Hashtable is the SQL commands（<key>: SQL command; <value>: command's DbParameter[]）
    public Boolean ExecuteSqlTran(SortedList SQLStringList)
    {
        OpenDB();
        Boolean ifSucc = false;
        int lastNumber = -1;
        using (DbConnection dbconn = db.CreateConnection())
        {
            dbconn.Open();
            DbTransaction dbtran = dbconn.BeginTransaction();
            try
            {
                for (int i = 0; i < SQLStringList.Count; i++)
                {
                    string strsql = SQLStringList.GetKey(i).ToString().Trim();

                    if (strsql.Trim().Length > 1)
                    {
                        DbCommand dbCommand = db.GetSqlStringCommand(strsql);
                        object valuei = SQLStringList.GetByIndex(i);
                        if (valuei != null)
                        {
                            DbParameter[] cmdParms = (DbParameter[])valuei;
                            SetCmdParams(dbCommand, cmdParms);
                        }
                        db.ExecuteNonQuery(dbCommand, dbtran);
                    }
                }
                dbtran.Commit();
                ifSucc = true;
            }
            catch
            {
                dbtran.Rollback();
                ifSucc = false;
            }
            finally
            {
                dbconn.Close();
            }
        }
        return ifSucc;
    }
    #endregion 

    #region 事务处理
    /// <summary>
    /// 开始一个事务，在一个实例中只能有一个事务出现
    /// </summary>
    /// <returns>成功与否</returns>
    public bool BeginTrans()
    {
        if (inTrans) return false;
        try
        {
            OpenDB();
            dbConn = db.CreateConnection();
            dbConn.Open();
            dbTrans = dbConn.BeginTransaction();
            inTrans = true;
            return true;
        }
        catch
        {
            return false;
        }
    }
    /// <summary>
    /// 提交当前事务
    /// </summary>
    /// <returns>成功与否</returns>
    public bool CommitTrans()
    {
        if (!inTrans) return false;
        try
        {
            dbTrans.Commit();
            inTrans = false;
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            dbConn.Close();
        }
    }

    /// <summary>
    /// 回滚当前事务
    /// </summary>
    /// <returns>成功与否</returns>
    public bool RollbackTrans()
    {
        if (!inTrans) return false;
        try
        {
            dbTrans.Rollback();
            inTrans = false;
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            dbConn.Close();
        }
    }
    #endregion

    #region 包括事务处理的内部私有方法
    private DataSet ExecuteDataSet(DbCommand dbCommand)
    {
        if (inTrans)
        {
            return db.ExecuteDataSet(dbCommand, dbTrans);
        }
        else
        {
            return db.ExecuteDataSet(dbCommand);
        }
    }
    
    private object ExecuteScalar(DbCommand dbCommand)
    {
        object obj;

        if (inTrans)
        {
            obj = db.ExecuteScalar(dbCommand, dbTrans);
        }
        else
        {
            obj = db.ExecuteScalar(dbCommand);
        }
        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
        {
            return null;
        }
        else
        {
            return obj;
        }
    }

    private int ExecuteNonQuery(DbCommand dbCommand)
    {
        if (inTrans)
        {
            return db.ExecuteNonQuery(dbCommand, dbTrans);
        }
        else
        {
            return db.ExecuteNonQuery(dbCommand);
        }
    }

    private IDataReader ExecuteReader( DbCommand dbCommand )
    {
        IDataReader dr = null;
        try
        {
            if (inTrans)
            {
                dr = db.ExecuteReader(dbCommand, dbTrans);
            }
            else
            {
                dr = db.ExecuteReader(dbCommand);
            }
        }
        catch
        {
            dr.Close();
            throw;
        }
        return dr;
    }

     #endregion

    #region ***特定操作***
    public Boolean CheckUnique(string sTable, string sPKCol, string sCol, string sValue, Boolean ifNew, int iSeq)
    {
        string sCount;
        DbParameter[] param = {
                                    SetParam("@" + sCol, DbType.String, sValue)
                                };
        if (ifNew)
        {
            sCount = GetSingleValueWithParams("Select Count(" + sCol + ") from " + sTable + " Where " + sCol + "=@" + sCol, param).ToString();
        }
        else
        {
            sCount = GetSingleValueWithParams("Select Count(" + sCol + ") from " + sTable + " Where " + sCol + "=@" + sCol + " and " + sPKCol + "<>" + iSeq.ToString(), param).ToString();
        }

        if (sCount == "0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion

    #region 扩充的DBOP功能
    /// <summary>
    /// 利用格式化的SQL语句返回DataSet
    /// </summary>
    /// <param name="formatSql">格式化的Sql语句</param>
    /// <param name="paramValues">各参数的值(个数应该和SQL语句中的参数对应)</param>
    /// <returns>DataSet</returns>
    public DataSet GetDataSetWithParams(string formatSql, params Object[] paramValues)
    {
        if ((paramValues != null) && (paramValues.Length > 0))
        {
            SqlFormatter formatter = new SqlFormatter();
            formatter.Format(formatSql, paramValues);
            return GetDataSetWithParams(formatter.Sql, formatter.Parameters);
        }
        return GetDataSet(formatSql);

    }

    /// <summary>
    /// 利用格式化的SQL语句返回单个值
    /// </summary>
    /// <param name="formatSql">格式化的Sql语句</param>
    /// <param name="paramValues">各参数的值(个数应该和SQL语句中的参数对应)</param>
    /// <returns>Object</returns>
    public object GetSingleValueWithParams(string formatSql, params Object[] paramValues)
    {
        if ((paramValues != null) && (paramValues.Length > 0))
        {
            SqlFormatter formatter = new SqlFormatter();
            formatter.Format(formatSql, paramValues);
            return GetSingleValueWithParams(formatter.Sql, formatter.Parameters);
        }
        return GetSingleValueWithParams(formatSql);
    }

    /// <summary>
    /// 执行格式化的SQL语句
    /// </summary>
    /// <param name="formatSql">格式化的Sql语句</param>
    /// <param name="paramValues">各参数的值(个数应该和SQL语句中的参数对应)</param>
    /// <returns>影响的行数</returns>
    public int ExecNonQueryWithParams(string formatSql, params Object[] paramValues)
    {
        if ((paramValues != null) && (paramValues.Length > 0))
        {
            SqlFormatter formatter = new SqlFormatter();
            formatter.Format(formatSql, paramValues);
            return ExecNonQueryWithParams(formatter.Sql, formatter.Parameters);
        }
        return ExecNonQueryWithParams(formatSql);
    }

    /// <summary>
    /// 利用格式化的SQL语句返回DataReader
    /// </summary>
    /// <param name="formatSql">格式化的Sql语句</param>
    /// <param name="paramValues">各参数的值(个数应该和SQL语句中的参数对应)</param>
    /// <returns>IDataReader</returns>
    public IDataReader GetDataReaderWithParams(string formatSql, params Object[] paramValues)
    {
        if ((paramValues != null) && (paramValues.Length > 0))
        {
            SqlFormatter formatter = new SqlFormatter();
            formatter.Format(formatSql, paramValues);
            return GetDataReaderWithParams(formatter.Sql, formatter.Parameters);
        }
        return GetDataReaderWithParams(formatSql);
    }

    #endregion
}
