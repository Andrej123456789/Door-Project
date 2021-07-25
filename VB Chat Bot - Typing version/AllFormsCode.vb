Public Class Form1

    Public UserList As New List(Of String)
    Public AutoList As New List(Of String)

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adding User values
        UserList.Add("Hello") '0
        UserList.Add("exit") '1
        UserList.Add("save") '2
        UserList.Add("flip the coin") '3
        UserList.Add("User name") '4
        UserList.Add("tips and tricks") '5, ...
        UserList.Add("help")
        UserList.Add("/0")
        UserList.Add("HOST OS")
        UserList.Add("start a session")

        'Adding Bot values
        AutoList.Add("Welcome!") '0
        AutoList.Add("My name is: Locker") '1, ...
        AutoList.Add("Most of Micorosft Word Home tab shortcut valid for our Notepad (all RichTextBoxes).")
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged
        If RichTextBox2.Text = "" Then
            TextBox2.Text = ""
        ElseIf RichTextBox2.Text = UserList(0) Then
            TextBox2.Text = AutoList(0)
        ElseIf RichTextBox2.Text = UserList(1) Then
            Me.Close()
        ElseIf RichTextBox2.Text = UserList(2) Then
            TextBox2.Text = "Error...!"
        ElseIf RichTextBox2.Text = UserList(3) Then
            Dim value As Integer = CInt(Int((6 * Rnd() + 1)))
            TextBox2.Text = value
        ElseIf RichTextBox2.Text = UserList(4) Then
            TextBox2.Text = AutoList(1)
        ElseIf RichTextBox2.Text = UserList(5) Then
            TextBox2.Text = AutoList(2)
        ElseIf RichTextBox2.Text = UserList(6) Then
            TextBox2.Text = ""

            For Each nexter In UserList
                MsgBox(nexter)
            Next
        ElseIf RichTextBox2.Text = UserList(7) Then
            TextBox2.Text = "Cannot divided by zero!!"
        ElseIf RichTextBox2.Text = UserList(8) Then
            TextBox2.Text = My.Computer.Info.OSFullName
        ElseIf RichTextBox2.Text = UserList(9) Then
            Form2.Show()
            'Dim Session As New Session
            'Session.session()

        ElseIf RichTextBox2.Text = "version" Then
            TextBox2.Text = "v1.0.0 Direct updates on GitHub"
        Else
            TextBox2.Text = "Error!! Try again..."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each Status In TextBox2.Text
            MsgBox(Status)
        Next
    End Sub
End Class


Public Class Form2

    Public UserAnswer As New List(Of String)
    Public AutoAnswer As New List(Of String)

    Dim username As String = Nothing
    Dim lastname As String = Nothing

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged
        If RichTextBox2.Text = "show names" Then
            TextBox2.Text = username & "" & lastname
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = RichTextBox2.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lastname = RichTextBox2.Text
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = "What's your name and surname: "
    End Sub
End Class