using System;
using DI.Interfaces;
namespace DI.Services
{
    public class ExampleSingletonService : IExampleSingletonService
    {
        private readonly Guid Id;

        public ExampleSingletonService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid() => Id.ToString();
    }
}
