using Exiled.API.Interfaces;
using System.ComponentModel;

// Copyright (c) 2026 polyshed

namespace CuffedProtect
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
