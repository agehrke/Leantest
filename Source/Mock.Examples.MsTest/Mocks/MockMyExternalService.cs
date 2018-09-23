using System;
using System.Collections.Generic;
using System.Linq;
using ExampleApp.Domain;
using LeanTest.Core.ExecutionHandling;
using LeanTest.Mock;
using Mock.Examples.MsTest.Application;

namespace Mock.Examples.MsTest.Mocks
{
    internal class MockMyExternalService : IMockForDataWithContextBuilder<MyData>, IMockForDataWithContextBuilder<MyOtherData>, IMyExternalService
    {
        private List<MyData> MyData { get; } = new List<MyData>();

        public int GetAge(string key) => MyData.First().Age;

        public ContextBuilder WithData(MyOtherData data) => ContextBuilderFactory.ContextBuilder; // TODO: Get from IoC?
        public void PreBuild() { }
        public void Build(Type type) { }
        public void PostBuild() {}
        public ContextBuilder WithData(MyData data)
        {
            MyData.Add(data);
            return ContextBuilderFactory.ContextBuilder;
        }
    }
}
