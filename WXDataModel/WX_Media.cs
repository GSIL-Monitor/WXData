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
    
    public partial class WX_Media
    {
        public int MyMediaId { get; set; }
        public string AppId { get; set; }
        public string MediaId { get; set; }
        public string MediaName { get; set; }
        public string MediaType { get; set; }
        public string MediaContent { get; set; }
        public Nullable<int> MediaState { get; set; }
        public Nullable<System.DateTime> UploadTime { get; set; }
    
        public virtual WX_App WX_App { get; set; }
    }
}
