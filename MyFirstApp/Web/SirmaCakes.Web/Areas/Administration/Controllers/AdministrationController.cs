namespace SirmaCakes.Web.Areas.Administration.Controllers
{
    using SirmaCakes.Common;
    using SirmaCakes.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
