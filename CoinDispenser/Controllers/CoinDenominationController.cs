using CoinDispenser.Attributes;
using CoinDispenser.Context;
using CoinDispenser.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoinDispenser
{
    //a controller for the CoinDispenser Service 
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class CoinDenominationController : ControllerBase
    { 
        //Defining Context for database connection, and transactions
        private CoinDenominationContext _coinContext;

        //Defining Lists to be added coins based on denomination returned on the process
        List<string> coinsToDispenseR5list = new List<string>();
        List<string> coinsToDispenseR2list = new List<string>();
        List<string> coinsToDispenseR1list = new List<string>();
        List<string> coinsToDispense50clist = new List<string>();
        List<string> coinsToDispense20clist = new List<string>();
        List<string> coinsToDispense10clist = new List<string>();
        List<string> coinsToDispense5clist = new List<string>();
        List<string> coinsToDispense2clist = new List<string>();
        List<string> coinsToDispense1clist = new List<string>();

        public CoinDenominationController(CoinDenominationContext coinContext)
        {
            _coinContext = coinContext;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<CoinDenomination> Get()
        {
            return _coinContext.CoinDenominations.ToList();
        }

        // GET api/<CoinDenomination>/5/200
        [HttpGet("{id}/{paidAmount}")]
        public string Get(int id, double paidAmount)
        {
            //Getting denomination values from database using id
            CoinDenomination value = _coinContext.CoinDenominations.FirstOrDefault(s => s.CoinDenominationId == id);
            //using denomination values to assign on new variable as array.
            int[] coins = { value.V1, value.V2, value.V3, value.V4, value.V5, value.V6, value.V7, value.V8, value.V9 };

            //change variable assigned the input value
            double change = paidAmount;
            //multiplying change by 100 so that we can have amount that each coin denomination can be catered.
            //(all the coin denomination values are converted are represented in cents values in database e.g R5 will be 500,
            //if amount enter is R1, we multiply by 100 to get 100c
            change *= 100;
           
            //looping thoough the coin array in reverse order
            // this is to ensure that the process will generate minimum combination of coins
            for (int i = coins.Length-1; i >= 0; i--)
            {
                //checking if change divided by the last item picked first on coin array result in greater than zero, and the change processed is still more than zero
                if (change / coins[i] >= 1 && change > 0)
                { 
                    // defining new variable to get division results (e.g the result might be 10,20)
                    double chg = (change / coins[i]);
                    // convert division result to string ("10,20")
                    string cstr = chg.ToString();
                    //  checking if division result value contain ',' 
                    if (cstr.LastIndexOf(',') > 0)
                    {
                        //if true - we need to take first part of the fraction (e.g 10,20 we will take 10)
                        // because our loop iteration relies on integer and with fractional value is going to give wrong calculation
                        cstr = cstr.Substring(0, cstr.LastIndexOf(','));
                        //  first part of the fraction taken is converted back to integer to be used on the loop,
                        chg = int.Parse(cstr);
                    }
                    //based on the first item from coins array and the results of division,
                    //it will determine how many times we add on the coinsDenominationList for each using this loop
                    for (int j = 0; j < int.Parse(chg.ToString()); j++)
                    {
                        // if statements to check the item from coins array, if it matches the denominations defined
                        // 500=R5, 200=R2,100=R1,50=50c,=20=20c,10=10c,5=5c,2=2c,1=1c
                        // Statement: change -= coins[i] in each IF statements, ensures that the added denomination on the denominationList is subtracted from change value,
                        // so that the goes down to allow other deniminations to be processed(if value is 700, and we subtract 500 as first picked item on coins array,
                        // we will remain with 200, this will allow 200 denomination to process (giving us R2 in the coindenominationList of R2s.
                        if (coins[i] == 500)
                        { 
                            coinsToDispenseR5list.Add("R5");
                            change -= coins[i];
                        }
                        if (coins[i] == 200)
                        {
                            coinsToDispenseR2list.Add("R2");
                            change -= coins[i];
                        }
                        if (coins[i] == 100)
                        {
                            coinsToDispenseR1list.Add("R1");
                            change -= coins[i];
                        }
                        if (coins[i] == 50)
                        {
                            coinsToDispense50clist.Add("50c");
                            change -= coins[i];
                        }
                        if (coins[i] == 20)
                        {
                            coinsToDispense20clist.Add("20c");
                            change -= coins[i];
                        }
                        if (coins[i] == 10)
                        {
                            coinsToDispense10clist.Add("10c");
                            change -= coins[i];
                        }
                        if (coins[i] == 5)
                        {
                            coinsToDispense5clist.Add("5c");
                            change -= coins[i];
                        }
                        if (coins[i] == 2)
                        {
                            coinsToDispense2clist.Add("2c");
                            change -= coins[i];
                        }
                        if (coins[i] == 1)
                        {
                            coinsToDispense1clist.Add("1c");
                            change -= coins[i];
                        }
                    }

                }
             

            }
            
            // Display Summary of change based on the denominations existing in their lists
            string summary =  "\nAmount To Change: " + paidAmount + "" +
                "\n\nSUMMARY OF CHANGE \n";
            if (coinsToDispenseR5list.Count > 0)
            {
                summary += coinsToDispenseR5list.Count + " x R5 Coins dispensed: "+ string.Join(", ", coinsToDispenseR5list.ToArray()) + "\n";
            }
            if (coinsToDispenseR2list.Count > 0)
            {
                summary += coinsToDispenseR2list.Count + " x R2 Coins dispensed: "+ string.Join(", ", coinsToDispenseR2list.ToArray()) + "\n";
            }
            if (coinsToDispenseR1list.Count > 0)
            {
                summary += coinsToDispenseR1list.Count +" x R1 Coins dispensed: "+ string.Join(", ", coinsToDispenseR1list.ToArray()) + "\n";
            }
            if (coinsToDispense50clist.Count > 0)
            {
                summary += coinsToDispense50clist.Count +" x 50c Coins dispensed: "+ string.Join(", ", coinsToDispense50clist.ToArray()) + "\n";
            }
            if (coinsToDispense20clist.Count > 0)
            {
                summary += coinsToDispense20clist.Count +" x 20c Coins dispensed: "+ string.Join(", ", coinsToDispense20clist.ToArray()) + "\n";
            }
            if (coinsToDispense10clist.Count > 0)
            {
                summary += coinsToDispense10clist.Count +" x 10c Coins dispensed: "+ string.Join(", ", coinsToDispense10clist.ToArray()) + "\n";
            }
            if (coinsToDispense5clist.Count > 0)
            {
                summary += coinsToDispense5clist.Count +" x 5c Coins dispensed: "+ string.Join(", ", coinsToDispense5clist.ToArray()) + "\n";
            }
            if (coinsToDispense2clist.Count > 0)
            {
                summary += coinsToDispense2clist.Count +" x 2c Coins dispensed:"+ string.Join(", ", coinsToDispense2clist.ToArray()) + "\n";
            }
            if (coinsToDispense1clist.Count > 0)
            {
                summary += coinsToDispense1clist.Count +" x 1c Coins dispensed: "+ string.Join(", ", coinsToDispense1clist.ToArray())+"\n";
            }

            return summary;
        }

       
    }
}
