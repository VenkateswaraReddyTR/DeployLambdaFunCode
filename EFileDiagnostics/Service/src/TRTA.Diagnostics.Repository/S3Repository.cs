using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Repository
{
    public class S3Repository : IFileRepository
    {
        private IAmazonS3 _client = null;
        private ILogger<S3Repository> _logger;
        private IConfiguration _configuration;

        public S3Repository(ILogger<S3Repository> logger, IConfiguration config)
        {
            _logger = logger;
            _configuration = config;
            if (_client == null)
            {
                _logger.LogInformation($"S3 end point is {config["S3endpoint"]}");
                var endpoint = Amazon.RegionEndpoint.GetBySystemName(config["S3endpoint"]);
                _client = new AmazonS3Client(endpoint);
            }
        }

        public async Task<bool> PutFileAsync(string path, IFormFile file)
        {
            using (var fileStream = file.OpenReadStream())
            {
                string md5;
                using (var objMd5 = System.Security.Cryptography.MD5.Create())
                {
                    var hash = objMd5.ComputeHash(fileStream);
                    md5 = Convert.ToBase64String(hash);
                    var putRequest = new PutObjectRequest
                    {
                        MD5Digest = md5,
                        BucketName = _configuration["S3bucket"],
                        Key = Path.GetFileName(path),
                        InputStream = fileStream,
                        ContentType = "application/xml"
                    };

                    PutObjectResponse response = await _client.PutObjectAsync(putRequest);
                    return true;
                }
            }
        }
    }
}
