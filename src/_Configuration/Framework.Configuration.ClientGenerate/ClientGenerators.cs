﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

using Framework.DomainDriven.DTOGenerator.Client;
using Framework.DomainDriven.FacadeServiceProxyGenerator;
using Framework.DomainDriven.Generation;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using FileInfo = Framework.DomainDriven.Generation.FileInfo;

namespace Framework.Configuration.ClientGenerate
{
    [TestClass]
    public partial class ClientGenerators
    {
        [TestMethod]
        public void GenerateMainTest()
        {
            this.GenerateMain().ToList();
        }

        public IEnumerable<FileInfo> GenerateMain()
        {
            return this.GenerateClientDTO()
                       .Concat(this.GenerateMainFacade());
        }

        [TestMethod]
        public void GenerateClientDTOTest()
        {
            this.GenerateClientDTO().ToList();
        }

        private IEnumerable<FileInfo> GenerateClientDTO()
        {
            var generator = new ClientFileGenerator(this.Environment.ClientDTO);

            var outputPath = Path.Combine(this.GeneratePath, @"_Configuration\Framework.Configuration.Generated.DTO.Silverlight");

            yield return generator.GenerateSingle(outputPath, "Configuration.Generated", this.CheckOutService);
        }

        [TestMethod]
        public void GenerateMainFacadeTest()
        {
            this.GenerateMainFacade().ToList();
        }

        private IEnumerable<FileInfo> GenerateMainFacade()
        {
            var generator = new FacadeServiceProxyGeneratorFileGenerator(this.Environment.MainFacadeServiceProxy);

            var outputPath = Path.Combine(this.GeneratePath, @"_Configurator\Configurator.Client.Context.Services.Configuration");

            return generator.GenerateFacadeServiceProxy(outputPath, "Configuration.generated", this.CheckOutService);
        }
    }
}
