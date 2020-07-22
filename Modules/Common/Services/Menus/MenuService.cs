﻿using Authentication.Core;
using AutoMapper;
using Common.Modes.Menu;
using Common.Modes.Menu.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Services.Menus
{
    public class MenuService : IMenuService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkCommon _unitOfWork;
        public MenuService(
            IUnitOfWorkCommon unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<MenuDto>> GetMenusByUserRoles(MenuFilter menuFilter)
        {
            var menuOrigins = await _unitOfWork.MenuRepository.FindAll().AsNoTracking().ToListAsync();
            var menuFilters = menuOrigins.Where(r => !r.Parent.HasValue).OrderBy(r => r.OrderNumber).ToList();
            return GetMenuByParent(menuOrigins, menuFilters);
        }

        private List<MenuDto> GetMenuByParent(List<Menu> menuOrigins, List<Menu> menuFilters)
        {
            var menus = new List<MenuDto>();
            foreach (var menuFilter in menuFilters)
            {
                var menu = _mapper.Map<MenuDto>(menuFilter);
                var subMenus = menuOrigins.Where(r => r.Parent.HasValue && r.Parent.Value == menuFilter.Id)
                    .OrderBy(r => r.OrderNumber).ToList();
                if (subMenus.Any())
                {
                    menu.Items = GetMenuByParent(menuOrigins, subMenus);
                }
                menus.Add(menu);
            }
            return menus;
        }
        public List<MenuDto> GetMenuByParent()
        {

            var listParentMenu = _unitOfWork.MenuRepository.FindAll().Where(x => x.Parent == 0).ToList();
            var listMenu = _unitOfWork.MenuRepository.FindAll().ToList();
            var query = (from s in listParentMenu
                         select new MenuDto
                         {
                             Id = s.Id,
                             Label = s.Label,
                             RouterLink=s.RouterLink,
                             Items = (from c in listMenu
                                      where s.Id == c.Parent
                                      select new MenuDto
                                      {
                                          RouterLink = c.RouterLink,
                                          Label = c.Label,
                                      }).ToList(),
                         }).ToList();
            return query;
        }

    }
}
