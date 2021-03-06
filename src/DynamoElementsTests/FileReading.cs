﻿using System.IO;
using Dynamo.Models;
using Dynamo.Tests;
using Dynamo.Utilities;
using NUnit.Framework;

namespace Dynamo.Tests
{
    [TestFixture]
    class FileReadingTests : DynamoUnitTest
    {
        string localDynamoStringTestFloder { get { return Path.Combine(GetTestDirectory(), "core", "files"); } }

        [Test]
        public void CanOpenADynFileFromBefore6_0()
        {
            DynamoModel model = Controller.DynamoModel;
            string testFilePath = Path.Combine(localDynamoStringTestFloder, "fileTests_pre6_0.dyn");

            model.Open(testFilePath);
            Assert.DoesNotThrow(() => dynSettings.Controller.RunExpression(null)); 
        }

        [Test]
        public void CanOpenADynFileFromAfter6_0()
        {
            DynamoModel model = Controller.DynamoModel;
            string testFilePath = Path.Combine(localDynamoStringTestFloder, "fileTests_post6_0.dyn");

            model.Open(testFilePath);
            Assert.DoesNotThrow(() => dynSettings.Controller.RunExpression(null));
        }
    }
}
