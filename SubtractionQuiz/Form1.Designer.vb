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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblSubSign = New System.Windows.Forms.Label()
        Me.txtBoxDiff = New System.Windows.Forms.TextBox()
        Me.grpBoxScore = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblOver = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpBoxScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(32, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(146, 18)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "SUBTRACTION QUIZ"
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(73, 38)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(54, 18)
        Me.lblNum1.TabIndex = 1
        Me.lblNum1.Text = "- - - - -"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(73, 80)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(54, 18)
        Me.lblNum2.TabIndex = 2
        Me.lblNum2.Text = "- - - - -"
        '
        'lblSubSign
        '
        Me.lblSubSign.AutoSize = True
        Me.lblSubSign.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubSign.Location = New System.Drawing.Point(43, 80)
        Me.lblSubSign.Name = "lblSubSign"
        Me.lblSubSign.Size = New System.Drawing.Size(14, 18)
        Me.lblSubSign.TabIndex = 3
        Me.lblSubSign.Text = "-"
        '
        'txtBoxDiff
        '
        Me.txtBoxDiff.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxDiff.Location = New System.Drawing.Point(35, 106)
        Me.txtBoxDiff.Name = "txtBoxDiff"
        Me.txtBoxDiff.Size = New System.Drawing.Size(143, 25)
        Me.txtBoxDiff.TabIndex = 5
        '
        'grpBoxScore
        '
        Me.grpBoxScore.Controls.Add(Me.lblTotal)
        Me.grpBoxScore.Controls.Add(Me.lblOver)
        Me.grpBoxScore.Controls.Add(Me.lblScore)
        Me.grpBoxScore.Location = New System.Drawing.Point(12, 137)
        Me.grpBoxScore.Name = "grpBoxScore"
        Me.grpBoxScore.Size = New System.Drawing.Size(115, 76)
        Me.grpBoxScore.TabIndex = 6
        Me.grpBoxScore.TabStop = False
        Me.grpBoxScore.Text = "SCORE"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(76, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 42)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "0"
        '
        'lblOver
        '
        Me.lblOver.AutoSize = True
        Me.lblOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOver.Location = New System.Drawing.Point(46, 16)
        Me.lblOver.Name = "lblOver"
        Me.lblOver.Size = New System.Drawing.Size(28, 42)
        Me.lblOver.TabIndex = 7
        Me.lblOver.Text = "/"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(6, 16)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(39, 42)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "0"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(133, 161)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseMnemonic = False
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(133, 190)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 222)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpBoxScore)
        Me.Controls.Add(Me.txtBoxDiff)
        Me.Controls.Add(Me.lblSubSign)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.lblHeader)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Subtraction Quiz"
        Me.grpBoxScore.ResumeLayout(False)
        Me.grpBoxScore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblSubSign As System.Windows.Forms.Label
    Friend WithEvents txtBoxDiff As System.Windows.Forms.TextBox
    Friend WithEvents grpBoxScore As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblOver As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
