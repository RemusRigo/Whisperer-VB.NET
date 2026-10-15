Imports Microsoft.Win32

Public Module libReg

   Public Function RegValueExists(root As RegistryKey, path As String, valueName As String) As Boolean
	  Using key As RegistryKey = root.OpenSubKey(path, writable:=False)
		 If key Is Nothing Then
			Return False ' Key does not exist
		 End If

		 Dim names() As String = key.GetValueNames()
		 Return names.Contains(valueName)
	  End Using
   End Function

   Public Function RegReadDWord(root As RegistryKey, path As String, name As String) As Integer
	  Dim r As Integer = -1
	  Try
		 Using key As RegistryKey = root.OpenSubKey(path, False)
			If key IsNot Nothing Then
			   r = Convert.ToInt32(key.GetValue(name, Nothing))
			End If
		 End Using
	  Catch ex As Exception
	  End Try
	  Return r
   End Function

   Public Function RegWriteDWord(root As RegistryKey, path As String, name As String, value As Integer) As Boolean
	  Try
		 Using key As RegistryKey = root.CreateSubKey(path, True)
			key.SetValue(name, value, RegistryValueKind.DWord)
		 End Using
		 Return True
	  Catch ex As Exception
		 Return False
	  End Try
   End Function

End Module
