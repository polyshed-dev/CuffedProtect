using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CuffedProtect
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Whether SCPs should be able to kill cuffed players")]
        public bool LetSCPsKill { get; set; } = false;
    }
}