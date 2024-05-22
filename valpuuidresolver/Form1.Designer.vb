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
        Submit = New Button()
        Label1 = New Label()
        TextInput = New TextBox()
        TextOutput = New TextBox()
        Copy = New Button()
        ApiKeyInput = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Submit
        ' 
        Submit.Location = New Point(14, 170)
        Submit.Name = "Submit"
        Submit.Size = New Size(160, 32)
        Submit.TabIndex = 3
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 9)
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
        TextOutput.Location = New Point(12, 132)
        TextOutput.Name = "TextOutput"
        TextOutput.ReadOnly = True
        TextOutput.Size = New Size(328, 23)
        TextOutput.TabIndex = 2
        ' 
        ' Copy
        ' 
        Copy.Location = New Point(180, 170)
        Copy.Name = "Copy"
        Copy.Size = New Size(160, 32)
        Copy.TabIndex = 4
        Copy.Text = "Copy"
        Copy.UseVisualStyleBackColor = True
        ' 
        ' ApiKeyInput
        ' 
        ApiKeyInput.Location = New Point(12, 77)
        ApiKeyInput.Name = "ApiKeyInput"
        ApiKeyInput.Size = New Size(328, 23)
        ApiKeyInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 5
        Label2.Text = "API Key"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 6
        Label3.Text = "Output"
        ' 
        ' Form1
        ' 
        AcceptButton = Submit
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(352, 215)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(TextInput)
        Controls.Add(ApiKeyInput)
        Controls.Add(TextOutput)
        Controls.Add(Submit)
        Controls.Add(Copy)
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

    Friend WithEvents Submit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextInput As TextBox
    Friend WithEvents TextOutput As TextBox
    Friend WithEvents Copy As Button
    Friend WithEvents ApiKeyInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
