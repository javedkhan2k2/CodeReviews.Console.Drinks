﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Info.Models
{
	internal class Drink
	{
        public string idDrink { get; set; }
        public string strDrink { get; set; }
    }
	internal class DrinkS
	{
        [JsonProperty("drinks")]
        public List<Drink>DrinksList { get; set; }
    }
}
