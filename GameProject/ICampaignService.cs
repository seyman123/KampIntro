﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface ICampaignService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
