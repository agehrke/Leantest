﻿using System;
using Core.Examples.MsTest.Domain;
using LeanTest.Core.ExecutionHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Json.Examples.MsTest.TestSetup
{
    [TestClass]
    public static class AssemblyInitializer
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            var iocFactory = new Func<IIocContainer>(() => new MyOwnIoC());

            ContextBuilderFactory.Initialize(CleanContextMode.ReCreate, iocFactory);
        }
    }
}
