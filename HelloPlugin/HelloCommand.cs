using System;
using System.Collections.Generic;
using System.CommandLine;
using Microsoft.Extensions.DependencyInjection;
using ICommand = PluginBase.ICommand;

namespace HelloPlugin
{
    public class HelloCommand : ICommand
    {
        public string Name { get => "hello"; }
        public string Description { get => "Displays hello message."; }

        public int Execute()
        {
            Console.WriteLine("Hello !!!");
            return 0;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Option> CreateConfigureOptions()
        {
            throw new NotImplementedException();
        }
    }
}
