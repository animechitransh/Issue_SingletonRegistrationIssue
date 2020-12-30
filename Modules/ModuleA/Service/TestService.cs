using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.Service
{
    public class TestService : ITestService
    {
        public string Test()
        {
            return "Love from Service";
        }
    }
}
