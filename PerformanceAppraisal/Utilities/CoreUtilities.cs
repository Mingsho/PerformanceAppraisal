﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerformanceAppraisal.Utilities
{
    public static class CoreUtilities
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentException("request");
            }
                

            var context = HttpContext.Current;
            var isCallbackRequest = false; //call back requests are ajax requests

            if(context!=null && context.CurrentHandler!=null && context.CurrentHandler is System.Web.UI.Page)
            {
                isCallbackRequest = ((System.Web.UI.Page)context.CurrentHandler).IsCallback;
            }

            return isCallbackRequest || (request["X-Requested-With"]=="XMLHttpRequest") ||
                (request.Headers["X-Requested-With"]=="XMLHttpRequest");
        }
    }
}