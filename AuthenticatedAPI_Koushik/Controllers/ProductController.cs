using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AuthenticatedAPI_Library;
using AuthenticatedAPI_Koushik.Data;
using System.Collections.Generic;
namespace AuthenticatedAPI_Koushik.Controllers;

[Authorize]
[Route("[controller]")]
[ApiController]

public class ProductController : ControllerBase
{

}