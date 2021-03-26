using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;

namespace Rohm.Pricer
{
    internal class ApiClient
    {
        //https://www.infoworld.com/article/3198673/when-to-use-webclient-vs-httpclient-vs-httpwebrequest.html

        private readonly string _baseUrl;
        internal ApiClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        internal TOut Request<TOut>(Methods method, string route, object data = default)
            where TOut : class
        {

            var request = WebRequest.Create($"{_baseUrl}/{route}");
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Method = method.ToString();
            request.Headers.Add("content-type", "application/json");

            if (data == null)
            {
                using (var requestStream = request.GetRequestStream())
                {
                    string jsonData = JsonConvert.SerializeObject(data);
                    byte[] requestBody = Encoding.Default.GetBytes(jsonData);
                    requestStream.Write(requestBody, 0, requestBody.Length);
                }
            }

            using (var httpResponse = (HttpWebResponse)request.GetResponse())
            {
                if (httpResponse.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedException();
                }

                if (httpResponse.StatusCode == HttpStatusCode.Forbidden)
                {
                    throw new ForbiddenException();
                }

                if (httpResponse.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new NotFoundExcecption();
                }

                if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                {
                    throw new BadRequestException();
                }

                if (httpResponse.StatusCode == HttpStatusCode.InternalServerError)
                {
                    throw new InternalServerErrorException();
                }

                if (httpResponse.StatusCode == HttpStatusCode.NoContent)
                {
                    throw new NoContentException();
                }

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return JsonConvert.DeserializeObject<TOut>(streamReader.ReadToEnd());
                }
            }
        }
    }
}
