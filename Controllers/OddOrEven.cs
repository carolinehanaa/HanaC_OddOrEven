/*Caroline Hana
10-26-2022
Odd or even, the console will display if the number is even or odd
Peer Review : Carlos Felipe - This program works great. It takes in any number and tells me if it's odd or even. The code is formatted and named correctly. 
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HanaC_OddOrEven.Controllers
{
    [Route("[controller]")]
    public class OddOrEven : Controller
    {
        [HttpGet]
        [Route("OddOrEven/{number}")]

        public string OddEven(int number)
        {
            int remainder = number % 2;
            string result = "";
            if (remainder == 0)
            {
                result = $"{number} is an even number";
            }
            else
            {
                result = $"{number} is an odd number";
            }

            return result;


        }
    }
}