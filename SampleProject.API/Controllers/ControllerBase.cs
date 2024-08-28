﻿using SampleProject.Business.Abstractions;
using SampleProject.Shared.Responses;
using Microsoft.AspNetCore.Mvc;

namespace SampleProject.API.Controllers
{
    public interface IController
    {
        IActionResult CreateOk();
        IActionResult CreateOkForResponse<T>(T result);
    }

    [Produces("application/json")]
    [ApiController]
    public abstract class ControllerBase<TBusiness> : ControllerBase, IController
        where TBusiness : IBusiness
    {
        protected readonly TBusiness _business;

        protected ControllerBase(TBusiness business)
        {
            _business = business;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        public IActionResult CreateOk()
        {
            return Ok(new ActionResponse()
            {
                IsSucceeded = true
            });
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        public IActionResult CreateOkForResponse<T>(T result)
        {
            return Ok(new ActionResponse<T>()
            {
                IsSucceeded = true,
                Data = result
            });
        }
    }

    [Produces("application/json")]
    [ApiController]
    public abstract class Controller<TBusiness> : Controller, IController
        where TBusiness : IBusiness
    {
        protected readonly TBusiness _business;

        protected Controller(TBusiness business)
        {
            _business = business;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        public IActionResult CreateOk()
        {
            return Ok(new ActionResponse()
            {
                IsSucceeded = true
            });
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        public IActionResult CreateOkForResponse<T>(T result)
        {
            return Ok(new ActionResponse<T>()
            {
                IsSucceeded = true,
                Data = result
            });
        }
    }
}
