//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TT_SACH
    {
        public int MA_TT_SACH { get; set; }
        public string URL_IMAGE { get; set; }
        public string MOTA { get; set; }
        public Nullable<int> MASACH { get; set; }
    
        public virtual Sach Sach { get; set; }
    }
}
