Public Class UserControl1
    Public temp1 As Integer
    Public temp1array() As Integer
    Public temp2array() As Integer
    Public Sub dB_compare()
        '位置0 
        If Form1.dB_array(0) - Form1.dB_array_compare(0) = 0 Then
            Label37.Text = Form1.dB_array(0)
            Label37.ForeColor = Color.Black
        ElseIf Form1.dB_array(0) - Form1.dB_array_compare(0) > 0 Then
            Label37.Text = Form1.dB_array(0) & "(+" & Form1.dB_array(0) - Form1.dB_array_compare(0) & ")"
            Label37.ForeColor = Color.Blue
        Else
            Label37.Text = Form1.dB_array(0) & "(" & Form1.dB_array(0) - Form1.dB_array_compare(0) & ")"
            Label37.ForeColor = Color.Red
        End If
        '位置1 
        If Form1.dB_array(1) - Form1.dB_array_compare(1) = 0 Then
            Label38.Text = Form1.dB_array(1)
            Label38.ForeColor = Color.Black
        ElseIf Form1.dB_array(1) - Form1.dB_array_compare(1) > 0 Then
            Label38.Text = Form1.dB_array(1) & "(+" & Form1.dB_array(1) - Form1.dB_array_compare(1) & ")"
            Label38.ForeColor = Color.Blue
        Else
            Label38.Text = Form1.dB_array(1) & "(" & Form1.dB_array(1) - Form1.dB_array_compare(1) & ")"
            Label38.ForeColor = Color.Red
        End If
        '位置2
        If Form1.dB_array(2) - Form1.dB_array_compare(2) = 0 Then
            Label39.Text = Form1.dB_array(2)
            Label39.ForeColor = Color.Black

        ElseIf Form1.dB_array(2) - Form1.dB_array_compare(2) > 0 Then
            Label39.Text = Form1.dB_array(2) & "(+" & Form1.dB_array(2) - Form1.dB_array_compare(2) & ")"
            Label39.ForeColor = Color.Blue
        Else
            Label39.Text = Form1.dB_array(2) & "(" & Form1.dB_array(2) - Form1.dB_array_compare(2) & ")"
            Label39.ForeColor = Color.Red
        End If
        '位置3
        If Form1.dB_array(3) - Form1.dB_array_compare(3) = 0 Then
            Label40.Text = Form1.dB_array(3)
            Label40.ForeColor = Color.Black

        ElseIf Form1.dB_array(3) - Form1.dB_array_compare(3) > 0 Then
            Label40.Text = Form1.dB_array(3) & "(+" & Form1.dB_array(3) - Form1.dB_array_compare(3) & ")"
            Label40.ForeColor = Color.Blue
        Else
            Label40.Text = Form1.dB_array(3) & "(" & Form1.dB_array(3) - Form1.dB_array_compare(3) & ")"
            Label40.ForeColor = Color.Red
        End If
        '位置4
        If Form1.dB_array(4) - Form1.dB_array_compare(4) = 0 Then
            Label41.Text = Form1.dB_array(4)
            Label41.ForeColor = Color.Black

        ElseIf Form1.dB_array(4) - Form1.dB_array_compare(4) > 0 Then
            Label41.Text = Form1.dB_array(4) & "(+" & Form1.dB_array(4) - Form1.dB_array_compare(4) & ")"
            Label41.ForeColor = Color.Blue
        Else
            Label41.Text = Form1.dB_array(4) & "(" & Form1.dB_array(4) - Form1.dB_array_compare(4) & ")"
            Label41.ForeColor = Color.Red
        End If
        '位置5
        If Form1.dB_array(5) - Form1.dB_array_compare(5) = 0 Then
            Label42.Text = Form1.dB_array(5)
            Label42.ForeColor = Color.Black

        ElseIf Form1.dB_array(5) - Form1.dB_array_compare(5) > 0 Then
            Label42.Text = Form1.dB_array(5) & "(+" & Form1.dB_array(5) - Form1.dB_array_compare(5) & ")"
            Label42.ForeColor = Color.Blue
        Else
            Label42.Text = Form1.dB_array(5) & "(" & Form1.dB_array(5) - Form1.dB_array_compare(5) & ")"
            Label42.ForeColor = Color.Red
        End If
        '位置6
        If Form1.dB_array(6) - Form1.dB_array_compare(6) = 0 Then
            Label43.Text = Form1.dB_array(6)
            Label43.ForeColor = Color.Black

        ElseIf Form1.dB_array(6) - Form1.dB_array_compare(6) > 0 Then
            Label43.Text = Form1.dB_array(6) & "(+" & Form1.dB_array(6) - Form1.dB_array_compare(6) & ")"
            Label43.ForeColor = Color.Blue
        Else
            Label43.Text = Form1.dB_array(6) & "(" & Form1.dB_array(6) - Form1.dB_array_compare(6) & ")"
            Label43.ForeColor = Color.Red
        End If
        '位置7
        If Form1.dB_array(7) - Form1.dB_array_compare(7) = 0 Then
            Label44.Text = Form1.dB_array(7)
            Label44.ForeColor = Color.Black

        ElseIf Form1.dB_array(7) - Form1.dB_array_compare(7) > 0 Then
            Label44.Text = Form1.dB_array(7) & "(+" & Form1.dB_array(7) - Form1.dB_array_compare(7) & ")"
            Label44.ForeColor = Color.Blue
        Else
            Label44.Text = Form1.dB_array(7) & "(" & Form1.dB_array(7) - Form1.dB_array_compare(7) & ")"
            Label44.ForeColor = Color.Red
        End If
        '位置8
        If Form1.dB_array(8) - Form1.dB_array_compare(8) = 0 Then
            Label45.Text = Form1.dB_array(8)
            Label45.ForeColor = Color.Black

        ElseIf Form1.dB_array(8) - Form1.dB_array_compare(8) > 0 Then
            Label45.Text = Form1.dB_array(8) & "(+" & Form1.dB_array(8) - Form1.dB_array_compare(8) & ")"
            Label45.ForeColor = Color.Blue
        Else
            Label45.Text = Form1.dB_array(8) & "(" & Form1.dB_array(8) - Form1.dB_array_compare(8) & ")"
            Label45.ForeColor = Color.Red
        End If
        '位置9
        If Form1.dB_array(9) - Form1.dB_array_compare(9) = 0 Then
            Label46.Text = Form1.dB_array(9)
            Label46.ForeColor = Color.Black

        ElseIf Form1.dB_array(9) - Form1.dB_array_compare(9) > 0 Then
            Label46.Text = Form1.dB_array(9) & "(+" & Form1.dB_array(9) - Form1.dB_array_compare(9) & ")"
            Label46.ForeColor = Color.Blue
        Else
            Label46.Text = Form1.dB_array(9) & "(" & Form1.dB_array(9) - Form1.dB_array_compare(9) & ")"
            Label46.ForeColor = Color.Red
        End If
        '位置10
        If Form1.dB_array(10) - Form1.dB_array_compare(10) = 0 Then
            Label47.Text = Form1.dB_array(10)
            Label47.ForeColor = Color.Black

        ElseIf Form1.dB_array(10) - Form1.dB_array_compare(10) > 0 Then
            Label47.Text = Form1.dB_array(10) & "(+" & Form1.dB_array(10) - Form1.dB_array_compare(10) & ")"
            Label47.ForeColor = Color.Blue
        Else
            Label47.Text = Form1.dB_array(10) & "(" & Form1.dB_array(10) - Form1.dB_array_compare(10) & ")"
            Label47.ForeColor = Color.Red
        End If
        '位置11
        If Form1.dB_array(11) - Form1.dB_array_compare(11) = 0 Then
            Label48.Text = Form1.dB_array(11)
            Label48.ForeColor = Color.Black

        ElseIf Form1.dB_array(11) - Form1.dB_array_compare(11) > 0 Then
            Label48.Text = Form1.dB_array(11) & "(+" & Form1.dB_array(11) - Form1.dB_array_compare(11) & ")"
            Label48.ForeColor = Color.Blue
        Else
            Label48.Text = Form1.dB_array(11) & "(" & Form1.dB_array(11) - Form1.dB_array_compare(11) & ")"
            Label48.ForeColor = Color.Red
        End If
        '位置12
        If Form1.dB_array(12) - Form1.dB_array_compare(12) = 0 Then
            Label49.Text = Form1.dB_array(12)
            Label49.ForeColor = Color.Black

        ElseIf Form1.dB_array(12) - Form1.dB_array_compare(12) > 0 Then
            Label49.Text = Form1.dB_array(12) & "(+" & Form1.dB_array(12) - Form1.dB_array_compare(12) & ")"
            Label49.ForeColor = Color.Blue
        Else
            Label49.Text = Form1.dB_array(12) & "(" & Form1.dB_array(0) - Form1.dB_array_compare(12) & ")"
            Label49.ForeColor = Color.Red
        End If
        '位置13
        If Form1.dB_array(13) - Form1.dB_array_compare(13) = 0 Then
            Label50.Text = Form1.dB_array(13)
            Label50.ForeColor = Color.Black

        ElseIf Form1.dB_array(13) - Form1.dB_array_compare(13) > 0 Then
            Label50.Text = Form1.dB_array(13) & "(+" & Form1.dB_array(13) - Form1.dB_array_compare(13) & ")"
            Label50.ForeColor = Color.Blue
        Else
            Label50.Text = Form1.dB_array(13) & "(" & Form1.dB_array(13) - Form1.dB_array_compare(13) & ")"
            Label50.ForeColor = Color.Red
        End If
        '位置14
        If Form1.dB_array(14) - Form1.dB_array_compare(14) = 0 Then
            Label51.Text = Form1.dB_array(14)
            Label51.ForeColor = Color.Black

        ElseIf Form1.dB_array(14) - Form1.dB_array_compare(14) > 0 Then
            Label51.Text = Form1.dB_array(14) & "(+" & Form1.dB_array(14) - Form1.dB_array_compare(14) & ")"
            Label51.ForeColor = Color.Blue
        Else
            Label51.Text = Form1.dB_array(14) & "(" & Form1.dB_array(14) - Form1.dB_array_compare(14) & ")"
            Label51.ForeColor = Color.Red
        End If
        '位置15
        If Form1.dB_array(15) - Form1.dB_array_compare(15) = 0 Then
            Label52.Text = Form1.dB_array(15)
            Label52.ForeColor = Color.Black

        ElseIf Form1.dB_array(15) - Form1.dB_array_compare(15) > 0 Then
            Label52.Text = Form1.dB_array(15) & "(+" & Form1.dB_array(15) - Form1.dB_array_compare(15) & ")"
            Label52.ForeColor = Color.Blue
        Else
            Label52.Text = Form1.dB_array(15) & "(" & Form1.dB_array(15) - Form1.dB_array_compare(15) & ")"
            Label52.ForeColor = Color.Red
        End If

    End Sub
    Public Shared Sub InsertArrayElement(Of T)(    ' Insert Value in any position from Array
          ByRef sourceArray() As T,
          ByVal insertIndex As Integer,
          ByVal newValue As T)

        Dim newPosition As Integer
        Dim counter As Integer

        newPosition = insertIndex
        If (newPosition < 0) Then
            newPosition = 0
        End If

        If (newPosition > sourceArray.Length) Then
            newPosition = sourceArray.Length
        End If

        Array.Resize(sourceArray, sourceArray.Length + 1)

        For counter = sourceArray.Length - 2 To newPosition Step -1
            sourceArray(counter + 1) = sourceArray(counter)
        Next counter

        sourceArray(newPosition) = newValue
    End Sub
    Public Sub Start_EQ_Refresh_By_Last_End_EQ()
        Dim refresh_i As Integer
        For refresh_i = 1 To 15
            'If refresh_i < 14 Then
            If Form1.EQ_end_freq_in_Decimal(refresh_i) <> 0 Then
                Form1.EQ_start_freq_in_Decimal(refresh_i) = Form1.EQ_end_freq_in_Decimal(refresh_i - 1)
            Else
                Form1.EQ_start_freq_in_Decimal(refresh_i) = Form1.EQ_end_freq_in_Decimal(refresh_i)
            End If
            'End If

        Next
        'Form1.EQ_start_label_refresh()    <-   no need, already wrote it and being after this sub in other calling function

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            Form1.array_from_clipboard_2D(1, 58) = "0x0001"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            Form1.array_from_clipboard_2D(1, 58) = "0x0003"
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox3.Checked = False
            CheckBox7.Checked = False
            Form1.array_from_clipboard_2D(1, 58) = "0x0005"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            Form1.array_from_clipboard_2D(1, 58) = "0x0000"
        End If


    End Sub

    Private Sub Chart1_Click_1(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            Form1.array_from_clipboard_2D(1, 58) = "0x0002"
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            CheckBox4.Checked = False
            CheckBox3.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            Form1.array_from_clipboard_2D(1, 58) = "0x0004"
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox3.Checked = False
            Form1.array_from_clipboard_2D(1, 58) = "0x0006"

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click  'Add Click
        Dim i_add As Integer
        Dim i_check_equals As Integer
        Dim check_start_equals As Integer = 0
        Dim check_end_equals As Integer = 0
        Dim end_add As Integer = 8000
        Dim debug_1(3) As Integer
        Dim input_value_as_array(2) As Integer
        '---------------------------check if one of input-start or input-end is empty or not
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter your value completely!")
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please enter your value correctly!")
            Exit Sub
        End If

        '---------------------------check if input-start > input-end
        If Convert.ToInt32(TextBox1.Text) > Convert.ToInt32(TextBox2.Text) Then
            MessageBox.Show("Please enter your value completely!")
            Exit Sub
        End If


        '---------------------------check Input start and end were within bandwidth setting or not
        input_value_as_array(0) = Convert.ToInt32(TextBox1.Text)
        input_value_as_array(1) = Convert.ToInt32(TextBox2.Text)
        If CheckBox8.Checked = True Then          ':    判斷當下add的 frequency是否為在限制頻帶內: NB
            If input_value_as_array.Max > 4000 Then
                MessageBox.Show("Out Of NB Bandwitdh Range!")
                Exit Sub
            End If
        ElseIf CheckBox9.Checked = True Then
            If input_value_as_array.Max > 8000 Then
                MessageBox.Show("Out Of WB Bandwitdh Range!")
                Exit Sub
            End If
        ElseIf CheckBox10.Checked = True Then
            If input_value_as_array.Max > 16000 Then
                MessageBox.Show("Out Of SWB Bandwitdh Range!")
                Exit Sub
            End If
        ElseIf CheckBox11.Checked = True Then
            If input_value_as_array.Max > 24000 Then
                MessageBox.Show("Out Of FB Bandwitdh Range!")
                Exit Sub
            End If
        End If
        '---------------------------check Input-Start Equals to one of Original-Start or not
        For i_check_equals = 0 To 15
            If Form1.EQ_start_freq_in_Decimal(i_check_equals) = Convert.ToInt32(TextBox1.Text) Then
                check_start_equals += 1
                Exit For
            End If
            'Form1.EQ_end_refresh()   ;   debug專用
        Next
        '---------------------------check Input-End Equals to one of Original-End or not
        For i_check_equals = 0 To 15
            If Form1.EQ_end_freq_in_Decimal(i_check_equals) = Convert.ToInt32(TextBox2.Text) Then
                check_end_equals += 1
                Exit For
            End If

            'Form1.EQ_end_refresh()     ;   debug專用
        Next
        '---------------------------check Sum Equals or not
        If check_start_equals + check_end_equals > 1 Then
            MessageBox.Show("Wrong Value !")
            Exit Sub
        End If
        '---------------------------Add End Frequency, TextBox1 = Input-start;TextBox2 = Input-End
        For i_add = 0 To 15
            temp1 = Form1.EQ_end_freq_in_Decimal(i_add)


            If Form1.EQ_end_freq_in_Decimal(i_add) > Convert.ToInt32(TextBox2.Text) Then 'Input end < original end, (=,<) (<,<)
                InsertArrayElement(Of Integer)(Form1.EQ_end_freq_in_Decimal, i_add, Convert.ToInt32(TextBox2.Text))
                InsertArrayElement(Of Integer)(Form1.dB_array, i_add, Form1.dB_array(i_add))  ' Insert dB 
                'InsertArrayElement(Of Integer)(Form1.dB_array_compare, i_add, Form1.dB_array(i_add))  ' Insert dB_compare
                InsertArrayElement(Of Integer)(Form1.dB_array_compare, i_add, Form1.dB_array_compare(i_add))  ' Insert dB_compare try_v1
                'Form1.EQ_end_refresh()  '更新panel上 EQ end的顯示
                'Form1.dB_refresh()      '更新panel上的 dB 顯示
                Start_EQ_Refresh_By_Last_End_EQ()  '<= check if this is needed or not?
                Form1.EQ_start_label_refresh()
                Exit For

            ElseIf Form1.EQ_end_freq_in_Decimal(i_add) = Convert.ToInt32(TextBox2.Text) Then  'Input end = original end, then to find input start insert position in EQ end array
                '不做事
                Exit For
            ElseIf Form1.EQ_end_freq_in_Decimal(i_add) = 0 Then
                InsertArrayElement(Of Integer)(Form1.EQ_end_freq_in_Decimal, i_add, Convert.ToInt32(TextBox2.Text))
                InsertArrayElement(Of Integer)(Form1.dB_array, i_add, Form1.dB_array(i_add))  ' Insert dB
                'InsertArrayElement(Of Integer)(Form1.dB_array_compare, i_add, Form1.dB_array(i_add))  ' Insert dB_compare
                InsertArrayElement(Of Integer)(Form1.dB_array_compare, i_add, Form1.dB_array_compare(i_add))  ' Insert dB_compare try_v1
                Start_EQ_Refresh_By_Last_End_EQ()  '<= check if this is needed or not?
                Form1.EQ_start_label_refresh()
                Exit For
            ElseIf Form1.EQ_end_freq_in_Decimal(i_add + 1) = 0 Then ' If input end > all original ends
                InsertArrayElement(Of Integer)(Form1.EQ_end_freq_in_Decimal, i_add + 1, Convert.ToInt32(TextBox2.Text))
                Start_EQ_Refresh_By_Last_End_EQ()                                             ' Establish Start EQ 

                InsertArrayElement(Of Integer)(Form1.dB_array, i_add + 1, 0)  ' Insert dB

                InsertArrayElement(Of Integer)(Form1.dB_array_compare, i_add + 1, 0)  ' Insert dB_compare
                Form1.EQ_start_label_refresh()

                'InsertArrayElement(Of Integer)(Form1.dB_array, i_add, Form1.dB_array(i_add - 1))  ' 這段註解，因為外加超出的頻段dB為本就為0
                Exit For
            End If

        Next

        '---------------------------Add Start Frequency 
        For i_add = 0 To 15
            If Form1.EQ_start_freq_in_Decimal(i_add) = Convert.ToInt32(TextBox1.Text) Then
                Exit For
            ElseIf Form1.EQ_end_freq_in_Decimal(i_add) > Convert.ToInt32(TextBox1.Text) Then 'Input start > original start
                InsertArrayElement(Of Integer)(Form1.EQ_end_freq_in_Decimal, i_add, Convert.ToInt32(TextBox1.Text))
                InsertArrayElement(Of Integer)(Form1.dB_array, i_add, Form1.dB_array(i_add)) ' add dB
                'InsertArrayElement(Of Integer)(Form1.dB_array_compare, i_add, Form1.dB_array(i_add))  ' Insert dB_compare 
                InsertArrayElement(Of Integer)(Form1.dB_array_compare, i_add, Form1.dB_array_compare(i_add))  ' Insert dB_compare try_v1

                Start_EQ_Refresh_By_Last_End_EQ() '<= check if this is needed or not?
                Form1.EQ_start_label_refresh()
                'Form1.EQ_end_refresh() ''<= check if this is needed or not? looks like it should be changed into EQ_start_refresh
                Exit For

            ElseIf Form1.EQ_end_freq_in_Decimal(i_add) = Convert.ToInt32(TextBox1.Text) Then  'Input end = original end, then to find input start insert position in EQ end array
                '不做事
                Exit For
            ElseIf Form1.EQ_end_freq_in_Decimal(i_add + 1) = 0 Then ' If input start > all original ends
                InsertArrayElement(Of Integer)(Form1.EQ_end_freq_in_Decimal, i_add + 1, Convert.ToInt32(TextBox1.Text))
                'InsertArrayElement(Of Integer)(Form1.dB_array, i_add, Form1.dB_array(i_add)) '這段註解，因為外加超出的頻段dB為本就為0
                Exit For
            End If

        Next
        Form1.debug_into_form1()




        Form1.EQ_start_label_refresh()    '在每一次Add click後 refresh EQ start array
        Form1.EQ_end_label_refresh()      '在每一次Add click後 refresh EQ end array
        Form1.dB_label_refresh()          '在每一次Add click後 refresh dB array
        dB_compare()

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'dB (0) increase gain
        If Form1.EQ_end_freq_in_Decimal(0) = 0 Then             ' 用來判斷當頻段沒有頻率值時，不能加減dB
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(0) += 1  'value increase 1 after one click

        '------------- dB array與 dB array compare 互相比較 以 顯示 正負值
        If Form1.dB_array(0) - Form1.dB_array_compare(0) = 0 Then
            Label37.Text = Form1.dB_array(0)
            Label37.ForeColor = Color.Black
        ElseIf Form1.dB_array(0) - Form1.dB_array_compare(0) > 0 Then
            Label37.Text = Form1.dB_array(0) & "(+" & Form1.dB_array(0) - Form1.dB_array_compare(0) & ")"
            Label37.ForeColor = Color.Blue
        Else
            Label37.Text = Form1.dB_array(0) & "(" & Form1.dB_array(0) - Form1.dB_array_compare(0) & ")"
            Label37.ForeColor = Color.Red
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'dB (0) decrease gain
        If Form1.EQ_end_freq_in_Decimal(0) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(0) -= 1      'value decrease 1 after one click
        If Form1.dB_array(0) - Form1.dB_array_compare(0) = 0 Then
            Label37.Text = Form1.dB_array(0)
            Label37.ForeColor = Color.Black

        ElseIf Form1.dB_array(0) - Form1.dB_array_compare(0) > 0 Then
            Label37.Text = Form1.dB_array(0) & "(+" & Form1.dB_array(0) - Form1.dB_array_compare(0) & ")"
            Label37.ForeColor = Color.Blue
        Else
            Label37.Text = Form1.dB_array(0) & "(" & Form1.dB_array(0) - Form1.dB_array_compare(0) & ")"
            Label37.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click   'dB (1) increase gain
        If Form1.EQ_end_freq_in_Decimal(1) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(1) += 1
        If Form1.dB_array(1) - Form1.dB_array_compare(1) = 0 Then
            Label38.Text = Form1.dB_array(1)
            Label38.ForeColor = Color.Black
        ElseIf Form1.dB_array(1) - Form1.dB_array_compare(1) > 0 Then
            Label38.Text = Form1.dB_array(1) & "(+" & Form1.dB_array(1) - Form1.dB_array_compare(1) & ")"
            Label38.ForeColor = Color.Blue
        Else
            Label38.Text = Form1.dB_array(1) & "(" & Form1.dB_array(1) - Form1.dB_array_compare(1) & ")"
            Label38.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click   'dB (1) decrease gain
        If Form1.EQ_end_freq_in_Decimal(1) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(1) -= 1
        If Form1.dB_array(1) - Form1.dB_array_compare(1) = 0 Then
            Label38.Text = Form1.dB_array(0)
            Label38.ForeColor = Color.Black

        ElseIf Form1.dB_array(1) - Form1.dB_array_compare(1) > 0 Then
            Label38.Text = Form1.dB_array(1) & "(+" & Form1.dB_array(1) - Form1.dB_array_compare(1) & ")"
            Label38.ForeColor = Color.Blue
        Else
            Label38.Text = Form1.dB_array(1) & "(" & Form1.dB_array(1) - Form1.dB_array_compare(1) & ")"
            Label38.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'dB (2) increase gain
        If Form1.EQ_end_freq_in_Decimal(2) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(2) += 1
        If Form1.dB_array(2) - Form1.dB_array_compare(2) = 0 Then
            Label39.Text = Form1.dB_array(2)
            Label39.ForeColor = Color.Black

        ElseIf Form1.dB_array(2) - Form1.dB_array_compare(2) > 0 Then
            Label39.Text = Form1.dB_array(2) & "(+" & Form1.dB_array(2) - Form1.dB_array_compare(2) & ")"
            Label39.ForeColor = Color.Blue
        Else
            Label39.Text = Form1.dB_array(2) & "(" & Form1.dB_array(2) - Form1.dB_array_compare(2) & ")"
            Label39.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'dB (2) decrease gain
        If Form1.EQ_end_freq_in_Decimal(2) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(2) -= 1
        If Form1.dB_array(2) - Form1.dB_array_compare(2) = 0 Then
            Label39.Text = Form1.dB_array(2)
            Label39.ForeColor = Color.Black

        ElseIf Form1.dB_array(2) - Form1.dB_array_compare(2) > 0 Then
            Label39.Text = Form1.dB_array(2) & "(+" & Form1.dB_array(2) - Form1.dB_array_compare(2) & ")"
            Label39.ForeColor = Color.Blue
        Else
            Label39.Text = Form1.dB_array(2) & "(" & Form1.dB_array(2) - Form1.dB_array_compare(2) & ")"
            Label39.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'dB (3) increase gain
        If Form1.EQ_end_freq_in_Decimal(3) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(3) += 1
        If Form1.dB_array(3) - Form1.dB_array_compare(3) = 0 Then
            Label40.Text = Form1.dB_array(3)
            Label40.ForeColor = Color.Black

        ElseIf Form1.dB_array(3) - Form1.dB_array_compare(3) > 0 Then
            Label40.Text = Form1.dB_array(3) & "(+" & Form1.dB_array(3) - Form1.dB_array_compare(3) & ")"
            Label40.ForeColor = Color.Blue
        Else
            Label40.Text = Form1.dB_array(3) & "(" & Form1.dB_array(3) - Form1.dB_array_compare(3) & ")"
            Label40.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'dB (3) decrease gain
        If Form1.EQ_end_freq_in_Decimal(3) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(3) -= 1
        If Form1.dB_array(3) - Form1.dB_array_compare(3) = 0 Then
            Label40.Text = Form1.dB_array(3)
            Label40.ForeColor = Color.Black

        ElseIf Form1.dB_array(3) - Form1.dB_array_compare(3) > 0 Then
            Label40.Text = Form1.dB_array(3) & "(+" & Form1.dB_array(3) - Form1.dB_array_compare(3) & ")"
            Label40.ForeColor = Color.Blue
        Else
            Label40.Text = Form1.dB_array(3) & "(" & Form1.dB_array(3) - Form1.dB_array_compare(3) & ")"
            Label40.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'dB (4) increase gain
        If Form1.EQ_end_freq_in_Decimal(4) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(4) += 1
        If Form1.dB_array(4) - Form1.dB_array_compare(4) = 0 Then
            Label41.Text = Form1.dB_array(4)
            Label41.ForeColor = Color.Black

        ElseIf Form1.dB_array(4) - Form1.dB_array_compare(4) > 0 Then
            Label41.Text = Form1.dB_array(4) & "(+" & Form1.dB_array(4) - Form1.dB_array_compare(4) & ")"
            Label41.ForeColor = Color.Blue
        Else
            Label41.Text = Form1.dB_array(4) & "(" & Form1.dB_array(4) - Form1.dB_array_compare(4) & ")"
            Label41.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'dB (4) decrease gain
        If Form1.EQ_end_freq_in_Decimal(4) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(4) -= 1
        If Form1.dB_array(4) - Form1.dB_array_compare(4) = 0 Then
            Label41.Text = Form1.dB_array(4)
            Label41.ForeColor = Color.Black

        ElseIf Form1.dB_array(4) - Form1.dB_array_compare(4) > 0 Then
            Label41.Text = Form1.dB_array(4) & "(+" & Form1.dB_array(4) - Form1.dB_array_compare(4) & ")"
            Label41.ForeColor = Color.Blue
        Else
            Label41.Text = Form1.dB_array(4) & "(" & Form1.dB_array(4) - Form1.dB_array_compare(4) & ")"
            Label41.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'dB (5) increase gain
        If Form1.EQ_end_freq_in_Decimal(5) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(5) += 1
        If Form1.dB_array(5) - Form1.dB_array_compare(5) = 0 Then
            Label42.Text = Form1.dB_array(5)
            Label42.ForeColor = Color.Black

        ElseIf Form1.dB_array(5) - Form1.dB_array_compare(5) > 0 Then
            Label42.Text = Form1.dB_array(5) & "(+" & Form1.dB_array(5) - Form1.dB_array_compare(5) & ")"
            Label42.ForeColor = Color.Blue
        Else
            Label42.Text = Form1.dB_array(5) & "(" & Form1.dB_array(5) - Form1.dB_array_compare(5) & ")"
            Label42.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'dB (5) decrease gain
        If Form1.EQ_end_freq_in_Decimal(5) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(5) -= 1
        If Form1.dB_array(5) - Form1.dB_array_compare(5) = 0 Then
            Label42.Text = Form1.dB_array(5)
            Label42.ForeColor = Color.Black

        ElseIf Form1.dB_array(5) - Form1.dB_array_compare(5) > 0 Then
            Label42.Text = Form1.dB_array(5) & "(+" & Form1.dB_array(5) - Form1.dB_array_compare(5) & ")"
            Label42.ForeColor = Color.Blue
        Else
            Label42.Text = Form1.dB_array(5) & "(" & Form1.dB_array(5) - Form1.dB_array_compare(5) & ")"
            Label42.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'dB (6) increase gain
        If Form1.EQ_end_freq_in_Decimal(6) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(6) += 1
        If Form1.dB_array(6) - Form1.dB_array_compare(6) = 0 Then
            Label43.Text = Form1.dB_array(6)
            Label43.ForeColor = Color.Black

        ElseIf Form1.dB_array(6) - Form1.dB_array_compare(6) > 0 Then
            Label43.Text = Form1.dB_array(6) & "(+" & Form1.dB_array(6) - Form1.dB_array_compare(6) & ")"
            Label43.ForeColor = Color.Blue
        Else
            Label43.Text = Form1.dB_array(6) & "(" & Form1.dB_array(6) - Form1.dB_array_compare(6) & ")"
            Label43.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'dB (6) decrease gain
        If Form1.EQ_end_freq_in_Decimal(6) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(6) -= 1
        If Form1.dB_array(6) - Form1.dB_array_compare(6) = 0 Then
            Label43.Text = Form1.dB_array(6)
            Label43.ForeColor = Color.Black

        ElseIf Form1.dB_array(6) - Form1.dB_array_compare(6) > 0 Then
            Label43.Text = Form1.dB_array(6) & "(+" & Form1.dB_array(6) - Form1.dB_array_compare(6) & ")"
            Label43.ForeColor = Color.Blue
        Else
            Label43.Text = Form1.dB_array(6) & "(" & Form1.dB_array(6) - Form1.dB_array_compare(6) & ")"
            Label43.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'dB (7) increase gain
        If Form1.EQ_end_freq_in_Decimal(7) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(7) += 1
        If Form1.dB_array(7) - Form1.dB_array_compare(7) = 0 Then
            Label44.Text = Form1.dB_array(7)
            Label44.ForeColor = Color.Black

        ElseIf Form1.dB_array(7) - Form1.dB_array_compare(7) > 0 Then
            Label44.Text = Form1.dB_array(7) & "(+" & Form1.dB_array(7) - Form1.dB_array_compare(7) & ")"
            Label44.ForeColor = Color.Blue
        Else
            Label44.Text = Form1.dB_array(7) & "(" & Form1.dB_array(7) - Form1.dB_array_compare(7) & ")"
            Label44.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'dB (7) decrease gain
        If Form1.EQ_end_freq_in_Decimal(7) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(7) -= 1
        If Form1.dB_array(7) - Form1.dB_array_compare(7) = 0 Then
            Label44.Text = Form1.dB_array(7)
            Label44.ForeColor = Color.Black

        ElseIf Form1.dB_array(7) - Form1.dB_array_compare(7) > 0 Then
            Label44.Text = Form1.dB_array(7) & "(+" & Form1.dB_array(7) - Form1.dB_array_compare(7) & ")"
            Label44.ForeColor = Color.Blue
        Else
            Label44.Text = Form1.dB_array(7) & "(" & Form1.dB_array(7) - Form1.dB_array_compare(7) & ")"
            Label44.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'dB (8) increase gain
        If Form1.EQ_end_freq_in_Decimal(8) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(8) += 1
        If Form1.dB_array(8) - Form1.dB_array_compare(8) = 0 Then
            Label45.Text = Form1.dB_array(8)
            Label45.ForeColor = Color.Black

        ElseIf Form1.dB_array(8) - Form1.dB_array_compare(8) > 0 Then
            Label45.Text = Form1.dB_array(8) & "(+" & Form1.dB_array(8) - Form1.dB_array_compare(8) & ")"
            Label45.ForeColor = Color.Blue
        Else
            Label45.Text = Form1.dB_array(8) & "(" & Form1.dB_array(8) - Form1.dB_array_compare(8) & ")"
            Label45.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        'dB (8) decrease gain
        If Form1.EQ_end_freq_in_Decimal(8) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(8) -= 1
        If Form1.dB_array(8) - Form1.dB_array_compare(8) = 0 Then
            Label45.Text = Form1.dB_array(8)
            Label45.ForeColor = Color.Black

        ElseIf Form1.dB_array(8) - Form1.dB_array_compare(8) > 0 Then
            Label45.Text = Form1.dB_array(8) & "(+" & Form1.dB_array(8) - Form1.dB_array_compare(8) & ")"
            Label45.ForeColor = Color.Blue
        Else
            Label45.Text = Form1.dB_array(8) & "(" & Form1.dB_array(8) - Form1.dB_array_compare(8) & ")"
            Label45.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        'dB (9) increase gain
        If Form1.EQ_end_freq_in_Decimal(9) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(9) += 1
        If Form1.dB_array(9) - Form1.dB_array_compare(9) = 0 Then
            Label46.Text = Form1.dB_array(9)
            Label46.ForeColor = Color.Black

        ElseIf Form1.dB_array(9) - Form1.dB_array_compare(9) > 0 Then
            Label46.Text = Form1.dB_array(9) & "(+" & Form1.dB_array(9) - Form1.dB_array_compare(9) & ")"
            Label46.ForeColor = Color.Blue
        Else
            Label46.Text = Form1.dB_array(9) & "(" & Form1.dB_array(9) - Form1.dB_array_compare(9) & ")"
            Label46.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        'dB (9) decrease gain
        If Form1.EQ_end_freq_in_Decimal(9) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(9) -= 1
        If Form1.dB_array(9) - Form1.dB_array_compare(9) = 0 Then
            Label46.Text = Form1.dB_array(9)
            Label46.ForeColor = Color.Black

        ElseIf Form1.dB_array(9) - Form1.dB_array_compare(9) > 0 Then
            Label46.Text = Form1.dB_array(9) & "(+" & Form1.dB_array(9) - Form1.dB_array_compare(9) & ")"
            Label46.ForeColor = Color.Blue
        Else
            Label46.Text = Form1.dB_array(9) & "(" & Form1.dB_array(9) - Form1.dB_array_compare(9) & ")"
            Label46.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        'dB (10) increase gain
        If Form1.EQ_end_freq_in_Decimal(10) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(10) += 1
        If Form1.dB_array(10) - Form1.dB_array_compare(10) = 0 Then
            Label47.Text = Form1.dB_array(10)
            Label47.ForeColor = Color.Black

        ElseIf Form1.dB_array(10) - Form1.dB_array_compare(10) > 0 Then
            Label47.Text = Form1.dB_array(10) & "(+" & Form1.dB_array(10) - Form1.dB_array_compare(10) & ")"
            Label47.ForeColor = Color.Blue
        Else
            Label47.Text = Form1.dB_array(10) & "(" & Form1.dB_array(10) - Form1.dB_array_compare(10) & ")"
            Label47.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        'dB (10) decrease gain
        If Form1.EQ_end_freq_in_Decimal(10) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(10) -= 1
        If Form1.dB_array(10) - Form1.dB_array_compare(10) = 0 Then
            Label47.Text = Form1.dB_array(10)
            Label47.ForeColor = Color.Black

        ElseIf Form1.dB_array(10) - Form1.dB_array_compare(10) > 0 Then
            Label47.Text = Form1.dB_array(10) & "(+" & Form1.dB_array(10) - Form1.dB_array_compare(10) & ")"
            Label47.ForeColor = Color.Blue
        Else
            Label47.Text = Form1.dB_array(10) & "(" & Form1.dB_array(10) - Form1.dB_array_compare(10) & ")"
            Label47.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        'dB (11) increase gain
        If Form1.EQ_end_freq_in_Decimal(12) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(11) += 1
        If Form1.dB_array(11) - Form1.dB_array_compare(11) = 0 Then
            Label48.Text = Form1.dB_array(11)
            Label48.ForeColor = Color.Black

        ElseIf Form1.dB_array(11) - Form1.dB_array_compare(11) > 0 Then
            Label48.Text = Form1.dB_array(11) & "(+" & Form1.dB_array(11) - Form1.dB_array_compare(11) & ")"
            Label48.ForeColor = Color.Blue
        Else
            Label48.Text = Form1.dB_array(11) & "(" & Form1.dB_array(11) - Form1.dB_array_compare(11) & ")"
            Label48.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        'dB (11) decrease gain
        If Form1.EQ_end_freq_in_Decimal(11) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(11) -= 1
        If Form1.dB_array(11) - Form1.dB_array_compare(11) = 0 Then
            Label48.Text = Form1.dB_array(11)
            Label48.ForeColor = Color.Black

        ElseIf Form1.dB_array(11) - Form1.dB_array_compare(11) > 0 Then
            Label48.Text = Form1.dB_array(11) & "(+" & Form1.dB_array(11) - Form1.dB_array_compare(11) & ")"
            Label48.ForeColor = Color.Blue
        Else
            Label48.Text = Form1.dB_array(11) & "(" & Form1.dB_array(11) - Form1.dB_array_compare(11) & ")"
            Label48.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        'dB (12) increase gain
        If Form1.EQ_end_freq_in_Decimal(12) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(12) += 1
        If Form1.dB_array(12) - Form1.dB_array_compare(12) = 0 Then
            Label49.Text = Form1.dB_array(12)
            Label49.ForeColor = Color.Black

        ElseIf Form1.dB_array(12) - Form1.dB_array_compare(12) > 0 Then
            Label49.Text = Form1.dB_array(12) & "(+" & Form1.dB_array(12) - Form1.dB_array_compare(12) & ")"
            Label49.ForeColor = Color.Blue
        Else
            Label49.Text = Form1.dB_array(12) & "(" & Form1.dB_array(0) - Form1.dB_array_compare(12) & ")"
            Label49.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        'dB (12) decrease gain
        If Form1.EQ_end_freq_in_Decimal(12) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(12) -= 1
        If Form1.dB_array(12) - Form1.dB_array_compare(12) = 0 Then
            Label49.Text = Form1.dB_array(12)
            Label49.ForeColor = Color.Black

        ElseIf Form1.dB_array(12) - Form1.dB_array_compare(12) > 0 Then
            Label49.Text = Form1.dB_array(12) & "(+" & Form1.dB_array(12) - Form1.dB_array_compare(12) & ")"
            Label49.ForeColor = Color.Blue
        Else
            Label49.Text = Form1.dB_array(12) & "(" & Form1.dB_array(12) - Form1.dB_array_compare(12) & ")"
            Label49.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        'dB (13) increase gain
        If Form1.EQ_end_freq_in_Decimal(13) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(13) += 1
        If Form1.dB_array(13) - Form1.dB_array_compare(13) = 0 Then
            Label50.Text = Form1.dB_array(13)
            Label50.ForeColor = Color.Black

        ElseIf Form1.dB_array(13) - Form1.dB_array_compare(13) > 0 Then
            Label50.Text = Form1.dB_array(13) & "(+" & Form1.dB_array(13) - Form1.dB_array_compare(13) & ")"
            Label50.ForeColor = Color.Blue
        Else
            Label50.Text = Form1.dB_array(13) & "(" & Form1.dB_array(13) - Form1.dB_array_compare(13) & ")"
            Label50.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        'dB (13) decrease gain
        If Form1.EQ_end_freq_in_Decimal(13) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(13) -= 1
        If Form1.dB_array(13) - Form1.dB_array_compare(13) = 0 Then
            Label50.Text = Form1.dB_array(13)
            Label50.ForeColor = Color.Black

        ElseIf Form1.dB_array(13) - Form1.dB_array_compare(13) > 0 Then
            Label50.Text = Form1.dB_array(13) & "(+" & Form1.dB_array(13) - Form1.dB_array_compare(13) & ")"
            Label50.ForeColor = Color.Blue
        Else
            Label50.Text = Form1.dB_array(13) & "(" & Form1.dB_array(13) - Form1.dB_array_compare(13) & ")"
            Label50.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        'dB (14) increase gain
        If Form1.EQ_end_freq_in_Decimal(14) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(14) += 1
        If Form1.dB_array(14) - Form1.dB_array_compare(14) = 0 Then
            Label51.Text = Form1.dB_array(14)
            Label51.ForeColor = Color.Black

        ElseIf Form1.dB_array(14) - Form1.dB_array_compare(14) > 0 Then
            Label51.Text = Form1.dB_array(14) & "(+" & Form1.dB_array(14) - Form1.dB_array_compare(14) & ")"
            Label51.ForeColor = Color.Blue
        Else
            Label51.Text = Form1.dB_array(14) & "(" & Form1.dB_array(14) - Form1.dB_array_compare(14) & ")"
            Label51.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        'dB (14) decrease gain
        If Form1.EQ_end_freq_in_Decimal(14) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(14) -= 1
        If Form1.dB_array(14) - Form1.dB_array_compare(14) = 0 Then
            Label51.Text = Form1.dB_array(14)
            Label51.ForeColor = Color.Black

        ElseIf Form1.dB_array(14) - Form1.dB_array_compare(14) > 0 Then
            Label51.Text = Form1.dB_array(14) & "(+" & Form1.dB_array(14) - Form1.dB_array_compare(14) & ")"
            Label51.ForeColor = Color.Blue
        Else
            Label51.Text = Form1.dB_array(14) & "(" & Form1.dB_array(14) - Form1.dB_array_compare(14) & ")"
            Label51.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        'dB (15) increase gain
        If Form1.EQ_end_freq_in_Decimal(15) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(15) += 1
        If Form1.dB_array(15) - Form1.dB_array_compare(15) = 0 Then
            Label52.Text = Form1.dB_array(15)
            Label52.ForeColor = Color.Black

        ElseIf Form1.dB_array(15) - Form1.dB_array_compare(15) > 0 Then
            Label52.Text = Form1.dB_array(15) & "(+" & Form1.dB_array(15) - Form1.dB_array_compare(15) & ")"
            Label52.ForeColor = Color.Blue
        Else
            Label52.Text = Form1.dB_array(15) & "(" & Form1.dB_array(15) - Form1.dB_array_compare(15) & ")"
            Label52.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        'dB (15) decrease gain
        If Form1.EQ_end_freq_in_Decimal(15) = 0 Then
            MessageBox.Show("Wrong Row! Empty Frequency Band!")
            Exit Sub
        End If
        Form1.dB_array(15) -= 1
        If Form1.dB_array(15) - Form1.dB_array_compare(15) = 0 Then
            Label52.Text = Form1.dB_array(15)
            Label52.ForeColor = Color.Black

        ElseIf Form1.dB_array(15) - Form1.dB_array_compare(15) > 0 Then
            Label52.Text = Form1.dB_array(15) & "(+" & Form1.dB_array(15) - Form1.dB_array_compare(15) & ")"
            Label52.ForeColor = Color.Blue
        Else
            Label52.Text = Form1.dB_array(15) & "(" & Form1.dB_array(15) - Form1.dB_array_compare(15) & ")"
            Label52.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click  'remove EQ band from EQ-Band-List

        Dim row_index As Integer = 0
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()


    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click

    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim row_index As Integer = 1
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim row_index As Integer = 2
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Dim row_index As Integer = 3
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim row_index As Integer = 4
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim row_index As Integer = 5
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim row_index As Integer = 6
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim row_index As Integer = 7
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim row_index As Integer = 8
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Dim row_index As Integer = 9
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim row_index As Integer = 10
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim row_index As Integer = 11
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim row_index As Integer = 12
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Dim row_index As Integer = 13
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim row_index As Integer = 14
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Dim row_index As Integer = 15
        Dim i_del_row As Integer

        temp1array = Form1.dB_array
        temp2array = Form1.EQ_end_freq_in_Decimal
        For i_del_row = row_index To Form1.EQ_end_freq_in_Decimal.Length - 2
            If i_del_row = Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.EQ_start_freq_in_Decimal(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array(Form1.EQ_end_freq_in_Decimal.Length) = 0
                Form1.dB_array_compare(Form1.EQ_end_freq_in_Decimal.Length) = 0


            ElseIf i_del_row < Form1.EQ_end_freq_in_Decimal.Length - 1 Then
                Form1.EQ_end_freq_in_Decimal(i_del_row) = Form1.EQ_end_freq_in_Decimal(i_del_row + 1)
                Form1.dB_array(i_del_row) = Form1.dB_array(i_del_row + 1)
                Form1.dB_array_compare(i_del_row) = Form1.dB_array_compare(i_del_row + 1)
                Start_EQ_Refresh_By_Last_End_EQ()
            End If

        Next

        Form1.EQ_start_label_refresh()
        Form1.EQ_end_label_refresh()
        Form1.dB_label_refresh()
        dB_compare()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            CheckBox8.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged

        If CheckBox10.Checked = True Then
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
        End If

    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged

        If CheckBox11.Checked = True Then
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox12.Checked = False
        End If

    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged

        If CheckBox12.Checked = True Then
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
        End If
    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click

    End Sub

    Private Sub Label76_Click(sender As Object, e As EventArgs) Handles Label76.Click

    End Sub
End Class
