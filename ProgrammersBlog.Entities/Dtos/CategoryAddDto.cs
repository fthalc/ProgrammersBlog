﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage ="{0} boş geçilmemelidir.")]
        [MaxLength(70,ErrorMessage ="{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3,ErrorMessage ="{0} {1} az olmamalıdır.")]
        public String Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} az olmamalıdır.")]
        public String Description { get; set; }
        [DisplayName("Kategori Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} az olmamalıdır.")]
        public String Note { get; set; }
        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public bool IsActive { get; set; }
    }
}
