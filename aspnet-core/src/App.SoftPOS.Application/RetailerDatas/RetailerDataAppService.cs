using App.SoftPOS.MTIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace App.SoftPOS.RetailerDatas
{
    public class RetailerDataAppService : CrudAppService<RD_Seg01, RD_Seg01Dto, string>, IRetailerData01
    {
        private readonly IRepository<RD_Seg01, string> _RD_Seg01Repository;

        public RetailerDataAppService(IRepository<RD_Seg01, string> repository01)
            : base(repository01)
        {
            _RD_Seg01Repository = repository01;
        }

        public async Task GetSeg01(string input)
        {
            var segArray = input.Split(',');
            var RetailerDataSeg01 = new RD_Seg01Dto()
            {
                Id = Guid.NewGuid().ToString("N"),
                NextLoad = segArray[0],
                ReconciliationTime = segArray[1],
                ArabicName = segArray[2],
                EnglishNumber = segArray[3],
                EnglishName = segArray[4],
                LanguageIndicator = segArray[5],
                TerminalCurrencyCode = segArray[6],
                TerminalCountryCode = segArray[7],
                TransactionCurrencyExponent = segArray[8],
                CurrencySymbolArabic = segArray[9],
                CurrencySymbolEnglish = segArray[10],
                ReceiptArabic01 = segArray[11],
                ReceiptArabic02 = segArray[12],
                ReceiptEnglish01 = segArray[13],
                ReceiptEnglish02 = segArray[14],
                Category_ID = "41055277-cce8-37d7-bb37-39f62806960b",
                Segment_ID = "00000621-RD-Seg"
            };
            try
            {
                var seg = ObjectMapper.Map<RD_Seg01Dto, RD_Seg01>(RetailerDataSeg01);
                await _RD_Seg01Repository.InsertAsync(seg);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message);
            }
        }
    }
}
