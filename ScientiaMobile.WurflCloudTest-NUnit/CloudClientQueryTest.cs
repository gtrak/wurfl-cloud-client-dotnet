﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ScientiaMobile.WurflCloud.Config;
using ScientiaMobile.WurflCloud;
using ScientiaMobile.WurflCloud.Cache;


namespace ScientiaMobile.WurflCloudTest_NUnit
{
    [TestClass]
    public class CloudClientQueryTest
    {
        [TestMethod]
        public void testClient()
        {
            var ua = "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en-US) AppleWebKit/534.8+ (KHTML, like Gecko) Version/6.0.0.466 Mobile Safari/534.8+";

            var config = new DefaultCloudClientConfig
            {
                ApiKey = "XXXXXX:YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY"
            };

            var cache = new NoWurflCloudCache();

            var manager = new CloudClientManager(config,cache);

            var capabilities = new string[0];

            WurflCloud.Device.DeviceInfo di = manager.GetDeviceInfo(ua, capabilities);

            Assert.AreEqual(0, di.Errors.Count);
        }
    }
}
