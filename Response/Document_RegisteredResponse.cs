using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class Document_RegisteredResponse : CommonResponse
{
public DocumentStatus Status {get; set; } 
}
}

