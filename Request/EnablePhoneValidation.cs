using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/PhoneValidation", "POST", Summary = @"Enable phone validation", Notes = @"If authCode is empty, system will send an authCode the user's phone number. When user receive the code, call this funcion again with the code.")]
public class EnablePhoneValidation : IReturn<CommonResponse>
{
[ApiMember(Name = "IsEnable", Description = "Enable or disable phone validation", ParameterType = "query", DataType = "bool", IsRequired = true)]
public Boolean IsEnable {get; set; } 
[ApiMember(Name = "Password", Description = "Require password confirmation to disable phone validation", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Password {get; set; } 
[ApiMember(Name = "AuthCode", Description = "The code shown on the phone", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String AuthCode {get; set; } 
}
}

