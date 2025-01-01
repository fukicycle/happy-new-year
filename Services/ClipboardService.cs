using System;
using Microsoft.JSInterop;

namespace nerd.Services;

public sealed class ClipboardService
{
    private readonly IJSRuntime _runtime;
    public ClipboardService(IJSRuntime runtime)
    {
        _runtime = runtime;
    }
    public async Task CopyToClipboardAsync(string text)
    {
        await _runtime.InvokeVoidAsync("navigator.clipboard.writeText", text);
    }
}
