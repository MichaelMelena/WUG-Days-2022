# MAUI Blazor Hybrid
Součástí tohoto repozitáře je Prezentace z WUG days 2022 na Téma [MAUI Blazor Hybrid](https://github.com/MichaelMelena/WUG-Days-2022/blob/main/Blazor%20Hybrid.pdf). Kde jsme si řekli jak funguje MAUI Blazor Hybrid a jak vyvíjet zároveň pro web a nativní platformy. 


Všechny ukázky zmíněné v prezentaci jsou dostupné na GitHub v repositáří popsaných v sekci Ukázky.

## Ukázky

### 1. Blazor Hybrid šablona
Ukázka co Blazor Hybrid šablona obsahuje a jak jsou do sebe jednotlivé části zapojené.
Tuto ukázku si můžete snadno reprodukovat zavoláním příkazu:

`dotnet new maui-blazor -n BlazoHybridTemplate`

Pokud se vám nechce stahovat Visual Studio Preview tak se můžete na šablonu podívat v repositáři [MAUI Blazor Hybrid Template](https://github.com/MichaelMelena/WUG-BlazorHybrid-Template).

### 2. Havit.Blazor v MAUI
Použití existujících
[Blazor knihoven v MAUI](https://github.com/MichaelMelena/MAUI-Havit-Blazor-demo-WUG-days-2022)
a to konkrétně [Havit.Blazor](https://github.com/havit/Havit.Blazor). Pro více informací o knihvně navštivte [Havit.Blazor documentation](https://havit.blazor.eu/).

### 3. Přístup k nativním funkcím
Jak v Blazor Hybrid přístupovat k nativním platformním funkcím platform. [Přístup k seonzorům zařízení](https://github.com/MichaelMelena/Blazor-Hybrid-Sensors-Demo-WUG)

### 4. Blazor Hybrid a Native MAUI
Ukázka jak může část aplikace může používat Blazor Hybrid zatímco zbytek aplikace používá MAUI komponenty viz ukázka
[Kombinace Blazor Hybrid a MAUI komponent](https://github.com/MichaelMelena/Blazor-Hybrid-SplitView-Demo-WUG)

### 5. Vývoj pro Web + Native
Jak současně vyvíjet aplikaci pro WEB a Nativní platformy. Struktura a
[rozložení projektů pro nativní platofrmy a Web](https://github.com/MichaelMelena/Blazor-Hybrid-Platform-Specific-Implementation-WUG-Days)


## Demo aplikace
https://github.com/microsoft/dotnet-podcasts

## Zdroje
* [HAVIT Blazor Free Bootstrap 5 components for Blazor](https://havit.blazor.eu/)
* [ASP.NET Core Blazor Hybrid](https://docs.microsoft.com/en-gb/aspnet/core/blazor/hybrid/?view=aspnetcore-6.0)
* [WebView2 - Microsoft Edge Developer](https://developer.microsoft.com/en-us/microsoft-edge/webview2/)
* [Introduction to Microsoft Edge WebView2](https://docs.microsoft.com/en-us/microsoft-edge/webview2/)
* [Accessing device sensors in MAUI Blazor Hybrid](https://docs.microsoft.com/en-us/dotnet/maui/platform-integration/device/battery?tabs=android)
* [Devblog Introduction to MAUI - One codebase for many platforms](https://devblogs.microsoft.com/dotnet/introducing-dotnet-maui-one-codebase-many-platforms/)
* [.NET Build talking about MAUI a Blazor Hybrid release](https://mybuild.microsoft.com/en-US/sessions/599c82b6-0c5a-4add-9961-48b85d9ffde0?source=sessions)
