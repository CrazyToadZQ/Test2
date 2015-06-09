using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;
using System.Drawing;

namespace HikVision
{
    public delegate void fVoiceDataCallBack(int lVoiceComHandle, [MarshalAs(UnmanagedType.LPArray)]  byte[] pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser);

    public delegate void SerialDataCallBack(int lSerialHandle, [MarshalAs(UnmanagedType.LPArray)]  byte[] pRecvDataBuffer, uint dwBufSize, uint dwUser);

    public delegate void DrawFun(int lRealHandle, System.Drawing.Graphics hDc, uint dwUser);

    public delegate void RealDataCallBack(int lRealHandle, uint dwDataType, [MarshalAs(UnmanagedType.LPArray, SizeConst = 11520)] byte[] pBuffer, uint dwBufSize, uint dwUser);

    public delegate void PlayDataCallBack(int lPlayHandle, uint dwDataType, [MarshalAs(UnmanagedType.LPArray)]  byte[] pBuffer, uint dwBufSize, uint dwUser);



    public struct CCTVpara
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public string sUserName;//用户名称
        public string sPassword;//密码
        public string sDVRIP;//ip地址
        public ushort wDVRPort;//端口
        public int channel;//通道号
        public int chnRet;//返回的参数
    }

    public struct NET_DVR_DEVICEINFO
    {
        // [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]  

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public byte[] sSerialNumber;//[SERIALNO_LEN];  //序列号
        public byte byAlarmInPortNum;  //DVR报警输入个数
        public byte byAlarmOutPortNum;  //DVR报警输出个数
        public byte byDiskNum;    //DVR 硬盘个数
        public byte byDVRType;    //DVR类型, 
        public byte byChanNum;    //DVR 通道个数
        public byte byStartChan;   //起始通道号,例如DVS-1,DVR - 1
    }


    public struct NET_DVR_DISKSTATE
    {
        public uint dwVolume;//硬盘的容量
        public uint dwFreeSpace;//硬盘的剩余空间
        public uint dwHardDiskStatic; //硬盘的状态,休眠,活动,不正常等
    }


    public struct NET_DVR_TIME
    {
        public int dwYear;    /*   年 */
        public int dwMonth;   /*   月 */
        public int dwDay;    /*   日 */
        public int dwHour;   /*   时 */
        public int dwMinute;   /*   分 */
        public int dwSecond;   /*   秒 */
    }
    public struct NET_DVR_FIND_DATA
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string sFileName;    /*   文件名 */
        public NET_DVR_TIME struStartTime; /*   文件的开始时间 */
        public NET_DVR_TIME struStopTime; /*   文件的结束时间 */
        public int dwFileSize;    /*   文件的大小 */
    }


    public struct NET_DVR_CHANNELSTATE
    {
        public byte byRecordStatic; //通道是否在录像,0-不录像,1-录像
        public byte bySignalStatic; //连接的信号状态,0-正常,1-信号丢失
        public byte byHardwareStatic;//通道硬件状态,0-正常,1-异常,例如DSP死掉
        public char reservedData;
        public uint dwBitRate;//实际码率
        public uint dwLinkNum;//客户端连接的个数
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]  //MAX_LINK
        public uint[] dwClientIP;//客户端的IP地址
    }

    public struct NET_DVR_WORKSTATE
    {

        public uint dwDeviceStatic;  //设备的状态,0-正常,1-CPU占用率太高,超过85%,2-硬件错误,例如串口死掉

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public NET_DVR_DISKSTATE[] struHardDiskStatic; //MAX_DISKNUM

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public NET_DVR_CHANNELSTATE[] struChanStatic;//通道的状态MAX_CHANNUM

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] byAlarmInStatic; //报警端口的状态,0-没有报警,1-有报警MAX_ALARMIN

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] byAlarmOutStatic; //报警输出端口的状态,0-没有输出,1-有报警输出MAX_ALARMOUT
        public uint dwLocalDisplay;//本地显示状态,0-正常,1-不正常
    }

    public struct NET_DVR_ETHERNET
    {
        public string sDVRIP;          //DVR IP地址
        public string sDVRIPMask;      // DVR IP地址掩码
        public uint dwNetInterface;   //网络接口 1-10MBase-T 2-10MBase-T全双工 3-100MBase-TX 4-100M全双工 5-10M/100M自适应
        public ushort wDVRPort;  //端口号
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] byMACAddr;  //服务器的物理地址MACADDR_LEN
    }


    public struct NET_DVR_NETCFG
    {
        public uint dwSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public NET_DVR_ETHERNET[] struEtherNet;  /* 以太网口 */
        public string sManageHostIP;  //远程管理主机地址
        public short wManageHostPort; //远程管理主机端口号
        public string sDNSIP;            //DNS服务器地址  
        public string sMultiCastIP;     //多播组地址
        public string sGatewayIP;        //网关地址 
        public string sNFSIP;   //NAS主机IP地址 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] sNFSDirectory;//NAS目录PATHNAME_LEN
        public uint dwPPPOE;    //0-不启用,1-启用
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] sPPPoEUser; //PPPoE用户名NAME_LEN
        //  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public string sPPPoEPassword;// PPPoE密码
        public string sPPPoEIP;   //PPPoE IP地址(只读)
        public ushort wHttpPort;    //HTTP端口号
    }

    public struct NET_DVR_ALARMOUTSTATUS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Output;//MAX_ALARMOUT
    }

    public struct NET_DVR_CLIENTINFO
    {
        public int lChannel;//通道号
        public int lLinkMode;//最高位(31)为0表示主码流，为1表示子码流，0－30位表示码流连接方式: 0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-音视频分开(TCP)
        public System.IntPtr hPlayWnd;//播放窗口的句柄,为NULL表示不播放图象
        public string sMultiCastIP;//多播组地址
    }

    /// <summary>
    /// 海康嵌入式
    /// </summary>
    public sealed class Hik_HCNetSDK
    {
        #region 常量定义
        public const int NET_DVR_NOERROR = 0; //没有错误
        public const int NET_DVR_PASSWORD_ERROR = 1;  //用户名密码错误
        public const int NET_DVR_NOENOUGHPRI = 2;  //权限不足
        public const int NET_DVR_NOINIT = 3; //没有初始化
        public const int NET_DVR_CHANNEL_ERROR = 4;  //通道号错误
        public const int NET_DVR_OVER_MAXLINK = 5; //连接到DVR的客户端个数超过最大
        public const int NET_DVR_VERSIONNOMATCH = 6; //版本不匹配
        public const int NET_DVR_NETWORK_FAIL_CONNECT = 7;//连接服务器失败
        public const int NET_DVR_NETWORK_SEND_ERROR = 8; //向服务器发送失败
        public const int NET_DVR_NETWORK_RECV_ERROR = 9;//从服务器接收数据失败
        public const int NET_DVR_NETWORK_RECV_TIMEOUT = 10; //从服务器接收数据超时
        public const int NET_DVR_NETWORK_ERRORDATA = 11; //传送的数据有误
        public const int NET_DVR_ORDER_ERROR = 12;//调用次序错误
        public const int NET_DVR_OPERNOPERMIT = 13; //无此权限
        public const int NET_DVR_COMMANDTIMEOUT = 14;//DVR命令执行超时
        public const int NET_DVR_ERRORSERIALPORT = 15;//串口号错误
        public const int NET_DVR_ERRORALARMPORT = 16; //报警端口错误
        public const int NET_DVR_PARAMETER_ERROR = 17; //参数错误
        public const int NET_DVR_CHAN_EXCEPTION = 18;//服务器通道处于错误状态
        public const int NET_DVR_NODISK = 19;//没有硬盘
        public const int NET_DVR_ERRORDISKNUM = 20;//硬盘号错误
        public const int NET_DVR_DISK_FULL = 21; //服务器硬盘满
        public const int NET_DVR_DISK_ERROR = 22;//服务器硬盘出错
        public const int NET_DVR_NOSUPPORT = 23; //服务器不支持
        public const int NET_DVR_BUSY = 24;//服务器忙
        public const int NET_DVR_MODIFY_FAIL = 25; //服务器修改不成功
        public const int NET_DVR_PASSWORD_FORMAT_ERROR = 26; //密码输入格式不正确
        public const int NET_DVR_DISK_FORMATING = 27; //硬盘正在格式化，不能启动操作
        public const int NET_DVR_DVRNORESOURCE = 28; //DVR资源不足
        public const int NET_DVR_DVROPRATEFAILED = 29; //DVR操作失败
        public const int NET_DVR_OPENHOSTSOUND_FAIL = 30; //打开PC声音失败
        public const int NET_DVR_DVRVOICEOPENED = 31; //服务器语音对讲被占用
        public const int NET_DVR_TIMEINPUTERROR = 32; //时间输入不正确
        public const int NET_DVR_NOSPECFILE = 33; //回放时服务器没有指定的文件
        public const int NET_DVR_CREATEFILE_ERROR = 34;//创建文件出错
        public const int NET_DVR_FILEOPENFAIL = 35; //打开文件出错
        public const int NET_DVR_OPERNOTFINISH = 36; //上次的操作还没有完成
        public const int NET_DVR_GETPLAYTIMEFAIL = 37; //获取当前播放的时间出错
        public const int NET_DVR_PLAYFAIL = 38; //播放出错
        public const int NET_DVR_FILEFORMAT_ERROR = 39; //文件格式不正确
        public const int NET_DVR_DIR_ERROR = 40; //路径错误
        public const int NET_DVR_ALLOC_RESOUCE_ERROR = 41; //资源分配错误
        public const int NET_DVR_AUDIO_MODE_ERROR = 42; //声卡模式错误
        public const int NET_DVR_NOENOUGH_BUF = 43;//缓冲区太小
        public const int NET_DVR_CREATESOCKET_ERROR = 44; //创建SOCKET出错
        public const int NET_DVR_SETSOCKET_ERROR = 45; //设置SOCKET出错
        public const int NET_DVR_MAX_NUM = 46;//个数达到最大
        public const int NET_DVR_USERNOTEXIST = 47; //用户不存在
        public const int NET_DVR_WRITEFLASHERROR = 48;  //写FLASH出错
        public const int NET_DVR_UPGRADEFAIL = 49; //DVR升级失败
        public const int NET_DVR_CARDHAVEINIT = 50; //解码卡已经初始化过
        public const int NET_DVR_PLAYERFAILED = 51; //播放器中错误
        public const int NET_DVR_MAX_USERNUM = 52; //用户数达到最大
        public const int NET_DVR_GETLOCALIPANDMACFAIL = 53; //获得客户端的IP地址或物理地址失败
        public const int NET_DVR_NOENCODEING = 54;//该通道没有编码
        public const int NET_DVR_IPMISMATCH = 55; //IP地址不匹配
        public const int NET_DVR_MACMISMATCH = 56;//MAC地址不匹配
        public const int NET_DVR_UPGRADELANGMISMATCH = 57;//升级文件语言不匹配
        public const int NET_DVR_DDRAWDEVICENOSUPPORT = 58;//本地显卡不支持


        //查找文件和日志函数返回值
        public const int NET_DVR_FILE_SUCCESS = 1000; //获得文件信息
        public const int NET_DVR_FILE_NOFIND = 1001;//没有文件
        public const int NET_DVR_ISFINDING = 1002;//正在查找文件
        public const int NET_DVR_NOMOREFILE = 1003; //查找文件时没有更多的文件
        public const int NET_DVR_FILE_EXCEPTION = 1004; //查找文件时异常

        //NET_DVR_IsSupport()返回值 
        //1－9位分别表示以下信息（位与是TRUE)表示支持；
        public const int NET_DVR_SUPPORT_DDRAW = 0x01;//支持DIRECTDRAW，如果不支持，则播放器不能工作；
        public const int NET_DVR_SUPPORT_BLT = 0x02;//显卡支持BLT操作，如果不支持，则播放器不能工作；
        public const int NET_DVR_SUPPORT_BLTFOURCC = 0x04;//显卡BLT支持颜色转换，如果不支持，播放器会用软件方法作RGB转换；
        public const int NET_DVR_SUPPORT_BLTSHRINKX = 0x08;//显卡BLT支持X轴缩小；如果不支持，系统会用软件方法转换；
        public const int NET_DVR_SUPPORT_BLTSHRINKY = 0x10;//显卡BLT支持Y轴缩小；如果不支持，系统会用软件方法转换；
        public const int NET_DVR_SUPPORT_BLTSTRETCHX = 0x20;//显卡BLT支持X轴放大；如果不支持，系统会用软件方法转换；
        public const int NET_DVR_SUPPORT_BLTSTRETCHY = 0x40;//显卡BLT支持Y轴放大；如果不支持，系统会用软件方法转换；
        public const int NET_DVR_SUPPORT_SSE = 0x80;//CPU支持SSE指令，Intel Pentium3以上支持SSE指令；
        public const int NET_DVR_SUPPORT_MMX = 0x100;//CPU支持MMX指令集，Intel Pentium3以上支持SSE指令；

        public const int SET_PRESET = 8;// 设置预置点 
        public const int CLE_PRESET = 9; // 清除预置点 
        public const int GOTO_PRESET = 39;// 转到预置点

        public const int LIGHT_PWRON = 2; /* 接通灯光电源 */
        public const int WIPER_PWRON = 3; /* 接通雨刷开关 */
        public const int FAN_PWRON = 4;/* 接通风扇开关 */
        public const int HEATER_PWRON = 5;/* 接通加热器开关 */
        public const int AUX_PWRON = 6;/* 接通辅助设备开关 */

        public const int ZOOM_IN = 11; /* 焦距以速度SS变大(倍率变大) */
        public const int ZOOM_OUT = 12;/* 焦距以速度SS变小(倍率变小) */
        public const int FOCUS_NEAR = 13; /* 焦点以速度SS前调 */
        public const int FOCUS_FAR = 14;/* 焦点以速度SS后调 */
        public const int IRIS_OPEN = 15; /* 光圈以速度SS扩大 */
        public const int IRIS_CLOSE = 16; /* 光圈以速度SS缩小 */
        public const int TILT_UP = 21;/* 云台以SS的速度上仰 */
        public const int TILT_DOWN = 22;/* 云台以SS的速度下俯 */
        public const int PAN_LEFT = 23;/* 云台以SS的速度左转 */
        public const int PAN_RIGHT = 24; /* 云台以SS的速度右转 */
        public const int PAN_AUTO = 29; /* 云台以SS的速度左右自动扫描 */

        public const int RUN_CRUISE = 36; /* 开始轨迹 */
        public const int RUN_SEQ = 37; /* 开始巡航 */
        public const int STOP_SEQ = 38;/* 停止巡航 */

        //显示模式
        public enum DispMode { NORMALMODE = 0, OVERLAYMODE };
        //发送模式
        public enum TransMode { PTOPTCPMODE, PTOPUDPMODE, MULTIMODE, RTPMODE, AUDIODETACH, NOUSEMODE };

        public const int NET_DVR_SYSHEAD = 1;//系统头数据
        public const int NET_DVR_STREAMDATA = 2; //流数据

        //播放控制命令宏定义 NET_DVR_PlayBackControl,NET_DVR_PlayControlLocDisplay,NET_DVR_DecPlayBackCtrl的宏定义
        public const int NET_DVR_PLAYSTART = 1;//开始播放
        public const int NET_DVR_PLAYSTOP = 2;//停止播放
        public const int NET_DVR_PLAYPAUSE = 3;//暂停播放
        public const int NET_DVR_PLAYRESTART = 4;//恢复播放
        public const int NET_DVR_PLAYFAST = 5;//快放
        public const int NET_DVR_PLAYSLOW = 6;//慢放
        public const int NET_DVR_PLAYNORMAL = 7;//正常速度
        public const int NET_DVR_PLAYFRAME = 8;//单帧放
        public const int NET_DVR_PLAYSTARTAUDIO = 9;//打开声音
        public const int NET_DVR_PLAYSTOPAUDIO = 10;//关闭声音
        public const int NET_DVR_PLAYAUDIOVOLUME = 11;//调节音量
        public const int NET_DVR_PLAYSETPOS = 12;//改变文件回放的进度
        public const int NET_DVR_PLAYGETPOS = 13;//获取文件回放的进度
        public const int NET_DVR_PLAYGETTIME = 14;//获取当前已经播放的时间
        public const int NET_DVR_PLAYGETFRAME = 15;//获取当前已经播放的帧数
        public const int NET_DVR_GETTOTALFRAMES = 16;//获取当前播放文件总的帧数
        public const int NET_DVR_GETTOTALTIME = 17;//获取当前播放文件总的时间
        public const int NET_DVR_THROWBFRAME = 20;//丢B帧

        //NET_DVR_GetDVRConfig,NET_DVR_GetDVRConfig的命令定义
        public const int NET_DVR_GET_DEVICECFG = 100;  //获取设备参数
        public const int NET_DVR_SET_DEVICECFG = 101; //设置设备参数
        public const int NET_DVR_GET_NETCFG = 102; //获取网络参数
        public const int NET_DVR_SET_NETCFG = 103; //设置网络参数
        public const int NET_DVR_GET_PICCFG = 104; //获取图象参数
        public const int NET_DVR_SET_PICCFG = 105; //设置图象参数
        public const int NET_DVR_GET_COMPRESSCFG = 106; //获取压缩参数
        public const int NET_DVR_SET_COMPRESSCFG = 107; //设置压缩参数
        public const int NET_DVR_GET_COMPRESSCFG_EX = 204; //获取压缩参数(扩展)
        public const int NET_DVR_SET_COMPRESSCFG_EX = 205; //设置压缩参数(扩展)
        public const int NET_DVR_GET_RECORDCFG = 108;//获取录像时间参数
        public const int NET_DVR_SET_RECORDCFG = 109; //设置录像时间参数
        public const int NET_DVR_GET_DECODERCFG = 110; //获取解码器参数
        public const int NET_DVR_SET_DECODERCFG = 111; //设置解码器参数
        public const int NET_DVR_GET_RS232CFG = 112; //获取232串口参数
        public const int NET_DVR_SET_RS232CFG = 113;//设置232串口参数
        public const int NET_DVR_GET_ALARMINCFG = 114; //获取报警输入参数
        public const int NET_DVR_SET_ALARMINCFG = 115; //设置报警输入参数
        public const int NET_DVR_GET_ALARMOUTCFG = 116; //获取报警输出参数
        public const int NET_DVR_SET_ALARMOUTCFG = 117; //设置报警输出参数
        public const int NET_DVR_GET_TIMECFG = 118; //获取DVR时间
        public const int NET_DVR_SET_TIMECFG = 119; //设置DVR时间
        public const int NET_DVR_GET_PREVIEWCFG = 120; //获取预览参数
        public const int NET_DVR_SET_PREVIEWCFG = 121; //设置预览参数
        public const int NET_DVR_GET_VIDEOOUTCFG = 122; //获取视频输出参数
        public const int NET_DVR_SET_VIDEOOUTCFG = 123; //设置视频输出参数
        public const int NET_DVR_GET_USERCFG = 124; //获取用户参数
        public const int NET_DVR_SET_USERCFG = 125; //设置用户参数
        public const int NET_DVR_GET_EXCEPTIONCFG = 126; //获取异常参数  //////////*****************
        public const int NET_DVR_SET_EXCEPTIONCFG = 127;  //设置异常参数  //////////*****************
        public const int NET_DVR_GET_SHOWSTRING = 130; //获取叠加字符参数
        public const int NET_DVR_SET_SHOWSTRING = 131; //设置叠加字符参数
        public const int NET_DVR_GET_AUXOUTCFG = 140; //获取辅助输出设置
        public const int NET_DVR_SET_AUXOUTCFG = 141;  //设置辅助输出设置
        //2006-04-13 -s系列双输出
        public const int NET_DVR_GET_PREVIEWCFG_AUX = 142; //获取预览参数
        public const int NET_DVR_SET_PREVIEWCFG_AUX = 143; //设置预览参数
        public const int NET_DVR_GET_PICCFG_EX = 200; //获取图象参数（扩展）
        public const int NET_DVR_SET_PICCFG_EX = 201; //设置图象参数（扩展）
        public const int NET_DVR_GET_USERCFG_EX = 202; //获取用户参数
        public const int NET_DVR_SET_USERCFG_EX = 203; //设置用户参数

        //回调函数类型
        public const int COMM_ALARM = 0x1100;//报警信息
        public const int COMM_TRADEINFO = 0x1500;//ATMDVR主动上传交易信息

        //消息方式
        //异常类型
        public const int EXCEPTION_AUDIOEXCHANGE = 0x8001;//语音对讲异常
        public const int EXCEPTION_ALARM = 0x8002;//报警异常
        public const int EXCEPTION_PREVIEW = 0x8003; //网络预览异常
        public const int EXCEPTION_SERIAL = 0x8004;//透明通道异常
        public const int EXCEPTION_RECONNECT = 0x8005;//预览时重连

        public const int NAME_LEN = 32;
        public const int SERIALNO_LEN = 48;
        public const int MACADDR_LEN = 6;
        public const int MAX_ETHERNET = 2;
        public const int PATHNAME_LEN = 128;
        public const int PASSWD_LEN = 16;
        public const int MAX_CHANNUM = 16;
        public const int MAX_ALARMOUT = 4;
        public const int MAX_TIMESEGMENT = 4;
        public const int MAX_PRESET = 128;
        public const int MAX_DAYS = 7;
        public const int PHONENUMBER_LEN = 32;
        public const int MAX_DISKNUM = 16;
        public const int MAX_WINDOW = 16;
        public const int MAX_VGA = 1;
        public const int MAX_USERNUM = 16;
        public const int MAX_EXCEPTIONNUM = 16;
        public const int MAX_LINK = 6;
        public const int MAX_ALARMIN = 16;
        public const int MAX_VIDEOOUT = 2;
        public const int MAX_NAMELEN = 16; //DVR本地登陆名
        public const int MAX_RIGHT = 32;//权限
        public const int CARDNUM_LEN = 20;
        public const int MAX_SHELTERNUM = 4;//遮挡区域数
        public const int MAX_DECPOOLNUM = 4;
        public const int MAX_DECNUM = 4;
        public const int MAX_TRANSPARENTNUM = 2;
        public const int MAX_STRINGNUM = 4;
        public const int MAX_AUXOUT = 4;

        /* 网络接口定义 */
        public const int NET_IF_10M_HALF = 1;    /* 10M ethernet */
        public const int NET_IF_10M_FULL = 2;
        public const int NET_IF_100M_HALF = 3;    /* 100M ethernet */
        public const int NET_IF_100M_FULL = 4;
        public const int NET_IF_AUTO = 5;

        //设备型号(DVR类型)
        public const int DVR = 1;
        public const int ATMDVR = 2;
        public const int DVS = 3;
        public const int DEC = 4; /* 6001D */
        public const int ENC_DEC = 5; /* 6001F */
        public const int DVR_HC = 6;
        public const int DVR_HT = 7;
        public const int DVR_HF = 8;
        public const int DVR_HS = 9;
        public const int DVR_HTS = 10;
        public const int DVR_HB = 11;
        public const int DVR_HCS = 12;
        public const int DVS_A = 13;
        public const int DVR_HC_S = 14;
        public const int DVR_HT_S = 15;
        public const int DVR_HF_S = 16;
        public const int DVR_HS_S = 17;
        public const int ATMDVR_S = 18;
        public const int LOWCOST_DVR = 19;
        #endregion

        //  public static readonly  int  SERIALNO_LEN = 48;


        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_Init();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_Cleanup();

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_Login(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, ref  NET_DVR_DEVICEINFO lpDeviceInfo);/////////////////////**********************************

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout(int lUserID);/////////////////////**********************************
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessage(uint nMessage, System.IntPtr hWnd);/////////////////////////**************************8
        //public static extern bool NET_DVR_SetDVRMessCallBack(BOOL (CALLBACK *fMessCallBack)(int  lCommand,char *sDVRIP,char *pBuf,uint  dwBufLen));
        //public static extern bool NET_DVR_SetDVRMessCallBack_EX(BOOL (CALLBACK *fMessCallBack_EX)(int  lCommand,int  lUserID,char *pBuf,uint  dwBufLen));
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConnectTime(uint dwWaitTime, uint dwTryTimes);/////////////////////**********************************
        [DllImport("HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKVersion();
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_IsSupport();
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StartListen(string sLocalIP, ushort wLocalPort);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen();

        [DllImport("HCNetSDK.dll")]
        public static extern uint NET_DVR_GetLastError();
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetShowMode(uint dwShowType, System.Drawing.Color colorKey);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr(string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, string sGetIP);
        //图像预览
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay(int lUserID, ref NET_DVR_CLIENTINFO lpClientInfo);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopRealPlay(int lRealHandle);
        //视频参数是索引值 1-10
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetVideoEffect(int lRealHandle, uint pBrightValue, uint pContrastValue, uint pSaturationValue, uint pHueValue);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterDrawFun(int lRealHandle, DrawFun x, uint dwUser);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayerBufNumber(int lRealHandle, uint dwBufNum);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ThrowBFrame(int lRealHandle, uint dwNum);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAudioMode(uint dwMode);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound(int lRealHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound();
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSoundShare(int lRealHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSoundShare(int lRealHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_Volume(int lRealHandle, ushort wVolume);
        //录像
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData(int lRealHandle, string sFileName);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopSaveRealData(int lRealHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRealDataCallBack(int lRealHandle, RealDataCallBack x, uint dwUser);
        //抓图
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture(int lRealHandle, string sPicFileName);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrame(int lUserID, int lChannel);
        //云台控制
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl(int lRealHandle, uint dwPTZCommand, uint dwStop);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_Other(int lUserID, int lChannel, uint dwPTZCommand, uint dwStop);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ(int lRealHandle, byte[] pPTZCodeBuf, uint dwBufSize);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_Other(int lUserID, int lChannel, byte[] pPTZCodeBuf, uint dwBufSize);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_Other(int lUserID, int lChannel, uint dwPTZPresetCmd, uint dwPresetIndex);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_EX(int lRealHandle, byte[] pPTZCodeBuf, uint dwBufSize);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_EX(int lRealHandle, uint dwPTZCommand, uint dwStop);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_EX(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_Other(int lUserID, int lChannel, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_EX(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack(int lRealHandle, uint dwPTZTrackCmd);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_EX(int lRealHandle, uint dwPTZTrackCmd);
        //带速度的云台控制
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_Other(int lUserID, int lChannel, uint dwPTZCommand, uint dwStop, uint dwSpeed);

        //文件回放
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile(int lFindHandle, ref NET_DVR_FIND_DATA lpFindData);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose(int lFindHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByName(int lUserID, string sPlayBackFileName, System.IntPtr hWnd);
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, System.IntPtr hWnd);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, uint lpOutValue);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBack(int lPlayHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayDataCallBack(int lPlayHandle, PlayDataCallBack x, uint dwUser);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackSaveData(int lPlayHandle, string sFileName);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBackSave(int lPlayHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPlayBackOsdTime(int lPlayHandle, ref NET_DVR_TIME lpOsdTime);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackCaptureFile(int lPlayHandle, string sFileName);
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByName(int lUserID, string sDVRFileName, string sSavedFileName);
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, string sSavedFileName);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopGetFile(int lFileHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetDownloadPos(int lFileHandle);

        //恢复默认值
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreConfig(int lUserID);
        //保存参数
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveConfig(int lUserID);
        //重启
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RebootDVR(int lUserID);
        //关闭DVR
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ShutDownDVR(int lUserID);
        //升级
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_Upgrade(int lUserID, string sFileName);
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeState(int lUpgradeHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseUpgradeHandle(int lUpgradeHandle);
        //远程格式化硬盘
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FormatDisk(int lUserID, int lDiskNumber);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetFormatProgress(int lFormatHandle, int pCurrentFormatDisk, int pCurrentDiskPos, int pFormatStatic);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseFormatHandle(int lFormatHandle);
        //报警
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan(int lUserID);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan(int lAlarmHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut(int lUserID, ref NET_DVR_ALARMOUTSTATUS lpAlarmOutState);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAlarmOut(int lUserID, int lAlarmOutPort, int lAlarmOutStatic);




        //语音对讲
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom(int lUserID, fVoiceDataCallBack x, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVoiceComClientVolume(int lVoiceComHandle, ushort wVolume);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopVoiceCom(int lVoiceComHandle);
        //语音广播
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStop();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_AddDVR(int lUserID);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR(int lUserID);
        //语音转发
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StartVoiceCom_MR(int lUserID, fVoiceDataCallBack x, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_VoiceComSendData(int lVoiceComHandle, byte[] pSendBuf, uint dwBufSize);

        //透明通道设置
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_SerialStart(int lUserID, int lSerialPort, SerialDataCallBack x, uint dwUser);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, byte[] pSendBuf, uint dwBufSize);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStop(int lSerialHandle);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SendTo232Port(int lUserID, byte[] pSendBuf, uint dwBufSize);
        //远程控制本地显示
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClickKey(int lUserID, int lKeyIndex);

        //远程控制手动录像
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDVRRecord(int lUserID, int lChannel, int lRecordType);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDVRRecord(int lUserID, int lChannel);
    }
}
