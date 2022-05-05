using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class HTTPErors
    {
        public enum HttpErrors
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequerd = 402,
            Forbidden = 403,
            NotFound = 404
        }
        
        public void WhatIsError(int num)
        {
            switch (num)
            {
                case (int)HttpErrors.BadRequest:
                    Console.WriteLine(HttpErrors.BadRequest);
                    break;
                case (int)HttpErrors.Unauthorized:
                    Console.WriteLine(HttpErrors.Unauthorized);
                    break;
                case (int)HttpErrors.PaymentRequerd:
                    Console.WriteLine(HttpErrors.PaymentRequerd);
                    break;
                case (int)HttpErrors.Forbidden:
                    Console.WriteLine(HttpErrors.Forbidden);
                    break;
                case (int)HttpErrors.NotFound:
                    Console.WriteLine(HttpErrors.NotFound);
                    break;
                default:
                    break;
            }
        }
    }
}
