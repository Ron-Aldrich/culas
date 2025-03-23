<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        text = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' text
        ' 
        text.Location = New Point(68, 83)
        text.Name = "text"
        text.PlaceholderText = "Insert LRN"
        text.Size = New Size(232, 23)
        text.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(154, 149)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "DELETE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(382, 250)
        Controls.Add(Button1)
        Controls.Add(text)
        Name = "Form5"

        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents text As TextBox
    Friend WithEvents Button1 As Button
End Class
