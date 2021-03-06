﻿namespace TarkDDD.Domain.Validations
{
    public class ValidationError 
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }
        
        public ValidationError()
        {
        }

        public ValidationError(int statusCode, string errorMessage)
        {
            Message = errorMessage;
            StatusCode = statusCode;
        }

        public ValidationError(int statusCode)
        {
            StatusCode = statusCode;
        }

        public ValidationError(string errorMessage)
        {
            Message = errorMessage;
        }
    }
}
