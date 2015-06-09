using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OSCEExamPlatformWeb
{
    public class SoftDog
    {
        //Sense4 API

        // ctlCode definition for S4Control
        static public uint S4_LED_UP = 0x00000004;  // LED up
        static public uint S4_LED_DOWN = 0x00000008;  // LED down
        static public uint S4_LED_WINK = 0x00000028;  // LED wink
        static public uint S4_GET_DEVICE_TYPE = 0x00000025;	//get device type
        static public uint S4_GET_SERIAL_NUMBER = 0x00000026;	//get device serial
        static public uint S4_GET_VM_TYPE = 0x00000027;  // get VM type
        static public uint S4_GET_DEVICE_USABLE_SPACE = 0x00000029;  // get total space
        static public uint S4_SET_DEVICE_ID = 0x0000002a;  // set device ID

        // device type definition 
        static public uint S4_LOCAL_DEVICE = 0x00;		// local device 
        static public uint S4_MASTER_DEVICE = 0x80;		// net master device
        static public uint S4_SLAVE_DEVICE = 0xc0;		// net slave device

        // vm type definiton 
        static public uint S4_VM_51 = 0x00;		// VM51
        static public uint S4_VM_251_BINARY = 0x01;		// VM251 binary mode
        static public uint S4_VM_251_SOURCE = 0x02;		// VM251 source mode


        // PIN type definition 
        static public uint S4_USER_PIN = 0x000000a1;		// user PIN
        static public uint S4_DEV_PIN = 0x000000a2;		// dev PIN
        static public uint S4_AUTHEN_PIN = 0x000000a3;		// autheticate Key


        // file type definition 
        static public uint S4_RSA_PUBLIC_FILE = 0x00000006;		// RSA public file
        static public uint S4_RSA_PRIVATE_FILE = 0x00000007;		// RSA private file 
        static public uint S4_EXE_FILE = 0x00000008;		// VM file
        static public uint S4_DATA_FILE = 0x00000009;		// data file

        // dwFlag definition for S4WriteFile
        static public uint S4_CREATE_NEW = 0x000000a5;		// create new file
        static public uint S4_UPDATE_FILE = 0x000000a6;		// update file
        static public uint S4_KEY_GEN_RSA_FILE = 0x000000a7;		// produce RSA key pair
        static public uint S4_SET_LICENCES = 0x000000a8;		// set the license number for modle,available for net device only
        static public uint S4_CREATE_ROOT_DIR = 0x000000ab;		// create root directory, available for empty device only
        static public uint S4_CREATE_SUB_DIR = 0x000000ac;		// create child directory
        static public uint S4_CREATE_MODULE = 0x000000ad;		// create modle, available for net device only

        // the three parameters below must be bitwise-inclusive-or with S4_CREATE_NEW, only for executive file
        static public uint S4_FILE_READ_WRITE = 0x00000000;      // can be read and written in executive file,default
        static public uint S4_FILE_EXECUTE_ONLY = 0x00000100;      // can NOT be read or written in executive file
        static public uint S4_CREATE_PEDDING_FILE = 0x00002000;		// create padding file


        /* return value*/
        static public uint S4_SUCCESS = 0x00000000;		// succeed
        static public uint S4_UNPOWERED = 0x00000001;
        static public uint S4_INVALID_PARAMETER = 0x00000002;
        static public uint S4_COMM_ERROR = 0x00000003;
        static public uint S4_PROTOCOL_ERROR = 0x00000004;
        static public uint S4_DEVICE_BUSY = 0x00000005;
        static public uint S4_KEY_REMOVED = 0x00000006;
        static public uint S4_INSUFFICIENT_BUFFER = 0x00000011;
        static public uint S4_NO_LIST = 0x00000012;
        static public uint S4_GENERAL_ERROR = 0x00000013;
        static public uint S4_UNSUPPORTED = 0x00000014;
        static public uint S4_DEVICE_TYPE_MISMATCH = 0x00000020;
        static public uint S4_FILE_SIZE_CROSS_7FFF = 0x00000021;
        static public uint S4_DEVICE_UNSUPPORTED = 0x00006a81;
        static public uint S4_FILE_NOT_FOUND = 0x00006a82;
        static public uint S4_INSUFFICIENT_SECU_STATE = 0x00006982;
        static public uint S4_DIRECTORY_EXIST = 0x00006901;
        static public uint S4_FILE_EXIST = 0x00006a80;
        static public uint S4_INSUFFICIENT_SPACE = 0x00006a84;
        static public uint S4_OFFSET_BEYOND = 0x00006B00;
        static public uint S4_PIN_BLOCK = 0x00006983;
        static public uint S4_FILE_TYPE_MISMATCH = 0x00006981;
        static public uint S4_CRYPTO_KEY_NOT_FOUND = 0x00009403;
        static public uint S4_APPLICATION_TEMP_BLOCK = 0x00006985;
        static public uint S4_APPLICATION_PERM_BLOCK = 0x00009303;
        static public int S4_DATA_BUFFER_LENGTH_ERROR = 0x00006700;
        static public uint S4_CODE_RANGE = 0x00010000;
        static public uint S4_CODE_RESERVED_INST = 0x00020000;
        static public uint S4_CODE_RAM_RANGE = 0x00040000;
        static public uint S4_CODE_BIT_RANGE = 0x00080000;
        static public uint S4_CODE_SFR_RANGE = 0x00100000;
        static public uint S4_CODE_XRAM_RANGE = 0x00200000;
        static public uint S4_ERROR_UNKNOWN = 0xffffffff;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SENSE4_CONTEXT
        {
            public int dwIndex;		//device index
            public int dwVersion;		//version		
            public int hLock;			//device handle
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserve;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
            public byte[] bAtr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] bID;
            public uint dwAtrLen;
        }

        //Assume that Sense4user.dll in c:\, if not, modify the lines below
        [DllImport(@"Sense4.dll")]
        private static extern uint S4Enum([MarshalAs(UnmanagedType.LPArray), Out] SENSE4_CONTEXT[] s4_context, ref uint size);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4Open(ref SENSE4_CONTEXT s4_context);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4Close(ref SENSE4_CONTEXT s4_context);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4Control(ref SENSE4_CONTEXT s4Ctx, uint ctlCode, byte[] inBuff,
            uint inBuffLen, byte[] outBuff, uint outBuffLen, ref uint BytesReturned);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4CreateDir(ref SENSE4_CONTEXT s4Ctx, string DirID, uint DirSize, uint Flags);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4ChangeDir(ref SENSE4_CONTEXT s4Ctx, string Path);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4EraseDir(ref SENSE4_CONTEXT s4Ctx, string DirID);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4VerifyPin(ref SENSE4_CONTEXT s4Ctx, byte[] Pin, uint PinLen, uint PinType);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4ChangePin(ref SENSE4_CONTEXT s4Ctx, byte[] OldPin, uint OldPinLen,
            byte[] NewPin, uint NewPinLen, uint PinType);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4WriteFile(ref SENSE4_CONTEXT s4Ctx, string FileID, uint Offset,
            byte[] Buffer, uint BufferSize, uint FileSize, ref uint BytesWritten, uint Flags,
            uint FileType);
        [DllImport(@"Sense4.dll")]
        private static extern uint S4Execute(ref SENSE4_CONTEXT s4Ctx, string FileID, byte[] InBuffer,
            uint InbufferSize, byte[] OutBuffer, uint OutBufferSize, ref uint BytesReturned);


        uint size = 0;
        uint ret = 0;
        SENSE4_CONTEXT[] si = null;
        byte[] outBuffer = new byte[256];
        uint BytesReturned = 0;

        /// <summary>
        /// enumerate devices	枚举加密狗	
        /// </summary>
        /// <returns></returns>
        public uint EnumDevice()
        {
            ret = S4Enum(null, ref size);
            return ret;
        }

        /// <summary>
        /// 校验开发商PIN码
        /// </summary>
        /// <returns></returns>
        public uint VerifyDevPin()
        {
            si = new SENSE4_CONTEXT[size / Marshal.SizeOf(typeof(SENSE4_CONTEXT))];
            ret = S4Enum(si, ref size);
            Debug.Assert(0x00 == ret);

            //open the first device 打开第一个加密狗
            ret = S4Open(ref si[0]);
            Debug.Assert(0x00 == ret);

            byte[] inBuffer = new byte[512];
            inBuffer[0] = 0x04;

            outBuffer[0] = 0xff;
            outBuffer[1] = 0x01;
            outBuffer[2] = 0x02;

            //have LED up 打开LED灯
            ret = S4Control(ref si[0], S4_LED_WINK, inBuffer, 1, outBuffer, 256, ref BytesReturned);
            Debug.Assert(0x00 == ret);

            //开发商PIN码
            byte[] Pin = {	0x32,0x30, 0x31, 0x34, 0x30,0x33, 0x30, 0x31, 
								0x31,0x31, 0x31, 0x31, 0x31,0x31, 0x31, 0x31,
								0x32,0x30, 0x31, 0x34, 0x30,0x33, 0x30, 0x31};

            //verify dev PIN  校验PIN码
            ret = S4VerifyPin(ref si[0], Pin, 24, S4_DEV_PIN);

            return ret;
        }

        /// <summary>
        /// ROOT字典根的擦除和建立(恢复初始密码用，不需要)
        /// </summary>
        public void RootDirectory()
        {
            if (0x00 == ret)
            {
                //erase root directory  擦除字典根
                ret = S4EraseDir(ref si[0], null);
                Debug.Assert(0x00 == ret);
            }

            //reate root directory  重建字典根
            ret = S4CreateDir(ref si[0], "\\", 0, S4_CREATE_ROOT_DIR);
            Debug.Assert(0x00 == ret);

            //change current directory to root directory
            ret = S4ChangeDir(ref si[0], "\\");
            Debug.Assert(0x00 == ret);
        }

        /// <summary>
        /// 关闭加密狗
        /// </summary>
        /// <param name="rett"></param>
        public void CloseDevice(uint rett)
        {
            //have LED down  关闭LED灯
            ret = S4Control(ref si[0], S4_LED_DOWN, null, 0, outBuffer, 256, ref BytesReturned);
            Debug.Assert(0x00 == ret);

            //close device   关闭加密狗设备
            ret = S4Close(ref si[0]);
            Debug.Assert(0x00 == ret);

        }


    }
}
