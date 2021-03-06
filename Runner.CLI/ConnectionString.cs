﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticVoid.OrmPerformance.Harness.Contract;

namespace StaticVoid.OrmPerformace.Runner.CLI
{
    public class ConnectionString : IConnectionString
    {
        public string Server { get { return System.Configuration.ConfigurationManager.AppSettings["DbServer"]; } }

        public string Database{ get {return "StaticVoid.OrmPerfomance.Test"; } }
        public bool Trusted{ get {return true; } }

        public string FormattedConnectionString
        {
            get 
            {
                return String.Format("Data Source={0};Initial Catalog={1};Integrated Security={2};", Server, Database, Trusted.ToString());
            }
        }
    }
}
