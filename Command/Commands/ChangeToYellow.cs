using UnityEngine;

namespace Patterns.Command
{
    public class ChangeToYellow : ChangeColorCommand
    {
        // -------- Properties -----------
        public override Color Color { get { return Color.yellow; } }
        
        // ########### Constructor #############
        public ChangeToYellow(ICommandable commandable)
        {
            this.Commandable = commandable;
        }
    }
}