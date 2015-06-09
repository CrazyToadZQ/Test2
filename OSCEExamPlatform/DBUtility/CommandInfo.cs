using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Tellyes.DBUtility
{
    public enum EffentNextType
    {
        /// <summary>
        /// 对其他语句无任何影响 
        /// </summary>
        None,
        /// <summary>
        /// 当前语句必须为"select count(1) from .."格式，如果存在则继续执行，不存在回滚事务
        /// </summary>
        WhenHaveContine,
        /// <summary>
        /// 当前语句必须为"select count(1) from .."格式，如果不存在则继续执行，存在回滚事务
        /// </summary>
        WhenNoHaveContine,
        /// <summary>
        /// 当前语句影响到的行数必须大于0，否则回滚事务
        /// </summary>
        ExcuteEffectRows,
        /// <summary>
        /// 执行SQL语句，此句为第一句并且为添加的T-SQL，执行完毕后，需要将此句的Identity取出，写入以后的语句中，为其所用。
        /// </summary>
        WhenHaveContinueAndUse,
        /// <summary>
        /// 执行SQL语句，此句需要前面的语句所取出的Identity，写入此句当中，并为自己补全语句。再进行操作
        /// </summary>
        WhenHaveContinueToUse,
        /// <summary>
        /// 引发事件-当前语句必须为"select count(1) from .."格式，如果不存在则继续执行，存在回滚事务
        /// </summary>
        SolicitationEvent,
        /// <summary>
        /// 执行SQL语句，此句需要取出Identity，并写入对象2中，以便其他语句引用
        /// </summary>
        WhenHaveContinueAndUse2,
        /// <summary>
        /// 此对象需要用到其他的ID，而本身又产生Identity给其他的对象使用
        /// </summary>
        WhenHaveContinueToUseAndUse
        
    }   
    public class CommandInfo
    {
        public object ShareObject = null;
        public object OriginalData = null;
        event EventHandler _solicitationEvent;
        public event EventHandler SolicitationEvent
        {
            add
            {
                _solicitationEvent += value;
            }
            remove
            {
                _solicitationEvent -= value;
            }
        }
        public void OnSolicitationEvent()
        {
            if (_solicitationEvent != null)
            {
                _solicitationEvent(this,new EventArgs());
            }
        }
        public string CommandText;
        public System.Data.Common.DbParameter[] Parameters;
        public EffentNextType EffentNextType = EffentNextType.None;
        public CommandInfo()
        {

        }
        public CommandInfo(string sqlText, SqlParameter[] para)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
        }
        public CommandInfo(string sqlText, SqlParameter[] para, EffentNextType type)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
            this.EffentNextType = type;
        }
    }
}
