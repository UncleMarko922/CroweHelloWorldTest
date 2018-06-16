using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    abstract class OutputStrategy
    {

        public abstract string Output(string msg);

    }

    class ConsoleOutput : OutputStrategy
    {

        public override string Output(string msg)
        {

            Console.WriteLine(msg);

            return "ConsoleOutput";

        }

    }



    class DatabaseOutput : OutputStrategy
    {

        public override string Output(string msg)
        {

            //can use ConfigurationManager.AppSettings["DBConnectionString"] in the future

            Console.WriteLine("Write " + msg + " to DB here...");

            return "DatabaseOutput";

        }

    }



    class FileOutput : OutputStrategy
    {

        public override string Output(string msg)
        {

            //can use ConfigurationManager.AppSettings["FilePath"] in the future

            Console.WriteLine("Write " + msg + " to File here...");

            return "FileOutput";

        }

    }

    //Would use strategy pattern and act as the API

    class MessageOutput
    {

        private string _msg;

        private OutputStrategy _outputstrategy;

        public void SetOutputStrategy(OutputStrategy outputstrategy)
        {

            this._outputstrategy = outputstrategy;

        }

        public void SetMessage(string msg)
        {

            _msg = msg;

        }

        public string Output()
        {

            return _outputstrategy.Output(_msg);

        }

    }

}

