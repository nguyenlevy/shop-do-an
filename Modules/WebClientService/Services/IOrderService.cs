using Core.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebClientService.Models;
using WebClientService.Models.Dto;

namespace WebClientService.Services
{
   public interface IOrderService
    {
        Task<ApiJsonResult> Create(Order data);
    }
}
