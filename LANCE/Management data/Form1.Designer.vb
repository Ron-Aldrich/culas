<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Timer1 = New Timer(components)
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(63, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(508, 126)
        Label1.TabIndex = 0
        Label1.Text = "Welcome to System " & vbCrLf & "     Management"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 245)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 25)
        Label2.TabIndex = 1
        Label2.Text = "Laoding.."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(129, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(22, 25)
        Label3.TabIndex = 2
        Label3.Text = "0"
        ' 
        ' Timer1
        ' 
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = SystemColors.HotTrack
        ProgressBar1.Location = New Point(39, 273)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(561, 34)
        ProgressBar1.Step = 5
        ProgressBar1.TabIndex = 0
        ProgressBar1.UseWaitCursor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(639, 336)
        Controls.Add(ProgressBar1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar

End Class
