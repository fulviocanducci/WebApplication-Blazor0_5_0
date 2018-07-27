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
    }
}
