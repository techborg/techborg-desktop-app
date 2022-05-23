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
        Me.webbrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'webbrowser1
        '
        Me.webbrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webbrowser1.Location = New System.Drawing.Point(0, 0)
        Me.webbrowser1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.webbrowser1.MinimumSize = New System.Drawing.Size(27, 27)
        Me.webbrowser1.Name = "webbrowser1"
        Me.webbrowser1.Size = New System.Drawing.Size(800, 450)
        Me.webbrowser1.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.webbrowser1)
        Me.Name = "Form1"
        Me.Text = "TechBorg Application"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webbrowser1 As WebBrowser
End Class
