using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// 评委查询自己相关考试的复合实体类
    /// </summary>
    /// 
    [Serializable]
    public class CompositedModelJudgeQuery
    {
        public Tellyes.Model.ExamTable examTable=new ExamTable();
        public Tellyes.Model.ExamUser examUser = new ExamUser();
    }

    [Serializable]
    public class CompositedModelStudentQuery
    {
        public Tellyes.Model.ExamTable examTable = new ExamTable();
        public Tellyes.Model.ExamStudent examStudent = new ExamStudent();
    }


    /// <summary>
    /// 教师查询考站信息实体类，多表联查复合实体类
    /// </summary>
    [Serializable]
    public class CompositedModelTeacherQueryExamStation
    {

        private int _eId;
        private int _esId;
        private int _roomId;
        private int _deviceId;
        private string _examStationClass;
        private string _esName;
        private string _subject;
        private string _roomName;
        private string _deviceName;
        

        /// <summary>
        /// 考试ID
        /// </summary>
        public int E_ID
        {
            set { _eId = value; }
            get { return _eId; }
        }
        /// <summary>
        /// 考站ID
        /// </summary>
        public int EsId
        {
            set { _esId = value; }
            get { return _esId; }
        }
        /// <summary>
        /// 房间ID
        /// </summary>
        public int RoomId
        {
            set { _roomId = value; }
            get { return _roomId; }
        }
        /// <summary>
        /// 设备ID
        /// </summary>
        public int DeviceId
        {
            set { _deviceId = value; }
            get { return _deviceId; }
        }

        /// <summary>
        /// 考站类型
        /// </summary>
        public string ExamStationClass
        {
            set { _examStationClass = value; }
            get { return _examStationClass; }
        }
        /// <summary>
        /// 考站名称
        /// </summary>
        public string EsName
        {
            set { _esName = value; }
            get { return _esName; }
        }

        /// <summary>
        /// 考站科目
        /// </summary>
        public string Subject
        {
            set {  _subject = value; }
            get { return  _subject; }     
        }

        /// <summary>
        /// 房间名称
        /// </summary>
        public string RoomName
        {
            set { _roomName = value; }
            get { return _roomName; }
        }

        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName
        {
            set { _deviceName = value; }
            get { return _deviceName; }
        }      
    }


    /// <summary>
    /// 教师查询考站信息实体类，多表联查复合实体类
    /// </summary>
    [Serializable]
    public class CompositedModelTeacherQueryExamStationUser
    {

        private int _eId;
        private int _esId;
        private int _esrId;
        private int _roomId;
        private int _euId;
        private int _uId;
        private int _is_sp;
        private int _is_judge;
        private string _userName;

        /// <summary>
        /// 考试ID
        /// </summary>
        public int E_ID
        {
            set { _eId = value; }
            get { return _eId; }
        }
        /// <summary>
        /// 考站ID
        /// </summary>
        public int EsId
        {
            set { _esId = value; }
            get { return _esId; }
        }
        /// <summary>
        /// 房间ID
        /// </summary>
        public int RoomId
        {
            set { _roomId = value; }
            get { return _roomId; }
        }
        /// <summary>
        /// ExamStation_Room表中的主键 ESR_ID
        /// </summary>
        public int EsrId
        {
            set { _esrId = value; }
            get { return _esrId; }
        }
        /// <summary>
        /// ExamUser表中的主键 EU_ID
        /// </summary>
        public int EuserId
        {
            set { _euId = value; }
            get { return _euId; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId
        {
            set { _uId = value; }
            get { return _uId; }
        }
        /// <summary>
        /// 是否是SP（0：非SP，1：是SP）
        /// </summary>
        public int IsSp
        {
            set { _is_sp = value; }
            get { return _is_sp; }
        }
        /// <summary>
        /// 是否是评委（0：非评委，1：客观评委，2:现场评委，3：远程评委）
        /// </summary>
        public int IsJudgement
        {
            set { _is_sp = value; }
            get { return _is_sp; }
        }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string UserName
        {
            set { _userName = value; }
            get { return _userName; }
        }       
    }

}
