using UnityEngine;

namespace Patterns.Command
{
    abstract public class ChangeColorCommand : ICommand
    {
        // -------- Properties -----------
        public ICommandable Commandable { get; protected set; }   // reference to commandable object
        public abstract Color Color { get; }                      // color to change commandable object to

        public void Execute()
        {
            Commandable.UpdateColor(Color);
        }
        
        public override string ToString()
        {
            return this.GetType().Name;  // return class name
        }
    }
}