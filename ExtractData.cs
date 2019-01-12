// Copied from
// https://stackoverflow.com/questions/45953778/how-to-use-powershell-to-extract-data-from-dll-or-exe-files
// and added Main()
using System;
using System.Runtime.InteropServices;
using System.Text;

public class ExtractData
{
    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
	private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)]string lpFileName);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int LoadString(IntPtr hInstance, int ID, StringBuilder lpBuffer, int nBufferMax);

    [DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool FreeLibrary(IntPtr hModule);

    public string ExtractStringFromDLL(string file, int number) {
	IntPtr lib = LoadLibrary(file);
	StringBuilder result = new StringBuilder(2048);
	LoadString(lib, number, result, result.Capacity);
	FreeLibrary(lib);
	return result.ToString();
    }
    static void Main(string[] args) {
	ExtractData ext = new ExtractData();
	Console.WriteLine(ext.ExtractStringFromDLL(args[0], Convert.ToInt32(args[1])));
    }
}
