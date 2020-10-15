using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Data;
using WePrint.Models;

namespace WePrint.Mappings
{
    public class Maps : Profile
    {

        public Maps()
        {
            CreateMap<Customer, CustomerVm>().ReverseMap();
            CreateMap<Account, AccountVm>().ReverseMap();
            CreateMap<Cart, CartVM>().ReverseMap();
            CreateMap<Category, CategoryVm>().ReverseMap();
            CreateMap<Chat, ChatVm>().ReverseMap();
            CreateMap<Order, OrderVm>().ReverseMap();
            CreateMap<Product, ProductVm>().ReverseMap();

        }
    }
}
