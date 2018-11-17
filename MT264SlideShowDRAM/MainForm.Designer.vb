<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.fileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.openMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.printPreviewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.outerTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.slidePictureBox = New System.Windows.Forms.PictureBox()
        Me.slideTextBox = New System.Windows.Forms.TextBox()
        Me.innerTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.restartButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.zoomButton = New System.Windows.Forms.Button()
        Me.anOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.aFontDialog = New System.Windows.Forms.FontDialog()
        Me.aColorDialog = New System.Windows.Forms.ColorDialog()
        Me.aPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.aPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.FormateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackgroundColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainMenu.SuspendLayout()
        Me.outerTableLayoutPanel.SuspendLayout()
        CType(Me.slidePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.innerTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMenu, Me.FormateToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(508, 24)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'fileMenu
        '
        Me.fileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openMenuItem, Me.toolStripSeparator, Me.printPreviewMenuItem, Me.printMenuItem, Me.toolStripSeparator2, Me.exitMenuItem})
        Me.fileMenu.Name = "fileMenu"
        Me.fileMenu.Size = New System.Drawing.Size(35, 20)
        Me.fileMenu.Text = "&File"
        '
        'openMenuItem
        '
        Me.openMenuItem.Image = CType(resources.GetObject("openMenuItem.Image"), System.Drawing.Image)
        Me.openMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openMenuItem.Name = "openMenuItem"
        Me.openMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.openMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.openMenuItem.Text = "&Open..."
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(149, 6)
        '
        'printPreviewMenuItem
        '
        Me.printPreviewMenuItem.Image = CType(resources.GetObject("printPreviewMenuItem.Image"), System.Drawing.Image)
        Me.printPreviewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printPreviewMenuItem.Name = "printPreviewMenuItem"
        Me.printPreviewMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.printPreviewMenuItem.Text = "Print Pre&view..."
        '
        'printMenuItem
        '
        Me.printMenuItem.Image = CType(resources.GetObject("printMenuItem.Image"), System.Drawing.Image)
        Me.printMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printMenuItem.Name = "printMenuItem"
        Me.printMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.printMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.printMenuItem.Text = "&Print..."
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'exitMenuItem
        '
        Me.exitMenuItem.Name = "exitMenuItem"
        Me.exitMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.exitMenuItem.Text = "E&xit"
        '
        'outerTableLayoutPanel
        '
        Me.outerTableLayoutPanel.AutoSize = True
        Me.outerTableLayoutPanel.ColumnCount = 2
        Me.outerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.outerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.outerTableLayoutPanel.Controls.Add(Me.slidePictureBox, 0, 0)
        Me.outerTableLayoutPanel.Controls.Add(Me.slideTextBox, 0, 1)
        Me.outerTableLayoutPanel.Controls.Add(Me.innerTableLayoutPanel, 1, 0)
        Me.outerTableLayoutPanel.Controls.Add(Me.zoomButton, 1, 1)
        Me.outerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outerTableLayoutPanel.Location = New System.Drawing.Point(0, 24)
        Me.outerTableLayoutPanel.Name = "outerTableLayoutPanel"
        Me.outerTableLayoutPanel.RowCount = 4
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.03063!))
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.969365!))
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.outerTableLayoutPanel.Size = New System.Drawing.Size(508, 423)
        Me.outerTableLayoutPanel.TabIndex = 1
        '
        'slidePictureBox
        '
        Me.slidePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.slidePictureBox.Location = New System.Drawing.Point(3, 3)
        Me.slidePictureBox.MinimumSize = New System.Drawing.Size(300, 300)
        Me.slidePictureBox.Name = "slidePictureBox"
        Me.slidePictureBox.Size = New System.Drawing.Size(402, 341)
        Me.slidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.slidePictureBox.TabIndex = 4
        Me.slidePictureBox.TabStop = False
        '
        'slideTextBox
        '
        Me.slideTextBox.BackColor = System.Drawing.Color.White
        Me.slideTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.slideTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.slideTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slideTextBox.ForeColor = System.Drawing.Color.Black
        Me.slideTextBox.Location = New System.Drawing.Point(3, 350)
        Me.slideTextBox.Multiline = True
        Me.slideTextBox.Name = "slideTextBox"
        Me.slideTextBox.ReadOnly = True
        Me.slideTextBox.Size = New System.Drawing.Size(402, 47)
        Me.slideTextBox.TabIndex = 7
        Me.slideTextBox.TabStop = False
        '
        'innerTableLayoutPanel
        '
        Me.innerTableLayoutPanel.AutoSize = True
        Me.innerTableLayoutPanel.ColumnCount = 1
        Me.innerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.innerTableLayoutPanel.Controls.Add(Me.previousButton, 0, 2)
        Me.innerTableLayoutPanel.Controls.Add(Me.restartButton, 0, 0)
        Me.innerTableLayoutPanel.Controls.Add(Me.nextButton, 0, 1)
        Me.innerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.innerTableLayoutPanel.Location = New System.Drawing.Point(411, 3)
        Me.innerTableLayoutPanel.Name = "innerTableLayoutPanel"
        Me.innerTableLayoutPanel.RowCount = 3
        Me.innerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.innerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.innerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.innerTableLayoutPanel.Size = New System.Drawing.Size(94, 341)
        Me.innerTableLayoutPanel.TabIndex = 8
        '
        'previousButton
        '
        Me.previousButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previousButton.Location = New System.Drawing.Point(3, 229)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(88, 109)
        Me.previousButton.TabIndex = 0
        Me.previousButton.Text = "Previous slide"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'restartButton
        '
        Me.restartButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.restartButton.Location = New System.Drawing.Point(3, 3)
        Me.restartButton.Name = "restartButton"
        Me.restartButton.Size = New System.Drawing.Size(88, 107)
        Me.restartButton.TabIndex = 2
        Me.restartButton.Text = "First slide"
        Me.restartButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nextButton.Location = New System.Drawing.Point(3, 116)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(88, 107)
        Me.nextButton.TabIndex = 1
        Me.nextButton.Text = "Next slide"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'zoomButton
        '
        Me.zoomButton.Location = New System.Drawing.Point(410, 349)
        Me.zoomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.zoomButton.Name = "zoomButton"
        Me.zoomButton.Size = New System.Drawing.Size(94, 47)
        Me.zoomButton.TabIndex = 9
        Me.zoomButton.Text = "Zoom text"
        Me.zoomButton.UseVisualStyleBackColor = True
        '
        'anOpenFileDialog
        '
        Me.anOpenFileDialog.Filter = "Text files|*.txt"
        Me.anOpenFileDialog.Title = "Open story file"
        '
        'aPrintDialog
        '
        Me.aPrintDialog.UseEXDialog = True
        '
        'aPrintPreviewDialog
        '
        Me.aPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.aPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.aPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.aPrintPreviewDialog.Enabled = True
        Me.aPrintPreviewDialog.Icon = CType(resources.GetObject("aPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.aPrintPreviewDialog.Name = "fPrintPreviewDialog"
        Me.aPrintPreviewDialog.Visible = False
        '
        'FormateToolStripMenuItem
        '
        Me.FormateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextToolStripMenuItem})
        Me.FormateToolStripMenuItem.Name = "FormateToolStripMenuItem"
        Me.FormateToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FormateToolStripMenuItem.Text = "Format"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFontToolStripMenuItem, Me.ChangeColourToolStripMenuItem, Me.ChangeBackgroundColourToolStripMenuItem})
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TextToolStripMenuItem.Text = "Text"
        '
        'ChangeFontToolStripMenuItem
        '
        Me.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem"
        Me.ChangeFontToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ChangeFontToolStripMenuItem.Text = "Change Font"
        '
        'ChangeColourToolStripMenuItem
        '
        Me.ChangeColourToolStripMenuItem.Name = "ChangeColourToolStripMenuItem"
        Me.ChangeColourToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ChangeColourToolStripMenuItem.Text = "Change Colour"
        '
        'ChangeBackgroundColourToolStripMenuItem
        '
        Me.ChangeBackgroundColourToolStripMenuItem.Name = "ChangeBackgroundColourToolStripMenuItem"
        Me.ChangeBackgroundColourToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ChangeBackgroundColourToolStripMenuItem.Text = "Change Background Colour"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(508, 447)
        Me.Controls.Add(Me.outerTableLayoutPanel)
        Me.Controls.Add(Me.mainMenu)
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MT264 Slide Show"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.outerTableLayoutPanel.ResumeLayout(False)
        Me.outerTableLayoutPanel.PerformLayout()
        CType(Me.slidePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.innerTableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents fileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents printMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents printPreviewMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents outerTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents restartButton As System.Windows.Forms.Button
    Friend WithEvents slidePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents aPrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents aPrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents anOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents slideTextBox As System.Windows.Forms.TextBox
    Friend WithEvents innerTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents zoomButton As System.Windows.Forms.Button
    Friend WithEvents aFontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents aColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents FormateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeColourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeBackgroundColourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
