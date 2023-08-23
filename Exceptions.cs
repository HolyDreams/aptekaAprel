using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptekaAprel
{
    internal class Exceptions
    {
        public static void Process(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            var discord = new DiscordWebHook();
            discord.SendMessage(ex.Message);
        }
    }
}
