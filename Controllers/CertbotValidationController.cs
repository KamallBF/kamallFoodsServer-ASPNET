using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Controllers
{
    public class CertbotValidationController: ControllerBase
    {
        private string CertbotId =
            "lkLH7CnpxfWa04eniDgIz-AzZJ0eewFlfIF1BbZcI-g.gfd9Nl-_3_6aXPsWYFkDGev_yZ5uKKUE0qj2jAVUTnU";
        
        [AllowAnonymous]
        [HttpGet]
        [Route(".well-known/acme-challenge/{id}")]
        public ActionResult LetsEncryptValidation([FromRoute] string id)
        {
            return Ok(id + "." + CertbotId);
        }
    }
}