using System.Collections.Generic;

namespace Patterns.Command
{
    public class CommandInvoker
    {	
		// --------- internal fields --------
        internal List<ICommand> buffer = new List<ICommand>();
        internal int i = -1;

        public void BufferCommand(ICommand newCommand)
        {
            buffer.Add(newCommand);
        }

        public void Next()
        {
            if (i < buffer.Count - 1)
                buffer[++i].Execute();
        }

        public void Prev()
        {
            if (i > 0 && buffer.Count > 0)
                buffer[--i].Execute();
        }

        public virtual void Clear()
        {
            buffer = new List<ICommand>();
            i = -1;
        }

    }
}