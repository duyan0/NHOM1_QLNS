﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TacGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TacGia()
        {
            this.SanPham = new HashSet<SanPham>();
        }
    
        public int IDtg { get; set; }
        [Required(ErrorMessage = "Tên tác giả không được để trống.")]
        [StringLength(100, ErrorMessage = "Tên tác giả không được vượt quá 100 ký tự.")]
        public string TenTacGia { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(TacGiaValidator), nameof(TacGiaValidator.ValidateNgaySinh))]
        public DateTime NgaySinh { get; set; }

        public string QuocGia { get; set; }
        public string TieuSu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPham { get; set; }
        public static class TacGiaValidator
        {
            public static ValidationResult ValidateNgaySinh(DateTime ngaySinh, ValidationContext context)
            {
                if (ngaySinh > DateTime.Now)
                {
                    return new ValidationResult("Ngày sinh không được là ngày trong tương lai.");
                }
                return ValidationResult.Success;
            }
        }
    
    }
}
