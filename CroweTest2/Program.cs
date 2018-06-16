using System;
using System.Collections.Generic;
using System.Configuration;
using Output;

namespace CroweTest
{
    class Program
    {

        static void Main()
        {

            MessageOutput myMessage = new MessageOutput();
            myMessage.SetMessage(ConfigurationSettings.AppSettings["Message"]);

            switch (ConfigurationSettings.AppSettings["Strategy"])
            {

                case "Database":

                    myMessage.SetOutputStrategy(new DatabaseOutput());
                    break;

                case "File":

                    myMessage.SetOutputStrategy(new FileOutput());

                    break;

                case "Console":

                default:

                    myMessage.SetOutputStrategy(new ConsoleOutput());

                    break;

            }

            string result = myMessage.Output();          

            Console.ReadKey();

        }

    }

}









/*       

//app.config

<?xml version="1.0"?>

<configuration>

  <startup>

    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/>

  </startup>

  <appSettings>

    <add key="Message" value="Hello World" />

    <add key="Strategy" value="Console" />

  </appSettings>

</configuration>

*/


