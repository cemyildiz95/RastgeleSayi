using System;
using System.Threading;
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
            var sleepTime = Environment.GetEnvironmentVariable("WAIT_TIME") ?? "2";

            Thread.Sleep(Int32.Parse(sleepTime) * 1000);
            var number = rand.Next(101);
            string result = "{ lowerLimit: 0 , higherLimit: 100 , number: " + number +" }";

            return result;
        }
    }
}
