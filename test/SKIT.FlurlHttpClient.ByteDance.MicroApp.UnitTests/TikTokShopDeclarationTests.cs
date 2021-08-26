﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    public class MicroAppDeclarationTests
    {
        private static readonly Assembly _assembly = Assembly.Load("SKIT.FlurlHttpClient.ByteDance.MicroApp");

        [Fact(DisplayName = "验证 API 模型命名")]
        public void ApiModelsNamingTest()
        {
            CodeStyleUtil.VerifyApiModelsNaming(_assembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 模型定义")]
        public void ApiModelsDefinitionTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectTestDirectory, "ModelSamples");
            Assert.True(Directory.Exists(workdir));

            CodeStyleUtil.VerifyApiModelsDefinition(_assembly, workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 事件定义")]
        public void ApiEventsDefinitionTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectTestDirectory, "EventSamples");
            Assert.True(Directory.Exists(workdir));

            CodeStyleUtil.VerifyApiEventsDefinition(_assembly, workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 接口命名")]
        public void ApiExtensionsNamingTest()
        {
            CodeStyleUtil.VerifyApiExtensionsNaming(_assembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证代码规范")]
        public void CodeStyleTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectSourceDirectory);
            Assert.True(Directory.Exists(workdir));

            CodeStyleUtil.VerifySourceCodeStyle(workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }
    }
}
