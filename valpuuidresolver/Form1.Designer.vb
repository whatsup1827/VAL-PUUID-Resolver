<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        TextInput = New TextBox()
        TextOutput = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 85)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 32)
        Button1.TabIndex = 1
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(104, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter a Riot ID or PUUID"
        ' 
        ' TextInput
        ' 
        TextInput.Location = New Point(12, 27)
        TextInput.Name = "TextInput"
        TextInput.Size = New Size(328, 23)
        TextInput.TabIndex = 0
        ' 
        ' TextOutput
        ' 
        TextOutput.Location = New Point(12, 56)
        TextOutput.Name = "TextOutput"
        TextOutput.ReadOnly = True
        TextOutput.Size = New Size(328, 23)
        TextOutput.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(180, 85)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 32)
        Button2.TabIndex = 2
        Button2.Text = "Copy"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(352, 126)
        Controls.Add(Button2)
        Controls.Add(TextOutput)
        Controls.Add(TextInput)
        Controls.Add(Label1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "VALORANT PUUID Resolver"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextInput As TextBox
    Friend WithEvents TextOutput As TextBox
    Friend WithEvents Button2 As Button

End Class
