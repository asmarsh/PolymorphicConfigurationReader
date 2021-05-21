using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicConfigurationReader
{
    internal interface IConfigurationReader
    {
        string Read(string key);
    }
}