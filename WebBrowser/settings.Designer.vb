<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxHomePage = New System.Windows.Forms.TextBox()
        Me.ButtonSaveAndExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HomePage"
        '
        'TextBoxHomePage
        '
        Me.TextBoxHomePage.Location = New System.Drawing.Point(15, 30)
        Me.TextBoxHomePage.Name = "TextBoxHomePage"
        Me.TextBoxHomePage.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxHomePage.TabIndex = 1
        Me.TextBoxHomePage.Text = "http://www.google.com"
        '
        'ButtonSaveAndExit
        '
        Me.ButtonSaveAndExit.AutoSize = True
        Me.ButtonSaveAndExit.Location = New System.Drawing.Point(309, 350)
        Me.ButtonSaveAndExit.Name = "ButtonSaveAndExit"
        Me.ButtonSaveAndExit.Size = New System.Drawing.Size(83, 23)
        Me.ButtonSaveAndExit.TabIndex = 2
        Me.ButtonSaveAndExit.Text = "Save and Exit"
        Me.ButtonSaveAndExit.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 385)
        Me.Controls.Add(Me.ButtonSaveAndExit)
        Me.Controls.Add(Me.TextBoxHomePage)
        Me.Controls.Add(Me.Label1)
        Me.Name = "settings"
        Me.Text = "settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxHomePage As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSaveAndExit As System.Windows.Forms.Button
End Class
