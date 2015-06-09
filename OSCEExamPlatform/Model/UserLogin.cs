using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tellyes.Model
{
    /// <summary>
    /// 用户的角色分派表
    /// </summary>
    [Serializable]
    public partial class UserLogin
    {
        public UserLogin()
        {
 
        }

        private UserInfo _userEntity = new UserInfo();
        private List<Module> _moduleList = new List<Module>();
        private List<ModuleGroup> _moduleGroupList = new List<ModuleGroup>();
        
        //范国斌3月10日更改，变存List对象入Session为string对象，目的：减少Session的存储压力
        private string _mList = "";

        public string MList
        {
            get { return _mList; }
            set { _mList = value; }
        }

        public List<ModuleGroup> ModuleGroupList
        {
            get { return _moduleGroupList; }
            set { _moduleGroupList = value; }
        }

        public List<Module> ModuleList
        {
            get { return _moduleList; }
            set { _moduleList = value; }
        } 

        public UserInfo UserEntity
        {
            get { return _userEntity; }
            set { _userEntity = value; }
        }
 

    }
}
