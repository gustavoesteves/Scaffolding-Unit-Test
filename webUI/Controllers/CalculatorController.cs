using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoLibrary;

namespace webUI.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        [HttpGet("[action]/{FirstNumber}/{SecondNumber}/{Calc}")]
        public double GetCalc(double FirstNumber, double SecondNumber, string Calc)
        {
            double result = 0;

            switch (Calc)
            {
                case "Subtract":
                    result = Calculator.Subtract(FirstNumber, SecondNumber);
                    break;
                case "Multiply":
                    result = Calculator.Multiply(FirstNumber, SecondNumber);
                    break;
                case "Divide":
                    result = Calculator.Divide(FirstNumber, SecondNumber);
                    break;
                default:
                    result = Calculator.Add(FirstNumber, SecondNumber);
                    break;
            }

            return result;
        }
    }
}