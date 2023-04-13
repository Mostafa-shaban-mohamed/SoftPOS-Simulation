using App.SoftPOS.AIDDatas;
using App.SoftPOS.AIDLists;
using App.SoftPOS.CardSchemas;
using App.SoftPOS.DeviceSpecifics;
using App.SoftPOS.MessageTexts;
using App.SoftPOS.PublicKeys;
using App.SoftPOS.RetailerDatas;
using App.SoftPOS.RevokeCertificates;
using App.SoftPOS.TerminalConnections;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.SoftPOS.Segment
{
    public class SegmentDto
    {
        public RD_Seg01Dto RD_Seg01Dtos { get; set; }
        public RD_Seg02Dto RD_Seg02Dtos { get; set; }
        public RD_Seg03Dto RD_Seg03Dtos { get; set; }
        public RD_Seg04Dto RD_Seg04Dtos { get; set; }

        public CS_Seg01Dto CS_Seg01Dtos { get; set; }
        public CS_Seg02Dto CS_Seg02Dtos { get; set; }
        public CS_Seg03Dto CS_Seg03Dtos { get; set; }

        public MT_Seg01Dto MT_Seg01Dtos { get; set; }

        public PK_Seg01Dto PK_Seg01Dtos { get; set; }

        public TC_Seg01Dto TC_Seg01Dtos { get; set; }

        public DS_Seg01Dto DS_Seg01Dtos { get; set; }

        public AL_Seg01Dto AL_Seg01Dtos { get; set; }

        public AD_Seg01Dto AD_Seg01Dtos { get; set; }

        public RC_Seg01Dto RC_Seg01Dtos { get; set; }
    }
}
