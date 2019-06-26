using System;
using System.Collections.Generic;
using System.Text;

namespace Accoon.Pitshop.CustomerApi.Persistence.Infastructure                                                                                                          
{
    public interface IEnvironmentService
    {
        string EnvironmentName { get; set; }
    }
}
