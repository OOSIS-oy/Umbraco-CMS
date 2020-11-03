﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace Umbraco.Extensions
{
    public static class ActionContextExtensions
    {
        /// <summary>
        /// Recursively gets a data token from a controller context hierarchy.
        /// </summary>
        /// <param name="actionContext">The action context.</param>
        /// <param name="dataTokenName">The name of the data token.</param>
        /// <returns>The data token, or null.</returns>
        /// MIGRAGED TO NETCORE AS EXTENSION ON HTTPCONTEXT
        internal static object GetDataTokenInViewContextHierarchy(this ActionContext actionContext, string dataTokenName)
        {

            var controllerActionDescriptor = actionContext.ActionDescriptor as ControllerActionDescriptor;
            while (!(controllerActionDescriptor is null))
            {
                object token;
                if (actionContext.RouteData.DataTokens.TryGetValue(dataTokenName, out token))
                    return token;
                controllerActionDescriptor = controllerActionDescriptor.ParentActionViewContext;
            }
            return null;
        }
    }
}
