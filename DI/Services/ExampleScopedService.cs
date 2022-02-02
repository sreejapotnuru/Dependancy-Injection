using System;
using DI.Interfaces;
namespace DI.Services
{
    public class ExampleScopedService : IExampleScopedService
    {

        private readonly Guid Id;

        public ExampleScopedService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid() => Id.ToString();
    }
}
