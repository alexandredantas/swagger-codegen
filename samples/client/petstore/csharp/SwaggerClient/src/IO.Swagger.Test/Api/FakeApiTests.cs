using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing FakeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FakeApiTests
    {
        private FakeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new FakeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FakeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
			Assert.IsInstanceOfType(typeof(FakeApi), instance, "instance is a FakeApi");
        }

        
        /// <summary>
        /// Test TestEndpointParameters
        /// </summary>
        [Test]
        public void TestEndpointParametersTest()
        {
			/* comment out the following as the endpiont is fake
            // TODO: add unit test for the method 'TestEndpointParameters'
            double? number = 12.3; // TODO: replace null with proper value
            double? _double = 34.5; // TODO: replace null with proper value
            string _string = "charp test"; // TODO: replace null with proper value
			byte[] _byte = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };; // TODO: replace null with proper value
            int? integer = 3; // TODO: replace null with proper value
            int? int32 = 2; // TODO: replace null with proper value
            long? int64 = 1; // TODO: replace null with proper value
            float? _float = 7.8F; // TODO: replace null with proper value
            byte[] binary = null; // TODO: replace null with proper value
			DateTime? date = null; // TODO: replace null with proper value
            DateTime? dateTime = null; // TODO: replace null with proper value
            string password = null; // TODO: replace null with proper value
            instance.TestEndpointParameters(number, _double, _string, _byte, integer, int32, int64, _float, binary, date, dateTime, password);
			*/
            
        }
        
    }

}
