EXPERIMENT 9 - Widget Demo App (Student Profile Card)

This zip contains ONLY the files you replace inside a new project.
Create the project in Visual Studio first (project name: WidgetDemoApp), then:

OPTION A - Xamarin.Forms (if "Mobile App (Xamarin.Forms)" exists in Visual Studio)
  1. Replace WidgetDemoApp\MainPage.xaml and MainPage.xaml.cs with the files in  Xamarin.Forms\
  2. Copy Assets\avatar.png into WidgetDemoApp.Android\Resources\drawable\
     (Solution Explorer: right-click drawable > Add > Existing Item. Build Action = AndroidResource)
  3. Set WidgetDemoApp.Android as startup project, choose the emulator, press Run.

OPTION B - .NET MAUI (the successor of Xamarin.Forms, use if the Xamarin template is missing)
  1. Create project: ".NET MAUI App", name WidgetDemoApp.
  2. Replace MainPage.xaml and MainPage.xaml.cs with the files in  MAUI\
  3. Copy Assets\avatar.png into the project's Resources\Images\ folder.
  4. Choose "Android Emulators" as the run target and press Run.

The project name MUST be WidgetDemoApp (the XAML uses x:Class="WidgetDemoApp.MainPage").
If you use another name, change the namespace in the .xaml.cs and x:Class in the .xaml.
