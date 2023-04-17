using Microsoft.AspNetCore.Components.Web;

namespace BlazorWasmDisplayExceptionOnScreen.Client
{
    public class CustomErrBoundary : ErrorBoundary
    {
        protected override Task OnErrorAsync(Exception exception)
        {
            //
            // write exception to database
            //
            return base.OnErrorAsync(exception);
        }
    }
}
