<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmCrapsGame
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPlay = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtGames = New System.Windows.Forms.TextBox
        Me.txtWinsResults = New System.Windows.Forms.TextBox
        Me.txtGameStatus = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLossesResults = New System.Windows.Forms.TextBox
        Me.btnQuit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(26, 271)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(125, 40)
        Me.btnPlay.TabIndex = 8
        Me.btnPlay.Text = "Play"
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(169, 271)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Games to Play:"
        '
        'txtGames
        '
        Me.txtGames.Location = New System.Drawing.Point(96, 35)
        Me.txtGames.Name = "txtGames"
        Me.txtGames.Size = New System.Drawing.Size(70, 20)
        Me.txtGames.TabIndex = 1
        '
        'txtWinsResults
        '
        Me.txtWinsResults.Location = New System.Drawing.Point(212, 28)
        Me.txtWinsResults.Multiline = True
        Me.txtWinsResults.Name = "txtWinsResults"
        Me.txtWinsResults.Size = New System.Drawing.Size(110, 218)
        Me.txtWinsResults.TabIndex = 5
        '
        'txtGameStatus
        '
        Me.txtGameStatus.Location = New System.Drawing.Point(15, 102)
        Me.txtGameStatus.Multiline = True
        Me.txtGameStatus.Name = "txtGameStatus"
        Me.txtGameStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGameStatus.Size = New System.Drawing.Size(173, 144)
        Me.txtGameStatus.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Wins"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(362, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Losses"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Detail of Games"
        '
        'txtLossesResults
        '
        Me.txtLossesResults.Location = New System.Drawing.Point(337, 28)
        Me.txtLossesResults.Multiline = True
        Me.txtLossesResults.Name = "txtLossesResults"
        Me.txtLossesResults.Size = New System.Drawing.Size(110, 218)
        Me.txtLossesResults.TabIndex = 7
        '
        'btnQuit
        '
        Me.btnQuit.Enabled = False
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(312, 271)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(125, 40)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "Quit"
        '
        'FrmCrapsGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 323)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtLossesResults)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGameStatus)
        Me.Controls.Add(Me.txtWinsResults)
        Me.Controls.Add(Me.txtGames)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "FrmCrapsGame"
        Me.Text = "Craps Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGames As System.Windows.Forms.TextBox
    Friend WithEvents txtWinsResults As System.Windows.Forms.TextBox
    Friend WithEvents txtGameStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLossesResults As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
