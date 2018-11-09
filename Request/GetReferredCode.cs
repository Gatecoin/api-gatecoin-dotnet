using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/ReferredCode", "GET", Summary = @"Get referral code", Notes = @"")]
public class GetReferredCode : IReturn<ReferredCodeResponse>
{
}
}

