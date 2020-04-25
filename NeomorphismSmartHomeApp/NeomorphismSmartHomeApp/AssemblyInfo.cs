using Xamarin.Forms;

#if RELEASE
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

#endif
///<see href="https://github.com/felipebaltazar/Xamarin.Custom.Fonts"/>
[assembly: ExportFont("RobotoCondensed-Regular.ttf", Alias = "RobotoCondensedRegular")]
[assembly: ExportFont("RobotoCondensed-Bold.ttf", Alias = "RobotoCondensedBold")]
[assembly: ExportFont("RobotoCondensed-Light.ttf", Alias = "RobotoCondensedLight")]