using Mono.Addins;

[assembly:Addin(
	"Other", 
	Namespace = "Olo.BuildTools",
	Version = "1.0", 
	Url = "http://github.com/ololabs/xs-addins"
)]

[assembly:AddinName ("Olo.BuildTools")]
[assembly:AddinDescription ("Some tools used as part of the build process at Olo")]
[assembly:AddinAuthor ("Olo")]

[assembly:AddinDependency ("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]