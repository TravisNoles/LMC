<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmdLookup = New System.Windows.Forms.Button()
        Me.lblCity1 = New System.Windows.Forms.Label()
        Me.lblCity2 = New System.Windows.Forms.Label()
        Me.cbCity1 = New System.Windows.Forms.ComboBox()
        Me.cbCity2 = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDistanceCalc = New System.Windows.Forms.Label()
        Me.lblDistanceTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdLookup
        '
        Me.cmdLookup.Location = New System.Drawing.Point(106, 155)
        Me.cmdLookup.Name = "cmdLookup"
        Me.cmdLookup.Size = New System.Drawing.Size(75, 23)
        Me.cmdLookup.TabIndex = 0
        Me.cmdLookup.Text = "Lookup"
        Me.cmdLookup.UseVisualStyleBackColor = True
        '
        'lblCity1
        '
        Me.lblCity1.AutoSize = True
        Me.lblCity1.Location = New System.Drawing.Point(12, 29)
        Me.lblCity1.Name = "lblCity1"
        Me.lblCity1.Size = New System.Drawing.Size(33, 13)
        Me.lblCity1.TabIndex = 1
        Me.lblCity1.Text = "City 1"
        '
        'lblCity2
        '
        Me.lblCity2.AutoSize = True
        Me.lblCity2.Location = New System.Drawing.Point(240, 29)
        Me.lblCity2.Name = "lblCity2"
        Me.lblCity2.Size = New System.Drawing.Size(33, 13)
        Me.lblCity2.TabIndex = 2
        Me.lblCity2.Text = "City 2"
        '
        'cbCity1
        '
        Me.cbCity1.FormattingEnabled = True
        Me.cbCity1.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"})
        Me.cbCity1.Location = New System.Drawing.Point(12, 45)
        Me.cbCity1.Name = "cbCity1"
        Me.cbCity1.Size = New System.Drawing.Size(121, 21)
        Me.cbCity1.TabIndex = 3
        '
        'cbCity2
        '
        Me.cbCity2.FormattingEnabled = True
        Me.cbCity2.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"})
        Me.cbCity2.Location = New System.Drawing.Point(152, 45)
        Me.cbCity2.Name = "cbCity2"
        Me.cbCity2.Size = New System.Drawing.Size(121, 21)
        Me.cbCity2.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(103, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(99, 13)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Distance Calculator"
        '
        'lblDistanceCalc
        '
        Me.lblDistanceCalc.AutoSize = True
        Me.lblDistanceCalc.Location = New System.Drawing.Point(132, 100)
        Me.lblDistanceCalc.Name = "lblDistanceCalc"
        Me.lblDistanceCalc.Size = New System.Drawing.Size(10, 17)
        Me.lblDistanceCalc.TabIndex = 6
        Me.lblDistanceCalc.Text = "0"
        Me.lblDistanceCalc.UseCompatibleTextRendering = True
        '
        'lblDistanceTotal
        '
        Me.lblDistanceTotal.AutoSize = True
        Me.lblDistanceTotal.Location = New System.Drawing.Point(31, 100)
        Me.lblDistanceTotal.Name = "lblDistanceTotal"
        Me.lblDistanceTotal.Size = New System.Drawing.Size(76, 13)
        Me.lblDistanceTotal.TabIndex = 7
        Me.lblDistanceTotal.Text = "Total Distance"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 205)
        Me.Controls.Add(Me.lblDistanceTotal)
        Me.Controls.Add(Me.lblDistanceCalc)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cbCity2)
        Me.Controls.Add(Me.cbCity1)
        Me.Controls.Add(Me.lblCity2)
        Me.Controls.Add(Me.lblCity1)
        Me.Controls.Add(Me.cmdLookup)
        Me.Name = "frmMain"
        Me.Text = "Distance Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdLookup As System.Windows.Forms.Button
    Friend WithEvents lblCity1 As System.Windows.Forms.Label
    Friend WithEvents lblCity2 As System.Windows.Forms.Label
    Friend WithEvents cbCity1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbCity2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDistanceCalc As System.Windows.Forms.Label
    Friend WithEvents lblDistanceTotal As System.Windows.Forms.Label

End Class
