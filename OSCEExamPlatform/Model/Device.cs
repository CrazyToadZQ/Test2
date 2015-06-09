using System;
using System.Text;
namespace Tellyes.Model
{
	/// <summary>
	/// Device:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Device
	{
        public Device()
        { }
        #region Model
        private int _d_id;
        private string _d_serialnumber;
        private string _d_name;
        private int? _dc_id;
        private int? _dc_id1;
        private int? _dt_id;
        private string _d_model;
        private string _d_manufacturer;
        private string _d_manufacturernumber;
        private DateTime? _d_manufacturedate = Convert.ToDateTime("2012-12-12 12:00");
        private string _d_batch;
        private string _d_warrantyinfo;
        private string _d_remark;
        private DateTime _d_registerdate= DateTime.Now;
        private string _d_position;
        private int _d_iscanuse = 1;
        private string _d_state = "良好";
        private string _d_statedescription;
        private int _d_currusecount = 0;
        private int _d_examusecount = 0;
        private int _d_totalusecount = 0;
        private int _d_currusetime = 0;
        private int _d_examusetime = 0;
        private int _d_totalusetime = 0;
        private int _d_abnormalcount = 0;
        private int _d_repairedcount = 0;
        private byte[] _d_twodimensioncode;
        private byte[] _d_image;
        private string _d_skill;
        private string _d_scoreitems;
        private int? _d_int1;
        private int? _d_int2;
        private int? _d_int3;
        private int? _d_int4;
        private int? _d_int5;
        private string _d_string1;
        private string _d_string2;
        private string _d_string3;
        private string _d_string4;
        private string _d_string5;
        private string _d_string6;
        private string _d_string7;
        private string _d_string8;
        private string _d_string9;
        private string _d_string10;
        private DateTime? _d_datetime1;
        private DateTime? _d_datetime2;
        private DateTime? _d_datetime3;
        private DateTime? _d_datetime4;
        private DateTime? _d_datetime5;
        private string _d_qrcode;
        /// <summary>
        /// 设备ID
        /// </summary>
        public virtual int D_ID
        {
            set { _d_id = value; }
            get { return _d_id; }
        }
        /// <summary>
        /// 设备编号
        /// </summary>
        public virtual string D_SerialNumber
        {
            set { _d_serialnumber = value; }
            get { return _d_serialnumber; }
        }
        /// <summary>
        /// 设备名称
        /// </summary>
        public virtual string D_Name
        {
            set { _d_name = value; }
            get { return _d_name; }
        }
        /// <summary>
        /// 设备分类ID
        /// </summary>
        public virtual int? DC_ID
        {
            set { _dc_id = value; }
            get { return _dc_id; }
        }
        /// <summary>
        /// 设备分类ID1（预留）
        /// </summary>
        public virtual int? DC_ID1
        {
            set { _dc_id1 = value; }
            get { return _dc_id1; }
        }
        /// <summary>
        /// 设备类型ID（预留）
        /// </summary>
        public virtual int? DT_ID
        {
            set { _dt_id = value; }
            get { return _dt_id; }
        }
        /// <summary>
        /// 设备型号
        /// </summary>
        public virtual string D_Model
        {
            set { _d_model = value; }
            get { return _d_model; }
        }
        /// <summary>
        /// 制造商
        /// </summary>
        public virtual string D_Manufacturer
        {
            set { _d_manufacturer = value; }
            get { return _d_manufacturer; }
        }
        /// <summary>
        /// 出厂编号
        /// </summary>
        public virtual string D_ManufacturerNumber
        {
            set { _d_manufacturernumber = value; }
            get { return _d_manufacturernumber; }
        }
        /// <summary>
        /// 制造日期
        /// </summary>
        public virtual DateTime? D_ManufactureDate
        {
            set { _d_manufacturedate = value; }
            get { return _d_manufacturedate; }
        }
        /// <summary>
        /// 批次
        /// </summary>
        public virtual string D_Batch
        {
            set { _d_batch = value; }
            get { return _d_batch; }
        }
        /// <summary>
        /// 质保信息
        /// </summary>
        public virtual string D_WarrantyInfo
        {
            set { _d_warrantyinfo = value; }
            get { return _d_warrantyinfo; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string D_Remark
        {
            set { _d_remark = value; }
            get { return _d_remark; }
        }
        /// <summary>
        /// 登记日期
        /// </summary>
        public virtual DateTime D_RegisterDate
        {
            set { _d_registerdate = value; }
            get { return _d_registerdate; }
        }
        /// <summary>
        /// 设备所处位置
        /// </summary>
        public virtual string D_Position
        {
            set { _d_position = value; }
            get { return _d_position; }
        }
        /// <summary>
        /// 设备是否可用
        /// </summary>
        public virtual int D_IsCanUse
        {
            set { _d_iscanuse = value; }
            get { return _d_iscanuse; }
        }
        /// <summary>
        /// 设备状态（良好、异常、维修、外借、报废）
        /// </summary>
        public virtual string D_State
        {
            set { _d_state = value; }
            get { return _d_state; }
        }
        /// <summary>
        /// 状态描述（异常描述、维修情况、外借日期等）
        /// </summary>
        public virtual string D_StateDescription
        {
            set { _d_statedescription = value; }
            get { return _d_statedescription; }
        }
        /// <summary>
        /// 课程累计使用次数
        /// </summary>
        public virtual int D_CurrUseCount
        {
            set { _d_currusecount = value; }
            get { return _d_currusecount; }
        }
        /// <summary>
        /// 考试累计使用次数
        /// </summary>
        public virtual int D_ExamUseCount
        {
            set { _d_examusecount = value; }
            get { return _d_examusecount; }
        }
        /// <summary>
        /// 总累计使用次数
        /// </summary>
        public virtual int D_TotalUseCount
        {
            set { _d_totalusecount = value; }
            get { return _d_totalusecount; }
        }
        /// <summary>
        /// 课程累计使用时间（单位：秒）
        /// </summary>
        public virtual int D_CurrUseTime
        {
            set { _d_currusetime = value; }
            get { return _d_currusetime; }
        }
        /// <summary>
        /// 考试累计使用时间（单位：秒）
        /// </summary>
        public virtual int D_ExamUseTime
        {
            set { _d_examusetime = value; }
            get { return _d_examusetime; }
        }
        /// <summary>
        /// 总累计使用时间（单位：秒）
        /// </summary>
        public virtual int D_TotalUseTime
        {
            set { _d_totalusetime = value; }
            get { return _d_totalusetime; }
        }
        /// <summary>
        /// 设备异常次数
        /// </summary>
        public virtual int D_AbnormalCount
        {
            set { _d_abnormalcount = value; }
            get { return _d_abnormalcount; }
        }
        /// <summary>
        /// 设备维修次数
        /// </summary>
        public virtual int D_RepairedCount
        {
            set { _d_repairedcount = value; }
            get { return _d_repairedcount; }
        }


        /// <summary>
        /// 设备二维码
        /// </summary>
        public virtual byte[] D_TwoDimensionCode
        {
            set { _d_twodimensioncode = value; }
            get { return _d_twodimensioncode; }
        }

        /// <summary>
        /// 设备图片信息
        /// </summary>
        public virtual byte[] D_Image
        {
            set { _d_image = value; }
            get { return _d_image;  }
        }

        /// <summary>
        /// 设备技能表（SBS用）
        /// </summary>
        public virtual string D_Skill
        {
            set { _d_skill = value; }
            get { return _d_skill; }
        }
        /// <summary>
        /// 设备客观评分项（预留）
        /// </summary>
        public virtual string D_ScoreItems
        {
            set { _d_scoreitems = value; }
            get { return _d_scoreitems; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? D_int1
        {
            set { _d_int1 = value; }
            get { return _d_int1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? D_int2
        {
            set { _d_int2 = value; }
            get { return _d_int2; }
        }
        /// <summary>
        /// 总异常时长（单位：分钟）
        /// </summary>
        public virtual int? D_int3
        {
            set { _d_int3 = value; }
            get { return _d_int3; }
        }
        /// <summary>
        /// 逻辑删除列（0：此条记录还存在，1：此条记录已经删除）
        /// </summary>
        public virtual int? D_int4
        {
            set { _d_int4 = value; }
            get { return _d_int4; }
        }
        /// <summary>
        /// 总维修时长（单位：分钟）
        /// </summary>
        public virtual int? D_int5
        {
            set { _d_int5 = value; }
            get { return _d_int5; }
        }
        /// <summary>
        /// 设备图片存储路径(web根目录下的DeviceImage文件夹)
        /// </summary>
        public virtual string D_string1
        {
            set { _d_string1 = value; }
            get { return _d_string1; }
        }
        /// <summary>
        /// 设备总使用频率
        /// </summary>
        public virtual string D_string2
        {
            set { _d_string2 = value; }
            get { return _d_string2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string D_string3
        {
            set { _d_string3 = value; }
            get { return _d_string3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string D_string4
        {
            set { _d_string4 = value; }
            get { return _d_string4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string D_string5
        {
            set { _d_string5 = value; }
            get { return _d_string5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string D_string6
        {
            set { _d_string6 = value; }
            get { return _d_string6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string D_string7
        {
            set { _d_string7 = value; }
            get { return _d_string7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string D_string8
        {
            set { _d_string8 = value; }
            get { return _d_string8; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string D_string9
        {
            set { _d_string9 = value; }
            get { return _d_string9; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual string D_string10
        {
            set { _d_string10 = value; }
            get { return _d_string10; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? D_datetime1
        {
            set { _d_datetime1 = value; }
            get { return _d_datetime1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? D_datetime2
        {
            set { _d_datetime2 = value; }
            get { return _d_datetime2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? D_datetime3
        {
            set { _d_datetime3 = value; }
            get { return _d_datetime3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? D_datetime4
        {
            set { _d_datetime4 = value; }
            get { return _d_datetime4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? D_datetime5
        {
            set { _d_datetime5 = value; }
            get { return _d_datetime5; }
        }
        /// <summary>
        /// 设备二维码（SBS用）
        /// </summary>
        public virtual string D_QRCode
        {
            set { _d_qrcode = value; }
            get { return _d_qrcode; }
        }
        #endregion Model

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonString()
        {
            return this.ToJsonString(true);
        }


        /// <summary>
        /// 生成json结构
        /// </summary>
        /// <param name="close"></param>
        /// <returns></returns>
        public virtual string ToJsonString(bool close)
        {
            return new System.Text.StringBuilder(string.Empty)
                .Append(close ? "{" : "")
                .Append("\"D_ID\":\"").Append(Uri.EscapeDataString(this.D_ID.ToString())).Append("\",")
                .Append("\"D_SerialNumber\":\"").Append(Uri.EscapeDataString(this.D_SerialNumber.ToString())).Append("\",")
                .Append("\"D_Name\":\"").Append(Uri.EscapeDataString(this.D_Name == null ? "" : this.D_Name.ToString())).Append("\",")
                .Append("\"DC_ID\":\"").Append(Uri.EscapeDataString(this.DC_ID == null ? "" : this.DC_ID.ToString())).Append("\",")
                .Append("\"DC_ID1\":\"").Append(Uri.EscapeDataString(this.DC_ID1 == null ? "" : this.DC_ID1.ToString())).Append("\",")
                .Append("\"DT_ID\":\"").Append(Uri.EscapeDataString(this.DT_ID == null ? "" : this.DT_ID.ToString())).Append("\",")
                .Append("\"D_Model\":\"").Append(Uri.EscapeDataString(this.D_Model == null ? "" : this.D_Model.ToString())).Append("\",")
                .Append("\"D_Manufacturer\":\"").Append(Uri.EscapeDataString(this.D_Manufacturer == null ? "" : this.D_Manufacturer.ToString())).Append("\",")
                .Append("\"D_ManufacturerNumber\":\"").Append(Uri.EscapeDataString(this.D_ManufacturerNumber == null ? "" : this.D_ManufacturerNumber.ToString())).Append("\",")
                .Append("\"D_ManufactureDate\":\"").Append(Uri.EscapeDataString(this.D_ManufactureDate == null ? "" : Convert.ToDateTime(this.D_ManufactureDate).ToString("yyyy-MM-dd"))).Append("\",")
                .Append("\"D_Batch\":\"").Append(Uri.EscapeDataString(this.D_Batch == null ? "" : this.D_Batch.ToString())).Append("\",")
                .Append("\"D_WarrantyInfo\":\"").Append(Uri.EscapeDataString(this.D_WarrantyInfo == null ? "" : this.D_WarrantyInfo.ToString())).Append("\",")
                .Append("\"D_Remark\":\"").Append(Uri.EscapeDataString(this.D_Remark == null ? "" : this.D_Remark.ToString())).Append("\",")
                .Append("\"D_RegisterDate\":\"").Append(Uri.EscapeDataString(this.D_RegisterDate.ToString("yyyy-MM-dd"))).Append("\",")
                .Append("\"D_Position\":\"").Append(Uri.EscapeDataString(this.D_Position == null ? "" : this.D_Position.ToString())).Append("\",")
                .Append("\"D_IsCanUse\":\"").Append(Uri.EscapeDataString(this.D_IsCanUse.ToString())).Append("\",")
                .Append("\"D_State\":\"").Append(Uri.EscapeDataString(this.D_State.ToString())).Append("\",")
                .Append("\"D_StateDescription\":\"").Append(Uri.EscapeDataString(this.D_StateDescription == null ? "" : this.D_StateDescription.ToString())).Append("\",")
                .Append("\"D_CurrUseCount\":\"").Append(Uri.EscapeDataString(this.D_CurrUseCount.ToString())).Append("\",")
                .Append("\"D_ExamUseCount\":\"").Append(Uri.EscapeDataString(this.D_ExamUseCount.ToString())).Append("\",")
                .Append("\"D_TotalUseCount\":\"").Append(Uri.EscapeDataString(this.D_TotalUseCount.ToString())).Append("\",")
                .Append("\"D_CurrUseTime\":\"").Append(Uri.EscapeDataString(this.D_CurrUseTime.ToString())).Append("\",")
                .Append("\"D_ExamUseTime\":\"").Append(Uri.EscapeDataString(this.D_ExamUseTime.ToString())).Append("\",")
                .Append("\"D_TotalUseTime\":\"").Append(Uri.EscapeDataString(this.D_TotalUseTime.ToString())).Append("\",")
                .Append("\"D_AbnormalCount\":\"").Append(Uri.EscapeDataString(this.D_AbnormalCount.ToString())).Append("\",")
                .Append("\"D_RepairedCount\":\"").Append(Uri.EscapeDataString(this.D_RepairedCount.ToString())).Append("\",")
                //.Append("\"D_TwoDimensionCode\":\"").Append(Uri.EscapeDataString(this.D_TwoDimensionCode.ToString())).Append("\",")
                .Append("\"D_Skill\":\"").Append(Uri.EscapeDataString(this.D_Skill == null ? "" : this.D_Skill.ToString())).Append("\",")
                .Append("\"D_ScoreItems\":\"").Append(Uri.EscapeDataString(this.D_ScoreItems == null ? "" : this.D_ScoreItems.ToString())).Append("\",")
                .Append("\"D_int1\":\"").Append(Uri.EscapeDataString(this.D_int1 == null ? "" : this.D_int1.ToString())).Append("\",")
                .Append("\"D_int2\":\"").Append(Uri.EscapeDataString(this.D_int2 == null ? "" : this.D_int2.ToString())).Append("\",")
                .Append("\"D_int3\":\"").Append(Uri.EscapeDataString(this.D_int3 == null ? "" : this.D_int3.ToString())).Append("\",")
                .Append("\"D_int4\":\"").Append(Uri.EscapeDataString(this.D_int4 == null ? "" : this.D_int4.ToString())).Append("\",")
                .Append("\"D_int5\":\"").Append(Uri.EscapeDataString(this.D_int5 == null ? "" : this.D_int5.ToString())).Append("\",")
                .Append("\"D_string1\":\"").Append(Uri.EscapeDataString(this.D_string1 == null ? "" : this.D_string1.ToString())).Append("\",")
                .Append("\"D_string2\":\"").Append(Uri.EscapeDataString(this.D_string2 == null ? "" : this.D_string2.ToString())).Append("\",")
                .Append("\"D_string3\":\"").Append(Uri.EscapeDataString(this.D_string3 == null ? "" : this.D_string3.ToString())).Append("\",")
                .Append("\"D_string4\":\"").Append(Uri.EscapeDataString(this.D_string4 == null ? "" : this.D_string4.ToString())).Append("\",")
                .Append("\"D_string5\":\"").Append(Uri.EscapeDataString(this.D_string5 == null ? "" : this.D_string5.ToString())).Append("\",")
                .Append("\"D_string6\":\"").Append(Uri.EscapeDataString(this.D_string6 == null ? "" : this.D_string6.ToString())).Append("\",")
                .Append("\"D_string7\":\"").Append(Uri.EscapeDataString(this.D_string7 == null ? "" : this.D_string7.ToString())).Append("\",")
                .Append("\"D_string8\":\"").Append(Uri.EscapeDataString(this.D_string8 == null ? "" : this.D_string8.ToString())).Append("\",")
                .Append("\"D_string9\":\"").Append(Uri.EscapeDataString(this.D_string9 == null ? "" : this.D_string9.ToString())).Append("\",")
                .Append("\"D_string10\":\"").Append(Uri.EscapeDataString(this.D_string10 == null ? "" : this.D_string10.ToString())).Append("\",")
                .Append("\"D_datetime1\":\"").Append(Uri.EscapeDataString(this.D_datetime1 == null ? "" : Convert.ToDateTime(this.D_datetime1).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"D_datetime2\":\"").Append(Uri.EscapeDataString(this.D_datetime2 == null ? "" : Convert.ToDateTime(this.D_datetime2).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"D_datetime3\":\"").Append(Uri.EscapeDataString(this.D_datetime3 == null ? "" : Convert.ToDateTime(this.D_datetime3).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"D_datetime4\":\"").Append(Uri.EscapeDataString(this.D_datetime4 == null ? "" : Convert.ToDateTime(this.D_datetime4).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"D_datetime5\":\"").Append(Uri.EscapeDataString(this.D_datetime5 == null ? "" : Convert.ToDateTime(this.D_datetime5).ToString("yyyy-MM-dd HH:mm:ss"))).Append("\",")
                .Append("\"D_QRCode\":\"").Append(Uri.EscapeDataString(this.D_QRCode == null ? "" : this.D_QRCode.ToString())).Append("\"")
                .Append(close ? "}" : "")
                .ToString();
        }
   		


    }
}

