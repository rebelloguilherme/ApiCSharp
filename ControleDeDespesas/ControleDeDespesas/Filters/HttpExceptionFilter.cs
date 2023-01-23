using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeDespesas.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ControleDeDespesas.Filters
{
    public class HttpExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order => -10;

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is ValidationException ex)
            {
                context.Result = new ObjectResult(new
                {
                    Field = ex.Field,
                    Message = ex.Message
                })
                {
                    StatusCode = 400
                };
                context.ExceptionHandled = true;

            }

            // if (context.Exception != null)
            // {
            //     context.Result = new ObjectResult("Infelizmente ocorreu um erro em nossos servidores")
            //     {
            //         StatusCode = 500
            //     };
            // }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}