using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/ConnectionHistory", "GET", Summary = @"Gets connection history of logged in user", Notes = @"")]
public class GetConnectionHistory : IReturn<ConnectionHistoryResponse>
{
}
}

