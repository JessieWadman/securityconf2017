using System;

namespace FlatPlanetCafe.Models.ManageViewModels
{
    public partial class DependencyInjectAttribute : Attribute { }

    [DependencyInject]
    public class TwoFactorAuthenticationViewModel
    {
        public bool HasAuthenticator { get; set; }

        public int RecoveryCodesLeft { get; set; }

        public bool Is2faEnabled { get; set; }
    }
}
