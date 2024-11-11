﻿namespace Microservices.Web.Models
{
    public class ResponseDto
    {
        public bool isSuccess { get; set; } = true;
        public string Message { get; set; } = "";
        public object? Result { get; set; }
    }
}