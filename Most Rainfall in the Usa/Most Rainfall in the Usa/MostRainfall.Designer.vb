<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostRainfall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MostRainfall))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.RainAmount = New System.Windows.Forms.ListBox()
        Me.MnuRain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRainfallAvg = New System.Windows.Forms.Label()
        Me.btnRainfall = New System.Windows.Forms.Button()
        Me.lblRainfallAmount = New System.Windows.Forms.Label()
        Me.MnuRain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblTitle.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(64, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(351, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Most Rainfall in US _ Kauai"
        '
        'RainAmount
        '
        Me.RainAmount.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RainAmount.FormattingEnabled = True
        Me.RainAmount.Location = New System.Drawing.Point(610, 30)
        Me.RainAmount.Name = "RainAmount"
        Me.RainAmount.Size = New System.Drawing.Size(75, 290)
        Me.RainAmount.TabIndex = 2
        '
        'MnuRain
        '
        Me.MnuRain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MnuRain.Location = New System.Drawing.Point(0, 0)
        Me.MnuRain.Name = "MnuRain"
        Me.MnuRain.Size = New System.Drawing.Size(800, 24)
        Me.MnuRain.TabIndex = 3
        Me.MnuRain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblRainfallAvg
        '
        Me.lblRainfallAvg.AutoSize = True
        Me.lblRainfallAvg.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblRainfallAvg.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRainfallAvg.Location = New System.Drawing.Point(212, 88)
        Me.lblRainfallAvg.Name = "lblRainfallAvg"
        Me.lblRainfallAvg.Size = New System.Drawing.Size(121, 20)
        Me.lblRainfallAvg.TabIndex = 4
        Me.lblRainfallAvg.Text = "Rainfall Average"
        '
        'btnRainfall
        '
        Me.btnRainfall.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnRainfall.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRainfall.Location = New System.Drawing.Point(195, 138)
        Me.btnRainfall.Name = "btnRainfall"
        Me.btnRainfall.Size = New System.Drawing.Size(138, 64)
        Me.btnRainfall.TabIndex = 5
        Me.btnRainfall.Text = "Enter Rainfall"
        Me.btnRainfall.UseVisualStyleBackColor = False
        '
        'lblRainfallAmount
        '
        Me.lblRainfallAmount.AutoSize = True
        Me.lblRainfallAmount.BackColor = System.Drawing.Color.SandyBrown
        Me.lblRainfallAmount.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRainfallAmount.Location = New System.Drawing.Point(107, 317)
        Me.lblRainfallAmount.Name = "lblRainfallAmount"
        Me.lblRainfallAmount.Size = New System.Drawing.Size(363, 23)
        Me.lblRainfallAmount.TabIndex = 6
        Me.lblRainfallAmount.Text = "Average Rainfall per Month is X.X inches"
        Me.lblRainfallAmount.Visible = False
        '
        'MostRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRainfallAmount)
        Me.Controls.Add(Me.btnRainfall)
        Me.Controls.Add(Me.lblRainfallAvg)
        Me.Controls.Add(Me.RainAmount)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MnuRain)
        Me.MainMenuStrip = Me.MnuRain
        Me.Name = "MostRainfall"
        Me.Text = "Most Rainfall in US"
        Me.MnuRain.ResumeLayout(False)
        Me.MnuRain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents RainAmount As ListBox
    Friend WithEvents MnuRain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblRainfallAvg As Label
    Friend WithEvents btnRainfall As Button
    Friend WithEvents lblRainfallAmount As Label
End Class
