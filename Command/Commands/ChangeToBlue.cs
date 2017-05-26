using UnityEngine;

namespace Patterns.Command
{
    public class ChangeToBlue : ChangeColorCommand
    {
        // -------- Properties -----------
        public override Color Color { get { return Color.blue; } }
        
        // ########### Constructor #############
        public ChangeToBlue(ICommandable commandable)
        {
            this.Commandable = commandable;
        }
    }
}