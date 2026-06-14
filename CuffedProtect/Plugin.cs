using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events.EventArgs;
using System;

// Copyright (c) 2026 polyshed

namespace CuffedProtect
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance {get; private set;}
        
        public override string Name { get; } = "CuffedProtect";
        public override string  Author { get; } = "polyshed.";
        public override Version Version { get; } = new Version(0, 0, 1);
        public override Version RequiredExiledVersion { get; } = new Version(9, 14, 2);
        
        private EventHandler _handler;
        
        public override void OnEnabled()
        {
            base.OnEnabled();

            Instance = this;
            _handler = new EventHandler();
        }

        public override void OnDisabled()
        {
            _handler.UnsubscribeEvents();
            Instance = null;
            _handler = null;
            
            base.OnDisabled();
        }
    }
}
