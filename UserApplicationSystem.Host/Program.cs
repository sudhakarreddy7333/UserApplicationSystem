﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace UserApplicationSystem.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(UserApplicationSystem.Services.UserAccessService)))
            {
                host.Open();
                Console.WriteLine("app started");
                Console.ReadLine();
            }
        }
    }
}
