using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class TransactionsHistoryResponse : CommonResponse
{
public List<MiniTrade> Transactions {get; set; } 
}
}

