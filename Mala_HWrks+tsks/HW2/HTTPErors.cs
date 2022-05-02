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
            HttpErrors myError; //= HttpErrors.BadRequest;
            switch (num)
            {
                case (int)HttpErrors.BadRequest:
                    Console.WriteLine(myError = HttpErrors.BadRequest);
                    break;
                case (int)HttpErrors.Unauthorized:
                    Console.WriteLine(myError = HttpErrors.Unauthorized);
                    break;

                default:
                    break;
            }
        }
    }
}
