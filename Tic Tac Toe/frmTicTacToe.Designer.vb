<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTicTacToe
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblPlayer1X = New System.Windows.Forms.Label()
        Me.lblPlayer2O = New System.Windows.Forms.Label()
        Me.lstWin1 = New System.Windows.Forms.ListBox()
        Me.lstWin2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(148, 349)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(69, 32)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblPlayer1X
        '
        Me.lblPlayer1X.AutoSize = True
        Me.lblPlayer1X.Location = New System.Drawing.Point(26, 356)
        Me.lblPlayer1X.Name = "lblPlayer1X"
        Me.lblPlayer1X.Size = New System.Drawing.Size(98, 19)
        Me.lblPlayer1X.TabIndex = 1
        Me.lblPlayer1X.Text = "Player 1: X"
        '
        'lblPlayer2O
        '
        Me.lblPlayer2O.AutoSize = True
        Me.lblPlayer2O.Location = New System.Drawing.Point(241, 356)
        Me.lblPlayer2O.Name = "lblPlayer2O"
        Me.lblPlayer2O.Size = New System.Drawing.Size(97, 19)
        Me.lblPlayer2O.TabIndex = 2
        Me.lblPlayer2O.Text = "Player 2: O"
        '
        'lstWin1
        '
        Me.lstWin1.FormattingEnabled = True
        Me.lstWin1.ItemHeight = 19
        Me.lstWin1.Location = New System.Drawing.Point(13, 401)
        Me.lstWin1.Name = "lstWin1"
        Me.lstWin1.Size = New System.Drawing.Size(120, 80)
        Me.lstWin1.TabIndex = 3
        Me.lstWin1.Visible = False
        '
        'lstWin2
        '
        Me.lstWin2.FormattingEnabled = True
        Me.lstWin2.ItemHeight = 19
        Me.lstWin2.Location = New System.Drawing.Point(232, 401)
        Me.lstWin2.Name = "lstWin2"
        Me.lstWin2.Size = New System.Drawing.Size(120, 80)
        Me.lstWin2.TabIndex = 4
        Me.lstWin2.Visible = False
        '
        'frmTicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(364, 483)
        Me.Controls.Add(Me.lstWin2)
        Me.Controls.Add(Me.lstWin1)
        Me.Controls.Add(Me.lblPlayer2O)
        Me.Controls.Add(Me.lblPlayer1X)
        Me.Controls.Add(Me.btnReset)
        Me.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "frmTicTacToe"
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents lblPlayer1X As Label
    Friend WithEvents lblPlayer2O As Label
    Friend WithEvents lstWin1 As ListBox
    Friend WithEvents lstWin2 As ListBox
End Class
