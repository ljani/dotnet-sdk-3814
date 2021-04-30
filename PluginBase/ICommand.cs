using System.Collections.Generic;
using System.CommandLine;
using Microsoft.Extensions.DependencyInjection;

namespace PluginBase
{
    public interface ICommand
    {
        string Name { get; }
        string Description { get; }

        int Execute();

        public void ConfigureServices(IServiceCollection services);

        public IEnumerable<Option> CreateConfigureOptions();
    }
}
