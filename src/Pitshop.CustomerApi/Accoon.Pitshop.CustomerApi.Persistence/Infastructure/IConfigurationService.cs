using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accoon.Pitshop.CustomerApi.Persistence.Infastructure
{
    public interface IConfigurationService
    {
        IConfiguration GetConfiguration();
    }
}
