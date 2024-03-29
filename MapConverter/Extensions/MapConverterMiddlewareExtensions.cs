﻿using MapConverter.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MapConverter.Extensions;

public static class MapConverterMiddlewareExtensions
{
    public static void AddMapConverter(this IServiceCollection services)
    {
        services.AddSingleton<MapConverterService>();
    }
}