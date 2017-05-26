using UnityEngine;

namespace Patterns.Command
{
    public class ChangeToGreen : ChangeColorCommand
    {
        // -------- Properties -----------
        public override Color Color { get { return Color.green; } }
        
        // ########### Constructor #############
        public ChangeToGreen(ICommandable commandable)
        {
            this.Commandable = commandable;
        }
    }
}
