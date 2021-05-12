using NorthPoint.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Models.Mechanical
{
    public class MechanicalListItem
    {
        public int MechId { get; set; }

        public object Address { get; set; }


        [DisplayName("Electrical Service")]
        public ElecService ElecService { get; set; }

        [DisplayName("ElecService Condition")]
        public Conditions ElecServiceCondition { get; set; }

        [DisplayName("Service Panel")]
        public ServicePanel ServicePanel { get; set; }

        [DisplayName("Service Panel Condition")]
        public Conditions PanelCondition { get; set; }

        [DisplayName("Wiring")]
        public Wiring Wiring { get; set; }

        [DisplayName("Wiring Condition")]
        public Conditions WiringCondition { get; set; }

        [DisplayName("Switch/Plugs Grounded?")]
        public YesAndNo SwitchPlug { get; set; }

        [DisplayName("Ground Fault Circuit Plugs?")]
        public YesAndNo GFCPlug { get; set; }

        [DisplayName("Smoke Detectors?")]
        public YesAndNo SmokeDetectors { get; set; }
    }
}
