﻿Imports System.IO
Public Class Form1
    Public array_from_clipboard_2D(1, 208) As String       '宣告tutu參數2D array from clipboard 為全域變數
    Public EQ_start_freq_in_Decimal(15) As Integer
    Public EQ_end_freq_in_Decimal(15) As Integer
    Public dB_array(15) As Integer
    Public dB_array_compare(15) As Integer
    Public EQ_decimal_max_match_index As Integer
    Public tutu_sys01_bin As String
    Public tutu_sys00_bin As String
    Public tutu_onoff_bin As String
    Public tutu_sys00_bin_filled(15) As Integer
    Public tutu_sys01_bin_filled(15) As Integer
    Public EQ_End_1stmax_search As Integer
    Public Sub DRC_paste()
        If Convert.ToInt32(array_from_clipboard_2D(1, 91), 16) > 60000 Then
            UserControl22.NumericUpDown1.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 91), 16) - 65536)    'Expander Point 0
        Else
            UserControl22.NumericUpDown1.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 91), 16))
        End If

        If Convert.ToInt32(array_from_clipboard_2D(1, 92), 16) > 60000 Then
            UserControl22.NumericUpDown2.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 92), 16) - 65536)    'Expander Point 1
        Else
            UserControl22.NumericUpDown2.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 92), 16))
        End If
        '------DRC-Knee Points
        UserControl22.NumericUpDown3.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 93), 16))     'Number of Knee Points

        If Convert.ToInt32(array_from_clipboard_2D(1, 93), 16) = 2 Then
            UserControl22.NumericUpDown4.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 97), 16))
            UserControl22.NumericUpDown5.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 96), 16) - 65536)
            UserControl22.NumericUpDown6.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 95), 16) - 65536)
            'UserControl22.TextBox4.Enabled = False                 '因為在UserControl22.textbox4的text change event已經寫好判斷式了
            UserControl22.NumericUpDown8.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 101), 16) - 65536)
            UserControl22.NumericUpDown9.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 100), 16) - 65536)
            UserControl22.NumericUpDown10.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 99), 16) - 65536)
            'UserControl22.TextBox8.Enabled = False                 '因為在UserControl22.textbox4的text change event已經寫好判斷式了
        ElseIf Convert.ToInt32(array_from_clipboard_2D(1, 93), 16) = 3 Then
            UserControl22.NumericUpDown4.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 98), 16))
            UserControl22.NumericUpDown5.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 97), 16) - 65536)
            UserControl22.NumericUpDown6.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 96), 16) - 65536)
            UserControl22.NumericUpDown7.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 95), 16) - 65536)
            UserControl22.NumericUpDown8.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 102), 16) - 65536)
            UserControl22.NumericUpDown9.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 101), 16) - 65536)
            UserControl22.NumericUpDown10.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 100), 16) - 65536)
            UserControl22.NumericUpDown11.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 99), 16) - 65536)
        End If

        '------DRC-makeup gain     ;checkbox 12; EQ_cell no.105 
        If array_from_clipboard_2D(1, 105) = "0x0000" Then
            UserControl22.NumericUpDown12.Text = ""
            UserControl22.CheckBox7.Checked = True
            Exit Sub
        ElseIf array_from_clipboard_2D(1, 105) = "0x0100" Then
            UserControl22.NumericUpDown12.Text = "0"
        Else
            Dim string_drc14(1) As String
            string_drc14 = Convert.ToString(Math.Log10(Math.Round(Convert.ToInt32(array_from_clipboard_2D(1, 105), 16) / 256, 4)) * 20).Split(".")
            'UserControl22.NumericUpDown12.Text = string_drc14(0) & "." & string_drc14(1).Chars(0) & string_drc14(1).Chars(1) & string_drc14(1).Chars(2) & string_drc14(1).Chars(3)
            UserControl22.NumericUpDown12.Value = (Math.Log10(Math.Round(Convert.ToInt32(array_from_clipboard_2D(1, 105), 16) / 256, 4)) * 20)
        End If
        '------DRC-attack time      ;checkbox 13
        UserControl22.NumericUpDown13.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 103), 16))
        '------DRC-release time     ;checkbox 14
        UserControl22.NumericUpDown14.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 104), 16))

        '------1st MIC gain     ;checkbox 15; 106
        If array_from_clipboard_2D(1, 106) = "0x0000" Then
            UserControl22.NumericUpDown15.Text = ""
            UserControl22.CheckBox2.Checked = True

        Else
            Dim string_MIC(1) As String
            string_MIC = Convert.ToString(Math.Log10(Math.Round(Convert.ToInt32(array_from_clipboard_2D(1, 106), 16) / 256, 4)) * 20).Split(".")
            UserControl22.NumericUpDown15.Text = string_MIC(0) & "." & string_MIC(1).Chars(0) & string_MIC(1).Chars(1) & string_MIC(1).Chars(2) & string_MIC(1).Chars(3)
            UserControl22.CheckBox1.Checked = True

        End If

        '------2nd MIC gain     ;checkbox 16; 107
        If array_from_clipboard_2D(1, 107) = "0x0000" Then
            UserControl22.NumericUpDown16.Text = ""
            UserControl22.CheckBox4.Checked = True


        Else
            Dim string_MIC(1) As String
            string_MIC = Convert.ToString(Math.Log10(Math.Round(Convert.ToInt32(array_from_clipboard_2D(1, 107), 16) / 256, 4)) * 20).Split(".")
            UserControl22.NumericUpDown16.Text = string_MIC(0) & "." & string_MIC(1).Chars(0) & string_MIC(1).Chars(1) & string_MIC(1).Chars(2) & string_MIC(1).Chars(3)
            UserControl22.CheckBox3.Checked = True
        End If

        '----------------------Plot DRC by click DRC Plot button in DRC panel
        UserControl22.DRC_Plot()

        '----------------------判定DRC是否enable or disable
        DRC_Enable_Disable_check()
    End Sub
    Public Sub tutu_sys_parameter_to_binary()           '將Tutu sys參數轉換成 binary


        '------------------------------On/Off           ;可以直接用length的方式來判斷tutu是on or off， 因為無論是on or off，此參數的binary data長度都是1個binary，而這個binary就可以完成判斷 tutu on or off。
        tutu_onoff_bin = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 0), 16), 2)
        'tutu_onoff_bin.Chars(tutu_onoff_bin.Length - 1)     ;on or off

        '------------------------------SYS00            ;改用Int矩陣來存取bin裡面對應的1 or 0，是因為以防當tutu功能開啟很少時，如果用length的方式會造成bin12~bin15被捨棄掉而導致後續無法設計判斷該功能有無開啟
        tutu_sys00_bin = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 1), 16), 2)
        For i_sys00 As Integer = 0 To tutu_sys00_bin.Length - 1
            tutu_sys00_bin_filled(i_sys00) = Convert.ToInt32(tutu_sys00_bin.Chars(tutu_sys00_bin.Length - 1 - i_sys00), 16)
        Next
        'tutu_sys00_bin_filled(0)     ;HS mode
        'tutu_sys00_bin_filled(1)     ;Music stay mode
        'tutu_sys00_bin_filled(11)    ;Mic Block
        'tutu_sys00_bin_filled(12)    ;3Quest


        '------------------------------SYS01
        tutu_sys01_bin = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 2), 16), 2)
        For i_sys01 As Integer = 0 To tutu_sys01_bin.Length - 1
            tutu_sys01_bin_filled(i_sys01) = Convert.ToInt32(tutu_sys01_bin.Chars(tutu_sys01_bin.Length - 1 - i_sys01), 16)
        Next
        'tutu_sys01_bin_filled(6)    ;AEC
        'tutu_sys01_bin_filled(7)     ;BF
        'tutu_sys01_bin_filled(8)     ;NS
        'tutu_sys01_bin_filled(9)    ;EQ
        'tutu_sys01_bin_filled(10)    ;AGC
        'tutu_sys01_bin_filled(11)    ;DRC
        'tutu_sys01_bin_filled(12)    ;HPF
        'tutu_sys01_bin_filled(13)    ;SC
        'tutu_sys01_bin_filled(14)    ;DAQ    
        'tutu_sys01_bin_filled(15)    ;SPKID
    End Sub
    Public Sub check_and_correct_eq_over_bandwidth()
        If UserControl12.CheckBox8.Checked = True Then                      'NB
            For check_1st_max As Integer = 0 To EQ_end_freq_in_Decimal.Length - 1
                If EQ_end_freq_in_Decimal(check_1st_max) = 4000 Then
                    For EQ_End_1stmax_search = check_1st_max + 1 To EQ_end_freq_in_Decimal.Length - 1
                        EQ_end_freq_in_Decimal(EQ_End_1stmax_search) = 0
                        dB_array(EQ_End_1stmax_search) = 0
                    Next
                    Exit For
                ElseIf EQ_end_freq_in_Decimal(check_1st_max) > 4000 Then
                    EQ_end_freq_in_Decimal(check_1st_max) = 4000
                    For EQ_End_1stmax_search = check_1st_max + 1 To EQ_end_freq_in_Decimal.Length - 1
                        EQ_end_freq_in_Decimal(EQ_End_1stmax_search) = 0
                        dB_array(EQ_End_1stmax_search) = 0
                    Next
                End If
            Next
            'If EQ_end_freq_in_Decimal.Max > 4000 Then                       'NB
            '    EQ_decimal_max_match_index = Array.IndexOf(EQ_end_freq_in_Decimal, EQ_end_freq_in_Decimal.Max)
            '    EQ_end_freq_in_Decimal(EQ_decimal_max_match_index) = 4000
            '    For check_max_i As Integer = EQ_decimal_max_match_index + 1 To EQ_end_freq_in_Decimal.Length - 1
            '        EQ_end_freq_in_Decimal(check_max_i) = 0
            '    Next
            'ElseIf EQ_end_freq_in_Decimal.Max = 4000 Then
            '    EQ_decimal_max_match_index = Array.IndexOf(EQ_end_freq_in_Decimal, EQ_end_freq_in_Decimal.Max)
            '    For check_max_i As Integer = EQ_decimal_max_match_index + 1 To EQ_end_freq_in_Decimal.Length - 1
            '        EQ_end_freq_in_Decimal(check_max_i) = 0
            '    Next
            'End If
        ElseIf UserControl12.CheckBox9.Checked = True Then                      'WB
            For check_1st_max As Integer = 0 To EQ_end_freq_in_Decimal.Length - 1
                If EQ_end_freq_in_Decimal(check_1st_max) = 8000 Then
                    For EQ_End_1stmax_search = check_1st_max + 1 To EQ_end_freq_in_Decimal.Length - 1
                        EQ_end_freq_in_Decimal(EQ_End_1stmax_search) = 0
                        dB_array(EQ_End_1stmax_search) = 0
                    Next
                    Exit For
                ElseIf EQ_end_freq_in_Decimal(check_1st_max) > 8000 Then
                    EQ_end_freq_in_Decimal(check_1st_max) = 8000
                    For EQ_End_1stmax_search = check_1st_max + 1 To EQ_end_freq_in_Decimal.Length - 1
                        EQ_end_freq_in_Decimal(EQ_End_1stmax_search) = 0
                        dB_array(EQ_End_1stmax_search) = 0
                    Next
                End If
            Next

        ElseIf UserControl12.CheckBox10.Checked = True Then                      'SWB
            For check_1st_max As Integer = 0 To EQ_end_freq_in_Decimal.Length - 1
                If EQ_end_freq_in_Decimal(check_1st_max) = 16000 Then
                    For EQ_End_1stmax_search = check_1st_max + 1 To EQ_end_freq_in_Decimal.Length - 1
                        EQ_end_freq_in_Decimal(EQ_End_1stmax_search) = 0
                        dB_array(EQ_End_1stmax_search) = 0
                    Next
                    Exit For
                ElseIf EQ_end_freq_in_Decimal(check_1st_max) > 16000 Then
                    EQ_end_freq_in_Decimal(check_1st_max) = 16000
                    For EQ_End_1stmax_search = check_1st_max + 1 To EQ_end_freq_in_Decimal.Length - 1
                        EQ_end_freq_in_Decimal(EQ_End_1stmax_search) = 0
                        dB_array(EQ_End_1stmax_search) = 0
                    Next
                End If
            Next

        ElseIf UserControl12.CheckBox11.Checked = True Then                      'FB
            For check_1st_max As Integer = 0 To EQ_end_freq_in_Decimal.Length - 1
                If EQ_end_freq_in_Decimal(check_1st_max) = 24000 Then
                    For EQ_End_1stmax_search = check_1st_max + 1 To EQ_end_freq_in_Decimal.Length - 1
                        EQ_end_freq_in_Decimal(EQ_End_1stmax_search) = 0
                        dB_array(EQ_End_1stmax_search) = 0
                    Next
                    Exit For
                ElseIf EQ_end_freq_in_Decimal(check_1st_max) > 24000 Then
                    EQ_end_freq_in_Decimal(check_1st_max) = 24000
                    For EQ_End_1stmax_search = check_1st_max + 1 To EQ_end_freq_in_Decimal.Length - 1
                        EQ_end_freq_in_Decimal(EQ_End_1stmax_search) = 0
                        dB_array(EQ_End_1stmax_search) = 0
                    Next
                End If
            Next
            'ElseIf UserControl12.CheckBox9.Checked = True Then
            '    If EQ_end_freq_in_Decimal.Max > 8000 Then                       'WB
            '        EQ_decimal_max_match_index = Array.IndexOf(EQ_end_freq_in_Decimal, EQ_end_freq_in_Decimal.Max)
            '        EQ_end_freq_in_Decimal(EQ_decimal_max_match_index) = 8000
            '        For check_max_i As Integer = EQ_decimal_max_match_index + 1 To EQ_end_freq_in_Decimal.Length - 1
            '            EQ_end_freq_in_Decimal(check_max_i) = 0
            '        Next
            '    End If
            'ElseIf UserControl12.CheckBox10.Checked = True Then                 'SWB
            '    If EQ_end_freq_in_Decimal.Max > 16000 Then
            '        EQ_decimal_max_match_index = Array.IndexOf(EQ_end_freq_in_Decimal, EQ_end_freq_in_Decimal.Max)
            '        EQ_end_freq_in_Decimal(EQ_decimal_max_match_index) = 16000
            '        For check_max_i As Integer = EQ_decimal_max_match_index + 1 To EQ_end_freq_in_Decimal.Length - 1
            '            EQ_end_freq_in_Decimal(check_max_i) = 0
            '        Next
            '    End If
            'ElseIf UserControl12.CheckBox11.Checked = True Then                 'FB
            '    If EQ_end_freq_in_Decimal.Max > 24000 Then
            '        EQ_decimal_max_match_index = Array.IndexOf(EQ_end_freq_in_Decimal, EQ_end_freq_in_Decimal.Max)
            '        EQ_end_freq_in_Decimal(EQ_decimal_max_match_index) = 24000
            '        For check_max_i As Integer = EQ_decimal_max_match_index + 1 To EQ_end_freq_in_Decimal.Length - 1
            '            EQ_end_freq_in_Decimal(check_max_i) = 0
            '        Next
            '    End If
            'End If
        End If
    End Sub
    Public Sub debug_into_form1()
        Dim debug_form1 As Integer
        debug_form1 = 0

    End Sub
    Public Sub grid_debug()
        For eq_i As Integer = 0 To EQ_end_freq_in_Decimal.Length - 1
            'UserControl12.DataGridView1.Rows.Add(EQ_end_freq_in_Decimal(eq_i), eq_i)


        Next
    End Sub
    Public Sub SWB_FB_label_backimage_load()
        UserControl12.Label65.Show()    '100hz for NB/WB/SWB/FB
        UserControl12.Label77.Show()
        UserControl12.Label78.Show()
        UserControl12.Label79.Show()
        UserControl12.Label80.Show()
        UserControl12.Label81.Show()
        UserControl12.Label82.Show()
        UserControl12.Label83.Show()
        UserControl12.Label84.Show()
        UserControl12.Label85.Show()
        UserControl12.Label86.Show()
        UserControl12.Label87.Show()
        UserControl12.Label88.Show()
        UserControl12.Label89.Show()
        UserControl12.Label90.Show()
        UserControl12.Label91.Show()

        '-----------------------------Hide NB/WB Grid Label
        UserControl12.Label53.Hide()    '200hz for NB
        UserControl12.Label54.Hide()    '300hz for NB  
        UserControl12.Label55.Hide()    '400hz for NB  
        UserControl12.Label56.Hide()    '600hz for NB  
        UserControl12.Label57.Hide()    '800hz for NB  
        UserControl12.Label58.Hide()    '1000hz for NB  
        UserControl12.Label59.Hide()    '2000hz for NB  
        UserControl12.Label60.Hide()    '3000hz for NB  
        UserControl12.Label61.Hide()    '4000hz for NB  
        UserControl12.Label66.Hide()    '6000hz for NB  
        UserControl12.Label67.Hide()    '8000hz for NB  

    End Sub
    Public Sub NB_WB_label_backimage_load()
        UserControl12.Label53.Show()    '200hz for NB
        UserControl12.Label54.Show()    '300hz for NB  
        UserControl12.Label55.Show()    '400hz for NB  
        UserControl12.Label56.Show()    '600hz for NB  
        UserControl12.Label57.Show()    '800hz for NB  
        UserControl12.Label58.Show()    '1000hz for NB  
        UserControl12.Label59.Show()    '2000hz for NB  
        UserControl12.Label60.Show()    '3000hz for NB  
        UserControl12.Label61.Show()    '4000hz for NB  
        UserControl12.Label65.Show()    '100hz for NB/WB/SWB/FB  
        UserControl12.Label66.Show()    '6000hz for NB  
        UserControl12.Label67.Show()    '8000hz for NB 

        '-----------------------------Hide SWB/FB Grid Label
        UserControl12.Label77.Hide()
        UserControl12.Label78.Hide()
        UserControl12.Label79.Hide()
        UserControl12.Label80.Hide()
        UserControl12.Label81.Hide()
        UserControl12.Label82.Hide()
        UserControl12.Label83.Hide()
        UserControl12.Label84.Hide()
        UserControl12.Label85.Hide()
        UserControl12.Label86.Hide()
        UserControl12.Label87.Hide()
        UserControl12.Label88.Hide()
        UserControl12.Label89.Hide()
        UserControl12.Label90.Hide()
        UserControl12.Label91.Hide()

    End Sub

    Public Sub EQ_Enable_disable()                ' Check EQ參數是否開啟
        '-------------------------------------- 一開始先unchecked   
        UserControl12.CheckBox13.Checked = False
        UserControl12.CheckBox14.Checked = False
        If tutu_sys01_bin_filled(9) = 1 Then
            UserControl12.CheckBox13.Checked = True
        Else
            UserControl12.CheckBox14.Checked = True
        End If


    End Sub
    Public Sub DRC_Enable_Disable_check()
        UserControl22.CheckBox5.Checked = False
        UserControl22.CheckBox6.Checked = False
        If tutu_sys01_bin_filled(11) = 1 Then
            UserControl22.CheckBox5.Checked = True
        Else
            UserControl22.CheckBox6.Checked = True
        End If
    End Sub
    Public Sub Bandwidth_refresh()
        '---------------------------------------一開始全部unchecked
        UserControl12.CheckBox8.Checked = False
        UserControl12.CheckBox9.Checked = False
        UserControl12.CheckBox10.Checked = False
        UserControl12.CheckBox11.Checked = False
        UserControl12.CheckBox11.Checked = False

        '---------------------------------------開始確認參數是否為對應的頻寬
        If EQ_end_freq_in_Decimal.Max <= 4000 Then
            UserControl12.CheckBox8.Checked = True
            'UserControl12.Chart1.BackImage = ""       
            '------------註解掉下方的load back image，是因為避免在不同使用者的電腦上執行時因為沒有在相同的位置有相同的圖片檔案，而導致執行後 錯誤
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            SWB_FB_label_backimage_load()
            Exit Sub

        ElseIf EQ_end_freq_in_Decimal.Max <= 8000 Then
            UserControl12.CheckBox9.Checked = True
            'UserControl12.Chart1.BackImage = ""
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            SWB_FB_label_backimage_load()
            Exit Sub

        ElseIf EQ_end_freq_in_Decimal.Max <= 16000 Then
            UserControl12.CheckBox10.Checked = True
            'UserControl12.Chart1.BackImage = ""
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            SWB_FB_label_backimage_load()
            Exit Sub

        ElseIf EQ_end_freq_in_Decimal.Max <= 24000 Then
            UserControl12.CheckBox11.Checked = True
            'UserControl12.Chart1.BackImage = ""
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            SWB_FB_label_backimage_load()
            Exit Sub

        Else
            'UserControl12.CheckBox12.Checked = True
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            'UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            'SWB_FB_label_backimage_load()
            MessageBox.Show("Frequency is over 24000Hz, please re-check the value again!")

        End If
    End Sub

    Public Sub Bandwidth_check()


        '---------------------------------------開始確認參數是否為對應的頻寬
        If UserControl12.CheckBox8.Checked = True Then              'NB
            'UserControl12.Chart1.BackImage = ""
            '-----------------註解掉下方的load back image，是因為避免在不同使用者的電腦上執行時因為沒有在相同的位置有相同的圖片檔案，而導致執行後 錯誤
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            SWB_FB_label_backimage_load()




        ElseIf UserControl12.CheckBox9.Checked = True Then      'WB
            UserControl12.Chart1.BackImage = ""
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\xAxis_9k_V6_confirmed_1k_v3.bmp"
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            SWB_FB_label_backimage_load()

        ElseIf UserControl12.CheckBox10.Checked = True Then     'SWB
            'UserControl12.Chart1.BackImage = ""
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            SWB_FB_label_backimage_load()

        ElseIf UserControl12.CheckBox11.Checked = True Then     'FB
            'UserControl12.Chart1.BackImage = ""
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            SWB_FB_label_backimage_load()
        Else
            UserControl12.CheckBox12.Checked = True             'Others
            'UserControl12.Chart1.BackImage = "D:\Works\Codings\SWB_FB_right_grid_with_no_data_plus_major_grid_no_x_db_lable_no_transparent.bmp"
            UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 25000 ' 設定Axis-X 的最大值
            SWB_FB_label_backimage_load()
        End If
    End Sub
    Public Sub Bandwidth_fit_to_max_value()
        '------------------------------偵測目前EQ_end_freq_in_decimal的最大值是否符合 Bandwidth box所選擇的Bandwidth的最大值，若沒有，則將EQ_end_freq_in_decimal最大值的該Index的下一個位置Index+1 補上一個最大值的EQ
        'If EQ_end_freq_in_Decimal.Max < 4000 Then
        'EQ_decimal_max_match_index = Array.IndexOf(EQ_end_freq_in_Decimal, EQ_end_freq_in_Decimal.Max)
        'EQ_end_freq_in_Decimal(EQ_decimal_max_match_index + 1) = 4000
        '
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click  'EQ Click
        UserControl31.Hide()    'Developer Panel
        UserControl22.Hide()    'UserControl21 is DRC
        UserControl12.Show()    'UserControl11 is EQ
        UserControl12.Label92.Hide()


        '-----------------------------Hide NB/WB Grid Label
        UserControl12.Label53.Hide()    '200hz for NB
        UserControl12.Label54.Hide()    '300hz for NB  
        UserControl12.Label55.Hide()    '400hz for NB  
        UserControl12.Label56.Hide()    '600hz for NB  
        UserControl12.Label57.Hide()    '800hz for NB  
        UserControl12.Label58.Hide()    '1000hz for NB  
        UserControl12.Label59.Hide()    '2000hz for NB  
        UserControl12.Label60.Hide()    '3000hz for NB  
        UserControl12.Label61.Hide()    '4000hz for NB  
        'UserControl12.Label65.Hide()    '100hz for NB/WB/SWB/FB  ; 不hide，因為之後固定選用SWB/FB 並且常駐，100Hz也需要存在
        UserControl12.Label66.Hide()    '6000hz for NB  
        UserControl12.Label67.Hide()    '8000hz for NB  

        '-----------------------------Hide SWB/FB Grid Label ; 不hide，因為之後固定選用SWB/FB 並且常駐
        'UserControl12.Label77.Hide()
        'UserControl12.Label78.Hide()
        'UserControl12.Label79.Hide()
        'UserControl12.Label80.Hide()
        'UserControl12.Label81.Hide()
        'UserControl12.Label82.Hide()
        'UserControl12.Label83.Hide()
        'UserControl12.Label84.Hide()
        'UserControl12.Label85.Hide()
        'UserControl12.Label86.Hide()
        'UserControl12.Label87.Hide()
        'UserControl12.Label88.Hide()
        'UserControl12.Label89.Hide()
        'UserControl12.Label90.Hide()
        'UserControl12.Label91.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserControl22.Show()    'UserControl21 is DRC
        UserControl12.Hide()    'UserControl11 is EQ
        UserControl31.Hide()    'Developer Panel

    End Sub

    Private Sub UserControl21_Load(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button3_Click(sender As Object, EQ_Data2 As EventArgs) Handles Button3.Click 'Plot click
        'setup the chart area
        '----------以下是plot chart codes
        Dim newSeries = New DataVisualization.Charting.Series()
        UserControl12.Chart1.Titles.Clear()
        'UserControl12.Chart1.Titles.Add("Tutu Equalizer Line")

        'UserControl12.Chart1.ChartAreas(0).AxisY.Title = "Hz"
        'UserControl12.Chart1.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Black
        'UserControl12.Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = True

        UserControl12.Chart1.ChartAreas(0).AxisX.Title = "."

        'Specify series plot lines
        UserControl12.Chart1.Series.Clear()

        '-------------------------------- Example of adding a new plot information at the top-right of chart
        'serControl12.Chart1.Series.Add("plot1")
        'UserControl12.Chart1.Series("plot1").Color = Color.Red
        'UserControl12.Chart1.Series("plot1").ChartType = DataVisualization.Charting.SeriesChartType.Line

        'Set Chart Properties
        UserControl12.Chart1.ChartAreas(0).AxisX.IsLogarithmic = True
        UserControl12.Chart1.ChartAreas(0).AxisX.LogarithmBase = 10
        UserControl12.Chart1.ChartAreas(0).AxisX.IntervalOffset = 0
        UserControl12.Chart1.ChartAreas(0).AxisX.MajorGrid.Interval = 1    '可以在x軸上的100, 1000, 10000 劃出major grid; 因為現在X軸被宣告成Logaithmic軸，所以這邊的1格表示"每取完log對數後的值為1"來做間距
        UserControl12.Chart1.ChartAreas(0).AxisX.MajorGrid.LineWidth = 2
        UserControl12.Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = True
        UserControl12.Chart1.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightGray
        UserControl12.Chart1.ChartAreas(0).AxisX.MinorGrid.Interval = 1 '目前還不確定這邊的1實質上的意義是什麼，可以確定的是設定成1畫出來的圖是我們想要的
        UserControl12.Chart1.ChartAreas(0).AxisX.MinorGrid.Enabled = True
        UserControl12.Chart1.ChartAreas(0).AxisX.MinorGrid.LineColor = Color.Gainsboro
        UserControl12.Chart1.ChartAreas(0).AxisX.Minimum = 100
        'UserControl12.Chart1.ChartAreas(0).AxisX.MajorGrid.Interval = 1000
        'UserControl12.Chart1.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Red

        'UserControl12.Chart1.ChartAreas(0).AxisX.Interval = 10     'Tune this value to change X-minor-grid resolution
        'UserControl12.Chart1.ChartAreas(0).AxisX2.Interval = 1     'Tune this value to change X-minor-grid resolution

        '---------------------------------- Setting Axis-X range and Axis-Y range
        UserControl12.Chart1.ChartAreas(0).AxisY.Minimum = -15
        UserControl12.Chart1.ChartAreas(0).AxisY.Maximum = 15
        UserControl12.Chart1.ChartAreas(0).AxisY.IntervalOffset = 0
        UserControl12.Chart1.ChartAreas(0).AxisY.Interval = 3               '多少格標一次label
        UserControl12.Chart1.ChartAreas(0).AxisY.MajorGrid.Interval = 3     '多少格畫一次 Major Grid
        UserControl12.Chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = True
        UserControl12.Chart1.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray
        UserControl12.Chart1.ChartAreas(0).AxisY.MajorGrid.LineWidth = 2
        UserControl12.Chart1.ChartAreas(0).AxisY.MinorGrid.Interval = 1     '多少格畫一次 Minor Grid
        UserControl12.Chart1.ChartAreas(0).AxisY.MinorGrid.Enabled = True
        UserControl12.Chart1.ChartAreas(0).AxisY.MinorGrid.LineColor = Color.Gainsboro

        'UserControl12.Chart1.ChartAreas(0).AxisX.Maximum = 8000     '已經在paste裡的bandwidth_refresh_sub中確認好了


        '--------------------------------Bandwidth偵測 並且refresh 屬於該bandwidth的back image和 label
        Bandwidth_check()




        newSeries.ChartType = DataVisualization.Charting.SeriesChartType.Line
        newSeries.BorderWidth = 3





        'UserControl12.Chart1.ChartAreas(0).AxisY.MinorGrid = True



        'add data to the three series
        'here b varies: 2, 6, 12
        Dim n As Integer = 5  'number of points
        Dim a As Integer
        Dim EQ_chart(35) As Integer
        Dim dB_chart(35) As Integer
        Dim EQ_step As Integer = 1  'EQ_chart(0)不能動，所以此Step疊加參數要從1開始
        Dim dB_step As Integer = 1  'dB_chart(0)不能動，所以此Step疊加參數要從1開始
        Dim no_EQ_band_i As Integer


        dB_chart(0) = dB_array(0)   ' 第一個dB值設定


        '                   當EQ沒有任何值的時候，劃一條0-4000 都是0dB的線條
        If EQ_end_freq_in_Decimal.Max = 0 Then
            For no_EQ_band_i = 0 To 32
                EQ_chart(no_EQ_band_i) = 4000
                dB_chart(no_EQ_band_i) = 0
            Next


        End If

        '------------------------------偵測目前EQ_end_freq_in_decimal的最大值是否符合 Bandwidth box所選擇的Bandwidth的最大值，若沒有，則將EQ_end_freq_in_decimal最大值的該Index的下一個位置Index+1 補上一個最大值的EQ
        'If EQ_end_freq_in_Decimal.Max < 4000 Then
        'EQ_decimal_max_match_index = Array.IndexOf(EQ_end_freq_in_Decimal, EQ_end_freq_in_Decimal.Max)
        'EQ_end_freq_in_Decimal(EQ_decimal_max_match_index + 1) = 4000

        'End If



        '-------------------------以下是確認頻寬後，在開始將EQ_end_freq_in_decimal的參數填到EQ Chart中; 因為會依據不同的頻寬, 在 遇到EQ chart中需要補滿最大頻帶的情況時可以正確填上最大的對應頻帶


        If UserControl12.CheckBox8.Checked = True Then   'NB checked
            For a = 1 To 16                 ' 將即將要被拿來畫圖的EQ_chart和 dB_Chart在之後沒用到的頻段(意即沒有值的頻段)全部補滿，follow最後一個有值的頻段, ex: 4000 or 8000...etc
                If EQ_end_freq_in_Decimal(a - 1) <> 0 Then
                    If EQ_end_freq_in_Decimal(a - 1) > 4000 Then    '判斷如果在Panel上填的頻帶範圍超過NB，就會把餵給Chart的array裡的頻帶最大值降成4000Hz
                        If EQ_chart(EQ_step - 1) = 4000 Then            ' 如果前一個EQ_Chart內的頻段已經到達該頻寬的最大值，則當下頻段的start freq就繼承前一頻段的end freq
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)
                            EQ_step += 1
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)
                            EQ_step += 1

                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 如果前一個EQ_Chart內的頻段已經到達該頻寬的最大值，則當下頻段的db就繼承前一頻段的db
                            dB_step += 1                                ' dB_step is stepping by +1
                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 
                            dB_step += 1
                        Else
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 把當下頻段的start frequency設定成前一段還未超過4000頻段的 end frequency加1
                            EQ_step += 1                                ' EQ_step is stepping by +1
                            EQ_chart(EQ_step) = 4000                        ' 把當下的end frequency設定成4000
                            EQ_step += 1                                ' EQ_step is stepping by +1
                            dB_chart(dB_step) = dB_array(a - 1)   ' 
                            dB_step += 1                                ' dB_step is stepping by +1
                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 
                            dB_step += 1
                        End If ' dB_step is stepping by +1
                    Else
                        'EQ_chart(a) = EQ_end_freq_in_Decimal(a - 1) ' EQ_chart(1) follow EQ_end_freq_in_Decimal(0); 因為EQ_Chart(0)已經強制設定為1，因為Log-X axis的需求
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1
                        EQ_step += 1                        ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = EQ_end_freq_in_Decimal(a - 1)
                        EQ_step += 1                        ' EQ_step is stepping by +1
                        'dB_chart(a) = dB_array(a - 1)
                        dB_chart(dB_step) = dB_array(a - 1)
                        dB_step += 1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)
                        dB_step += 1
                    End If
                Else                        ' 把之後沒用到的頻段補上前一個頻段的end frequency hz; 把之後沒用到的頻段補上前一個頻段的dB 
                    If EQ_chart(EQ_step - 1) < 4000 Then        ''若在EQ band 0~14中沒有填上NB的最大頻帶 4000，自動補上4000hz
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = 4000   ' 
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        dB_chart(dB_step) = 0   ' 
                        dB_step += 1                                ' dB_step is stepping by +1
                        dB_chart(dB_step) = 0   ' 
                        dB_step += 1                                ' dB_step is stepping by +1
                    Else
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                        dB_step += 1                                ' dB_step is stepping by +1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                        dB_step += 1                                ' dB_step is stepping by +1
                    End If
                End If
            Next
            '--------------------以下情況是當遇到EQ band(15)最後一個band 沒有填到當下頻寬的最大頻帶時，會自動在EQ chart補上最大頻帶 ex: under NB, EQ band(15) is 3000, this fuction will add a new band 3001hz to 4000 hz into EQ chart automatically
            If EQ_chart(32) < 4000 Then
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 
                EQ_step += 1                                ' EQ_step is stepping by +1
                EQ_chart(EQ_step) = 4000   ' 
                EQ_step += 1                                ' EQ_step is stepping by +1
                dB_chart(dB_step) = 0   ' 
                dB_step += 1                                ' dB_step is stepping by +1
                dB_chart(dB_step) = 0   ' 
                dB_step += 1                                ' dB_step is stepping by +1
            Else
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                EQ_step += 1                                ' EQ_step is stepping by +1
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                EQ_step += 1                                ' EQ_step is stepping by +1
                dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                dB_step += 1                                ' dB_step is stepping by +1
                dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                dB_step += 1
            End If


        ElseIf UserControl12.CheckBox9.Checked = True Then      'WB checked
            For a = 1 To 16                 ' 將即將要被拿來畫圖的EQ_chart和 dB_Chart在之後沒用到的頻段(意即沒有值的頻段)全部補滿，follow最後一個有值的頻段, ex: 4000 or 8000...etc

                If EQ_end_freq_in_Decimal(a - 1) <> 0 Then
                    If EQ_end_freq_in_Decimal(a - 1) > 8000 Then    '判斷如果在Panel上填的頻帶範圍超過WB，就會把餵給Chart的array裡的頻帶最大值降成8000Hz
                        If EQ_chart(EQ_step - 1) = 8000 Then            ' 如果前一個EQ_Chart內的頻段已經到達該頻寬的最大值，則當下頻段的start freq就繼承前一頻段的end freq
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)
                            EQ_step += 1
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)
                            EQ_step += 1

                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 如果前一個EQ_Chart內的頻段已經到達該頻寬的最大值，則當下頻段的db就繼承前一頻段的db
                            dB_step += 1                                ' dB_step is stepping by +1
                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 
                            dB_step += 1
                        Else
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 把當下頻段的start frequency設定成前一段還未超過8000頻段的 end frequency加1
                            EQ_step += 1                                ' EQ_step is stepping by +1
                            EQ_chart(EQ_step) = 8000                        ' 把當下的end frequency設定成8000
                            EQ_step += 1                                ' EQ_step is stepping by +1
                            dB_chart(dB_step) = dB_array(a - 1)   ' 
                            dB_step += 1                                ' dB_step is stepping by +1
                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 
                            dB_step += 1                                ' dB_step is stepping by +1
                        End If
                    Else
                        'EQ_chart(a) = EQ_end_freq_in_Decimal(a - 1) ' EQ_chart(1) follow EQ_end_freq_in_Decimal(0); 因為EQ_Chart(0)已經強制設定為1，因為Log-X axis的需求
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1
                        EQ_step += 1                        ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = EQ_end_freq_in_Decimal(a - 1)
                        EQ_step += 1                        ' EQ_step is stepping by +1
                        'dB_chart(a) = dB_array(a - 1)
                        dB_chart(dB_step) = dB_array(a - 1)
                        dB_step += 1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)
                        dB_step += 1
                    End If
                Else                        ' 把之後沒用到的頻段補上前一個頻段的end frequency hz; 把之後沒用到的頻段補上前一個頻段的dB 
                    If EQ_chart(EQ_step - 1) < 8000 Then   '若在EQ band 0~14中沒有填上WB的最大頻帶 8000的話，自動補上8000hz
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = 8000   ' 
                        EQ_step += 1                                ' EQ_step is stepping by +1

                        dB_chart(dB_step) = 0   ' 
                        dB_step += 1                                ' dB_step is stepping by +1
                        dB_chart(dB_step) = 0   ' 
                        dB_step += 1                                ' dB_step is stepping by +1
                    Else
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                        EQ_step += 1                                ' EQ_step is stepping by +1

                        dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                        dB_step += 1                                ' dB_step is stepping by +1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                        dB_step += 1                                ' dB_step is stepping by +1
                    End If
                End If
            Next
            '--------------------以下情況是當遇到EQ band(15)最後一個band 沒有填到當下頻寬的最大頻帶時，會自動在EQ chart補上最大頻帶 ex: under NB, EQ band(15) is 3000, this fuction will add a new band 3001hz to 4000 hz into EQ chart automatically
            If EQ_chart(32) < 8000 Then
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 
                EQ_step += 1                                ' EQ_step is stepping by +1
                EQ_chart(EQ_step) = 8000   ' 
                EQ_step += 1                                ' EQ_step is stepping by +1

                dB_chart(dB_step) = 0   ' 
                dB_step += 1                                ' dB_step is stepping by +1
                dB_chart(dB_step) = 0   ' 
                dB_step += 1                                ' dB_step is stepping by +1
            Else
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                EQ_step += 1                                ' EQ_step is stepping by +1
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                EQ_step += 1                                ' EQ_step is stepping by +1

                dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                dB_step += 1                                ' dB_step is stepping by +1
                dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                dB_step += 1
            End If


        ElseIf UserControl12.CheckBox10.Checked = True Then     'SWB
            For a = 1 To 16                 ' 將即將要被拿來畫圖的EQ_chart和 dB_Chart在之後沒用到的頻段(意即沒有值的頻段)全部補滿，follow最後一個有值的頻段, ex: 4000 or 8000...etc
                If EQ_end_freq_in_Decimal(a - 1) <> 0 Then
                    If EQ_end_freq_in_Decimal(a - 1) > 16000 Then    '判斷如果在Panel上填的頻帶範圍超過SWB，就會把餵給Chart的array裡的頻帶最大值降成16000Hz
                        If EQ_chart(EQ_step - 1) = 16000 Then            ' 如果前一個EQ_Chart內的頻段已經到達該頻寬的最大值，則當下頻段的start freq就繼承前一頻段的end freq
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)
                            EQ_step += 1
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)
                            EQ_step += 1

                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 如果前一個EQ_Chart內的頻段已經到達該頻寬的最大值，則當下頻段的db就繼承前一頻段的db
                            dB_step += 1                                ' dB_step is stepping by +1
                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 
                            dB_step += 1
                        Else
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 把當下頻段的start frequency設定成前一段還未超過16000頻段的 end frequency加1
                            EQ_step += 1                                ' EQ_step is stepping by +1
                            EQ_chart(EQ_step) = 16000                        ' 把當下的end frequency設定成16000
                            EQ_step += 1                                ' EQ_step is stepping by +1
                            dB_chart(dB_step) = dB_array(a - 1)   ' 
                            dB_step += 1                                ' dB_step is stepping by +1
                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 
                            dB_step += 1                                ' dB_step is stepping by +1
                        End If
                    Else
                        'EQ_chart(a) = EQ_end_freq_in_Decimal(a - 1) ' EQ_chart(1) follow EQ_end_freq_in_Decimal(0); 因為EQ_Chart(0)已經強制設定為1，因為Log-X axis的需求
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1
                        EQ_step += 1                        ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = EQ_end_freq_in_Decimal(a - 1)
                        EQ_step += 1                        ' EQ_step is stepping by +1

                        'dB_chart(a) = dB_array(a - 1)
                        dB_chart(dB_step) = dB_array(a - 1)
                        dB_step += 1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)
                        dB_step += 1
                    End If
                Else                        ' 把之後沒用到的頻段補上前一個頻段的end frequency hz; 把之後沒用到的頻段補上前一個頻段的dB 
                    If EQ_chart(EQ_step - 1) < 16000 Then

                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = 16000   ' 
                        EQ_step += 1                                ' EQ_step is stepping by +1

                        dB_chart(dB_step) = 0   ' 
                        dB_step += 1                                ' dB_step is stepping by +1
                        dB_chart(dB_step) = 0   ' 
                        dB_step += 1                                ' dB_step is stepping by +1
                    Else
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                        EQ_step += 1                                ' EQ_step is stepping by +1

                        dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                        dB_step += 1                                ' dB_step is stepping by +1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                        dB_step += 1                                ' dB_step is stepping by +1
                    End If

                End If

            Next
            '--------------------以下情況是當遇到EQ band(15)最後一個band 沒有填到當下頻寬的最大頻帶時，會自動在EQ chart補上最大頻帶 ex: under NB, EQ band(15) is 3000, this fuction will add a new band 3001hz to 4000 hz into EQ chart automatically
            If EQ_chart(32) < 16000 Then
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 
                EQ_step += 1                                ' EQ_step is stepping by +1
                EQ_chart(EQ_step) = 16000   ' 
                EQ_step += 1                                ' EQ_step is stepping by +1

                dB_chart(dB_step) = 0   ' 
                dB_step += 1                                ' dB_step is stepping by +1
                dB_chart(dB_step) = 0   ' 
                dB_step += 1                                ' dB_step is stepping by +1
            Else
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                EQ_step += 1                                ' EQ_step is stepping by +1
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                EQ_step += 1                                ' EQ_step is stepping by +1

                dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                dB_step += 1                                ' dB_step is stepping by +1
                dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                dB_step += 1

            End If


        ElseIf UserControl12.CheckBox11.Checked = True Then     'FB
            For a = 1 To 16                 ' 將即將要被拿來畫圖的EQ_chart和 dB_Chart在之後沒用到的頻段(意即沒有值的頻段)全部補滿，follow最後一個有值的頻段, ex: 4000 or 8000...etc
                If EQ_end_freq_in_Decimal(a - 1) <> 0 Then
                    If EQ_end_freq_in_Decimal(a - 1) > 24000 Then    '判斷如果在Panel上填的頻帶範圍超過FB，就會把餵給Chart的array裡的頻帶最大值降成24000Hz
                        If EQ_chart(EQ_step - 1) = 24000 Then            ' 如果前一個EQ_Chart內的頻段已經到達該頻寬的最大值，則當下頻段的start freq就繼承前一頻段的end freq
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)
                            EQ_step += 1
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)
                            EQ_step += 1

                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 如果前一個EQ_Chart內的頻段已經到達該頻寬的最大值，則當下頻段的db就繼承前一頻段的db
                            dB_step += 1                                ' dB_step is stepping by +1
                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 
                            dB_step += 1
                        Else
                            EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 把當下頻段的start frequency設定成前一段還未超過24000頻段的 end frequency加1
                            EQ_step += 1                                ' EQ_step is stepping by +1
                            EQ_chart(EQ_step) = 24000                        ' 把當下的end frequency設定成24000
                            EQ_step += 1                                ' EQ_step is stepping by +1
                            dB_chart(dB_step) = dB_array(a - 1)   ' 
                            dB_step += 1                                ' dB_step is stepping by +1
                            dB_chart(dB_step) = dB_chart(dB_step - 1)   ' 
                            dB_step += 1                                ' dB_step is stepping by +1
                        End If
                    Else
                        'EQ_chart(a) = EQ_end_freq_in_Decimal(a - 1) ' EQ_chart(1) follow EQ_end_freq_in_Decimal(0); 因為EQ_Chart(0)已經強制設定為1，因為Log-X axis的需求
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1
                        EQ_step += 1                        ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = EQ_end_freq_in_Decimal(a - 1)
                        EQ_step += 1                        ' EQ_step is stepping by +1
                        'dB_chart(a) = dB_array(a - 1)
                        dB_chart(dB_step) = dB_array(a - 1)
                        dB_step += 1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)
                        dB_step += 1
                    End If
                Else                        ' 把之後沒用到的頻段補上前一個頻段的end frequency hz; 把之後沒用到的頻段補上前一個頻段的dB 
                    If EQ_chart(EQ_step - 1) < 24000 Then
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = 24000   ' 
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        dB_chart(dB_step) = 0   ' 
                        dB_step += 1                                ' dB_step is stepping by +1
                        dB_chart(dB_step) = 0   ' 
                        dB_step += 1                                ' dB_step is stepping by +1
                    Else
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                        EQ_step += 1                                ' EQ_step is stepping by +1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                        dB_step += 1                                ' dB_step is stepping by +1
                        dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                        dB_step += 1                                ' dB_step is stepping by +1
                    End If
                End If
            Next
            '--------------------以下情況是當遇到EQ band(15)最後一個band 沒有填到當下頻寬的最大頻帶時，會自動在EQ chart補上最大頻帶 ex: under NB, EQ band(15) is 3000, this fuction will add a new band 3001hz to 4000 hz into EQ chart automatically
            If EQ_chart(32) < 24000 Then
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1) + 1   ' 
                EQ_step += 1                                ' EQ_step is stepping by +1
                EQ_chart(EQ_step) = 24000   ' 
                EQ_step += 1                                ' EQ_step is stepping by +1
                dB_chart(dB_step) = 0   ' 
                dB_step += 1                                ' dB_step is stepping by +1
                dB_chart(dB_step) = 0   ' 
                dB_step += 1                                ' dB_step is stepping by +1
            Else
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                EQ_step += 1                                ' EQ_step is stepping by +1
                EQ_chart(EQ_step) = EQ_chart(EQ_step - 1)   ' Meaning next-cell value of EQ_Chart is equal to last-cell value of EQ_chart
                EQ_step += 1                                ' EQ_step is stepping by +1
                dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                dB_step += 1                                ' dB_step is stepping by +1
                dB_chart(dB_step) = dB_chart(dB_step - 1)   ' Meaning next-cell value of dB_Chart is equal to last-cell value of dB_chart
                dB_step += 1
            End If

        End If



        EQ_chart(0) = 1             ' 第一個EQ點 for Log-axis 的值最小值必須為1, 放在這才執行是因為前面的For裡面需要參考到EQ_chart(0)=0的值
        EQ_chart(35) = EQ_chart(34) + 1             '最後一個bonus EQ點 for Log-axis 的值 = 最後一個 original EQ 點 + 1hz; ex: 最後一個Tutu EQ點若為4000，此EQ點則為4001




        dB_chart(35) = UserControl12.Chart1.ChartAreas(0).AxisY.Minimum       ' 最後一個dB值 = chart Y axis的最小值



        'newSeries.Points.DataBindXY(EQ_end_freq_in_Decimal, dB_array)
        newSeries.Points.DataBindXY(EQ_chart, dB_chart)

        UserControl12.Chart1.Series.Add(newSeries)

        '------------------add EQ changed data in Datagrid from UserControl"EQ panel"
        'UserControl12.DataGridView1.DataSource = EQ_end_freq_in_Decimal








    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click 'Paste click, load Tutu Values
        Dim quotearray_i As Integer
        Dim quotearray_j As Integer
        Dim counter As Int32 = 1
        Dim array_in_clipboard As String
        Dim array_splitLf_from_clipboard(208) As String
        Dim array_splitvbCrLf_from_clipboard() As String
        Dim array_splitvbCrLf_from_clipboard_moved(208) As String
        Dim array_splitvbTab_from_clipboard_moved() As String
        Dim check_CR_LF_counter As Integer = 0
        'Dim array_from_clipboard_2D(1, 208) As String
        'Dim quotearray_2D(1, 208) As String


        'Dim quoteArray As String() = File.ReadAllLines("D:\textfile.txt")      'read .txt code example
        'Dim quoteArray_split() As String

        '-----------------------------------------Get EQ data from .txt file
        'For quotearray_i = 0 To 208
        'quoteArray_split = quoteArray(quotearray_i).Split(vbTab)
        'quotearray_2D(0, quotearray_i) = quoteArray_split(0) 'x=0欄的update
        'quotearray_2D(1, quotearray_i) = quoteArray_split(1) 'x=1欄的update
        'Next



        '-----------------------------------------array reset
        Array.Clear(EQ_start_freq_in_Decimal, 0, 16)
        Array.Clear(EQ_end_freq_in_Decimal, 0, 16)


        '-----------------------------------------dB color reset
        UserControl12.Label37.ForeColor = Color.Black
        UserControl12.Label38.ForeColor = Color.Black
        UserControl12.Label39.ForeColor = Color.Black
        UserControl12.Label40.ForeColor = Color.Black
        UserControl12.Label41.ForeColor = Color.Black
        UserControl12.Label42.ForeColor = Color.Black
        UserControl12.Label43.ForeColor = Color.Black
        UserControl12.Label44.ForeColor = Color.Black
        UserControl12.Label45.ForeColor = Color.Black
        UserControl12.Label46.ForeColor = Color.Black
        UserControl12.Label47.ForeColor = Color.Black
        UserControl12.Label48.ForeColor = Color.Black
        UserControl12.Label49.ForeColor = Color.Black
        UserControl12.Label50.ForeColor = Color.Black
        UserControl12.Label51.ForeColor = Color.Black
        UserControl12.Label52.ForeColor = Color.Black

        '-----------------------At first, check the data from clipboard is string format? 

        '-----------------------------------------Get EQ data from clipboard
        array_in_clipboard = Clipboard.GetText()


        '-----------------------If string from clipboard is Tutu parameter or not
        If Clipboard.ContainsText Then
            If array_in_clipboard.Length < 8000 Or array_in_clipboard.Length > 8400 Then    'copy from skype:8076;   copy from tutu module:8275
                MessageBox.Show("Not Tutu Parameter From Clipboard!  Please Copy Again!")
                Exit Sub

                'ElseIf array_in_clipboard.Chars(33) & array_in_clipboard.Chars(34) & array_in_clipboard.Chars(35) & array_in_clipboard.Chars(36) <> "TUTU" Then
                'MessageBox.Show("Not Tutu Parameter From Clipboard!  Please Copy Again!")
                'Exit Sub

            End If
        Else
            MessageBox.Show("Not Tutu Parameter From Clipboard!  Please Copy Again!")
            Exit Sub
        End If






        array_splitvbCrLf_from_clipboard = array_in_clipboard.Split(ControlChars.CrLf.ToCharArray)
        array_splitvbCrLf_from_clipboard_moved(0) = array_splitvbCrLf_from_clipboard(0)
        '-----------------------如果是從tutu module和 Jason's excel tool Copy下來，就會需要執行下面區塊(因為字串中有vbCR和 vbLF，會導致splt CrLF後每行tutu參數之間會有空一行)
        If array_splitvbCrLf_from_clipboard(1) = "" Then
            For quotearray_j = 0 To 416
                If array_splitvbCrLf_from_clipboard(quotearray_j) = "" Then
                    array_splitvbCrLf_from_clipboard_moved(counter) = array_splitvbCrLf_from_clipboard(quotearray_j + 1)
                    counter += 1
                End If
            Next
        Else
            array_splitvbCrLf_from_clipboard_moved = array_splitvbCrLf_from_clipboard
        End If


        'For quotearray_j = 0 To 416

        '    If array_splitvbCrLf_from_clipboard(quotearray_j) = "" Then
        '        array_splitvbCrLf_from_clipboard_moved(counter) = array_splitvbCrLf_from_clipboard(quotearray_j + 1)
        '        counter += 1
        '    Else
        '        check_CR_LF_counter = 1     '如果是從word or txt, or skype上面copy參數下來，只會有vbLF，在split CrLF後就不會有斷行，所以不是用本區塊code來做，並且用一個特製的counter + 1，讓下面的code來引用這counter。
        '        Exit For
        '    End If

        '    'If quotearray_j = 416 Then   利用某個counter的值來設定中斷點，讓debug可以指定在第幾個迴圈時再進入中斷點
        '    'counter = counter
        '    'End If

        'Next

        '-----------------------如果是從word or txt, or skype上面copy參數下來，還沒有move前的array_splitvbCrLf_from_clipboard就可以拿來用了
        'If check_CR_LF_counter = 1 Then
        '    array_splitvbCrLf_from_clipboard_moved = array_splitvbCrLf_from_clipboard
        'End If




        '------------------------------ 以下是建立出tutu 參數 2D Array ;array_from_clipboard_2D
        For quotearray_i = 0 To 208
            array_splitvbTab_from_clipboard_moved = array_splitvbCrLf_from_clipboard_moved(quotearray_i).Split(vbTab)
            array_from_clipboard_2D(0, quotearray_i) = array_splitvbTab_from_clipboard_moved(0)
            array_from_clipboard_2D(1, quotearray_i) = array_splitvbTab_from_clipboard_moved(1)
        Next

        '------------------------------ 將tutu on/off, SYS00 和 SYS01轉換成2進制 字串
        tutu_sys_parameter_to_binary()



        '------------------------------------判斷HPF 的value from clipbpard
        If array_from_clipboard_2D(1, 58) = "0x0000" Then
            UserControl12.CheckBox1.Checked = True
        ElseIf array_from_clipboard_2D(1, 58) = "0x0001" Then
            UserControl12.CheckBox2.Checked = True
        ElseIf array_from_clipboard_2D(1, 58) = "0x0002" Then
            UserControl12.CheckBox3.Checked = True
        ElseIf array_from_clipboard_2D(1, 58) = "0x0003" Then
            UserControl12.CheckBox4.Checked = True
        ElseIf array_from_clipboard_2D(1, 58) = "0x0004" Then
            UserControl12.CheckBox5.Checked = True
        ElseIf array_from_clipboard_2D(1, 58) = "0x0005" Then
            UserControl12.CheckBox6.Checked = True
        ElseIf array_from_clipboard_2D(1, 58) = "0x0006" Then
            UserControl12.CheckBox7.Checked = True



        End If

        '-------------------------Hex to Dec example
        Dim hex_to_dec_1 As Integer = 0
        hex_to_dec_1 = Convert.ToInt32(array_from_clipboard_2D(1, 59), 16)


        EQ_start_freq_in_Decimal(0) = 0 '起始頻點永遠為0

        '-------------------------EQ 2D Array in Decimal Format & dB_array in decimal
        For i = 0 To 15

            If i < 15 Then
                If Convert.ToInt32(array_from_clipboard_2D(1, 60 + i), 16) > 0 Then
                    EQ_end_freq_in_Decimal(i) = EQ_start_freq_in_Decimal(i) + Convert.ToInt32(array_from_clipboard_2D(1, 59 + i), 16) '建立 EQ end array
                    EQ_start_freq_in_Decimal(i + 1) = EQ_end_freq_in_Decimal(i)    ' 建立EQ start array
                    dB_array(i) = Convert.ToInt32(array_from_clipboard_2D(1, 75 + i), 16) ' 建立dB array
                    dB_array_compare(i) = Convert.ToInt32(array_from_clipboard_2D(1, 75 + i), 16) ' 建立dB array compare
                Else
                    EQ_end_freq_in_Decimal(i) = EQ_start_freq_in_Decimal(i) + Convert.ToInt32(array_from_clipboard_2D(1, 59 + i), 16) '如果下一列頻段差異為0，則不進行 EQ start 建立
                    dB_array(i) = Convert.ToInt32(array_from_clipboard_2D(1, 75 + i), 16)
                    dB_array_compare(i) = Convert.ToInt32(array_from_clipboard_2D(1, 75 + i), 16)
                End If

            Else
                EQ_end_freq_in_Decimal(i) = EQ_start_freq_in_Decimal(i) + Convert.ToInt32(array_from_clipboard_2D(1, 59 + i), 16)  ' 如果頻段探索索引值到底了，就不建立EQ Start array的值
                dB_array(i) = Convert.ToInt32(array_from_clipboard_2D(1, 75 + i), 16)
                dB_array_compare(i) = Convert.ToInt32(array_from_clipboard_2D(1, 75 + i), 16)
            End If
        Next


        '---------------------------------------   dB 數值Normalized, 讓他有正負值
        For i = 0 To 15
            If dB_array(i) > 60000 Then
                dB_array(i) = dB_array(i) - 65536   ' 如果在Hex為負的值，轉乘Decimal後會變成6xxxx的數值，所以必須透過子步驟轉呈負數
                dB_array_compare(i) = dB_array_compare(i) - 65536
            End If
        Next


        '---------------------------------------   Show EQ on Panel
        EQ_start_label_refresh()
        EQ_end_label_refresh()
        dB_label_refresh()

        '------------------- call this function to refresh bandwidth value to checkbox
        Bandwidth_refresh()


        '------------------------------ 判斷Tutu on or off; 如果off, 不讓你按EQ和 DRC，以及其他任何東西
        CheckBox1.Enabled = True        '讓使用者看到checkbox1
        CheckBox2.Enabled = True        '讓使用者看到checkbox2

        CheckBox1.Checked = False       '先設定checkbox 為 沒勾選
        CheckBox2.Checked = False       '先設定checkbox 為 沒勾選 
        If tutu_onoff_bin.Chars(tutu_onoff_bin.Length - 1) <> "1" Then
            CheckBox1.Checked = False
            CheckBox2.Checked = True
        Else
            CheckBox1.Checked = True
            CheckBox2.Checked = False
        End If

        '------------------------------ 判斷EQ 是否enable or disable
        EQ_Enable_disable()


        '----------------------------------------
        'MessageBox.Show(Hex(EQ_end_freq_in_Decimal(13)))   ' debug專用的message box example
        'array_from_clipboard_2D(1, 62) = Hex(4000) 'example: ' 在原本最後的頻段4000hz之後再加上4000hz的頻段，讓整個頻段到達8000hz

        '------------------- Perform Button3 click; this step is uneccessary, because it has already proceeded in Bandwidth_refresh()
        'Button3.PerformClick()


        '----------------------------------------------DRC Section----------------------------------------------------

        '------DRC-Expander Points
        If Convert.ToInt32(array_from_clipboard_2D(1, 91), 16) > 60000 Then
            UserControl22.NumericUpDown1.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 91), 16) - 65536)    'Expander Point 0
        Else
            UserControl22.NumericUpDown1.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 91), 16))
        End If

        If Convert.ToInt32(array_from_clipboard_2D(1, 92), 16) > 60000 Then
            UserControl22.NumericUpDown2.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 92), 16) - 65536)    'Expander Point 1
        Else
            UserControl22.NumericUpDown2.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 92), 16))
        End If
        '------DRC-Knee Points
        UserControl22.NumericUpDown3.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 93), 16))     'Number of Knee Points

        If Convert.ToInt32(array_from_clipboard_2D(1, 93), 16) = 2 Then
            UserControl22.NumericUpDown4.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 97), 16))
            UserControl22.NumericUpDown5.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 96), 16) - 65536)
            UserControl22.NumericUpDown6.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 95), 16) - 65536)
            'UserControl22.TextBox4.Enabled = False                 '因為在UserControl22.textbox4的text change event已經寫好判斷式了
            UserControl22.NumericUpDown8.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 101), 16) - 65536)
            UserControl22.NumericUpDown9.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 100), 16) - 65536)
            UserControl22.NumericUpDown10.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 99), 16) - 65536)
            'UserControl22.TextBox8.Enabled = False                 '因為在UserControl22.textbox4的text change event已經寫好判斷式了
        ElseIf Convert.ToInt32(array_from_clipboard_2D(1, 93), 16) = 3 Then
            UserControl22.NumericUpDown4.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 98), 16))
            UserControl22.NumericUpDown5.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 97), 16) - 65536)
            UserControl22.NumericUpDown6.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 96), 16) - 65536)
            UserControl22.NumericUpDown7.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 95), 16) - 65536)
            UserControl22.NumericUpDown8.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 102), 16) - 65536)
            UserControl22.NumericUpDown9.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 101), 16) - 65536)
            UserControl22.NumericUpDown10.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 100), 16) - 65536)
            UserControl22.NumericUpDown11.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 99), 16) - 65536)
        End If


        '------DRC-attack time      ;checkbox 13
        UserControl22.NumericUpDown13.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 103), 16))
        '------DRC-release time     ;checkbox 14
        UserControl22.NumericUpDown14.Text = Convert.ToString(Convert.ToInt32(array_from_clipboard_2D(1, 104), 16))

        '------1st MIC gain     ;checkbox 15; 106
        If array_from_clipboard_2D(1, 106) = "0x0000" Then
            UserControl22.NumericUpDown15.Text = ""
            UserControl22.CheckBox2.Checked = True

        Else
            Dim string_MIC(1) As String
            string_MIC = Convert.ToString(Math.Log10(Math.Round(Convert.ToInt32(array_from_clipboard_2D(1, 106), 16) / 256, 4)) * 20).Split(".")
            UserControl22.NumericUpDown15.Text = string_MIC(0) & "." & string_MIC(1).Chars(0) & string_MIC(1).Chars(1) & string_MIC(1).Chars(2) & string_MIC(1).Chars(3)
            UserControl22.CheckBox1.Checked = True

        End If

        '------2nd MIC gain     ;checkbox 16; 107
        If array_from_clipboard_2D(1, 107) = "0x0000" Then
            UserControl22.NumericUpDown16.Text = ""
            UserControl22.CheckBox4.Checked = True


        Else
            Dim string_MIC(1) As String
            string_MIC = Convert.ToString(Math.Log10(Math.Round(Convert.ToInt32(array_from_clipboard_2D(1, 107), 16) / 256, 4)) * 20).Split(".")
            UserControl22.NumericUpDown16.Text = string_MIC(0) & "." & string_MIC(1).Chars(0) & string_MIC(1).Chars(1) & string_MIC(1).Chars(2) & string_MIC(1).Chars(3)
            UserControl22.CheckBox3.Checked = True
        End If

        '----------------------Plot DRC by click DRC Plot button in DRC panel
        UserControl22.DRC_Plot()

        '------DRC-makeup gain     ;checkbox 12; EQ_cell no.105 ;放在最後才判斷DRC14是否mute，是因為要讓所有參數都填到panel上的controls後，再決定要不要反灰
        If array_from_clipboard_2D(1, 105) = "0x0000" Then
            UserControl22.NumericUpDown12.Text = ""
            UserControl22.CheckBox7.Checked = True
        ElseIf array_from_clipboard_2D(1, 105) = "0x0100" Then
            UserControl22.NumericUpDown12.Text = "0"
        Else
            Dim string_drc14(1) As String
            string_drc14 = Convert.ToString(Math.Log10(Math.Round(Convert.ToInt32(array_from_clipboard_2D(1, 105), 16) / 256, 4)) * 20).Split(".")
            'UserControl22.NumericUpDown12.Text = string_drc14(0) & "." & string_drc14(1).Chars(0) & string_drc14(1).Chars(1) & string_drc14(1).Chars(2) & string_drc14(1).Chars(3)
            UserControl22.NumericUpDown12.Value = (Math.Log10(Math.Round(Convert.ToInt32(array_from_clipboard_2D(1, 105), 16) / 256, 4)) * 20)
        End If


        '----------------------判定DRC是否enable or disable
        '---------------check if DRC is enable or disable
        DRC_Enable_Disable_check()

    End Sub
    Public Sub EQ_start_label_refresh()
        UserControl12.Label4.Text = EQ_start_freq_in_Decimal(0)     '  Shows Start Frequency on Panel
        UserControl12.Label5.Text = EQ_start_freq_in_Decimal(1)
        UserControl12.Label6.Text = EQ_start_freq_in_Decimal(2)
        UserControl12.Label7.Text = EQ_start_freq_in_Decimal(3)
        UserControl12.Label8.Text = EQ_start_freq_in_Decimal(4)
        UserControl12.Label9.Text = EQ_start_freq_in_Decimal(5)
        UserControl12.Label10.Text = EQ_start_freq_in_Decimal(6)
        UserControl12.Label11.Text = EQ_start_freq_in_Decimal(7)
        UserControl12.Label12.Text = EQ_start_freq_in_Decimal(8)
        UserControl12.Label13.Text = EQ_start_freq_in_Decimal(9)
        UserControl12.Label14.Text = EQ_start_freq_in_Decimal(10)
        UserControl12.Label15.Text = EQ_start_freq_in_Decimal(11)
        UserControl12.Label16.Text = EQ_start_freq_in_Decimal(12)
        UserControl12.Label17.Text = EQ_start_freq_in_Decimal(13)
        UserControl12.Label18.Text = EQ_start_freq_in_Decimal(14)
        UserControl12.Label19.Text = EQ_start_freq_in_Decimal(15)
    End Sub

    Public Sub EQ_end_label_refresh()

        UserControl12.Label20.Text = EQ_end_freq_in_Decimal(0)       ' Shows End Frequency on Panel
        UserControl12.Label21.Text = EQ_end_freq_in_Decimal(1)
        UserControl12.Label22.Text = EQ_end_freq_in_Decimal(2)
        UserControl12.Label23.Text = EQ_end_freq_in_Decimal(3)
        UserControl12.Label24.Text = EQ_end_freq_in_Decimal(4)
        UserControl12.Label25.Text = EQ_end_freq_in_Decimal(5)
        UserControl12.Label26.Text = EQ_end_freq_in_Decimal(6)
        UserControl12.Label27.Text = EQ_end_freq_in_Decimal(7)
        UserControl12.Label28.Text = EQ_end_freq_in_Decimal(8)
        UserControl12.Label29.Text = EQ_end_freq_in_Decimal(9)
        UserControl12.Label30.Text = EQ_end_freq_in_Decimal(10)
        UserControl12.Label31.Text = EQ_end_freq_in_Decimal(11)
        UserControl12.Label32.Text = EQ_end_freq_in_Decimal(12)
        UserControl12.Label33.Text = EQ_end_freq_in_Decimal(13)
        UserControl12.Label34.Text = EQ_end_freq_in_Decimal(14)
        UserControl12.Label35.Text = EQ_end_freq_in_Decimal(15)

    End Sub
    Public Sub dB_label_refresh()
        UserControl12.Label37.Text = dB_array(0)
        UserControl12.Label38.Text = dB_array(1)
        UserControl12.Label39.Text = dB_array(2)
        UserControl12.Label40.Text = dB_array(3)
        UserControl12.Label41.Text = dB_array(4)
        UserControl12.Label42.Text = dB_array(5)
        UserControl12.Label43.Text = dB_array(6)
        UserControl12.Label44.Text = dB_array(7)
        UserControl12.Label45.Text = dB_array(8)
        UserControl12.Label46.Text = dB_array(9)
        UserControl12.Label47.Text = dB_array(10)
        UserControl12.Label48.Text = dB_array(11)
        UserControl12.Label49.Text = dB_array(12)
        UserControl12.Label50.Text = dB_array(13)
        UserControl12.Label51.Text = dB_array(14)
        UserControl12.Label52.Text = dB_array(15)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

        Dim reader As New StreamReader("D:\tabtest.txt")

        Dim oneLine As String = reader.ReadLine()
        While Not oneLine Is Nothing
            Dim vals() As String = oneLine.Split(vbTab)

            'Do something interesting with the array of strings
            Dim s As String
            For Each s In vals
                Console.WriteLine(s)
            Next

            oneLine = reader.ReadLine()
        End While

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserControl12.Hide()
        UserControl22.Hide()
        UserControl31.Hide()
        Label1.Hide()
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False




    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click  'Copy Click
        UserControl31.DataGridView1.Rows.Clear()
        'DataGridView1.Columns.Clear()          '不能clear columns, 會導致無法存值進去DataGridView
        UserControl31.DataGridView1.Refresh()
        Dim str_data As String
        Dim sys01_0to3 As String
        Dim sys01_4to7 As String
        Dim sys01_8to11 As String
        Dim sys01_12to15 As String
        Dim sys01 As String
        '--------------------------------Set Tutu Enable or Disable
        If CheckBox1.Checked = True Then
            array_from_clipboard_2D(1, 0) = "0x0001"
        Else
            array_from_clipboard_2D(1, 0) = "0x0000"
        End If
        '--------------------------------Set EQ enable or disable
        If UserControl12.CheckBox13.Checked = True Then
            tutu_sys01_bin_filled(9) = 1
        Else
            tutu_sys01_bin_filled(9) = 0
        End If
        '--------------------------------Set DRC enable or disable
        If UserControl22.CheckBox5.Checked = True Then
            tutu_sys01_bin_filled(11) = 1
        Else
            tutu_sys01_bin_filled(11) = 0
        End If
        '--------------------------------Set SYS01 to array_from_clipboard_2D
        sys01_0to3 = tutu_sys01_bin_filled(3) & tutu_sys01_bin_filled(2) & tutu_sys01_bin_filled(1) & tutu_sys01_bin_filled(0)
        sys01_4to7 = tutu_sys01_bin_filled(7) & tutu_sys01_bin_filled(6) & tutu_sys01_bin_filled(5) & tutu_sys01_bin_filled(4)
        sys01_8to11 = tutu_sys01_bin_filled(11) & tutu_sys01_bin_filled(10) & tutu_sys01_bin_filled(9) & tutu_sys01_bin_filled(8)
        sys01_12to15 = tutu_sys01_bin_filled(15) & tutu_sys01_bin_filled(14) & tutu_sys01_bin_filled(13) & tutu_sys01_bin_filled(12)

        sys01_0to3 = Hex(Convert.ToInt32(sys01_0to3, 2))  'example: Convert.ToInt32(, 2):將字串"XXXX"轉成2進制格式字串->Hex():再把2進制格式字串轉成16進制格式字串
        sys01_4to7 = Hex(Convert.ToInt32(sys01_4to7, 2))
        sys01_8to11 = Hex(Convert.ToInt32(sys01_8to11, 2))
        sys01_12to15 = Hex(Convert.ToInt32(sys01_12to15, 2))
        array_from_clipboard_2D(1, 2) = "0x0000" & sys01_12to15 & sys01_8to11 & sys01_4to7 & sys01_0to3

        '--------------------------------Put Calibrated EQ value into array_from_clipboard_2D
        For loop1 As Integer = 0 To 15
            If loop1 = 0 Then
                str_data = Convert.ToString(Hex(EQ_end_freq_in_Decimal(loop1)))
                If str_data.Length = 1 Then
                    str_data = "0x000" & str_data
                ElseIf str_data.Length = 2 Then
                    str_data = "0x00" & str_data
                ElseIf str_data.Length = 3 Then
                    str_data = "0x0" & str_data
                ElseIf str_data.Length = 4 Then
                    str_data = "0x" & str_data
                End If
                array_from_clipboard_2D(1, 59 + loop1) = str_data

                'str_data = Convert.ToString(Hex(dB_array(loop1)))               ' Put Calibrated dB value into array_from_clipboard_2D
                'If str_data.Length = 1 Then
                '    str_data = "0x000" & str_data
                'ElseIf str_data.Length = 2 Then
                '    str_data = "0x00" & str_data
                'ElseIf str_data.Length = 3 Then
                '    str_data = "0x0" & str_data
                'ElseIf str_data.Length = 4 Then
                '    str_data = "0x" & str_data
                'End If
                'array_from_clipboard_2D(1, 75 + loop1) = str_data
                If dB_array(loop1) < 0 Then                      ' if dB <0, Put Calibrated dB value into array_from_clipboard_2D
                    str_data = Strings.Right(Convert.ToString(Hex(dB_array(loop1))), 4)
                    str_data = "0x" & str_data
                    array_from_clipboard_2D(1, 75 + loop1) = str_data
                Else
                    str_data = Convert.ToString(Hex(dB_array(loop1))) ' if dB >0, Put Calibrated dB value into array_from_clipboard_2D
                    If str_data.Length = 1 Then
                        str_data = "0x000" & str_data
                    ElseIf str_data.Length = 2 Then
                        str_data = "0x00" & str_data
                    ElseIf str_data.Length = 3 Then
                        str_data = "0x0" & str_data
                    ElseIf str_data.Length = 4 Then
                        str_data = "0x" & str_data
                    End If
                    array_from_clipboard_2D(1, 75 + loop1) = str_data
                End If
            ElseIf EQ_end_freq_in_Decimal(loop1) <> 0 Then          '防止相減後會有負的EQ band
                str_data = Convert.ToString(Hex(EQ_end_freq_in_Decimal(loop1) - EQ_end_freq_in_Decimal(loop1 - 1))) ' Put Calibrated EQ value into array_from_clipboard_2D
                If str_data.Length = 1 Then
                    str_data = "0x000" & str_data
                ElseIf str_data.Length = 2 Then
                    str_data = "0x00" & str_data
                ElseIf str_data.Length = 3 Then
                    str_data = "0x0" & str_data
                ElseIf str_data.Length = 4 Then
                    str_data = "0x" & str_data
                End If
                array_from_clipboard_2D(1, 59 + loop1) = str_data

                If dB_array(loop1) < 0 Then                      ' if dB <0, Put Calibrated dB value into array_from_clipboard_2D
                    str_data = Strings.Right(Convert.ToString(Hex(dB_array(loop1))), 4)
                    str_data = "0x" & str_data
                    array_from_clipboard_2D(1, 75 + loop1) = str_data
                Else
                    str_data = Convert.ToString(Hex(dB_array(loop1))) ' if dB >0, Put Calibrated dB value into array_from_clipboard_2D
                    If str_data.Length = 1 Then
                        str_data = "0x000" & str_data
                    ElseIf str_data.Length = 2 Then
                        str_data = "0x00" & str_data
                    ElseIf str_data.Length = 3 Then
                        str_data = "0x0" & str_data
                    ElseIf str_data.Length = 4 Then
                        str_data = "0x" & str_data
                    End If
                    array_from_clipboard_2D(1, 75 + loop1) = str_data
                End If

            Else
                array_from_clipboard_2D(1, 59 + loop1) = "0x0000"
                array_from_clipboard_2D(1, 75 + loop1) = "0x0000"
            End If

        Next
        '--------------------------------------Put DRC panel text value into array_from_clipboard_2D
        '先判斷DRC14，是因為如果 DRC14是 0x0000，那使用者也無法調整，所以參數也就不用重新copy了
        If UserControl22.CheckBox7.Checked = False Then
            '------------Expander 0
            If UserControl22.NumericUpDown1.Value = 0 Then
                array_from_clipboard_2D(1, 91) = "0x0000"
            Else
                array_from_clipboard_2D(1, 91) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown1.Value)), 4)
            End If
            '------------Expander 1
            If UserControl22.NumericUpDown2.Value = 0 Then
                array_from_clipboard_2D(1, 92) = "0x0000"
            Else
                array_from_clipboard_2D(1, 92) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown2.Value)), 4)
            End If
            '------------Knee Point Number
            array_from_clipboard_2D(1, 93) = "0x000" & Convert.ToString(Hex(UserControl22.NumericUpDown3.Value))


            If UserControl22.NumericUpDown3.Value = 2 Then          '如果Knee-Point = 2
                '-------------------------Knee-in
                'knee-2 in
                If UserControl22.NumericUpDown6.Value = 0 Then
                    array_from_clipboard_2D(1, 95) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 95) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown6.Value)), 4)
                End If
                'knee-1 in
                If UserControl22.NumericUpDown5.Value = 0 Then
                    array_from_clipboard_2D(1, 96) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 96) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown5.Value)), 4)
                End If
                'knee-0 in
                array_from_clipboard_2D(1, 97) = "0x0000"
                '-------------------------Knee-Outs
                'Knee-2 out
                If UserControl22.NumericUpDown10.Value = 0 Then
                    array_from_clipboard_2D(1, 99) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 99) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown10.Value)), 4)
                End If
                'Knee-1 out
                If UserControl22.NumericUpDown9.Value = 0 Then
                    array_from_clipboard_2D(1, 100) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 100) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown9.Value)), 4)
                End If
                'Knee-0 out
                If UserControl22.NumericUpDown8.Value = 0 Then
                    array_from_clipboard_2D(1, 101) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 101) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown8.Value)), 4)
                End If

            ElseIf UserControl22.NumericUpDown3.Value = 3 Then      '如果Knee-Point = 3
                '-------------------------Knee-in
                'knee-3 in
                If UserControl22.NumericUpDown7.Value = 0 Then
                    array_from_clipboard_2D(1, 95) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 95) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown7.Value)), 4)
                End If
                'knee-2 in
                If UserControl22.NumericUpDown6.Value = 0 Then
                    array_from_clipboard_2D(1, 96) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 96) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown6.Value)), 4)
                End If
                'knee-1 in
                If UserControl22.NumericUpDown5.Value = 0 Then
                    array_from_clipboard_2D(1, 97) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 97) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown5.Value)), 4)
                End If
                'knee-0 in
                array_from_clipboard_2D(1, 98) = "0x0000"
                '-------------------------Knee-Outs
                'Knee-3 out
                If UserControl22.NumericUpDown11.Value = 0 Then
                    array_from_clipboard_2D(1, 99) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 99) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown11.Value)), 4)
                End If
                'Knee-2 out
                If UserControl22.NumericUpDown10.Value = 0 Then
                    array_from_clipboard_2D(1, 100) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 100) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown10.Value)), 4)
                End If
                'Knee-1 out
                If UserControl22.NumericUpDown9.Value = 0 Then
                    array_from_clipboard_2D(1, 101) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 101) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown9.Value)), 4)
                End If
                'Knee-0 out
                If UserControl22.NumericUpDown8.Value = 0 Then
                    array_from_clipboard_2D(1, 102) = "0x0000"
                Else
                    array_from_clipboard_2D(1, 102) = "0x" & Strings.Right(Convert.ToString(Hex(UserControl22.NumericUpDown8.Value)), 4)
                End If
            End If
            'attack time
            If Convert.ToString(Hex(UserControl22.NumericUpDown13.Value)).Length = 3 Then
                array_from_clipboard_2D(1, 103) = "0x0" & Convert.ToString(Hex(UserControl22.NumericUpDown13.Value))
            ElseIf Convert.ToString(Hex(UserControl22.NumericUpDown13.Value)).Length = 2 Then
                array_from_clipboard_2D(1, 103) = "0x00" & Convert.ToString(Hex(UserControl22.NumericUpDown13.Value))
            ElseIf Convert.ToString(Hex(UserControl22.NumericUpDown13.Value)).Length = 1 Then
                array_from_clipboard_2D(1, 103) = "0x000" & Convert.ToString(Hex(UserControl22.NumericUpDown13.Value))
            Else
                array_from_clipboard_2D(1, 103) = "0x0000"
            End If

            'release time
            If Convert.ToString(Hex(UserControl22.NumericUpDown14.Value)).Length = 3 Then
                array_from_clipboard_2D(1, 104) = "0x0" & Convert.ToString(Hex(UserControl22.NumericUpDown14.Value))
            ElseIf Convert.ToString(Hex(UserControl22.NumericUpDown14.Value)).Length = 2 Then
                array_from_clipboard_2D(1, 104) = "0x00" & Convert.ToString(Hex(UserControl22.NumericUpDown14.Value))
            ElseIf Convert.ToString(Hex(UserControl22.NumericUpDown14.Value)).Length = 1 Then
                array_from_clipboard_2D(1, 104) = "0x000" & Convert.ToString(Hex(UserControl22.NumericUpDown14.Value))
            Else
                array_from_clipboard_2D(1, 104) = "0x0000"
            End If
            'Makeup gain  DRC14
            If Convert.ToString(Hex(Math.Round(Math.Pow(10, (UserControl22.NumericUpDown12.Value / 20)) * 256, 0))).Length = 4 Then
                array_from_clipboard_2D(1, 105) = "0x" & Convert.ToString(Hex(Math.Round(Math.Pow(10, (UserControl22.NumericUpDown12.Value / 20)) * 256, 0)))
            ElseIf Convert.ToString(Hex(Math.Round(Math.Pow(10, (UserControl22.NumericUpDown12.Value / 20)) * 256, 0))).Length = 3 Then
                array_from_clipboard_2D(1, 105) = "0x0" & Convert.ToString(Hex(Math.Round(Math.Pow(10, (UserControl22.NumericUpDown12.Value / 20)) * 256, 0)))
            ElseIf Convert.ToString(Hex(Math.Round(Math.Pow(10, (UserControl22.NumericUpDown12.Value / 20)) * 256, 0))).Length = 2 Then
                array_from_clipboard_2D(1, 105) = "0x00" & Convert.ToString(Hex(Math.Round(Math.Pow(10, (UserControl22.NumericUpDown12.Value / 20)) * 256, 0)))
            ElseIf Convert.ToString(Hex(Math.Round(Math.Pow(10, (UserControl22.NumericUpDown12.Value / 20)) * 256, 0))).Length = 1 Then
                array_from_clipboard_2D(1, 105) = "0x000" & Convert.ToString(Hex(Math.Round(Math.Pow(10, (UserControl22.NumericUpDown12.Value / 20)) * 256, 0)))
            Else
                array_from_clipboard_2D(1, 105) = "0x0000"
            End If
        Else '如果DRC14 = 0x0000，就不改動原本已經在 array_from_clipboard_2D的參數

        End If

        'array_from_clipboard_2D(1, 105) = Convert.ToString(Hex(Math.Round(Math.Pow(10, (UserControl22.NumericUpDown12.Value / 20)), 0)))    'makeup gain
        '---------------------------------------DRC done




        '------------------------------- put array_from_clipboard_2d to UserControl31.DataGridView1
        For index_gridview As Integer = 0 To 208        '209 is the length of one-dimentional axis in array_from_clipboard_2D; 
            UserControl31.DataGridView1.Rows.Add(array_from_clipboard_2D(0, index_gridview), array_from_clipboard_2D(1, index_gridview))
        Next


        '--------------------save chart image example
        'UserControl12.Chart1.SaveImage("D:\Works\Codings\SWB_FB.bmp", DataVisualization.Charting.ChartImageFormat.Bmp)

        CopyDataGridViewToClipboard(UserControl31.DataGridView1)     ' Copy calibrated tutu data in string format from DataGridView1
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged 'Tutu On
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            Button1.Enabled = True
            Button2.Enabled = True
            Panel2.Hide()

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged 'Tutu Off
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            Button1.Enabled = False
            Button2.Enabled = False
            Panel2.Show()

        End If
    End Sub

    Private Sub CopyDataGridViewToClipboard(ByRef dgv As DataGridView)

        Dim s As String = ""
        Dim oCurrentCol As DataGridViewColumn    'Get header
        oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        'Do                                                                         '這一步註解，是因為我不要把column的header copy下來
        '    s &= oCurrentCol.HeaderText & Chr(Keys.Tab)
        '    oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol,
        ' DataGridViewElementStates.Visible, DataGridViewElementStates.None)
        'Loop Until oCurrentCol Is Nothing
        's = s.Substring(0, s.Length - 1)
        's &= Environment.NewLine    'Get rows
        For Each row As DataGridViewRow In dgv.Rows
            oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
            Do
                If row.Cells(oCurrentCol.Index).Value IsNot Nothing Then
                    s &= row.Cells(oCurrentCol.Index).Value.ToString
                End If
                s &= Chr(Keys.Tab)
                oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol,
              DataGridViewElementStates.Visible, DataGridViewElementStates.None)
            Loop Until oCurrentCol Is Nothing
            s = s.Substring(0, s.Length - 1)
            s &= Environment.NewLine
        Next    'Put to clipboard
        Dim o As New DataObject
        o.SetText(s)
        Clipboard.SetDataObject(o, True)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Dim str_data As String
        'str_data = Convert.ToString(Hex(EQ_end_freq_in_Decimal(0)))
        'If str_data.Length = 1 Then
        '    str_data = "0x000" & str_data
        'ElseIf str_data.Length = 2 Then
        '    str_data = "0x00" & str_data
        'ElseIf str_data.Length = 3 Then
        '    str_data = "0x0" & str_data
        'ElseIf str_data.Length = 4 Then
        '    str_data = "0x" & str_data
        'End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UserControl22.Hide()    'UserControl21 is DRC
        UserControl12.Hide()    'UserControl11 is EQ
        UserControl31.Show()    'Developer Panel
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class
