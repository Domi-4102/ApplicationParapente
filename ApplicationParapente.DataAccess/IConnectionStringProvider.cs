using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess
{
    public interface IConnectionStringProvider
    {
        string ConnectionString { get; }
    }
}
