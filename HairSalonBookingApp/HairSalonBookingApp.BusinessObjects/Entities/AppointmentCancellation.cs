﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairSalonBookingApp.BusinessObjects.Entities
{
    public class AppointmentCancellation : BaseEntity
    {
        public AppointmentCancellation() : base() { }
        [Key]
        [Column("CancellationId")]
        public override Guid Id { get; set; }
        //FK from Appointment
        public Guid AppointmentId { get; set; }
        public string Reason { get; set; } = null!;


        [ForeignKey("AppointmentId")]
        public virtual Appointment Appointment { get; set; } = null!;
    }
}
