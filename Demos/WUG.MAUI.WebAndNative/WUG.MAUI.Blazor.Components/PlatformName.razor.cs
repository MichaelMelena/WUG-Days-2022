using System;
using Microsoft.AspNetCore.Components;

namespace WUG.MAUI.Blazor.Components;

public partial class PlatformName
{
	[Inject] private IPlatformNameService PlatformNameService { get; set; }
}

