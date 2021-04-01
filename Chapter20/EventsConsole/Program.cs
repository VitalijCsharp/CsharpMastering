using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsConsole
{
    public delegate void KeyPressEventDelegate();

    public class KeyBoardMaster
    {
        public event KeyPressEventDelegate wKeyPressEvent = null;
        public event KeyPressEventDelegate sKeyPressEvent = null;

        public void wKeyPress()
        {
            if(wKeyPressEvent != null)
            {
                wKeyPressEvent.Invoke();
            }
        }
        public void sKeyPress()
        {
            if(sKeyPressEvent != null)
            {
                sKeyPressEvent();
            }
        }
    }
    class Program
    {
        static void ButtonW_Click()
        {
            Console.WriteLine(" Forward");
        }

        static void ButtonS_Click()
        {
            Console.WriteLine(" Backward");
        }
        static void Main(string[] args)
        {
            KeyBoardMaster KM = new KeyBoardMaster();

            KM.wKeyPressEvent += ButtonW_Click;
            KM.sKeyPressEvent += ButtonS_Click;

            ConsoleKey pressedKey;

            while (true)
            {
                pressedKey = Console.ReadKey().Key;

                switch (pressedKey)
                {                    
                    case ConsoleKey.S:
                        KM.sKeyPress();
                        break;                    
                    case ConsoleKey.W:
                        KM.wKeyPress();
                        break;
                    
                    default:
                        break;
                }
            }
        }
    }
}
