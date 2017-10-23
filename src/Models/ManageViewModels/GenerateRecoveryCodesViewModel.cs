using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlatPlanetCafe.Models.ManageViewModels
{
    public partial class DependencyInjectAttribute : Attribute { }

    [DependencyInject]
    public class GenerateRecoveryCodesViewModel
    {
        public string[] RecoveryCodes { get; set; }
    }
}
