using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/InternalPayment", "GET", Summary = @"InternalPayment", Notes = @"")]
public class GetInternalPayments : IReturn<GetInternalPaymentsResponse>
{
}
}

