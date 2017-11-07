# Visual Studio for Mac Add-Ins

This is a collection of VS add-ins we've developed at [Olo](http://olo.com) to help us out. (Ok, so it's currently a collection of one, but we promise to add more as we create them!)

## Olo.BuildTools

### Install

Most users should install from the Visual Studio Add-in Gallery. 

If you want to contribute
- Install the [AddinMaker](https://github.com/mhutch/MonoDevelop.AddinMaker) found in the Visual Studio Add-in Gallery 
- Build the release configuration
- Navigate to the `bin/Release` folder in your terminal 
- Run `vstool setup pack Olo.BuildTools.dll` to generate a `.mpack` file
- Install the `.mpack` file in Xamarin Studio via `Add-ins->Install from file...` 

### System Information

This is an extension to Visual Studio's `vstool` command that allows you to capture information on all the tooling versions currently set up in Visual Studio. Essentially, this is the same as what is provided in Visual Studio's About dialog. We use this as part of our build processes in order to capture the exact versions used on our build servers when packaging an app.

You can display this output in the console by running:

`vstool systeminfo -c`

You can also pipe the output to a file by running:

`vstool systeminfo -f:toolversions.txt`