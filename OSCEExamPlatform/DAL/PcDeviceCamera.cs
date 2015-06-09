using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tellyes.DBUtility;
using System.Data.SqlClient;
using NHibernate;
using Tellyes.NHibernate;

namespace Tellyes.DAL
{


        #region Basic method
  //Pc系统设备摄像头绑定关系表
		public partial class PcDeviceCamera :BaseDAL<Tellyes.Model.PcDeviceCamera>
	{
   		     
		public bool Exists(int PDC_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PcDeviceCamera");
			strSql.Append(" where ");
			                                       strSql.Append(" PDC_ID = @PDC_ID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@PDC_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = PDC_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Tellyes.Model.PcDeviceCamera model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PcDeviceCamera(");			
            strSql.Append("Pc_String3,Pc_String4,Pc_String5,SD_ID,Camera_ID,Pc_Number1,Pc_Number2,Pc_Number3,Pc_Number4,Pc_String1,Pc_String2");
			strSql.Append(") values (");
            strSql.Append("@Pc_String3,@Pc_String4,@Pc_String5,@SD_ID,@Camera_ID,@Pc_Number1,@Pc_Number2,@Pc_Number3,@Pc_Number4,@Pc_String1,@Pc_String2");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@Pc_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@Pc_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@Pc_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@SD_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Camera_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@Pc_String2", SqlDbType.VarChar,500)             
              
            };
			            
            parameters[0].Value = model.Pc_String3;                        
            parameters[1].Value = model.Pc_String4;                        
            parameters[2].Value = model.Pc_String5;                        
            parameters[3].Value = Guid.NewGuid();                        
            parameters[4].Value = model.Camera_ID;                        
            parameters[5].Value = model.Pc_Number1;                        
            parameters[6].Value = model.Pc_Number2;                        
            parameters[7].Value = model.Pc_Number3;                        
            parameters[8].Value = model.Pc_Number4;                        
            parameters[9].Value = model.Pc_String1;                        
            parameters[10].Value = model.Pc_String2;                        
			   
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);			
			if (obj == null)
			{
				return 0;
			}
			else
			{
				                    
            	return Convert.ToInt32(obj);
                                                                  
			}			   
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tellyes.Model.PcDeviceCamera model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PcDeviceCamera set ");
			                                                
            strSql.Append(" Pc_String3 = @Pc_String3 , ");                                    
            strSql.Append(" Pc_String4 = @Pc_String4 , ");                                    
            strSql.Append(" Pc_String5 = @Pc_String5 , ");                                    
            strSql.Append(" SD_ID = @SD_ID , ");                                    
            strSql.Append(" Camera_ID = @Camera_ID , ");                                    
            strSql.Append(" Pc_Number1 = @Pc_Number1 , ");                                    
            strSql.Append(" Pc_Number2 = @Pc_Number2 , ");                                    
            strSql.Append(" Pc_Number3 = @Pc_Number3 , ");                                    
            strSql.Append(" Pc_Number4 = @Pc_Number4 , ");                                    
            strSql.Append(" Pc_String1 = @Pc_String1 , ");                                    
            strSql.Append(" Pc_String2 = @Pc_String2  ");            			
			strSql.Append(" where PDC_ID=@PDC_ID ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@PDC_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_String3", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@Pc_String4", SqlDbType.VarChar,2000) ,            
                        new SqlParameter("@Pc_String5", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@SD_ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Camera_ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_Number1", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_Number2", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_Number3", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_Number4", SqlDbType.Int,4) ,            
                        new SqlParameter("@Pc_String1", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@Pc_String2", SqlDbType.VarChar,500)             
              
            };
						            
            parameters[0].Value = model.PDC_ID;                        
            parameters[1].Value = model.Pc_String3;                        
            parameters[2].Value = model.Pc_String4;                        
            parameters[3].Value = model.Pc_String5;                        
            parameters[4].Value = model.SD_ID;                        
            parameters[5].Value = model.Camera_ID;                        
            parameters[6].Value = model.Pc_Number1;                        
            parameters[7].Value = model.Pc_Number2;                        
            parameters[8].Value = model.Pc_Number3;                        
            parameters[9].Value = model.Pc_Number4;                        
            parameters[10].Value = model.Pc_String1;                        
            parameters[11].Value = model.Pc_String2;                        
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int PDC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PcDeviceCamera ");
			strSql.Append(" where PDC_ID=@PDC_ID");
						SqlParameter[] parameters = {
					new SqlParameter("@PDC_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = PDC_ID;


			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string PDC_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PcDeviceCamera ");
			strSql.Append(" where ID in ("+PDC_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
				
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tellyes.Model.PcDeviceCamera GetModel(int PDC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PDC_ID, Pc_String3, Pc_String4, Pc_String5, SD_ID, Camera_ID, Pc_Number1, Pc_Number2, Pc_Number3, Pc_Number4, Pc_String1, Pc_String2  ");			
			strSql.Append("  from PcDeviceCamera ");
			strSql.Append(" where PDC_ID=@PDC_ID");
						SqlParameter[] parameters = {
					new SqlParameter("@PDC_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = PDC_ID;

			
			Tellyes.Model.PcDeviceCamera model=new Tellyes.Model.PcDeviceCamera();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["PDC_ID"].ToString()!="")
				{
					model.PDC_ID=int.Parse(ds.Tables[0].Rows[0]["PDC_ID"].ToString());
				}
																																				model.Pc_String3= ds.Tables[0].Rows[0]["Pc_String3"].ToString();
																																model.Pc_String4= ds.Tables[0].Rows[0]["Pc_String4"].ToString();
																																model.Pc_String5= ds.Tables[0].Rows[0]["Pc_String5"].ToString();
																																								if(ds.Tables[0].Rows[0]["SD_ID"].ToString()!="")
				{
					model.SD_ID= Guid.Parse(ds.Tables[0].Rows[0]["SD_ID"].ToString()) ;
				}
																				if(ds.Tables[0].Rows[0]["Camera_ID"].ToString()!="")
				{
					model.Camera_ID=int.Parse(ds.Tables[0].Rows[0]["Camera_ID"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["Pc_Number1"].ToString()!="")
				{
					model.Pc_Number1=int.Parse(ds.Tables[0].Rows[0]["Pc_Number1"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["Pc_Number2"].ToString()!="")
				{
					model.Pc_Number2=int.Parse(ds.Tables[0].Rows[0]["Pc_Number2"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["Pc_Number3"].ToString()!="")
				{
					model.Pc_Number3=int.Parse(ds.Tables[0].Rows[0]["Pc_Number3"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["Pc_Number4"].ToString()!="")
				{
					model.Pc_Number4=int.Parse(ds.Tables[0].Rows[0]["Pc_Number4"].ToString());
				}
																																				model.Pc_String1= ds.Tables[0].Rows[0]["Pc_String1"].ToString();
																																model.Pc_String2= ds.Tables[0].Rows[0]["Pc_String2"].ToString();
																										
				return model;
			}
			else
			{
				return null;
			}
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM PcDeviceCamera ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM PcDeviceCamera ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}   
	
        #endregion

        #region  ExtensionMethod
        protected override ICriteria _createConditionCriteria(ICriteria criteria, Dictionary<string, object> conditionDictionary)
        {
            
            return criteria;
        }
        #endregion  ExtensionMethod    
    }
}
