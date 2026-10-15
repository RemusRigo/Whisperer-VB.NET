Imports System.Runtime.ConstrainedExecution

Public Module libOS

   Private ReadOnly osVer As Version = Environment.OSVersion.Version

   '-----------------------------------------------------------------------------------------------
   ' Windows 11: Major = 10 Build >= 22000
   Public Function IsWindows11() As Boolean
	  Return osVer.Major = 10 AndAlso osVer.Build >= 22000
   End Function

   Public Function IsAtLeastWindows11() As Boolean
	  Return osVer.Major >= 10 AndAlso osVer.Build >= 22000
   End Function

   '-----------------------------------------------------------------------------------------------
   ' Windows 10: Major = 10 Build < 22000
   Public Function IsWindows10() As Boolean
	  Return osVer.Major = 10 AndAlso osVer.Build >= 22000
   End Function
   Public Function IsAtLeastWindows10() As Boolean
	  Return osVer.Major >= 10
   End Function

   '-----------------------------------------------------------------------------------------------
   ' Windows 8.1: Major = 6 Minor = 3
   Public Function IsWindows81() As Boolean
	  Return osVer.Major = 6 AndAlso osVer.Minor = 3
   End Function

   '-----------------------------------------------------------------------------------------------
   ' Windows 8: Major = 6 Minor = 2
   Public Function IsWindows8() As Boolean
	  Return osVer.Major = 6 AndAlso osVer.Minor = 2
   End Function
   Public Function IsAtLeastWindows8() As Boolean
	  Return osVer.Major >= 6 AndAlso osVer.Minor >= 2
   End Function

   '-----------------------------------------------------------------------------------------------
   ' Windows 7: Major = 6 Minor = 1
   Public Function IsWindows7() As Boolean
	  Return osVer.Major = 6 AndAlso osVer.Minor = 1
   End Function

   Public Function IsAtLeastWindows7() As Boolean
	  Return osVer.Major >= 6 AndAlso osVer.Minor >= 1
   End Function

   '-----------------------------------------------------------------------------------------------
   ' Windows Server 2003: Major = 5 Minor = 2
   Public Function IsWindowsServer2003() As Boolean
	  Return osVer.Major = 5 AndAlso osVer.Minor = 2
   End Function

   Public Function IsAtLeastWindowsServer2003() As Boolean
	  Return osVer.Major >= 5 AndAlso osVer.Minor >= 2
   End Function

   '-----------------------------------------------------------------------------------------------
   ' Windows XP: Major = 5 Minor = 1
   Public Function IsWindowsXP() As Boolean
	  Return osVer.Major = 5 AndAlso osVer.Minor = 1
   End Function

   Public Function IsAtLeastWindowsXP() As Boolean
	  Return osVer.Major >= 5 AndAlso osVer.Minor >= 1
   End Function

   '-----------------------------------------------------------------------------------------------
   ' Windows 2000: Major = 5 Minor = 0
   Public Function IsWindows2000() As Boolean
	  Return osVer.Major = 5 AndAlso osVer.Minor = 0
   End Function

   Public Function IsAtLeastWindows2000() As Boolean
	  Return osVer.Major >= 5 AndAlso osVer.Minor >= 0
   End Function

End Module
