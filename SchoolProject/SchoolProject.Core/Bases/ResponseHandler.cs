﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Bases
{
    public class ResponseHandler
    {
        public ResponseHandler()
        {


        }
        public Response<T> Deleted<T>()
        {
            return new Response<T>
            {
                CheckStatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "Deleted Successfully"
            };
        }
        public Response<T> Success<T>(T entity, object Meta = null)
        {
            return new Response<T>
            {
                CheckStatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "Successfully Executed",
                Data = entity,
                Meta = Meta
            };
        }
        public Response<T> Unauthorized<T>()
        {
            return new Response<T>
            {
                CheckStatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeeded = false,
                Message = "UnAuthorized"
            };
        }
        public Response<T> BadRequest<T>(string message = null)
        {
            return new Response<T>
            {
                CheckStatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false,
                Message = message == null ? "Bad Request" : message
            };
        }
        public Response<T> NotFound<T>(string message = null)
        {
            return new Response<T>
            {
                CheckStatusCode = System.Net.HttpStatusCode.NotFound,
                Succeeded = false,
                Message = message == null ? "Not Found" : message
            };
        }
        public Response<T> Created<T>(T entity,object meta=null)
        {
            return new Response<T>
            {
                Data = entity,
                CheckStatusCode = System.Net.HttpStatusCode.Created,
                Succeeded = true,
                Message = "Created Successfully",
                Meta = meta
            };




        }
        public Response<T> unProcessableEntity<T>(string message = null)
        {
            return new Response<T>
            {
                CheckStatusCode = System.Net.HttpStatusCode.UnprocessableEntity,
                Succeeded = false,
                Message = message == null ? "Un processable Entity" : message
            };
        }
    }
}
