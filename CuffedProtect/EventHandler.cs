using Exiled.Events.EventArgs.Player;

namespace CuffedProtect
{
    public class EventHandler
    {
        private Config _config => Plugin.Instance.Config;
        public EventHandler()
        {
            Exiled.Events.Handlers.Player.Hurting += OnHurting;
            Exiled.Events.Handlers.Player.RemovingHandcuffs += OnRemovingHandcuffs;
        }

        private void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Player.Cuffer != ev.Attacker && ev.Attacker.IsScp == _config.LetSCPsKill)
            {
                ev.IsAllowed = false;
            }
        }

        private void OnRemovingHandcuffs(RemovingHandcuffsEventArgs ev)
        {
            if (ev.Target.Cuffer != ev.Player && ev.Player.LeadingTeam != ev.Target.Cuffer.LeadingTeam)
            {
                ev.IsAllowed = false;
            }
        }
    }
}