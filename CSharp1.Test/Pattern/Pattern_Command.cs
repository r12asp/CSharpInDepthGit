using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public interface ICommand
    {
        void Execute();
    }
    //Invoker
    public class Switch
    {
        private ICommand _closeCommand;
        private ICommand _openCommand;

        public Switch(ICommand closeCommand, ICommand openCommand)
        {
            _closeCommand = closeCommand;
            _openCommand = openCommand;
        }
        public void Close()
        {
            _closeCommand.Execute();
        }
        public void Open()
        {
            _openCommand.Execute();
        }
    }

    //receiver interface
    public interface ISwitchable
    {
        void PowerOff();
        void PowerOn();
    }
    public class Light:ISwitchable
    {
        public void PowerOff()
        {
            System.Console.WriteLine("PowerOff");
        }
        public void PowerOn()
        {
            System.Console.WriteLine("PowerOn");
        }
    }
    public class CloseSwitchCommand:ICommand
    {
        private ISwitchable _switchable;
        public CloseSwitchCommand(ISwitchable switchable)
        {
            _switchable = switchable;
        }
        public void Execute()
        {
            _switchable.PowerOff();
        }
    }
    public class OpenSwitchCommand:ICommand
    {
        private ISwitchable _switchable;
        public OpenSwitchCommand(ISwitchable switchable)
        {
            _switchable = switchable;
        }
        public void Execute()
        {
            _switchable.PowerOn();
        }
    }

    internal class CommandMain
    {
        public static void test()
        {
            string args = Console.ReadLine();

            ISwitchable lamp = new Light();

            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            Switch sw = new Switch(switchClose, switchOpen);

            if(args.Equals("c"))
            {
                sw.Close();
            }else if(args.Equals("o"))
            {
                sw.Open();
            }else
            {
                Console.WriteLine("error arguments");
            }




            //Console.WriteLine(args);

        }
    }

}
