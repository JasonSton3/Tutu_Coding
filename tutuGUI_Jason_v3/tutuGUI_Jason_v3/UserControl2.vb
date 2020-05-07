Public Class UserControl2
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

        If TextBox11.Text = "" Then
            Exit Sub
        End If
        If TextBox10.Text = "-" Then
            TextBox10.ForeColor = Color.Red
            Exit Sub
        End If
        If TextBox10.Text = "" Then
            Exit Sub
        End If
        If Convert.ToInt32(Hex(TextBox10.Text), 16) - 65536 > Convert.ToInt32(Hex(TextBox11.Text), 16) - 65536 Then   'Expander-0 不能大於Expander-1
            TextBox10.ForeColor = Color.Red
        Else
            TextBox10.ForeColor = Color.Black
            TextBox11.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "2" Then
            TextBox9.ForeColor = Color.Black
            Label8.Enabled = False
            Label14.Enabled = False
            Label18.Enabled = False
            TextBox4.Enabled = False
            TextBox8.Enabled = False
        ElseIf TextBox9.Text = "3" Then
            TextBox9.ForeColor = Color.Black
            Label8.Enabled = True
            Label14.Enabled = True
            Label18.Enabled = True
            TextBox4.Enabled = True
            TextBox8.Enabled = True
        Else
            TextBox9.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

        If TextBox11.Text = "-" Then
            TextBox10.ForeColor = Color.Red
            Exit Sub
        End If
        If TextBox11.Text = "" Then
            Exit Sub
        End If
        If Convert.ToInt32(Hex(TextBox10.Text), 16) - 65536 > Convert.ToInt32(Hex(TextBox11.Text), 16) - 65536 Then   'Expander-0 不能大於Expander-1
            TextBox11.ForeColor = Color.Red
        Else
            TextBox10.ForeColor = Color.Black
            TextBox11.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UserControl2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If MouseButtons.Left = 1048576 Then
        '    MessageBox.Show("Mouse Left Button clicked")
        'End If

    End Sub
End Class
