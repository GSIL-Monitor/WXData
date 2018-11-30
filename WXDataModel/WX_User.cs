//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WXDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class WX_User
    {
        public WX_User()
        {
            this.WX_CustomMsg = new HashSet<WX_CustomMsg>();
            this.WX_Queue = new HashSet<WX_Queue>();
            this.WX_UserTag = new HashSet<WX_UserTag>();
        }
    
        public string OpenID { get; set; }
        public Nullable<int> GrooupId { get; set; }
        public string AppId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserNick { get; set; }
        public string UserName { get; set; }
        public string HeadImageUrl { get; set; }
        public string UserSex { get; set; }
        public string Language { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public Nullable<System.DateTime> SubscribeTime { get; set; }
        public Nullable<System.DateTime> UnSubscribeTime { get; set; }
        public string Telphone { get; set; }
        public string Emial { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Remark { get; set; }
        public string UserState { get; set; }
        public Nullable<System.DateTime> LastDateTime { get; set; }
        public string Subscribe_Scene { get; set; }
        public string QR_Scene { get; set; }
        public string QR_Scene_String { get; set; }
    
        public virtual SYS_User SYS_User { get; set; }
        public virtual WX_App WX_App { get; set; }
        public virtual ICollection<WX_CustomMsg> WX_CustomMsg { get; set; }
        public virtual ICollection<WX_Queue> WX_Queue { get; set; }
        public virtual WX_UserGroup WX_UserGroup { get; set; }
        public virtual ICollection<WX_UserTag> WX_UserTag { get; set; }
    }
}
