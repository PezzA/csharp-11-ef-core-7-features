﻿using KP_ConsoleAppNet8.Models;
using Microsoft.Extensions.Options;

namespace KP_ConsoleAppNet8.Classes;
internal class SetupServices
{
    private readonly ConnectionStrings _options;

    public SetupServices(IOptions<ConnectionStrings> options)
    {
        _options = options.Value;
    }
    /// <summary>
    /// Read connection strings from appsettings
    /// </summary>
    public void GetConnectionStrings()
    {
        DataConnections.Instance.MainConnection = _options.MainConnection;
        DataConnections.Instance.SecondaryConnection = _options.SecondaryConnection;
    }
}
