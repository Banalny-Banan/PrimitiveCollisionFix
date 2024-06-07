using Exiled.API.Interfaces;
using System;

namespace PrimitiveCollisionFix;

public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;
    public bool Debug { get; set; } = false;
}