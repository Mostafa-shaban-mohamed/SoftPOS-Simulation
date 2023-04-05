using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.SoftPOS.DownloadParameters;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace App.SoftPOS
{
    public class DownloadParameterDataSeederContributor: IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<DownloadParameter, Guid> _downloadParamRepo;

        public DownloadParameterDataSeederContributor(IRepository<DownloadParameter, Guid> downloadParamRepo)
        {
            _downloadParamRepo = downloadParamRepo;
        }

        public async Task SeedAsync(DataSeedContext context){
            if(await _downloadParamRepo.GetCountAsync() <= 0){
                await _downloadParamRepo.InsertAsync(
                    new DownloadParameter{
                        RecordNumber = "306000140"
                    }
                );
                await _downloadParamRepo.InsertAsync(
                    new DownloadParameter{
                        RecordNumber = "306000240"
                    }
                );
                await _downloadParamRepo.InsertAsync(
                    new DownloadParameter{
                        RecordNumber = "306000340"
                    }
                );
                await _downloadParamRepo.InsertAsync(
                    new DownloadParameter{
                        RecordNumber = "306000440"
                    }
                );
            }
        }
    }
}