using UnityEngine;

namespace Patterns.Command
{
    public class ChangeToRed : ChangeColorCommand
    {
        // -------- Properties -----------
        public override Color Color { get { return Color.red; } }
        
        // ########### Constructor #############
        public ChangeToRed(ICommandable commandable)
        {
            this.Commandable = commandable;
        }
    }
}