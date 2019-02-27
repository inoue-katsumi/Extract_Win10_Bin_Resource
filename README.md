# Extract_Win10_Bin_Resource

Extract Windows resource string from resource DLL.
https://katsumiinoue.wordpress.com/2019/01/10/windows%e3%83%90%e3%82%a4%e3%83%8a%e3%83%aa%e3%83%bc%e3%81%8b%e3%82%89%e3%83%aa%e3%82%bd%e3%83%bc%e3%82%b9%e6%96%87%e5%ad%97%e5%88%97%e3%82%92%e6%8a%9c%e3%81%8d%e5%8f%96%e3%82%8bc%e3%82%92github/

## Usage:

```bash
/mnt/c/Windows/Microsoft.NET/Framework64/v4.0.30319/csc.exe ExtractData.cs
./ExtractData.exe shell32.dll 21813 
```

## desktop_ini_string.sh:

Scans desktop.ini file recursively and find strings in DLLs.

## ExtractData.cs:

Created from https://stackoverflow.com/questions/45953778/how-to-use-powershell-to-extract-data-from-dll-or-exe-files
See my blog above.

## Win10_Japanese_DesktopIni_res.txt:

Windows10 Japanese version strings list.
