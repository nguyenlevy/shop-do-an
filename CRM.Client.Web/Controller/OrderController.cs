using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Core;
using Core.Core.Helper;
using Microsoft.AspNetCore.Mvc;
using WebClientService.Models;
using WebClientService.Services;

namespace Sales.Controller
{
	[Route("api/Orders")]
	[ApiController]
	public class OrderController : ControllerBase
    {
		private readonly IOrderService _orderService;
		private readonly LogService _logService;
		public OrderController(
			IOrderService orderService,
			LogService logService)
		{
			_orderService = orderService;
			_logService = logService;
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] Order data)
		{
			const string loggerHeader = "Create Contact -";
			_logService.Info($"{loggerHeader} Start");
			var result = new ApiJsonResult();
			try
			{
				result.Data = await _orderService.Create(data);
			}
			catch (Exception ex)
			{
				_logService.Error($"{loggerHeader} Throw error {ex.Message}");
				result.Code = CodeModel.Fail;
				result.Message = ex.Message;
			}

			return Ok(result);
		}
	}
}
