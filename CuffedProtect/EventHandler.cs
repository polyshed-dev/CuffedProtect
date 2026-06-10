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
            if (ev.Attacker != null && 
                ev.Player.IsCuffed && 
                ev.Player.Cuffer != ev.Attacker && 
                ev.Attacker.IsScp == false)
            {
                ev.IsAllowed = false;
            }
        }

        private void OnRemovingHandcuffs(RemovingHandcuffsEventArgs ev)
        {
            if (ev.Target.Cuffer != null && 
                ev.Target.Cuffer != ev.Player && 
                ev.Player.LeadingTeam != ev.Target.LeadingTeam)
            {
                ev.IsAllowed = false;
            }
        }

        public void UnsubscribeEvents()
        {
            Exiled.Events.Handlers.Player.Hurting -= OnHurting;
            Exiled.Events.Handlers.Player.RemovingHandcuffs -= OnRemovingHandcuffs;
        }
    }
}