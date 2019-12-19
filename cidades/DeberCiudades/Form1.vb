Public Class Form1
    Dim lista As New List(Of String)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lista.Add("PROINCIA: " & TextBox1.Text)
        lista.Add("CIUDAD: " & TextBox2.Text)
        lista.Add("POBLACION: " & TextBox3.Text)
        lista.Add("*******************************")
        TextBox4.Text = TextBox1.Text
        TextBox7.Text = TextBox1.Text
        TextBox5.Text = TextBox2.Text
        TextBox8.Text = TextBox2.Text
        TextBox6.Text = TextBox3.Text
        TextBox9.Text = TextBox3.Text
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Nuevo As Integer = Int(TextBox3.Text)
        Dim Menor As Integer = Int(TextBox6.Text)
        Dim Mayor As Integer = Int(TextBox9.Text)
        Dim Calcular As Class1 = New Class1
        Dim I As Integer = Calcular.Cal(Nuevo, Menor, Mayor)
        lista.Add("PROINCIA: " & TextBox1.Text)
        lista.Add("CIUDAD: " & TextBox2.Text)
        lista.Add("POBLACION: " & TextBox3.Text)
        lista.Add("*******************************")
        If I = 1 Then
            TextBox4.Text = TextBox1.Text
            TextBox5.Text = TextBox2.Text
            TextBox6.Text = TextBox3.Text
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf I = 2 Then
            TextBox7.Text = TextBox1.Text
            TextBox8.Text = TextBox2.Text
            TextBox9.Text = TextBox3.Text
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf I = 3 Then
            TextBox4.Text = TextBox4.Text & ", " & TextBox1.Text
            TextBox5.Text = TextBox5.Text & ", " & TextBox2.Text
            TextBox6.Text = TextBox3.Text
        ElseIf I = 4 Then
            TextBox7.Text = TextBox7.Text & ", " & TextBox1.Text
            TextBox8.Text = TextBox8.Text & ", " & TextBox2.Text
            TextBox9.Text = TextBox3.Text
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each item As String In lista
            Me.ListBox1.Items.Add(item)
        Next item
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        'gjkghkgjkgjk
    End Sub
End Class
