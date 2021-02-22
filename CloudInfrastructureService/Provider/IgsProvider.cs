using CloudInfrastructureService.Resource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CloudInfrastructureService.Provider
{
    public class IgsProvider : Provider
    {
        protected override string GetProviderName()
        {
            return "IGS";
        }
    }
}
