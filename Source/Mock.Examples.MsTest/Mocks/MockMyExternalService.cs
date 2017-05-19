using System;
using System.Linq;
using LeanTest.Mock;
using Mock.Examples.MsTest.Application;
using Mock.Examples.MsTest.Domain;

namespace Mock.Examples.MsTest.Mocks
{
    public interface ITypedData<T>
    {
    }

    public static class TypedDataExtensions
    {
        public static void WithData<T>(this ITypedData<T> theThis, T theT)
        { }
    }

    internal class MockMyExternalService : ITypedData<MyData>, IMockForData<MyData>, IMyExternalService
    {
        public int GetAge(string key)
        {
            return 42;
        }

        public void Clear(Type type)
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }

        public void WithData(MyData theT) => (this as IMockForData<MyData>).WithData(theT);
    }
}
