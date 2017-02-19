﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace jsLogger.Extensions
{
    public static class JavaScriptLoggingServiceCollectionExtensions
    {
        public static IServiceCollection AddJavaScriptLogging(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddSingleton<JavaScriptLoggingSnippet>();

            return services;
        }
    }
}
