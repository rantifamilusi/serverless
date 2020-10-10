# Serveless

This is a repository for building AWS Lambda and Azure functions in C# and compare performance and local development tools

# Requirements

## My Environment
- IDE - Visual Studio Code
- OS - macOS

- iTerm (Terminal)


## AWS
- AWS account (free tier for 12 month). You can sign up here [https://aws.amazon.com]
- .NET Core 3.1 [https://dotnet.microsoft.com/download/dotnet-core/3.1]
- .NET CLI [https://dotnet.microsoft.com/download]
- Create Basic Execution Role in AWS IAM.
- Install dotnet global tools for Lambda 
```
dotnet tool install -g Amazon.Lambda.Tools
```
- Install AWS Toolkit for Visual Studio Code [https://docs.aws.amazon.com/toolkit-for-vscode/latest/userguide/welcome.html]
- Install AWS CLI [https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-install.html]

## Azure
- An Azure account with an active subscription. Create an account for free. [https://azure.microsoft.com/free]
- Node.js, required by Windows for npm. Only Active LTS and Maintenance LTS versions. Use the node --version command to check your version. Not required for local development on macOS and Linux.
- The C# extension for Visual Studio Code. [https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp]
- The Azure Functions extension for Visual Studio Code. [https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azurefunctions]
- If you want to use command line `func` you should install Azure Functions Core Tools version 2.7.1846 or a later 2.x version. [https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local#v2].
- The Azure CLI version 2.4 or later. [https://docs.microsoft.com/en-us/cli/azure/install-azure-cli]






