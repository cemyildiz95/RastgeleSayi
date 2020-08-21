using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RastgeleSayi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Number : ControllerBase
    {
        [HttpGet]
        public string RastgeleSayi()
        {
            var rand = new Random();
            var sleepTime = Environment.GetEnvironmentVariable("WAIT_TIME");

            Thread.Sleep(Int32.Parse(sleepTime) * 1000);
            var number = rand.Next(101);
            string result = $"lowerLimit: 0 , higherLimit: 100 number: {number}";

            return result;
        }
    }
}
