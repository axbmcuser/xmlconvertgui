﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filechooser
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filechooser))
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.xmlname = New System.Windows.Forms.Label()
        Me.OutputButton = New System.Windows.Forms.Button()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.OutputLog = New System.Windows.Forms.TextBox()
        Me.ConversionDropDown = New System.Windows.Forms.ComboBox()
        Me.HeaderOption = New System.Windows.Forms.CheckBox()
        Me.ConvertBorders = New System.Windows.Forms.CheckBox()
        Me.TextureCheckButton = New System.Windows.Forms.Button()
        Me.SkinFolderButton = New System.Windows.Forms.Button()
        Me.ClearLogButton = New System.Windows.Forms.Button()
        Me.CheckFontsButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.CheckIncludesButton = New System.Windows.Forms.Button()
        Me.IndentingDropDown = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.EOLComboBox = New System.Windows.Forms.ComboBox()
        Me.AnimationMultiplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBracketsButton = New System.Windows.Forms.Button()
        Me.CheckIDsButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CheckValuesButton = New System.Windows.Forms.Button()
        Me.CheckVarsButton = New System.Windows.Forms.Button()
        Me.CheckLabelsButton = New System.Windows.Forms.Button()
        Me.AutoFixCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReorderButton = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "TexturePacker.exe"
        '
        'ConvertButton
        '
        Me.ConvertButton.Enabled = False
        Me.ConvertButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConvertButton.Location = New System.Drawing.Point(46, 450)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(280, 23)
        Me.ConvertButton.TabIndex = 3
        Me.ConvertButton.Text = "Convert XML Files"
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'xmlname
        '
        Me.xmlname.AutoSize = True
        Me.xmlname.Location = New System.Drawing.Point(160, 24)
        Me.xmlname.Name = "xmlname"
        Me.xmlname.Size = New System.Drawing.Size(99, 13)
        Me.xmlname.TabIndex = 4
        Me.xmlname.Text = "Choose Skin Folder"
        '
        'OutputButton
        '
        Me.OutputButton.Enabled = False
        Me.OutputButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputButton.Location = New System.Drawing.Point(46, 412)
        Me.OutputButton.Name = "OutputButton"
        Me.OutputButton.Size = New System.Drawing.Size(104, 24)
        Me.OutputButton.TabIndex = 5
        Me.OutputButton.Text = "Choose"
        Me.OutputButton.UseVisualStyleBackColor = True
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(11, 386)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(135, 13)
        Me.OutputLabel.TabIndex = 6
        Me.OutputLabel.Text = "Choose XML Output Folder"
        Me.OutputLabel.Visible = False
        '
        'OutputLog
        '
        Me.OutputLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputLog.BackColor = System.Drawing.SystemColors.Window
        Me.OutputLog.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputLog.Location = New System.Drawing.Point(401, 24)
        Me.OutputLog.Multiline = True
        Me.OutputLog.Name = "OutputLog"
        Me.OutputLog.ReadOnly = True
        Me.OutputLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputLog.Size = New System.Drawing.Size(846, 602)
        Me.OutputLog.TabIndex = 7
        Me.OutputLog.WordWrap = False
        '
        'ConversionDropDown
        '
        Me.ConversionDropDown.BackColor = System.Drawing.SystemColors.Control
        Me.ConversionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConversionDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConversionDropDown.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ConversionDropDown.Location = New System.Drawing.Point(11, 226)
        Me.ConversionDropDown.Name = "ConversionDropDown"
        Me.ConversionDropDown.Size = New System.Drawing.Size(121, 21)
        Me.ConversionDropDown.TabIndex = 8
        '
        'HeaderOption
        '
        Me.HeaderOption.AutoSize = True
        Me.HeaderOption.Location = New System.Drawing.Point(164, 296)
        Me.HeaderOption.Name = "HeaderOption"
        Me.HeaderOption.Size = New System.Drawing.Size(108, 17)
        Me.HeaderOption.TabIndex = 9
        Me.HeaderOption.Text = "Add XML Header"
        Me.HeaderOption.UseVisualStyleBackColor = True
        '
        'ConvertBorders
        '
        Me.ConvertBorders.AutoSize = True
        Me.ConvertBorders.Location = New System.Drawing.Point(164, 319)
        Me.ConvertBorders.Name = "ConvertBorders"
        Me.ConvertBorders.Size = New System.Drawing.Size(102, 17)
        Me.ConvertBorders.TabIndex = 12
        Me.ConvertBorders.Text = "Convert Borders"
        Me.ConvertBorders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ConvertBorders.UseVisualStyleBackColor = True
        '
        'TextureCheckButton
        '
        Me.TextureCheckButton.Location = New System.Drawing.Point(46, 58)
        Me.TextureCheckButton.Name = "TextureCheckButton"
        Me.TextureCheckButton.Size = New System.Drawing.Size(104, 23)
        Me.TextureCheckButton.TabIndex = 13
        Me.TextureCheckButton.Text = "Check Textures"
        Me.TextureCheckButton.UseVisualStyleBackColor = True
        '
        'SkinFolderButton
        '
        Me.SkinFolderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkinFolderButton.Location = New System.Drawing.Point(46, 19)
        Me.SkinFolderButton.Name = "SkinFolderButton"
        Me.SkinFolderButton.Size = New System.Drawing.Size(104, 23)
        Me.SkinFolderButton.TabIndex = 14
        Me.SkinFolderButton.Text = "Choose"
        Me.SkinFolderButton.UseVisualStyleBackColor = True
        '
        'ClearLogButton
        '
        Me.ClearLogButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearLogButton.Location = New System.Drawing.Point(1176, 636)
        Me.ClearLogButton.Name = "ClearLogButton"
        Me.ClearLogButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearLogButton.TabIndex = 15
        Me.ClearLogButton.Text = "Clear Log"
        Me.ClearLogButton.UseVisualStyleBackColor = True
        '
        'CheckFontsButton
        '
        Me.CheckFontsButton.Location = New System.Drawing.Point(46, 87)
        Me.CheckFontsButton.Name = "CheckFontsButton"
        Me.CheckFontsButton.Size = New System.Drawing.Size(104, 23)
        Me.CheckFontsButton.TabIndex = 16
        Me.CheckFontsButton.Text = "Check Fonts"
        Me.CheckFontsButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Conversion Options"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 671)
        Me.Splitter1.TabIndex = 18
        Me.Splitter1.TabStop = False
        '
        'CheckIncludesButton
        '
        Me.CheckIncludesButton.Location = New System.Drawing.Point(46, 116)
        Me.CheckIncludesButton.Name = "CheckIncludesButton"
        Me.CheckIncludesButton.Size = New System.Drawing.Size(104, 23)
        Me.CheckIncludesButton.TabIndex = 19
        Me.CheckIncludesButton.Text = "Check Includes"
        Me.CheckIncludesButton.UseVisualStyleBackColor = True
        '
        'IndentingDropDown
        '
        Me.IndentingDropDown.BackColor = System.Drawing.SystemColors.Control
        Me.IndentingDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IndentingDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IndentingDropDown.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.IndentingDropDown.Location = New System.Drawing.Point(11, 270)
        Me.IndentingDropDown.Name = "IndentingDropDown"
        Me.IndentingDropDown.Size = New System.Drawing.Size(121, 21)
        Me.IndentingDropDown.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 529)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Choose TexurePacker EXE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 561)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Choose BUILD Path"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(197, 561)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Run build.bat in skin folder"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'EOLComboBox
        '
        Me.EOLComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.EOLComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EOLComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EOLComboBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.EOLComboBox.Location = New System.Drawing.Point(11, 313)
        Me.EOLComboBox.Name = "EOLComboBox"
        Me.EOLComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EOLComboBox.TabIndex = 24
        '
        'AnimationMultiplier
        '
        Me.AnimationMultiplier.Location = New System.Drawing.Point(297, 235)
        Me.AnimationMultiplier.Name = "AnimationMultiplier"
        Me.AnimationMultiplier.Size = New System.Drawing.Size(37, 20)
        Me.AnimationMultiplier.TabIndex = 25
        Me.AnimationMultiplier.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 26)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Animation Time/Delay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiplier"
        '
        'CheckBracketsButton
        '
        Me.CheckBracketsButton.Location = New System.Drawing.Point(174, 87)
        Me.CheckBracketsButton.Name = "CheckBracketsButton"
        Me.CheckBracketsButton.Size = New System.Drawing.Size(104, 23)
        Me.CheckBracketsButton.TabIndex = 27
        Me.CheckBracketsButton.Text = "Check Brackets"
        Me.CheckBracketsButton.UseVisualStyleBackColor = True
        '
        'CheckIDsButton
        '
        Me.CheckIDsButton.Location = New System.Drawing.Point(174, 116)
        Me.CheckIDsButton.Name = "CheckIDsButton"
        Me.CheckIDsButton.Size = New System.Drawing.Size(104, 23)
        Me.CheckIDsButton.TabIndex = 28
        Me.CheckIDsButton.Text = "Check IDs"
        Me.CheckIDsButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(1038, 636)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(132, 23)
        Me.SaveButton.TabIndex = 29
        Me.SaveButton.Text = "Save Settings"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CheckValuesButton
        '
        Me.CheckValuesButton.Location = New System.Drawing.Point(174, 58)
        Me.CheckValuesButton.Name = "CheckValuesButton"
        Me.CheckValuesButton.Size = New System.Drawing.Size(104, 23)
        Me.CheckValuesButton.TabIndex = 30
        Me.CheckValuesButton.Text = "Check Values"
        Me.CheckValuesButton.UseVisualStyleBackColor = True
        '
        'CheckVarsButton
        '
        Me.CheckVarsButton.Location = New System.Drawing.Point(46, 145)
        Me.CheckVarsButton.Name = "CheckVarsButton"
        Me.CheckVarsButton.Size = New System.Drawing.Size(104, 23)
        Me.CheckVarsButton.TabIndex = 31
        Me.CheckVarsButton.Text = "Check Vars"
        Me.CheckVarsButton.UseVisualStyleBackColor = True
        '
        'CheckLabelsButton
        '
        Me.CheckLabelsButton.Location = New System.Drawing.Point(174, 145)
        Me.CheckLabelsButton.Name = "CheckLabelsButton"
        Me.CheckLabelsButton.Size = New System.Drawing.Size(104, 23)
        Me.CheckLabelsButton.TabIndex = 32
        Me.CheckLabelsButton.Text = "Check Labels"
        Me.CheckLabelsButton.UseVisualStyleBackColor = True
        '
        'AutoFixCheckBox
        '
        Me.AutoFixCheckBox.AutoSize = True
        Me.AutoFixCheckBox.Location = New System.Drawing.Point(164, 209)
        Me.AutoFixCheckBox.Name = "AutoFixCheckBox"
        Me.AutoFixCheckBox.Size = New System.Drawing.Size(99, 17)
        Me.AutoFixCheckBox.TabIndex = 33
        Me.AutoFixCheckBox.Text = "Auto-Fix Values"
        Me.AutoFixCheckBox.UseVisualStyleBackColor = True
        Me.AutoFixCheckBox.Visible = False
        '
        'ReorderButton
        '
        Me.ReorderButton.AutoSize = True
        Me.ReorderButton.Location = New System.Drawing.Point(164, 273)
        Me.ReorderButton.Name = "ReorderButton"
        Me.ReorderButton.Size = New System.Drawing.Size(121, 17)
        Me.ReorderButton.TabIndex = 34
        Me.ReorderButton.Text = "Re-Order XML Tags"
        Me.ReorderButton.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 636)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1019, 23)
        Me.ProgressBar1.TabIndex = 35
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(396, 628)
        Me.TabControl1.TabIndex = 36
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SkinFolderButton)
        Me.TabPage1.Controls.Add(Me.ReorderButton)
        Me.TabPage1.Controls.Add(Me.ConvertButton)
        Me.TabPage1.Controls.Add(Me.AutoFixCheckBox)
        Me.TabPage1.Controls.Add(Me.xmlname)
        Me.TabPage1.Controls.Add(Me.CheckLabelsButton)
        Me.TabPage1.Controls.Add(Me.OutputButton)
        Me.TabPage1.Controls.Add(Me.CheckVarsButton)
        Me.TabPage1.Controls.Add(Me.OutputLabel)
        Me.TabPage1.Controls.Add(Me.CheckValuesButton)
        Me.TabPage1.Controls.Add(Me.ConversionDropDown)
        Me.TabPage1.Controls.Add(Me.HeaderOption)
        Me.TabPage1.Controls.Add(Me.CheckIDsButton)
        Me.TabPage1.Controls.Add(Me.ConvertBorders)
        Me.TabPage1.Controls.Add(Me.CheckBracketsButton)
        Me.TabPage1.Controls.Add(Me.TextureCheckButton)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CheckFontsButton)
        Me.TabPage1.Controls.Add(Me.AnimationMultiplier)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.EOLComboBox)
        Me.TabPage1.Controls.Add(Me.CheckIncludesButton)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.IndentingDropDown)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(388, 602)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TreeView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(388, 602)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Media"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Choose the media items to ignore in scan"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.SystemColors.Control
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Location = New System.Drawing.Point(0, 58)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(335, 492)
        Me.TreeView1.TabIndex = 0
        '
        'Filechooser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 671)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.ClearLogButton)
        Me.Controls.Add(Me.OutputLog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(929, 657)
        Me.Name = "Filechooser"
        Me.Text = "Kodi Skinning Tool 1.2.7 - by phil65 - QOL update by axbmcuser (2023-02)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ConvertButton As System.Windows.Forms.Button
    Friend WithEvents xmlname As System.Windows.Forms.Label
    Friend WithEvents OutputButton As System.Windows.Forms.Button
    Friend WithEvents OutputFolderDialog As FolderSelect.FolderSelectDialog
    Friend WithEvents OutputLabel As System.Windows.Forms.Label
    Friend WithEvents OutputLog As System.Windows.Forms.TextBox
    Friend WithEvents ConversionDropDown As System.Windows.Forms.ComboBox
    Friend WithEvents HeaderOption As System.Windows.Forms.CheckBox
    Friend WithEvents ConvertBorders As System.Windows.Forms.CheckBox
    Friend WithEvents TextureCheckButton As System.Windows.Forms.Button
    Friend WithEvents SkinFolderButton As System.Windows.Forms.Button
    Friend WithEvents SkinFolderDialog As FolderSelect.FolderSelectDialog
    Friend WithEvents ClearLogButton As System.Windows.Forms.Button
    Friend WithEvents CheckFontsButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents CheckIncludesButton As System.Windows.Forms.Button
    Friend WithEvents IndentingDropDown As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BuildFolderDialog As FolderSelect.FolderSelectDialog
    Friend WithEvents EOLComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AnimationMultiplier As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBracketsButton As System.Windows.Forms.Button
    Friend WithEvents CheckIDsButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CheckValuesButton As System.Windows.Forms.Button
    Friend WithEvents CheckVarsButton As System.Windows.Forms.Button
    Friend WithEvents CheckLabelsButton As System.Windows.Forms.Button
    Friend WithEvents AutoFixCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ReorderButton As System.Windows.Forms.CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
