Module Module1
    Public sConstring As String

    Function Get_Constring()
        If Microsoft.VisualBasic.Right(Application.StartupPath, 1) = "\" Then
            sConstring = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\Project.accdb; Persist Security Info = False;"
        Else
            sConstring = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\Project.accdb; Persist Security Info = False;"
        End If
        Return sConstring

    End Function
End Module
