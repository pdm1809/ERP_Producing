using Microsoft.AspNetCore.Mvc;
using SampleProject.Business.Abstractions;
using SampleProject.Shared.Requests;
using SampleProject.Shared.Requests.AAColumnAliases;
using SampleProject.Shared.Responses;
using SampleProject.Shared.Responses.AAColumnAliases;
using System.Net;

namespace SampleProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AAColumnAliasController : ControllerBase<IAAColumnAliasBusiness>
    {
        public AAColumnAliasController(IAAColumnAliasBusiness business) : base(business)
        {
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ActionResponse<AAColumnAliasResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(FailActionResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetByIdSP(int id)
        {
            var response = await _business.GetByIdSP(id);
            return CreateOkForResponse(response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ActionResponse<PagedResult<AAColumnAliasResponse>>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(FailActionResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAll([FromQuery] BaseGetAllRequest request)
        {
            var response = await _business.GetAll(request);
            return CreateOkForResponse(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ActionResponse<AAColumnAliasResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(FailActionResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Insert(AAColumnAliasRequest request)
        {
            var response = await _business.Insert(request);
            return CreateOkForResponse(response);
        }

        [HttpPost("update")]
        [ProducesResponseType(typeof(ActionResponse<AAColumnAliasResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(FailActionResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Update(UpdateAAColumnAliasRequest request)
        {
            var response = await _business.Update(request);
            return CreateOkForResponse(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ActionResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(FailActionResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            await _business.Delete(id);
            return CreateOk();
        }
    }
}
