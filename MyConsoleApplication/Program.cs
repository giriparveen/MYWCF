using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using ClassLibrary1;


namespace MyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri httpUrl = new Uri("http://localhost:60918/ServiceCalculatorCost.svc");

            ServiceHost host = new ServiceHost(typeof(ClassLibrary1.HelloWorldService), httpUrl);

            host.AddServiceEndpoint(typeof(ClassLibrary1.IHelloWorldService), new WSHttpBinding(), "");

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();

            smb.HttpGetEnabled = true;

            host.Description.Behaviors.Add(smb);

            host.Open();


        }
    }
}
