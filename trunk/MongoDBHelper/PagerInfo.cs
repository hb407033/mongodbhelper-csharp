﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDBHelper
{
    public class PagerInfo
    {
        int _Page = 1;//当前页
        int _PageSize = 10;
        public int Page { get { return _Page; } set { _Page = value; } }
        public int PageSize { get { return _PageSize; } set { _PageSize = value; } }
    }
}
