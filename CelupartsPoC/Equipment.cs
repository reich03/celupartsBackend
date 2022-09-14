﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CelupartsPoC
{
    public class Equipment
    {
        [Key]
        public int IdEquipment { get; set; }
        public string TypeOfEquipment { get; set; } = string.Empty;
        public string EquipmentBrand { get; set; } = string.Empty;
        public string ModelOrReference { get; set; } = string.Empty;
        public string ImeiOrSerial { get; set; } = string.Empty;
        public byte[] EquipmentInvoice { get; set; }
        //public virtual List<RequestWithEquipments> Requests { get; set; } = new List<RequestWithEquipments>();
    }
}
