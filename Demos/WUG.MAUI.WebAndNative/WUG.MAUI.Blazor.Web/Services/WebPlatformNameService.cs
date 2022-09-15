using System;
using WUG.MAUI.Blazor.Components;

namespace WUG.MAUI.Blazor.Web.Services;

public class WebPlatformNameService : IPlatformNameService
{
	public string GetName => "WEB";
}

