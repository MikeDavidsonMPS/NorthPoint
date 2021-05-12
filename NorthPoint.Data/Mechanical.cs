using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Data
{
    public class Mechanical
    {
        [Key]
        public int MechId { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public object Address { get; set; }


        [Required]
        [DisplayName("Electrical Service")]
        public ElecService ElecService { get; set; }

        [DisplayName("ElecService Condition")]
        public Conditions ElecServiceCondition { get; set; }

        [Required]
        [DisplayName("Service Panel")]
        public ServicePanel ServicePanel { get; set; }

        [DisplayName("Service Panel Condition")]
        public Conditions PanelCondition { get; set; }

        [Required]
        [DisplayName("Wiring")]
        public Wiring Wiring { get; set; }

        [DisplayName("Wiring Condition")]
        public Conditions WiringCondition { get; set; }

        [Required]
        [DisplayName("Switch/Plugs Grounded?")]
        public YesAndNo SwitchPlug { get; set; }

        [Required]
        [DisplayName("Ground Fault Circuit Plugs?")]
        public YesAndNo GFCPlug { get; set; }

        [Required]
        [DisplayName("Smoke Detectors?")]
        public YesAndNo SmokeDetectors { get; set; }
    }
      public enum ElecService
      {
        OneTwentyTwoFourtyMainServiceOneHunderdAMP,
        OneTwentyTwoFourtyMainServiceTwoHundredAMP,
        NoService,
        other
      }

      public enum ServicePanel
      {
        PanelRatingOneHunderdAMP,
        PanelRatingTwoHunderdAMP,
        PanelRatingUnknownAMP,
        other
      }

      public enum Wiring
      {
        TinnedCopper,
        CopperPlatedAluminum,
        ArmoredCableBX,
        NonMetallicCableRomex,
        RabricCovered,
        KnobAndTubeCopper,
        other
      }

      public enum Conditions
      {
        New,
        Good,
        Monitor,
        RepairsNeeded,
        MajorConcern,
        Replacement
      }

      public enum YesAndNo
      {
        Yes,
        No,
        Partial
      }

}
