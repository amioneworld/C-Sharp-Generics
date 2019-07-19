using AutoMapper;
using System;
using System.Collections.Generic;
using static System.Console;

namespace HowToUseAutoMapper
{
    class Program
    {
        //private readonly IMapper _mapper;
        //public Program(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}
         
    
        static void Main(string[] args)
        {
            WriteLine("AutoMapper 8.1.0 Use for Object to Object Mapping");
            WriteLine("-------------------------------------------------");
            WriteLine();

            AutoMapperConfig.Initialize();



            var customers = new Customer()
            {
                Id = 1,
                FirstName = "Git",
                LastName = "Hub",
                Zip = "123456"
            };

        

            var customerDto = Mapper.Map<Customer, CustomerDto>(customers);

            // Now, We can only expose CustomerDto objects with basic details

            WriteLine($"Customer Id: {customerDto.Id}");
            WriteLine($"Customer Name: {customerDto.Name}");
            WriteLine($"Customer Zip: {customerDto.Zip}");


            var Order = new Order()
            {
                Id = 1001,
                OrderDate = DateTime.Now,
                Item = new  LineItem()
                { 
                        Id = 2001,
                        Name = "4K Television",
                        Cost = 1200
                }
            };

            // Now, We can only expose OrderDto objects with minimal details

            var orderDto = Mapper.Map<Order, OrderDto>(Order);

             
            WriteLine();
            WriteLine("Customer Orders");
            WriteLine($"Order Id: {orderDto.OrderId}, Order Date: {orderDto.OrderDate}");
            WriteLine();
            WriteLine("Line Item");

           
             WriteLine($"Item Id: {orderDto.ItemId} - {orderDto.ItemName} - {orderDto.ItemCost:C}");
             
        }
    }
}
