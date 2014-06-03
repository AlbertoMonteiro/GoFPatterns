﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create proxy and request a service 
            var proxy = new Proxy();
            proxy.Request();

            // Wait for user 
            Console.Read();
        }
    }
}