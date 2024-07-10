using System;
using RestSharp;

namespace HelloWorldApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var reqres = new Reqres();
            reqres.ExecuteAllRequests();
        }
    }
}



