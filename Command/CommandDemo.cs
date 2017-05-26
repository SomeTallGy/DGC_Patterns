using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Command
{
    public class CommandDemo : MonoBehaviour
    {

        // ------------ inspector fields --------------
        public CommandableSpheres commandReceiver;
        public Text bufferPosition;
        public Text bufferInfo;

        // ------------ private fields ----------------
        private CommandInvoker commandInvoker;

        // started when the game object is active in the scene
        void Start()
        {
            commandInvoker = new CommandInvoker();
        }

        // ------- this is Unity specific
        void OnGUI()
        {

            if (GUI.Button(new Rect(10, 10, 150, 100), "Red"))
            {
                commandInvoker.BufferCommand(new ChangeToRed(commandReceiver));
                UpdateBufferText();
            }
            if (GUI.Button(new Rect(170, 10, 150, 100), "Blue"))
            {
                commandInvoker.BufferCommand(new ChangeToBlue(commandReceiver));
                UpdateBufferText();
            }
            if (GUI.Button(new Rect(330, 10, 150, 100), "Green"))
            {
                commandInvoker.BufferCommand(new ChangeToGreen(commandReceiver));
                UpdateBufferText();
            }
            if (GUI.Button(new Rect(490, 10, 150, 100), "Yellow"))
            {
                commandInvoker.BufferCommand(new ChangeToYellow(commandReceiver));
                UpdateBufferText();
            }

            if (GUI.Button(new Rect(100, 120, 50, 20), "Prev"))
            {
                commandInvoker.Prev();
                UpdateBufferText();
            }

            if (GUI.Button(new Rect(170, 120, 50, 20), "Next"))
            {
                commandInvoker.Next();
                UpdateBufferText();
            }

            if (GUI.Button(new Rect(240, 120, 50, 20), "Clear"))
            {
                commandInvoker.Clear();
                UpdateBufferText();
            }
        }

        private void UpdateBufferText()
        {
            // 1. Update Buffer Info
            bufferInfo.text = commandInvoker.buffer.Count + " Commands in Buffer";

            // 2. Update Buffer Position
            bufferPosition.text = "";
            for(int i = 0; i < commandInvoker.buffer.Count; i++)
            {
                if(i == commandInvoker.i)
                {
                    bufferPosition.text += "*";
                }
                else
                {
                    bufferPosition.text += ".";
                }
            }
        }
    }
}
