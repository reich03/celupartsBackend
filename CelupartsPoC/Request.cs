﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CelupartsPoC
{
    public class Request
    {
        [Key]
        public int IdRequest { get; set; }

        public int? IdUser { get; set; } 
        [ForeignKey("IdUser")]
        [JsonIgnore]
        public virtual UserDto? UserDto { get; set; }

        public int? IdEquipment { get; set; }
        [ForeignKey("IdEquipment")]
        [JsonIgnore]
        public virtual Equipment? Equipment { get; set; }

        public string RequestType { get; set; } = string.Empty;
        public string PickUpAddress { get; set; } = string.Empty;
        public string DeliveryAddress { get; set; } = string.Empty;
        public string StatusQuote { get; set; } = string.Empty;
        public virtual List<Equipment>? Equipments { get; set; } = new List<Equipment>()!;
        public virtual List<RequestStatus> RequestStatus { get; set; } = new List<RequestStatus>()!;
        public virtual List<Repair> Repairs { get; set; } = new List<Repair>();
    }

    public class RequestWithEquipments
    {
        [Key]
        public int IdRequest { get; set; }
        public int? IdUser { get; set; }

        [ForeignKey("IdUser")]
        [JsonIgnore]
        public virtual UserDto? UserDto { get; set; }

        public int? IdEquipment { get; set; }
        [ForeignKey("IdEquipment")]
        [JsonIgnore]
        public virtual Equipment? Equipment { get; set; }

        public string RequestType { get; set; } = string.Empty;
        public string PickUpAddress { get; set; } = string.Empty;
        public string DeliveryAddress { get; set; } = string.Empty;
        public DateTime PickUpTime { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public int Quote { get; set; } = 0;
        public string StatusQuote { get; set; } = string.Empty;
        public virtual List<Equipment>? Equipments { get; set; } = new List<Equipment>()!;
        public virtual List<RequestStatus> RequestStatus { get; set; } = new List<RequestStatus>()!;
    }
}