#Loader.IO Verifier for .Net

Creates a URL for your ASP.Net websites that allows loader.io to verify your site given a validation value in web.config.

### Build Status:

| Branch | Status |
| ------ | ------ |
| master | [![Build status](https://ci.appveyor.com/api/projects/status/9781pidt35cay4it?svg=true)](https://ci.appveyor.com/project/kensykora/loaderio-verifier) |
| develop | [![Build status](https://ci.appveyor.com/api/projects/status/9781pidt35cay4it/branch/develop?svg=true)](https://ci.appveyor.com/project/kensykora/loaderio-verifier/branch/develop) |

# Installing

To install, simply install the package from NuGet and update the config value in `Web.config`.

```
PM> Install-Package LoaderIOVerifier
```

Now open *web.config* and change the default value to your code
that you got from https://loader.io/targets/ (click on the "Verify" button)

Example web.config snippet:

```
<configuration>
  ...
  <appSettings>
    ...
    <add key="LoaderIOKey" value="de69634b6d121e9cd0d5ea481dc091a7" />
  </appSettings>
</configuration>
```

This works great with Azure Websites where you can specify specific web.config values. Use this
to override the value you have set. Works great with web.config transforms, too!

# Contributing

Pull requests welcomed. Please ensure you create your edits in a branch off of the `develop` branch, not the `master` branch.
Develop builds can be installed from the nuget project feed https://ci.appveyor.com/nuget/loaderio-verifier-25pownxbfgr1/
