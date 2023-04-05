using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.SoftPOS.MTIs;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace App.SoftPOS
{
    public class MTIDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<MTI, Guid> _mtiRepo;

        public MTIDataSeederContributor(IRepository<MTI, Guid> mtiRepo)
        {
            _mtiRepo = mtiRepo;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _mtiRepo.GetCountAsync() <= 0)
            {
                await _mtiRepo.InsertAsync(
                    new MTI
                    {
                        MTI_Code_Req = "1304",
                        MTI_Code_Resp = "1314",
                        Download_Code = "306", //Full Download
                        Response_Code = "3060040" //40 record - temporary until we get all records saved on DB
                    },
                    autoSave: true
                );
            }
        }
    }
}