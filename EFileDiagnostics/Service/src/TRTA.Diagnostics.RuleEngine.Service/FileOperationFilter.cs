using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Linq;

namespace TRTA.Diagnostics.RuleEngine.Service
{
    public class FileOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (context.ApiDescription.ParameterDescriptions.Any(x => x.ModelMetadata.ModelType == typeof(IFormFile)))
            {
                operation.Parameters.Clear();

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "Accept",
                    In = ParameterLocation.Header,
                    Description = "Indicate the media type response that can be accepted - application / json is currently the only option.",
                    Required = true

                });
                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Description = "Insert the token",
                    Required = true
                });

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "file", // must match parameter name from controller method
                    Description = "Upload file (must be .xlsx - Excel document)",
                    Required = true
                });
            }
        }
    }
}
