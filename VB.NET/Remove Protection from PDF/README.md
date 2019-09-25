## How to remove protection from PDF in VB.NET and ByteScout PDF SDK

### This tutorial will show how to remove protection from PDF in VB.NET

The coding tutorials are designed to help you test the features without need to write your own code. What is ByteScout PDF SDK? It is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings. It can help you to remove protection from PDF in your VB.NET application.

Fast application programming interfaces of ByteScout PDF SDK for VB.NET plus the instruction and the code below will help you quickly learn how to remove protection from PDF. Follow the instructions from the scratch to work and copy the VB.NET code. Further enhancement of the code will make it more vigorous.

Download free trial version of ByteScout PDF SDK from our website with this and other source code samples for VB.NET.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gdsQ0EAqwGQ](https://www.youtube.com/watch?v=gdsQ0EAqwGQ)




<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports Bytescout.PDF

Module Program

    Sub Main()

        Try
            'Files
            Dim fileName As String = "ProtectedPDFFile.pdf"
            Dim fileName_UnProtected As String = "UnProtectedPDFFile.pdf"

            'Protected file password
            Dim filePassword As String = "admin@123"
            'Process file to remove password

            Dim document As Document = New Document()
            document.RegistrationName = "demo"
            document.RegistrationKey = "demo"
            document.Load(fileName, filePassword)

            ' Remove password protection and encryption
            document.Security.OwnerPassword = String.Empty
            document.Security.UserPassword = String.Empty
            document.Security.EncryptionAlgorithm = EncryptionAlgorithm.None

            ' Remove restrictions
            document.Security.AllowAccessibilitySupport = True
            document.Security.AllowAssemlyDocument = True
            document.Security.AllowContentExtraction = True
            document.Security.AllowFillForms = True
            document.Security.AllowModifyAnnotations = True
            document.Security.AllowModifyDocument = True
            document.Security.AllowPrintDocument = True
            document.Security.PrintQuality = PrintQuality.HightResolution

            'Save Unprotected file
            document.Save(fileName_UnProtected)
            Console.WriteLine("PDF restrictions removed successfully!")

            Process.Start(fileName_UnProtected)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()


    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****RemovePDFProtection.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{B3CD7966-495B-4DA8-897C-F6F033B18AF6}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>RemovePDFProtection.Program</StartupObject>
    <RootNamespace>RemovePDFProtection</RootNamespace>
    <AssemblyName>RemovePDFProtection</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <OptionExplicit>On</OptionExplicit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionCompare>Binary</OptionCompare>
  </PropertyGroup>
  <PropertyGroup>
    <OptionStrict>Off</OptionStrict>
  </PropertyGroup>
  <PropertyGroup>
    <OptionInfer>On</OptionInfer>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDF, Version=1.8.2.254, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF SDK\net2.0\Bytescout.PDF.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <None Include="ProtectedPDFFile.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->