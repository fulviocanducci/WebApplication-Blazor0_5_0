using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;
//https://blogs.msdn.microsoft.com/webdev/2018/07/25/blazor-0-5-0-experimental-release-now-available/
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
