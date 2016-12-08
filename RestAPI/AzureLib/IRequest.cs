using System;
using RestSharp;

namespace AzureLib
{
    public interface IRequest
    {
        IRestResponse Execute(Method method, Uri url);
    }
}