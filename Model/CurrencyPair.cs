﻿using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class CurrencyPair 
{
public System.String Name {get; set; } 
public System.String TradingCode {get; set; } 
}
}

