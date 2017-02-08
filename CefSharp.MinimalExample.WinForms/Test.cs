using CefSharp.WinForms;
using System.Threading.Tasks;

namespace CefSharp.MinimalExample.WinForms
{
    class Test
    {
        private readonly ChromiumWebBrowser _browser;

        public Test(ChromiumWebBrowser browser)
        {
            _browser = browser;
        }

        public object testEval()
        {
            return _testEval().Result.Result;
        }

        private async Task<JavascriptResponse> _testEval()
        {
            return await _browser.EvaluateScriptAsync("eval", "'hello'");
        }
    }
}