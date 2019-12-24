using System.Reflection;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
#if DEBUG && !NETSTANDARD && !NETCOREAPP
[assembly: AssemblyVersion(AssemblyInfo.VersionShort + ".*")]
#else
[assembly: AssemblyVersion(AssemblyInfo.Version)]
#endif

