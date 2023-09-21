﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FreeCourse.Shared.Dtos
{
    public class ResponseDto<T>
    {
        public T Data { get; private set; }

        [JsonIgnore]
        public int StatusCode { get; private set; }
        [JsonIgnore]
        public bool IsSuccessful { get; private set; }
        public List<string> Errors { get; set; }

        //Static Factory Method
        public static ResponseDto<T> Success(T data,int statusCode)
        {
            return new ResponseDto<T> { Data = data, StatusCode = statusCode,IsSuccessful=true };
        }
        public static ResponseDto<T> Success(int statusCode)
        {
            return new ResponseDto<T> { Data = default(T), StatusCode = statusCode, IsSuccessful = false };
        }
        public static ResponseDto<T> Fail(int statusCode, params string[] erros)
        {
            return new ResponseDto<T> {Data=default, Errors = erros.ToList(), StatusCode = statusCode,IsSuccessful = false };            
        }
        public static ResponseDto<T> Fail(string error, int statusCode)
        {
            return new ResponseDto<T> { Errors = new List<string> { error}, StatusCode = statusCode, IsSuccessful = false };
        }

    }
}