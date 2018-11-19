﻿using System;
using System.Collections.Generic;
using System.Text;
using Shoko.Models.Enums;
using Shoko.Models.Server.CrossRef;

namespace Shoko.Models.WebCache
{
    public class WebCache_CrossRef_AniDB_Provider 
    {
        public int WebCache_AniDB_ProviderID { get; set; }
        public int AnimeID { get; set; }
        public string CrossRefID { get; set; }
        public CrossRefSource CrossRefSource { get; set; }
        public CrossRefType CrossRefType { get; set; }
        public string EpisodesOverrideData { get; set; }
        public bool IsAdditive { get; set; }
        public int AniDBUserId { get; set; }
        public WebCache_ReliabilityType Type { get; set; }
        public int PopularityCount { get; set; }
    }
}
