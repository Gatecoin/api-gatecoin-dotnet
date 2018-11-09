using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Reference/QuickChangeCurrency", "Get", Summary = @"Get the available currency in quick change.", Notes = @"")]
public class GetQuickChangeCurrency : IReturn<GetQuickChangeCurrencyResponse>
{
}
}

