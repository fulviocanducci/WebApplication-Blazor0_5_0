using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Client.Library
{
    public class JsExample
    {
        public static Task MyAlert(string message)
        {
            return JSRuntime
                    .Current
                    .InvokeAsync<object>("functions.myAlert", message);
        }

        public static Task MySweetAlertSuccess(string title, string message)
        {
            return JSRuntime
                    .Current
                    .InvokeAsync<object>("functions.mySweetAlertSuccess", title, message);
        }

        public static Task MyConsole(string message)
        {
            return JSRuntime
                    .Current
                    .InvokeAsync<object>("functions.myConsole", message);
        }
    }
}
