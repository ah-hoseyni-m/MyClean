using Application.Interfaces;
using Application.Services;
using Domain.Dto;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presentation.Common;
using System.Threading;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _IOrderService;
    private readonly ILogger<OrderController> logger;

    public OrderController(IOrderService iOrderService,ILogger<OrderController> logger)
    {
        _IOrderService = iOrderService;
        this.logger = logger;
    }

    [HttpPost]
    public async Task<ApiResult<OrderModel>> Create(OrderModel model , CancellationToken cancellationToken)
    {
       
        var res = await _IOrderService.Create(model , cancellationToken);
        return Ok(res);
        //return new ApiResult<OrderModel>
        //{
        //    Data = res,
        //    IsSuccess = true,
        //    Message = "",
        //    StatusCode = ApiResultStatusCode.Success
        //};
    }
    [HttpGet]
    public async Task<ApiResult<OrderVwModel>> GetById(Guid Id)
    {
        logger.LogError("hghfhgh");
        var res = await _IOrderService.GetById(Id);
        if (res == null) { return NotFound(); }
        return res;
        //return new ApiResult<OrderVwModel>
        //{
        //    Data = res,
        //    IsSuccess = true,
        //    Message = "",
        //    StatusCode = ApiResultStatusCode.Success
        //};
    }
}
