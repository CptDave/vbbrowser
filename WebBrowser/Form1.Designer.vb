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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.ButtonForward = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 40)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(844, 442)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'ButtonBack
        '
        Me.ButtonBack.AutoSize = True
        Me.ButtonBack.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.Location = New System.Drawing.Point(12, 7)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(41, 28)
        Me.ButtonBack.TabIndex = 1
        Me.ButtonBack.Text = "<"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(676, 8)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 2
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(106, 7)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(68, 27)
        Me.ButtonEnter.TabIndex = 4
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'ButtonForward
        '
        Me.ButtonForward.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonForward.Location = New System.Drawing.Point(59, 7)
        Me.ButtonForward.Name = "ButtonForward"
        Me.ButtonForward.Size = New System.Drawing.Size(41, 28)
        Me.ButtonForward.TabIndex = 5
        Me.ButtonForward.Text = ">"
        Me.ButtonForward.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(180, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(490, 20)
        Me.TextBox1.TabIndex = 6
        '
        'ButtonSettings
        '
        Me.ButtonSettings.Location = New System.Drawing.Point(757, 7)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSettings.TabIndex = 7
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(844, 482)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonForward)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.WebBrowser1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Web Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonEnter As System.Windows.Forms.Button
    Friend WithEvents ButtonForward As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSettings As System.Windows.Forms.Button

End Class
