# T4 Custom Directive Processor Example

The code is from here: [Walkthrough: Create a Custom Directive Processor](https://learn.microsoft.com/en-us/visualstudio/modeling/walkthrough-creating-a-custom-directive-processor?view=vs-2022&tabs=csharp)

Test using [Mono T4 tool](https://github.com/mono/t4):

```shell
dotnet publish

t4 --dp='CustomDirectiveProcessor!CustomDP.CustomDirectiveProcessor!/{PATH_TO}/T4-DirectiveProcessor-Example/bin/Debug/netcoreapp3.1/publish/T4-DirectiveProcessor-Example.dll' -r='System.Xml.ReaderWriter, Version=6.0.0.0, Culture=neutral' ./TestDP.tt
```

For more usage, see: https://github.com/mono/t4/blob/main/dotnet-t4/readme.md

> Alternatively, invoking t4 powers.tt -c MyApp.Powers will produce a powers.cs file containing the runtime template class, which you can compile into your app and execute at runtime with new parameter values:…


VS Code launch.json for debug:

```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": ".NET Core Launch (console)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "${workspaceFolder}/dotnet-t4/bin/Debug/net6.0/t4.dll",
            "args": [
                "--dp=CustomDirectiveProcessor!CustomDP.CustomDirectiveProcessor!/{PATH_TO}/T4-DirectiveProcessor-Example/bin/Debug/netcoreapp3.1/publish/T4-DirectiveProcessor-Example.dll",
                "-r=System.Xml.ReaderWriter, Version=6.0.0.0, Culture=neutral",
                "/{PATH_TO}/T4-DirectiveProcessor-Example/TestDP.tt"
            ],
            "cwd": "${workspaceFolder}/dotnet-t4",
            "console": "internalConsole",
            "stopAtEntry": false
        },
        {
            "name": ".NET Core Attach",
            "type": "coreclr",
            "request": "attach"
        }
    ]
}
```
