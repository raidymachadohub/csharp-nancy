using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyRestAPI
{
    public class ExampleModule : NancyModule
    {
        public ExampleModule() : base("/api")
        {
            Get["/"] = Index;
        }

        //Get - http://localhost:44372:api/
        private dynamic Index(dynamic ars)
        {
            return "Welcome sample module. Using Nancy 1.4.4";
        }
    }
}