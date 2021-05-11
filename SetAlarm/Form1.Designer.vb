<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbSet = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateSet = New System.Windows.Forms.DateTimePicker()
        Me.BtnSet = New System.Windows.Forms.Button()
        Me.TxtRingtone = New System.Windows.Forms.TextBox()
        Me.BtnChoose = New System.Windows.Forms.Button()
        Me.MediaAlarm = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TimePicker = New System.Windows.Forms.Timer(Me.components)
        Me.TimeSet = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileName = New System.Windows.Forms.OpenFileDialog()
        CType(Me.MediaAlarm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Set Your Alarm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time Now :"
        '
        'LbSet
        '
        Me.LbSet.AutoSize = True
        Me.LbSet.Location = New System.Drawing.Point(259, 118)
        Me.LbSet.Name = "LbSet"
        Me.LbSet.Size = New System.Drawing.Size(52, 20)
        Me.LbSet.TabIndex = 2
        Me.LbSet.Text = "LbSet"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Set Time :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ringtone Alarm :"
        '
        'DateSet
        '
        Me.DateSet.Location = New System.Drawing.Point(244, 166)
        Me.DateSet.Name = "DateSet"
        Me.DateSet.Size = New System.Drawing.Size(238, 26)
        Me.DateSet.TabIndex = 5
        '
        'BtnSet
        '
        Me.BtnSet.Location = New System.Drawing.Point(498, 157)
        Me.BtnSet.Name = "BtnSet"
        Me.BtnSet.Size = New System.Drawing.Size(95, 48)
        Me.BtnSet.TabIndex = 6
        Me.BtnSet.Text = "Set"
        Me.BtnSet.UseVisualStyleBackColor = True
        '
        'TxtRingtone
        '
        Me.TxtRingtone.Location = New System.Drawing.Point(244, 222)
        Me.TxtRingtone.Name = "TxtRingtone"
        Me.TxtRingtone.Size = New System.Drawing.Size(238, 26)
        Me.TxtRingtone.TabIndex = 7
        '
        'BtnChoose
        '
        Me.BtnChoose.Location = New System.Drawing.Point(498, 211)
        Me.BtnChoose.Name = "BtnChoose"
        Me.BtnChoose.Size = New System.Drawing.Size(95, 48)
        Me.BtnChoose.TabIndex = 8
        Me.BtnChoose.Text = "Choose"
        Me.BtnChoose.UseVisualStyleBackColor = True
        '
        'MediaAlarm
        '
        Me.MediaAlarm.Enabled = True
        Me.MediaAlarm.Location = New System.Drawing.Point(91, 273)
        Me.MediaAlarm.Name = "MediaAlarm"
        Me.MediaAlarm.OcxState = CType(resources.GetObject("MediaAlarm.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaAlarm.Size = New System.Drawing.Size(355, 156)
        Me.MediaAlarm.TabIndex = 9
        '
        'TimePicker
        '
        '
        'TimeSet
        '
        '
        'OpenFileName
        '
        Me.OpenFileName.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 661)
        Me.Controls.Add(Me.MediaAlarm)
        Me.Controls.Add(Me.BtnChoose)
        Me.Controls.Add(Me.TxtRingtone)
        Me.Controls.Add(Me.BtnSet)
        Me.Controls.Add(Me.DateSet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LbSet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "FormAlarmMedia"
        CType(Me.MediaAlarm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LbSet As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateSet As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSet As System.Windows.Forms.Button
    Friend WithEvents TxtRingtone As System.Windows.Forms.TextBox
    Friend WithEvents BtnChoose As System.Windows.Forms.Button
    Friend WithEvents MediaAlarm As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TimePicker As System.Windows.Forms.Timer
    Friend WithEvents TimeSet As System.Windows.Forms.Timer
    Friend WithEvents OpenFileName As System.Windows.Forms.OpenFileDialog

End Class
