## How to add submit form action to PDF in Delphi and ByteScout PDF SDK What is ByteScout PDF SDK? It is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gdsQ0EAqwGQ](https://www.youtube.com/watch?v=gdsQ0EAqwGQ)




<!-- code block begin -->

##### **SubmitFormAction.bdsproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<BorlandProject>
	<PersonalityInfo>
		<Option>
			<Option Name="Personality">Delphi.Personality</Option>
			<Option Name="ProjectType"></Option>
			<Option Name="Version">1.0</Option>
			<Option Name="GUID">{F9A2A695-BC68-4BD2-99BC-F2F784634552}</Option>
		</Option>
	</PersonalityInfo>
	<Delphi.Personality>
		<Source>
			<Source Name="MainSource">SubmitFormAction.dpr</Source>
		</Source>
		<FileVersion>
			<FileVersion Name="Version">7.0</FileVersion>
		</FileVersion>
		<Compiler>
			<Compiler Name="A">8</Compiler>
			<Compiler Name="B">0</Compiler>
			<Compiler Name="C">1</Compiler>
			<Compiler Name="D">1</Compiler>
			<Compiler Name="E">0</Compiler>
			<Compiler Name="F">0</Compiler>
			<Compiler Name="G">1</Compiler>
			<Compiler Name="H">1</Compiler>
			<Compiler Name="I">1</Compiler>
			<Compiler Name="J">0</Compiler>
			<Compiler Name="K">0</Compiler>
			<Compiler Name="L">1</Compiler>
			<Compiler Name="M">0</Compiler>
			<Compiler Name="N">1</Compiler>
			<Compiler Name="O">1</Compiler>
			<Compiler Name="P">1</Compiler>
			<Compiler Name="Q">0</Compiler>
			<Compiler Name="R">0</Compiler>
			<Compiler Name="S">0</Compiler>
			<Compiler Name="T">0</Compiler>
			<Compiler Name="U">0</Compiler>
			<Compiler Name="V">1</Compiler>
			<Compiler Name="W">0</Compiler>
			<Compiler Name="X">1</Compiler>
			<Compiler Name="Y">1</Compiler>
			<Compiler Name="Z">1</Compiler>
			<Compiler Name="ShowHints">True</Compiler>
			<Compiler Name="ShowWarnings">True</Compiler>
			<Compiler Name="UnitAliases">WinTypes=Windows;WinProcs=Windows;DbiTypes=BDE;DbiProcs=BDE;DbiErrs=BDE;</Compiler>
			<Compiler Name="NamespacePrefix"></Compiler>
			<Compiler Name="GenerateDocumentation">False</Compiler>
			<Compiler Name="DefaultNamespace"></Compiler>
			<Compiler Name="SymbolDeprecated">True</Compiler>
			<Compiler Name="SymbolLibrary">True</Compiler>
			<Compiler Name="SymbolPlatform">True</Compiler>
			<Compiler Name="SymbolExperimental">True</Compiler>
			<Compiler Name="UnitLibrary">True</Compiler>
			<Compiler Name="UnitPlatform">True</Compiler>
			<Compiler Name="UnitDeprecated">True</Compiler>
			<Compiler Name="UnitExperimental">True</Compiler>
			<Compiler Name="HResultCompat">True</Compiler>
			<Compiler Name="HidingMember">True</Compiler>
			<Compiler Name="HiddenVirtual">True</Compiler>
			<Compiler Name="Garbage">True</Compiler>
			<Compiler Name="BoundsError">True</Compiler>
			<Compiler Name="ZeroNilCompat">True</Compiler>
			<Compiler Name="StringConstTruncated">True</Compiler>
			<Compiler Name="ForLoopVarVarPar">True</Compiler>
			<Compiler Name="TypedConstVarPar">True</Compiler>
			<Compiler Name="AsgToTypedConst">True</Compiler>
			<Compiler Name="CaseLabelRange">True</Compiler>
			<Compiler Name="ForVariable">True</Compiler>
			<Compiler Name="ConstructingAbstract">True</Compiler>
			<Compiler Name="ComparisonFalse">True</Compiler>
			<Compiler Name="ComparisonTrue">True</Compiler>
			<Compiler Name="ComparingSignedUnsigned">True</Compiler>
			<Compiler Name="CombiningSignedUnsigned">True</Compiler>
			<Compiler Name="UnsupportedConstruct">True</Compiler>
			<Compiler Name="FileOpen">True</Compiler>
			<Compiler Name="FileOpenUnitSrc">True</Compiler>
			<Compiler Name="BadGlobalSymbol">True</Compiler>
			<Compiler Name="DuplicateConstructorDestructor">True</Compiler>
			<Compiler Name="InvalidDirective">True</Compiler>
			<Compiler Name="PackageNoLink">True</Compiler>
			<Compiler Name="PackageThreadVar">True</Compiler>
			<Compiler Name="ImplicitImport">True</Compiler>
			<Compiler Name="HPPEMITIgnored">True</Compiler>
			<Compiler Name="NoRetVal">True</Compiler>
			<Compiler Name="UseBeforeDef">True</Compiler>
			<Compiler Name="ForLoopVarUndef">True</Compiler>
			<Compiler Name="UnitNameMismatch">True</Compiler>
			<Compiler Name="NoCFGFileFound">True</Compiler>
			<Compiler Name="ImplicitVariants">True</Compiler>
			<Compiler Name="UnicodeToLocale">True</Compiler>
			<Compiler Name="LocaleToUnicode">True</Compiler>
			<Compiler Name="ImagebaseMultiple">True</Compiler>
			<Compiler Name="SuspiciousTypecast">True</Compiler>
			<Compiler Name="PrivatePropAccessor">True</Compiler>
			<Compiler Name="UnsafeType">False</Compiler>
			<Compiler Name="UnsafeCode">False</Compiler>
			<Compiler Name="UnsafeCast">False</Compiler>
			<Compiler Name="OptionTruncated">True</Compiler>
			<Compiler Name="WideCharReduced">True</Compiler>
			<Compiler Name="DuplicatesIgnored">True</Compiler>
			<Compiler Name="UnitInitSeq">True</Compiler>
			<Compiler Name="LocalPInvoke">True</Compiler>
			<Compiler Name="MessageDirective">True</Compiler>
			<Compiler Name="CodePage"></Compiler>
		</Compiler>
		<Linker>
			<Linker Name="MapFile">0</Linker>
			<Linker Name="OutputObjs">0</Linker>
			<Linker Name="GenerateHpps">False</Linker>
			<Linker Name="ConsoleApp">1</Linker>
			<Linker Name="DebugInfo">False</Linker>
			<Linker Name="RemoteSymbols">False</Linker>
			<Linker Name="GenerateDRC">False</Linker>
			<Linker Name="MinStackSize">16384</Linker>
			<Linker Name="MaxStackSize">1048576</Linker>
			<Linker Name="ImageBase">4194304</Linker>
			<Linker Name="ExeDescription"></Linker>
		</Linker>
		<Directories>
			<Directories Name="OutputDir"></Directories>
			<Directories Name="UnitOutputDir"></Directories>
			<Directories Name="PackageDLLOutputDir"></Directories>
			<Directories Name="PackageDCPOutputDir"></Directories>
			<Directories Name="SearchPath"></Directories>
			<Directories Name="Packages"></Directories>
			<Directories Name="Conditionals"></Directories>
			<Directories Name="DebugSourceDirs"></Directories>
			<Directories Name="UsePackages">False</Directories>
		</Directories>
		<Parameters>
			<Parameters Name="RunParams"></Parameters>
			<Parameters Name="HostApplication"></Parameters>
			<Parameters Name="Launcher"></Parameters>
			<Parameters Name="UseLauncher">False</Parameters>
			<Parameters Name="DebugCWD"></Parameters>
			<Parameters Name="Debug Symbols Search Path"></Parameters>
			<Parameters Name="LoadAllSymbols">True</Parameters>
			<Parameters Name="LoadUnspecifiedSymbols">False</Parameters>
		</Parameters>
		<Language>
			<Language Name="ActiveLang"></Language>
			<Language Name="ProjectLang">$00000000</Language>
			<Language Name="RootDir"></Language>
		</Language>
		<VersionInfo>
			<VersionInfo Name="IncludeVerInfo">False</VersionInfo>
			<VersionInfo Name="AutoIncBuild">False</VersionInfo>
			<VersionInfo Name="MajorVer">1</VersionInfo>
			<VersionInfo Name="MinorVer">0</VersionInfo>
			<VersionInfo Name="Release">0</VersionInfo>
			<VersionInfo Name="Build">0</VersionInfo>
			<VersionInfo Name="Debug">False</VersionInfo>
			<VersionInfo Name="PreRelease">False</VersionInfo>
			<VersionInfo Name="Special">False</VersionInfo>
			<VersionInfo Name="Private">False</VersionInfo>
			<VersionInfo Name="DLL">False</VersionInfo>
			<VersionInfo Name="Locale">1049</VersionInfo>
			<VersionInfo Name="CodePage">1251</VersionInfo>
		</VersionInfo>
		<VersionInfoKeys>
			<VersionInfoKeys Name="CompanyName"></VersionInfoKeys>
			<VersionInfoKeys Name="FileDescription"></VersionInfoKeys>
			<VersionInfoKeys Name="FileVersion">1.0.0.0</VersionInfoKeys>
			<VersionInfoKeys Name="InternalName"></VersionInfoKeys>
			<VersionInfoKeys Name="LegalCopyright"></VersionInfoKeys>
			<VersionInfoKeys Name="LegalTrademarks"></VersionInfoKeys>
			<VersionInfoKeys Name="OriginalFilename"></VersionInfoKeys>
			<VersionInfoKeys Name="ProductName"></VersionInfoKeys>
			<VersionInfoKeys Name="ProductVersion">1.0.0.0</VersionInfoKeys>
			<VersionInfoKeys Name="Comments"></VersionInfoKeys>
		</VersionInfoKeys>
	</Delphi.Personality>
