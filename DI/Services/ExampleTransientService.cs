using DI.Interfaces;
using System;
namespace DI.Services
{
    public class ExampleTransientService : IExampleTransientService
    {
        private readonly Guid Id;

        public ExampleTransientService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid() => Id.ToString();
    }
}
