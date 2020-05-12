Public Class UserControl2
    Public DRC_knee2_input(4) As Integer
    Public DRC_knee3_input(5) As Integer
    Public DRC_knee2_output(4) As Integer
    Public DRC_knee3_output(5) As Integer
    Public newDRCSeries = New DataVisualization.Charting.Series()
    Public kneepoint_special_check As Integer = 0
    Public Sub panel_label_numeric_check()
        If CheckBox5.Checked = True And CheckBox7.Checked = True Then  'DRC enabled, DRC14 0x0000
            Label2.Enabled = False
            NumericUpDown1.Enabled = False
            Label21.Enabled = False
            'Expander 1
            Label3.Enabled = False
            NumericUpDown2.Enabled = False
            Label22.Enabled = False
            'Knee Points Number
            Label4.Enabled = False
            NumericUpDown3.Enabled = False
            Label23.Enabled = False
            'Knee points In & Out
            Label5.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
            Label8.Enabled = False
            Label9.Enabled = False
            Label10.Enabled = False
            Label11.Enabled = False
            Label12.Enabled = False
            Label13.Enabled = False
            Label14.Enabled = False
            Label15.Enabled = False
            Label16.Enabled = False
            Label17.Enabled = False
            Label18.Enabled = False
            NumericUpDown4.Enabled = False
            NumericUpDown5.Enabled = False
            NumericUpDown6.Enabled = False
            NumericUpDown7.Enabled = False
            NumericUpDown8.Enabled = False
            NumericUpDown9.Enabled = False
            NumericUpDown10.Enabled = False
            NumericUpDown11.Enabled = False
            'makeup gain
            Label19.Enabled = False
            NumericUpDown12.Enabled = False
            Label20.Enabled = False
            'attack time
            Label25.Enabled = False
            NumericUpDown13.Enabled = False
            Label24.Enabled = False
            'release time
            Label27.Enabled = False
            NumericUpDown14.Enabled = False
            Label26.Enabled = False
            'Panels
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            'Chart
            Chart1.Visible = False
        ElseIf CheckBox6.Checked = True And CheckBox7.Checked = True Then 'DRC disable, DRC14 0x0000
            Label2.Enabled = False
            NumericUpDown1.Enabled = False
            Label21.Enabled = False
            'Expander 1
            Label3.Enabled = False
            NumericUpDown2.Enabled = False
            Label22.Enabled = False
            'Knee Points Number
            Label4.Enabled = False
            NumericUpDown3.Enabled = False
            Label23.Enabled = False
            'Knee points In & Out
            Label5.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
            Label8.Enabled = False
            Label9.Enabled = False
            Label10.Enabled = False
            Label11.Enabled = False
            Label12.Enabled = False
            Label13.Enabled = False
            Label14.Enabled = False
            Label15.Enabled = False
            Label16.Enabled = False
            Label17.Enabled = False
            Label18.Enabled = False
            NumericUpDown4.Enabled = False
            NumericUpDown5.Enabled = False
            NumericUpDown6.Enabled = False
            NumericUpDown7.Enabled = False
            NumericUpDown8.Enabled = False
            NumericUpDown9.Enabled = False
            NumericUpDown10.Enabled = False
            NumericUpDown11.Enabled = False
            'makeup gain
            Label19.Enabled = False
            NumericUpDown12.Enabled = False
            Label20.Enabled = False
            'attack time
            Label25.Enabled = False
            NumericUpDown13.Enabled = False
            Label24.Enabled = False
            'release time
            Label27.Enabled = False
            NumericUpDown14.Enabled = False
            Label26.Enabled = False
            'Panels
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            'Chart
            Chart1.Visible = False
        ElseIf CheckBox5.Checked = True And CheckBox7.Checked = False Then    'DRC enable, DRC14 note muted
            'Expander 0
            Label2.Enabled = True
            NumericUpDown1.Enabled = True
            Label21.Enabled = True
            'Expander 1
            Label3.Enabled = True
            NumericUpDown2.Enabled = True
            Label22.Enabled = True
            'Knee Points Number
            Label4.Enabled = True
            NumericUpDown3.Enabled = True
            Label23.Enabled = True
            'Knee points In & Out
            If NumericUpDown3.Value = 2 Then
                Label5.Enabled = True
                Label6.Enabled = True
                Label7.Enabled = True
                Label9.Enabled = True
                Label10.Enabled = True
                Label11.Enabled = True
                Label12.Enabled = True
                Label13.Enabled = True
                Label15.Enabled = True
                Label16.Enabled = True
                Label17.Enabled = True
                NumericUpDown4.Enabled = True
                NumericUpDown5.Enabled = True
                NumericUpDown6.Enabled = True
                NumericUpDown8.Enabled = True
                NumericUpDown9.Enabled = True
                NumericUpDown10.Enabled = True
            ElseIf NumericUpDown3.Value = 3 Then
                Label5.Enabled = True
                Label6.Enabled = True
                Label7.Enabled = True
                Label8.Enabled = True
                Label9.Enabled = True
                Label10.Enabled = True
                Label11.Enabled = True
                Label12.Enabled = True
                Label13.Enabled = True
                Label14.Enabled = True
                Label15.Enabled = True
                Label16.Enabled = True
                Label17.Enabled = True
                Label18.Enabled = True
                NumericUpDown4.Enabled = True
                NumericUpDown5.Enabled = True
                NumericUpDown6.Enabled = True
                NumericUpDown7.Enabled = True
                NumericUpDown8.Enabled = True
                NumericUpDown9.Enabled = True
                NumericUpDown10.Enabled = True
                NumericUpDown11.Enabled = True
            End If
            'makeup gain
            Label19.Enabled = True
            NumericUpDown12.Enabled = True
            Label20.Enabled = True
            'attack time
            Label25.Enabled = True
            NumericUpDown13.Enabled = True
            Label24.Enabled = True
            'release time
            Label27.Enabled = True
            NumericUpDown14.Enabled = True
            Label26.Enabled = True
            'Panels
            Panel1.Enabled = True
            Panel2.Enabled = True
            Panel3.Enabled = True
            Chart1.Visible = True
        ElseIf CheckBox6.Checked = True And CheckBox7.Checked = False Then    ''DRC disable, DRC14 note muted
            'Expander 0
            Label2.Enabled = False
            NumericUpDown1.Enabled = False
            Label21.Enabled = False
            'Expander 1
            Label3.Enabled = False
            NumericUpDown2.Enabled = False
            Label22.Enabled = False
            'Knee Points Number
            Label4.Enabled = False
            NumericUpDown3.Enabled = False
            Label23.Enabled = False
            'Knee points In & Out
            Label5.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
            Label8.Enabled = False
            Label9.Enabled = False
            Label10.Enabled = False
            Label11.Enabled = False
            Label12.Enabled = False
            Label13.Enabled = False
            Label14.Enabled = False
            Label15.Enabled = False
            Label16.Enabled = False
            Label17.Enabled = False
            Label18.Enabled = False
            NumericUpDown4.Enabled = False
            NumericUpDown5.Enabled = False
            NumericUpDown6.Enabled = False
            NumericUpDown7.Enabled = False
            NumericUpDown8.Enabled = False
            NumericUpDown9.Enabled = False
            NumericUpDown10.Enabled = False
            NumericUpDown11.Enabled = False
            'makeup gain
            Label19.Enabled = True
            NumericUpDown12.Enabled = True
            Label20.Enabled = True
            'attack time
            Label25.Enabled = False
            NumericUpDown13.Enabled = False
            Label24.Enabled = False
            'release time
            Label27.Enabled = False
            NumericUpDown14.Enabled = False
            Label26.Enabled = False
            'Panels
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            'Chart
            Chart1.Visible = False
        End If
    End Sub
    Private Sub ClickHandler(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        '可以把畫圖的功能放在這
        'DRC_Plot()
    End Sub
    Private Sub UserControl2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------------------------- set NumericUpDown controls to be read-only
        NumericUpDown1.ReadOnly = True
        NumericUpDown2.ReadOnly = True
        NumericUpDown3.ReadOnly = True
        NumericUpDown4.ReadOnly = True
        NumericUpDown5.ReadOnly = True
        NumericUpDown6.ReadOnly = True
        NumericUpDown7.ReadOnly = True
        NumericUpDown8.ReadOnly = True
        NumericUpDown9.ReadOnly = True
        NumericUpDown10.ReadOnly = True
        NumericUpDown11.ReadOnly = True


        NumericUpDown1.BackColor = Color.White
        NumericUpDown2.BackColor = Color.White
        NumericUpDown3.BackColor = Color.White
        ' NumericUpDown4.BackColor = Color.White
        NumericUpDown5.BackColor = Color.White
        NumericUpDown6.BackColor = Color.White
        NumericUpDown7.BackColor = Color.White
        NumericUpDown8.BackColor = Color.White
        NumericUpDown9.BackColor = Color.White
        NumericUpDown10.BackColor = Color.White
        NumericUpDown11.BackColor = Color.White

        Panel7.Show()       '遮住 1st/2nd Mic Gain用的
        Label32.Hide()

        '---------------------------------- initialize Chart1 properties  ;Chart1初始化目前不能加在這，會導致DRC_Plot沒辦法運作(系統回報說: Chart1裡的Series已經存在了<= 有點看不懂，還沒釐清)
        'Chart1.Titles.Clear()
        'Chart1.Titles.Add("Tutu DRC Line")
        'Chart1.Series.Clear()
        'Chart1.ChartAreas(0).AxisX.Title = "Input(dB)"
        'Chart1.ChartAreas(0).AxisY.Title = "Output(dB)"
        'Chart1.ChartAreas(0).AxisX.Minimum = -96
        'Chart1.ChartAreas(0).AxisX.Maximum = 0
        'Chart1.ChartAreas(0).AxisY.Minimum = -96
        'Chart1.ChartAreas(0).AxisY.Maximum = 0
        'Chart1.ChartAreas(0).AxisX.IntervalOffset = 0   'AxisX 最右邊的起始offset
        'Chart1.ChartAreas(0).AxisX.Interval = 6         'AxisX 從最右邊的起始offset之後每格多少間距標刻度一次
        'Chart1.ChartAreas(0).AxisY.IntervalOffset = 0   'AxisX 最右邊的起始offset
        'Chart1.ChartAreas(0).AxisY.Interval = 6         'AxisX 從最右邊的起始offset之後每格多少間距標刻度一次


        'newDRCSeries.ChartType = DataVisualization.Charting.SeriesChartType.Line
        'newDRCSeries.BorderWidth = 3
        'newDRCSeries.Color = Color.LimeGreen

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            Label31.Enabled = False
            Label30.Enabled = False
            NumericUpDown15.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox3.Checked = False
            Label29.Enabled = False
            Label28.Enabled = False
            NumericUpDown16.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            Label31.Enabled = True
            Label30.Enabled = True
            NumericUpDown15.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox4.Checked = False
            Label29.Enabled = True
            Label28.Enabled = True
            NumericUpDown16.Enabled = True
        End If
    End Sub

    Private Sub NumericUpDown1_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.TextChanged 'Expander 0
        If NumericUpDown1.Value > NumericUpDown2.Value Then
            NumericUpDown2.Value = NumericUpDown1.Value
        End If
    End Sub
    Private Sub NumericUpDown1_Click(sender As Object, e As EventArgs) Handles NumericUpDown1.Click 'Expander 0
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown1_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown1.DoubleClick 'Expander 0
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown2_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.TextChanged 'Expander 1
        If NumericUpDown2.Value < NumericUpDown1.Value Then
            NumericUpDown1.Value = NumericUpDown2.Value
        End If
        NumericUpDown4.Minimum = NumericUpDown2.Value
        NumericUpDown5.Minimum = NumericUpDown2.Value
        NumericUpDown6.Minimum = NumericUpDown2.Value
        NumericUpDown7.Minimum = NumericUpDown2.Value
        NumericUpDown8.Minimum = NumericUpDown2.Value
        NumericUpDown9.Minimum = NumericUpDown2.Value
        NumericUpDown10.Minimum = NumericUpDown2.Value
        NumericUpDown11.Minimum = NumericUpDown2.Value
    End Sub
    Private Sub NumericUpDown2_Click(sender As Object, e As EventArgs) Handles NumericUpDown2.Click 'Expander 0
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown2_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown2.DoubleClick 'Expander 0
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown3_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.TextChanged
        If NumericUpDown3.Text = "2" Then
            kneepoint_special_check = 0
            NumericUpDown3.ForeColor = Color.Black
            Label8.Enabled = False
            Label14.Enabled = False
            Label18.Enabled = False
            NumericUpDown7.Enabled = False
            NumericUpDown11.Enabled = False
            kneepoint_special_check = kneepoint_special_check + 1
        ElseIf NumericUpDown3.Text = "3" Then
            NumericUpDown3.ForeColor = Color.Black
            Label8.Enabled = True
            Label14.Enabled = True
            Label18.Enabled = True
            NumericUpDown7.Enabled = True
            NumericUpDown11.Enabled = True
            If kneepoint_special_check = 1 Then
                NumericUpDown7.Value = NumericUpDown10.Value
                NumericUpDown11.Value = NumericUpDown7.Value
            End If
        Else
            NumericUpDown3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub NumericUpDown4_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.TextChanged
        '下面註解，因為
        'If NumericUpDown4.Value >= NumericUpDown8.Value Then
        '    NumericUpDown4.ForeColor = Color.Black
        '    NumericUpDown8.ForeColor = Color.Black
        'Else
        '    NumericUpDown4.ForeColor = Color.Red
        'End If
    End Sub
    Private Sub NumericUpDown8_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.TextChanged
        If NumericUpDown8.Value <= NumericUpDown4.Value And NumericUpDown8.Value < NumericUpDown5.Value Then
            NumericUpDown5.Value = NumericUpDown8.Value
        End If
        '註解掉下方，是因為不要用顏色來請示數值有無超過限制，直接透過上方的code來動態調整數值範圍就不用警示功能了
        'If NumericUpDown8.Value <= NumericUpDown4.Value And NumericUpDown8.Value >= NumericUpDown5.Value Then
        '    'NumericUpDown4.ForeColor = Color.Black
        '    'NumericUpDown8.ForeColor = Color.Black
        '    'NumericUpDown5.ForeColor = Color.Black
        'ElseIf NumericUpDown8.Value <= NumericUpDown4.Value Then
        '    'NumericUpDown4.ForeColor = Color.Black
        '    'NumericUpDown8.ForeColor = Color.Red
        '    NumericUpDown5.Value = NumericUpDown8.Value
        'ElseIf NumericUpDown8.Value >= NumericUpDown5.Value Then
        '    'NumericUpDown5.ForeColor = Color.Black
        '    'NumericUpDown8.ForeColor = Color.Red
        'Else
        '    'NumericUpDown8.ForeColor = Color.Red
        'End If
    End Sub
    Private Sub NumericUpDown8_Click(sender As Object, e As EventArgs) Handles NumericUpDown8.Click  '1把DRC_Plot放在click event 而不是在text_changed event的原因是因為不要導致多次重覆執行 DRC_Plot而浪費系統資源
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown8_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown8.DoubleClick  '設double click是因為，當使用者快速點擊時系統會觸發Double Click事件。
        DRC_Plot()
    End Sub

    Private Sub NumericUpDown5_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.TextChanged
        If NumericUpDown5.Value <= NumericUpDown8.Value And NumericUpDown5.Value < NumericUpDown9.Value Then
            NumericUpDown9.Value = NumericUpDown5.Value
        ElseIf NumericUpDown5.Value > NumericUpDown8.Value And NumericUpDown5.Value >= NumericUpDown9.Value Then
            NumericUpDown8.Value = NumericUpDown5.Value
        End If
        '註解掉下方，是因為不要用顏色來請示數值有無超過限制，直接透過上方的code來動態調整數值範圍就不用警示功能了
        'If NumericUpDown5.Value <= NumericUpDown8.Value And NumericUpDown5.Value >= NumericUpDown9.Value Then
        '    NumericUpDown8.ForeColor = Color.Black
        '    NumericUpDown5.ForeColor = Color.Black
        '    NumericUpDown9.ForeColor = Color.Black
        'ElseIf NumericUpDown5.Value <= NumericUpDown8.Value Then
        '    'NumericUpDown8.ForeColor = Color.Black
        '    'NumericUpDown5.ForeColor = Color.Red
        '    NumericUpDown9.Value = NumericUpDown5.Value
        'ElseIf NumericUpDown5.Value >= NumericUpDown9.Value Then
        '    'NumericUpDown9.ForeColor = Color.Black
        '    'NumericUpDown5.ForeColor = Color.Red
        '    NumericUpDown8.Value = NumericUpDown5.Value
        'Else
        '    NumericUpDown5.ForeColor = Color.Red
        'End If
    End Sub
    Private Sub NumericUpDown5_Click(sender As Object, e As EventArgs) Handles NumericUpDown5.Click
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown5_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown5.DoubleClick
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown9_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.TextChanged
        If NumericUpDown9.Value <= NumericUpDown5.Value And NumericUpDown9.Value < NumericUpDown6.Value Then
            NumericUpDown6.Value = NumericUpDown9.Value
        ElseIf NumericUpDown9.Value > NumericUpDown5.Value And NumericUpDown9.Value >= NumericUpDown6.Value Then
            NumericUpDown5.Value = NumericUpDown9.Value
        End If
        'If NumericUpDown9.Value <= NumericUpDown5.Value And NumericUpDown9.Value > NumericUpDown6.Value Then
        '    NumericUpDown5.ForeColor = Color.Black
        '    NumericUpDown9.ForeColor = Color.Black
        '    NumericUpDown6.ForeColor = Color.Black
        'ElseIf NumericUpDown9.Value <= NumericUpDown5.Value Then
        '    NumericUpDown5.ForeColor = Color.Black
        '    NumericUpDown9.ForeColor = Color.Red
        'ElseIf NumericUpDown9.Value > NumericUpDown6.Value Then
        '    NumericUpDown6.ForeColor = Color.Black
        '    NumericUpDown9.ForeColor = Color.Red
        'Else
        '    NumericUpDown9.ForeColor = Color.Red
        'End If
    End Sub
    Private Sub NumericUpDown9_Click(sender As Object, e As EventArgs) Handles NumericUpDown9.Click
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown9_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown9.DoubleClick
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown6_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.TextChanged
        If NumericUpDown6.Value <= NumericUpDown9.Value And NumericUpDown6.Value < NumericUpDown10.Value Then
            NumericUpDown10.Value = NumericUpDown6.Value
        ElseIf NumericUpDown6.Value > NumericUpDown9.Value And NumericUpDown6.Value >= NumericUpDown10.Value Then
            NumericUpDown9.Value = NumericUpDown6.Value
        End If
        'If NumericUpDown6.Value < NumericUpDown9.Value And NumericUpDown6.Value >= NumericUpDown10.Value Then
        '    NumericUpDown9.ForeColor = Color.Black
        '    NumericUpDown6.ForeColor = Color.Black
        '    NumericUpDown10.ForeColor = Color.Black
        'ElseIf NumericUpDown6.Value < NumericUpDown9.Value Then
        '    NumericUpDown9.ForeColor = Color.Black
        '    NumericUpDown6.ForeColor = Color.Red
        'ElseIf NumericUpDown6.Value >= NumericUpDown10.Value Then
        '    NumericUpDown10.ForeColor = Color.Black
        '    NumericUpDown6.ForeColor = Color.Red
        'Else
        '    NumericUpDown6.ForeColor = Color.Red
        'End If
    End Sub
    Private Sub NumericUpDown6_Click(sender As Object, e As EventArgs) Handles NumericUpDown6.Click
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown6_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown6.DoubleClick
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown10_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown10.TextChanged
        If NumericUpDown3.Value = 3 Then
            If NumericUpDown10.Value <= NumericUpDown6.Value And NumericUpDown10.Value < NumericUpDown7.Value Then
                NumericUpDown7.Value = NumericUpDown10.Value
            ElseIf NumericUpDown10.Value > NumericUpDown6.Value And NumericUpDown10.Value >= NumericUpDown7.Value Then
                NumericUpDown6.Value = NumericUpDown10.Value
            End If
            'If NumericUpDown10.Value <= NumericUpDown6.Value And NumericUpDown10.Value > NumericUpDown7.Value Then
            '    NumericUpDown6.ForeColor = Color.Black
            '    NumericUpDown10.ForeColor = Color.Black
            '    NumericUpDown7.ForeColor = Color.Black
            'ElseIf NumericUpDown10.Value <= NumericUpDown6.Value Then
            '    NumericUpDown6.ForeColor = Color.Black
            '    NumericUpDown10.ForeColor = Color.Red
            'ElseIf NumericUpDown10.Value > NumericUpDown7.Value Then
            '    NumericUpDown7.ForeColor = Color.Black
            '    NumericUpDown10.ForeColor = Color.Red
            'Else
            '    NumericUpDown10.ForeColor = Color.Red
            'End If
        ElseIf NumericUpDown3.Value = 2 Then
            If NumericUpDown10.Value > NumericUpDown6.Value Then
                NumericUpDown6.Value = NumericUpDown10.Value
            End If
            'If NumericUpDown10.Value <= NumericUpDown6.Value Then
            '    NumericUpDown6.ForeColor = Color.Black
            '    NumericUpDown10.ForeColor = Color.Black
            'Else
            '    NumericUpDown10.ForeColor = Color.Red
            'End If
        End If
    End Sub
    Private Sub NumericUpDown10_Click(sender As Object, e As EventArgs) Handles NumericUpDown10.Click
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown10_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown10.DoubleClick
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown7_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.TextChanged
        If NumericUpDown3.Value = 3 Then
            If NumericUpDown7.Value <= NumericUpDown10.Value And NumericUpDown7.Value < NumericUpDown11.Value Then
                NumericUpDown11.Value = NumericUpDown7.Value
            ElseIf NumericUpDown7.Value > NumericUpDown10.Value And NumericUpDown7.Value >= NumericUpDown11.Value Then
                NumericUpDown10.Value = NumericUpDown7.Value
            End If
            'If NumericUpDown7.Value < NumericUpDown10.Value And NumericUpDown7.Value >= NumericUpDown11.Value Then
            '    NumericUpDown10.ForeColor = Color.Black
            '    NumericUpDown7.ForeColor = Color.Black
            '    NumericUpDown11.ForeColor = Color.Black
            'ElseIf NumericUpDown7.Value < NumericUpDown10.Value Then
            '    NumericUpDown10.ForeColor = Color.Black
            '    NumericUpDown7.ForeColor = Color.Red
            'ElseIf NumericUpDown7.Value >= NumericUpDown11.Value Then
            '    NumericUpDown11.ForeColor = Color.Black
            '    NumericUpDown7.ForeColor = Color.Red
            'Else
            '    NumericUpDown7.ForeColor = Color.Red
            'End If
        ElseIf NumericUpDown3.Value = 2 Then
            Exit Sub
        End If
    End Sub
    Private Sub NumericUpDown7_Click(sender As Object, e As EventArgs) Handles NumericUpDown7.Click
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown7_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown7.DoubleClick
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown11_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown11.TextChanged
        If NumericUpDown3.Value = 3 Then
            If NumericUpDown11.Value > NumericUpDown7.Value Then
                NumericUpDown7.Value = NumericUpDown11.Value
            End If
            'If NumericUpDown11.Value <= NumericUpDown7.Value Then
            '    NumericUpDown7.ForeColor = Color.Black
            '    NumericUpDown11.ForeColor = Color.Black
            'Else
            '    NumericUpDown11.ForeColor = Color.Red
            'End If
        ElseIf NumericUpDown3.Value = 2 Then
            Exit Sub
        End If
    End Sub
    Private Sub NumericUpDown11_Click(sender As Object, e As EventArgs) Handles NumericUpDown11.Click
        DRC_Plot()
    End Sub
    Private Sub NumericUpDown11_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown11.DoubleClick
        DRC_Plot()
    End Sub
    Public Sub DRC_Plot()
        Dim newDRCSeries = New DataVisualization.Charting.Series()
        Chart1.Titles.Clear()
        'Chart1.Titles.Add("Tutu DRC Line")
        Chart1.Series.Clear()
        Chart1.ChartAreas(0).AxisX.Title = "Input(dB)"
        Chart1.ChartAreas(0).AxisY.Title = "Output(dB)"
        Chart1.ChartAreas(0).AxisX.Minimum = -96
        Chart1.ChartAreas(0).AxisX.Maximum = 0
        Chart1.ChartAreas(0).AxisY.Minimum = -96
        Chart1.ChartAreas(0).AxisY.Maximum = 0
        Chart1.ChartAreas(0).AxisX.IntervalOffset = 0   'AxisX 最右邊的起始offset
        Chart1.ChartAreas(0).AxisX.Interval = 6         'AxisX 從最右邊的起始offset之後每格多少間距標刻度一次
        Chart1.ChartAreas(0).AxisY.IntervalOffset = 0   'AxisX 最右邊的起始offset
        Chart1.ChartAreas(0).AxisY.Interval = 6         'AxisX 從最右邊的起始offset之後每格多少間距標刻度一次


        newDRCSeries.ChartType = DataVisualization.Charting.SeriesChartType.Line
        newDRCSeries.BorderWidth = 3
        newDRCSeries.Color = Color.LimeGreen
        Dim DRC_knee2_input(4) As Integer
        Dim DRC_knee3_input(5) As Integer
        Dim DRC_knee2_output(4) As Integer
        Dim DRC_knee3_output(5) As Integer

        If NumericUpDown3.Value = 2 Then
            DRC_knee2_input(0) = NumericUpDown1.Value
            DRC_knee2_input(1) = NumericUpDown2.Value
            DRC_knee2_input(2) = NumericUpDown6.Value
            DRC_knee2_input(3) = NumericUpDown5.Value
            DRC_knee2_input(4) = NumericUpDown4.Value

            DRC_knee2_output(0) = -96
            DRC_knee2_output(1) = NumericUpDown2.Value
            DRC_knee2_output(2) = NumericUpDown10.Value
            DRC_knee2_output(3) = NumericUpDown9.Value
            DRC_knee2_output(4) = NumericUpDown8.Value

            newDRCSeries.Points.DataBindXY(DRC_knee2_input, DRC_knee2_output)
            Chart1.Series.Add(newDRCSeries)
            'newDRCSeries.MarkerColor = Color.White
            'newDRCSeries.MarkerBorderColor = Color.LimeGreen
            'newDRCSeries.MarkerBorderWidth = 2
            newDRCSeries.Points(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(0).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(0).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(0).MarkerBorderWidth = 3
            newDRCSeries.Points(0).MarkerSize = 10
            newDRCSeries.Points(1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(1).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(1).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(1).MarkerBorderWidth = 3
            newDRCSeries.Points(1).MarkerSize = 10
            newDRCSeries.Points(2).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(2).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(2).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(2).MarkerBorderWidth = 3
            newDRCSeries.Points(2).MarkerSize = 10
            newDRCSeries.Points(3).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(3).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(3).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(3).MarkerBorderWidth = 3
            newDRCSeries.Points(3).MarkerSize = 10
            newDRCSeries.Points(4).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(4).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(4).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(4).MarkerBorderWidth = 3
            newDRCSeries.Points(4).MarkerSize = 10
        ElseIf NumericUpDown3.Value = 3 Then
            DRC_knee3_input(0) = NumericUpDown1.Value
            DRC_knee3_input(1) = NumericUpDown2.Value
            DRC_knee3_input(2) = NumericUpDown7.Value
            DRC_knee3_input(3) = NumericUpDown6.Value
            DRC_knee3_input(4) = NumericUpDown5.Value
            DRC_knee3_input(5) = NumericUpDown4.Value

            DRC_knee3_output(0) = -96
            DRC_knee3_output(1) = NumericUpDown2.Value
            DRC_knee3_output(2) = NumericUpDown11.Value
            DRC_knee3_output(3) = NumericUpDown10.Value
            DRC_knee3_output(4) = NumericUpDown9.Value
            DRC_knee3_output(5) = NumericUpDown8.Value

            newDRCSeries.Points.DataBindXY(DRC_knee3_input, DRC_knee3_output)
            Chart1.Series.Add(newDRCSeries)
            newDRCSeries.Points(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(0).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(0).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(0).MarkerBorderWidth = 3
            newDRCSeries.Points(0).MarkerSize = 10
            newDRCSeries.Points(1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(1).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(1).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(1).MarkerBorderWidth = 3
            newDRCSeries.Points(1).MarkerSize = 10
            newDRCSeries.Points(2).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(2).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(2).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(2).MarkerBorderWidth = 3
            newDRCSeries.Points(2).MarkerSize = 10
            newDRCSeries.Points(3).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(3).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(3).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(3).MarkerBorderWidth = 3
            newDRCSeries.Points(3).MarkerSize = 10
            newDRCSeries.Points(4).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(4).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(4).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(4).MarkerBorderWidth = 3
            newDRCSeries.Points(4).MarkerSize = 10
            newDRCSeries.Points(5).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            newDRCSeries.Points(5).MarkerColor = Color.SkyBlue
            newDRCSeries.Points(5).MarkerBorderColor = Color.LimeGreen
            newDRCSeries.Points(5).MarkerBorderWidth = 3
            newDRCSeries.Points(5).MarkerSize = 10

        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox6.Checked = False
            'Panel6.Hide()
            panel_label_numeric_check()
        Else
            CheckBox6.Checked = True
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox5.Checked = False
            'Panel6.Show()
            panel_label_numeric_check()
        Else
            CheckBox5.Checked = True
        End If
    End Sub



    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            panel_label_numeric_check()
        Else
            panel_label_numeric_check()

        End If
    End Sub


End Class
