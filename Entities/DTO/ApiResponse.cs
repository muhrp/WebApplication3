using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entities.DTO
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            Success = true;
        }

        public bool Success { get; set; }
        public dynamic? Data { get; set; }
        public int Total { get; set; }
        public string? Message { get; set; }
    }

    public static class Constant
    {
        public static bool ShowError = true;
    }

    public class BadRequestError : ApiResponse
    {
        public BadRequestError(Exception ex)
        {
            Success = false;
            Message = Constant.ShowError ? ex.Message : "Request Gagal";
        }
    }
}
