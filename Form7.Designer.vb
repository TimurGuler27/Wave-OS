<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppList
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
        Me.Pong = New System.Windows.Forms.Button()
        Me.LitniFind = New System.Windows.Forms.Button()
        Me.SpaceInvaders = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Pong
        '
        Me.Pong.Location = New System.Drawing.Point(0, 181)
        Me.Pong.Name = "Pong"
        Me.Pong.Size = New System.Drawing.Size(210, 23)
        Me.Pong.TabIndex = 0
        Me.Pong.Text = "Pong"
        Me.Pong.UseVisualStyleBackColor = True
        '
        'LitniFind
        '
        Me.LitniFind.Location = New System.Drawing.Point(0, 152)
        Me.LitniFind.Name = "LitniFind"
        Me.LitniFind.Size = New System.Drawing.Size(210, 23)
        Me.LitniFind.TabIndex = 1
        Me.LitniFind.Text = "LitniFind"
        Me.LitniFind.UseVisualStyleBackColor = True
        '
        'SpaceInvaders
        '
        Me.SpaceInvaders.Location = New System.Drawing.Point(0, 210)
        Me.SpaceInvaders.Name = "SpaceInvaders"
        Me.SpaceInvaders.Size = New System.Drawing.Size(210, 23)
        Me.SpaceInvaders.TabIndex = 2
        Me.SpaceInvaders.Text = "Space Invaders"
        Me.SpaceInvaders.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AppList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 264)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SpaceInvaders)
        Me.Controls.Add(Me.LitniFind)
        Me.Controls.Add(Me.Pong)
        Me.Name = "AppList"
        Me.Text = "Form7"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pong As System.Windows.Forms.Button
    Friend WithEvents LitniFind As System.Windows.Forms.Button
    Friend WithEvents SpaceInvaders As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
