using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Level", "GET", Summary = @"Get verif level of logged in user", Notes = @"")]
public class GetVerifLevel : IReturn<VerifLevelResponse>
{
}
}