</BorlandProject>

```

<!-- code block end -->    

<!-- code block begin -->

##### **SubmitFormAction.cfg:**
    
```
-$A8
-$B-
-$C+
-$D+
-$E-
-$F-
-$G+
-$H+
-$I+
-$J-
-$K-
-$L+
-$M-
-$N+
-$O+
-$P+
-$Q-
-$R-
-$S-
-$T-
-$U-
-$V+
-$W-
-$X+
-$YD
-$Z1
-cg
-AWinTypes=Windows;WinProcs=Windows;DbiTypes=BDE;DbiProcs=BDE;DbiErrs=BDE;
-H+
-W+
-M
-$M16384,1048576
-K$00400000
-LE"C:\Users\Àíäðåé\Documents\Borland Studio Projects\Bpl"
-LN"C:\Users\Àíäðåé\Documents\Borland Studio Projects\Bpl"
-w-UNSAFE_TYPE
-w-UNSAFE_CODE
-w-UNSAFE_CAST

```

<!-- code block end -->    

<!-- code block begin -->

##### **SubmitFormAction.dpr:**
    
```
program SubmitFormAction;

//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  ComObj,
  ShellApi,
  Windows,
  Bytescout_PDF_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDF_TLB.pas';

var
  doc: _Document;
  page: _Page;
  font: _Font;
  brush: _Brush;
  color: _Color;
  edit_box: _EditBox;
  check_box: _CheckBox;
  submit_button: _PushButton;
  submit_action: _SubmitFormAction;
  reset_button: _PushButton;
  reset_action: _ResetFormAction; 

