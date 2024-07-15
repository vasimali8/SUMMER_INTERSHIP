using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Helper
{
   
        public static class DateTimeExtensions
        {
            public static DateTime ToUtc(this DateTime dateTime)
            {
                return dateTime.Kind == DateTimeKind.Unspecified
                    ? DateTime.SpecifyKind(dateTime, DateTimeKind.Utc)
                    : dateTime.ToUniversalTime();
            }
        }
    

}
