﻿using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Domain.Enums
{
    public sealed class DepartmentEnum : SmartEnum<DepartmentEnum>
    {

        public static readonly DepartmentEnum Acil = new("Acil", 1);
        public static readonly DepartmentEnum Radyoloji = new("Radyoloji", 2);
        public static readonly DepartmentEnum Kardiyoloji = new("Kardiyoloji", 3);
        public static readonly DepartmentEnum Endokrinoloji = new("Endokrinoloji", 4);
        public static readonly DepartmentEnum Dermatoloji = new("Dermatoloji", 5);
        public static readonly DepartmentEnum Gastroenteroloji = new("Gastroenteroloji", 6);
        public static readonly DepartmentEnum GenelCerrahi = new("Genel Cerrahi", 7);
        public static readonly DepartmentEnum JinekolojiObstetrik = new("Jinekoloji ve Obstetrik", 8);
        public static readonly DepartmentEnum Hematoloji = new("Hematoloji", 9);
        public static readonly DepartmentEnum EnfeksiyonHastaliklari = new("Enfeksiyon Hastalıkları", 10);
        public static readonly DepartmentEnum Nefroloji = new("Nefroloji", 11);
        public static readonly DepartmentEnum Nöroloji = new("Nöroloji", 12);
        public static readonly DepartmentEnum Ortopedi = new("Ortopedi", 13);
        public static readonly DepartmentEnum Pediatri = new("Pediatri", 14);
        public static readonly DepartmentEnum Psikiyatri = new("Psikiyatri", 15);
        public static readonly DepartmentEnum Pulmonoloji = new("Pulmonoloji", 16);


        public DepartmentEnum(string name, int value) : base(name, value)
        {


        }
    }
}
