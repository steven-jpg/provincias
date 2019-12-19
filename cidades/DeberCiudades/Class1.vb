Public Class Class1
    Dim Nuevo As Integer
    Dim Menor As Integer
    Dim Mayor As Integer
    Public Function Cal(Nuevo, Menor, Mayor)
        Dim i As Integer = 0
        If Nuevo < Menor Then
            i = 1
            Return i
        ElseIf Nuevo > Mayor Then
            i = 2
            Return i
        ElseIf Nuevo = Menor Then
            i = 3
            Return i
        ElseIf Nuevo = Mayor Then
            i = 4
            Return i
        Else
            Return i
        End If
    End Function
End Class
