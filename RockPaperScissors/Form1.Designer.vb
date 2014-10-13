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
        Me.lblStart = New System.Windows.Forms.Label()
        Me.rdoRock = New System.Windows.Forms.RadioButton()
        Me.rdoPaper = New System.Windows.Forms.RadioButton()
        Me.rdoScissors = New System.Windows.Forms.RadioButton()
        Me.btnShoot = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnShootIf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(89, 20)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(195, 13)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Start game. Choose something to throw."
        '
        'rdoRock
        '
        Me.rdoRock.AutoSize = True
        Me.rdoRock.Location = New System.Drawing.Point(67, 61)
        Me.rdoRock.Name = "rdoRock"
        Me.rdoRock.Size = New System.Drawing.Size(51, 17)
        Me.rdoRock.TabIndex = 1
        Me.rdoRock.TabStop = True
        Me.rdoRock.Text = "Rock"
        Me.rdoRock.UseVisualStyleBackColor = True
        '
        'rdoPaper
        '
        Me.rdoPaper.AutoSize = True
        Me.rdoPaper.Location = New System.Drawing.Point(67, 100)
        Me.rdoPaper.Name = "rdoPaper"
        Me.rdoPaper.Size = New System.Drawing.Size(53, 17)
        Me.rdoPaper.TabIndex = 2
        Me.rdoPaper.TabStop = True
        Me.rdoPaper.Text = "Paper"
        Me.rdoPaper.UseVisualStyleBackColor = True
        '
        'rdoScissors
        '
        Me.rdoScissors.AutoSize = True
        Me.rdoScissors.Location = New System.Drawing.Point(67, 138)
        Me.rdoScissors.Name = "rdoScissors"
        Me.rdoScissors.Size = New System.Drawing.Size(64, 17)
        Me.rdoScissors.TabIndex = 3
        Me.rdoScissors.TabStop = True
        Me.rdoScissors.Text = "Scissors"
        Me.rdoScissors.UseVisualStyleBackColor = True
        '
        'btnShoot
        '
        Me.btnShoot.Location = New System.Drawing.Point(222, 61)
        Me.btnShoot.Name = "btnShoot"
        Me.btnShoot.Size = New System.Drawing.Size(87, 32)
        Me.btnShoot.TabIndex = 4
        Me.btnShoot.Text = "Shoot"
        Me.btnShoot.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(25, 240)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 5
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(64, 182)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 13)
        Me.lblScore.TabIndex = 7
        '
        'btnShootIf
        '
        Me.btnShootIf.Location = New System.Drawing.Point(222, 113)
        Me.btnShootIf.Name = "btnShootIf"
        Me.btnShootIf.Size = New System.Drawing.Size(85, 31)
        Me.btnShootIf.TabIndex = 8
        Me.btnShootIf.Text = "Shoot"
        Me.btnShootIf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 360)
        Me.Controls.Add(Me.btnShootIf)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnShoot)
        Me.Controls.Add(Me.rdoScissors)
        Me.Controls.Add(Me.rdoPaper)
        Me.Controls.Add(Me.rdoRock)
        Me.Controls.Add(Me.lblStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents rdoRock As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPaper As System.Windows.Forms.RadioButton
    Friend WithEvents rdoScissors As System.Windows.Forms.RadioButton
    Friend WithEvents btnShoot As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnShootIf As System.Windows.Forms.Button

End Class
