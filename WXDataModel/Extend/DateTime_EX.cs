﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXDataModel.Extend
{
    public static class DateTime_EX
    {
        public static string GetTimeParagraph(this DateTime now)
        {
            int temp = now.Hour;
            if (temp >= 18 || temp <= 4)
            {
                return "晚上好";
            }
            if (temp > 4 && temp < 12)
            {
                return "早上好";
            }
            return "下午好";
        }
    }
}