const
  OUTPUT_FILE_NAME: string = 'result.pdf';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create new document
  doc := CoDocument.Create();
  doc.RegistrationName := 'demo';
  doc.RegistrationKey := 'demo';

  // add page
  page := doc.ComHelpers.CreatePage(PAPERFORMAT_A4);
  doc.Pages.Add(page);

  // create sample form
  color := doc.ComHelpers.CreateColorRGB(0, 0, 0) as _Color;
  font := doc.ComHelpers.CreateStandardFont(STANDARDFONTS_TIMES, 14);
  brush := doc.ComHelpers.CreateSolidBrush(color) as _Brush;

  // create edit box
  edit_box := doc.ComHelpers.CreateEditBox(20, 20, 100, 25, 'editBox1');
  edit_box.Text := 'editBox1';
  page.Annotations.Add(edit_box as _Annotation);

  // create check box
  check_box := doc.ComHelpers.CreateCheckBox(20, 60, 15, 15, 'checkBox1');
  page.Annotations.Add(check_box as _Annotation);
  page.Canvas.DrawString('CheckBox', font, brush, 45, 60);

  // add submit button
  submit_button := doc.ComHelpers.CreatePushButton(20, 120, 80, 25, 'buttonSubmit');
  submit_button.Caption := 'Submit';
  page.Annotations.Add(submit_button as _Annotation);
  // add action
  submit_action := doc.ComHelpers.CreateSubmitFormAction('http://login.live.com');
  submit_action.SubmitFormat := SUBMITDATAFORMAT_HTML;
  submit_action.SubmitMethod := SUBMITMETHOD_GET;
  submit_action.Fields.Add(edit_box as _Field);
  submit_action.Fields.Add(check_box as _Field);
  submit_button.OnActivated := submit_action as _Action;

  // add reset button
  reset_button := doc.ComHelpers.CreatePushButton(120, 120, 80, 25, 'butonReset');
  reset_button.Caption := 'Reset';
  page.Annotations.Add(reset_button as _Annotation);
  // Add action
  reset_action := doc.ComHelpers.CreateResetFormAction();
  reset_action.Fields.Add(edit_box as _Field);
  reset_action.Fields.Add(check_box as _Field);
  reset_button.OnActivated := reset_action as _Action;

  // Ssave document to file
  doc.Save(OUTPUT_FILE_NAME);

  // show document in default pdf viewer
  ShellExecute(0, 'open', PAnsiChar(OUTPUT_FILE_NAME), nil, nil, SW_SHOWNORMAL);

  // free document object
  doc.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.

```

<!-- code block end -->