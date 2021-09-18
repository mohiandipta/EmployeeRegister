﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public int EmployeeName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public int Occupation { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public int ImageName { get; set; }
    }
}
