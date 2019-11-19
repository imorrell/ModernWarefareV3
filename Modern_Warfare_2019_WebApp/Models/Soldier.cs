using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modern_Warfare_2019_WebApp.Models
{
    public abstract class Soldier
    {
        //initialize properties
        #region Properties
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string SoldierName { get; set; }

        [Required]
        [Range(typeof(DateTime), "1/1/1900", "11/14/2001)", ErrorMessage = "Your too young to play this game!")]
        public DateTime DOB { get; set; }
        public abstract string CodeName { get; }
        public abstract string PrimaryWeapon { get; }
        public abstract List<string> PrimaryAttachments { get; }
        public abstract string SecondaryWeapon { get; }
        public abstract List<string> SecondaryAttachments { get; }
        public abstract List<string> Perks { get; }
        public abstract List<string> Eqipment { get; }
        public double Kills { get; set; }
        public double Deaths { get; set; }
        public double KDRatio { get => Kills/Deaths; }
        #endregion

        #region Methods
        public Soldier()
        {

        }

        public abstract string Description();

      

        #endregion
    }

}
