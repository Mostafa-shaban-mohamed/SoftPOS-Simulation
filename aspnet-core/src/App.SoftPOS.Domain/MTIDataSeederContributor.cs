using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.SoftPOS.Categories;
using App.SoftPOS.MTIs;
using App.SoftPOS.PosTerminals;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace App.SoftPOS
{
    public class MTIDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<MTI, Guid> _mtiRepo;
        private readonly IRepository<PosTerminal, string> _posTerminalRepo;

        public MTIDataSeederContributor(IRepository<MTI, Guid> mtiRepo, IRepository<PosTerminal, string> posTerminalRepo)
        {
            _mtiRepo = mtiRepo;
            _posTerminalRepo = posTerminalRepo;
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
            if(await _posTerminalRepo.GetCountAsync() <= 0)
            {
                await _posTerminalRepo.InsertAsync(
                    new PosTerminal
                    {
                        Terminal_ID = "00000621"
                    },
                    autoSave: true
                );
            }
        }
    }
}