Imports System.IO

Public Class Form1
    Dim s As Integer
    Dim d As Path

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TimeSet.Enabled = True
        DateSet.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub TimeSet_Tick(sender As System.Object, e As System.EventArgs) Handles TimeSet.Tick
        LbSet.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub TimePicker_Tick(sender As System.Object, e As System.EventArgs) Handles TimePicker.Tick
        Try
            If TimeOfDay = DateSet.Text Then
                If s = 1 Then
                    MediaAlarm.URL = TxtRingtone.Text.ToString
                Else
                    MsgBox(DateSet.Value)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSet_Click(sender As System.Object, e As System.EventArgs) Handles BtnSet.Click
        TimePicker.Enabled = True
        MsgBox("Alarm Sudah Di Set", MsgBoxStyle.Information)
    End Sub

    Private Sub BtnChoose_Click(sender As System.Object, e As System.EventArgs) Handles BtnChoose.Click
        If OpenFileName.ShowDialog = DialogResult.OK Then
            TxtRingtone.Text = ""
            TxtRingtone.Text = OpenFileName.FileName
            s = 1
        End If
    End Sub
End Class
