using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    [TableRelationShipAtrribute]
    public class TempExamUser
    {
        #region Model

        /// <summary>
        /// 临时考试用户ID
        /// </summary>		
        private Guid _tempexamuserid;
        public virtual Guid TempExamUserID
        {
            get { return _tempexamuserid; }
            set { _tempexamuserid = value; }
        }
        /// <summary>
        /// 考试ID
        /// </summary>		
        private Guid _tempexamtableid;
        public virtual Guid TempExamTableID
        {
            get { return _tempexamtableid; }
            set { _tempexamtableid = value; }
        }
        /// <summary>
        /// 考站ID
        /// </summary>		
        private Guid? _tempexamstationid;
        public virtual Guid? TempExamStationID
        {
            get { return _tempexamstationid; }
            set { _tempexamstationid = value; }
        }
        /// <summary>
        /// 考试房间ID
        /// </summary>		
        private Guid _tempexamstationroomid;
        public virtual Guid TempExamStationRoomID
        {
            get { return _tempexamstationroomid; }
            set { _tempexamstationroomid = value; }
        }
        /// <summary>
        /// 房间ID
        /// </summary>		
        private int? _roomid;
        public virtual int? RoomID
        {
            get { return _roomid; }
            set { _roomid = value; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>		
        private int _userinfoid;
        public virtual int UserInfoID
        {
            get { return _userinfoid; }
            set { _userinfoid = value; }
        }
        /// <summary>
        /// 用户类型，1-督考官，2-后备评委，3-后备SP，4-现场评委，5-远程评委，6-SP，7-其他
        /// </summary>		
        private int _usertype;
        public virtual int UserType
        {
            get { return _usertype; }
            set { _usertype = value; }
        }
        /// <summary>
        /// 用户评分权重，百分比
        /// </summary>		
        private int? _userscorepercent;
        public virtual int? UserScorePercent
        {
            get { return _userscorepercent; }
            set { _userscorepercent = value; }
        }
        /// <summary>
        /// 用户绑定评分表数量
        /// </summary>		
        private int? _usermarksheetcount;
        public virtual int? UserMarkSheetCount
        {
            get { return _usermarksheetcount; }
            set { _usermarksheetcount = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamusernumber1;
        public virtual int? TempExamUserNumber1
        {
            get { return _tempexamusernumber1; }
            set { _tempexamusernumber1 = value; }
        }
        /// <summary>
        /// 预留字段，整型
        /// </summary>		
        private int? _tempexamusernumber2;
        public virtual int? TempExamUserNumber2
        {
            get { return _tempexamusernumber2; }
            set { _tempexamusernumber2 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamusernumber3;
        public virtual decimal? TempExamUserNumber3
        {
            get { return _tempexamusernumber3; }
            set { _tempexamusernumber3 = value; }
        }
        /// <summary>
        /// 预留字段，精确浮点型
        /// </summary>		
        private decimal? _tempexamusernumber4;
        public virtual decimal? TempExamUserNumber4
        {
            get { return _tempexamusernumber4; }
            set { _tempexamusernumber4 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度1000
        /// </summary>		
        private string _tempexamuserstring1;
        public virtual string TempExamUserString1
        {
            get { return _tempexamuserstring1; }
            set { _tempexamuserstring1 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2000
        /// </summary>		
        private string _tempexamuserstring2;
        public virtual string TempExamUserString2
        {
            get { return _tempexamuserstring2; }
            set { _tempexamuserstring2 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度4000
        /// </summary>		
        private string _tempexamuserstring3;
        public virtual string TempExamUserString3
        {
            get { return _tempexamuserstring3; }
            set { _tempexamuserstring3 = value; }
        }
        /// <summary>
        /// 预留字段，字符串，长度2^31-1字节
        /// </summary>		
        private string _tempexamuserstring4;
        public virtual string TempExamUserString4
        {
            get { return _tempexamuserstring4; }
            set { _tempexamuserstring4 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamuserdatetime1;
        public virtual DateTime? TempExamUserDatetime1
        {
            get { return _tempexamuserdatetime1; }
            set { _tempexamuserdatetime1 = value; }
        }
        /// <summary>
        /// 预留字段，日期时间
        /// </summary>		
        private DateTime? _tempexamuserdatetime2;
        public virtual DateTime? TempExamUserDatetime2
        {
            get { return _tempexamuserdatetime2; }
            set { _tempexamuserdatetime2 = value; }
        }  

        #endregion

        #region Constructor

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TempExamUser()
            : this(default(Guid))
        { 
        
        }

        /// <summary>
        /// 仅使用Guid构造对象
        /// </summary>
        public TempExamUser(Guid tempExamUserID)
        {
            this.TempExamUserID = tempExamUserID;
        }

        #endregion

        #region ToJsonString

        /// <summary>
        /// 返回对象的闭合Json字符串
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }

        /// <summary>
        /// 根据参数返回对象的Json字符创
        /// </summary>
        /// <param name="close"></param>
        /// <returns></returns>
        public virtual string ToJsonString(bool close,List<Tellyes.Model.TempExamUserMarkSheet> tempExamUserMarkSheetList=null,List<Tellyes.Model.MarkSheet> markSheetList=null,Tellyes.Model.UserInfo userInfo=null,List<Tellyes.Model.Room> roomList=null)
        {
            StringBuilder result = new StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"TempExamUserID\":\"").Append(this.TempExamUserID).Append("\",")
                .Append("\"TempExamTableID\":\"").Append(this.TempExamTableID).Append("\",")
                .Append("\"TempExamStationID\":\"").Append(this.TempExamStationID == null ? "" : this.TempExamStationID.ToString()).Append("\",")
                .Append("\"TempExamStationRoomID\":\"").Append(this.TempExamStationRoomID).Append("\",")
                .Append("\"RoomID\":\"").Append(this.RoomID == null ? "" : this.RoomID.ToString()).Append("\",")
                .Append("\"UserInfoID\":\"").Append(this.UserInfoID).Append("\",")
                .Append("\"UserType\":\"").Append(this.UserType).Append("\",")
                .Append("\"UserScorePercent\":\"").Append(this.UserScorePercent == null ? "" : Convert.ToInt32(this.UserScorePercent).ToString()).Append("\",")
                .Append("\"UserMarkSheetCount\":\"").Append(this.UserMarkSheetCount == null ? "" : Convert.ToInt32(this.UserMarkSheetCount).ToString()).Append("\"");
                if (roomList != null)
                {
                    string roomName = roomList.Where(e => e.RoomID == this.RoomID).Select(e => e.RoomName).FirstOrDefault();
                    if (roomName != null)
                    {
                        result.Append(",\"RoomName\":\"" + Uri.EscapeDataString(roomName.Trim()) + "\"");
                    }
                    else
                    {
                        result.Append(",\"RoomName\":\"\"");
                    }
                }
                #region 评分表 名称 及 TempExamUserMarkSheetID
                if (this.UserType == 4 || this.UserType == 5 || this.UserType == 6)
                {
                    if (tempExamUserMarkSheetList != null && tempExamUserMarkSheetList.Count > 0 && markSheetList != null && markSheetList.Count > 0) 
                    {
                        Tellyes.Model.TempExamUserMarkSheet tempExamUserMarkSheet = tempExamUserMarkSheetList.Where(e => e.TempExamUserID == this.TempExamUserID).Select(e => e).FirstOrDefault();
                        if (tempExamUserMarkSheet != null)
                        {
                            result.Append(",\"TempExamUserMarkSheetID\":\"" + tempExamUserMarkSheet.TempExamUserMarkSheetID.ToString().Trim() + "\"");
                            MarkSheet m = markSheetList.Where(e => e.MS_ID == tempExamUserMarkSheet.MarkSheetID).FirstOrDefault();
                            if (m == null)
                            {
                                result.Append(",\"MS_Name\":\"\"");
                            }
                            else
                            {
                                result.Append(",\"MS_Name\":\"" +Uri.EscapeDataString(m.MS_Name.Trim()) + "\"");
                            }
                            result.Append(",\"MarkSheetID\":\"" + tempExamUserMarkSheet.MarkSheetID.ToString().Trim() + "\"");
                        }
                        else
                        {
                            result.Append(",\"TempExamUserMarkSheetID\":\"\"");
                            result.Append(",\"MS_Name\":\"\"");
                            result.Append(",\"MarkSheetID\":\"0\"");
                        }
                    }
                    if (userInfo != null)
                    {
                        result.Append(",\"U_ID\":\"" + userInfo.U_ID + "\"");
                        result.Append(",\"U_TrueName\":\"" + Uri.EscapeDataString( userInfo.U_TrueName )+ "\"");
                        result.Append(",\"U_Sex\":\"" + userInfo.U_Sex + "\"");
                        result.Append(",\"U_GoodField\":\""+Uri.EscapeDataString(userInfo.U_GoodField)+"\"");
                        result.Append(",\"U_Title\":\""+Uri.EscapeDataString(userInfo.U_Title)+"\"");
                        result.Append(",\"U_Phone\":\"" + userInfo.U_Phone + "\"");
                        result.Append(",\"U_Phone2\":\"" + userInfo.U_Phone2 + "\"");
                        result.Append(",\"U_Email\":\""+userInfo.U_Email+"\"");
                        result.Append(",\"U_Email2\":\""+userInfo.U_Email2+"\"");
                        result.Append(",\"U_Contont\":\""+Uri.EscapeDataString(userInfo.U_Contont)+"\"");
                    }
                }
                #endregion
                result.Append(close ? "}" : "").ToString();

            return result.ToString();
        }

        #endregion
    }

    public class TempExamUser_SingleExamMainPage 
    {
        public int U_ID { get; set; }
        public Guid TempExamUserID { get; set; }
        public string U_TrueName { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        public string U_Title { get; set; }
        public string U_GoodField { get; set; }
    }

    public enum ExamUserType
    { 
        Verifier=1,
        Back_Up_Jury=2,
        Back_Up_SP=3,
        Jury=4,
        Remote_Jury=5,
        SP=6,
        Other
    }
}
