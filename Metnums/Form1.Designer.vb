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
        Me.LabelXbawah = New System.Windows.Forms.Label()
        Me.LabelXatas = New System.Windows.Forms.Label()
        Me.LabelYrendah = New System.Windows.Forms.Label()
        Me.Labelh = New System.Windows.Forms.Label()
        Me.LabelSearchX = New System.Windows.Forms.Label()
        Me.TextBoxXbawah = New System.Windows.Forms.TextBox()
        Me.TextBoxXAtas = New System.Windows.Forms.TextBox()
        Me.TextBoxy1 = New System.Windows.Forms.TextBox()
        Me.TextBoxh = New System.Windows.Forms.TextBox()
        Me.TextBoxXsearch = New System.Windows.Forms.TextBox()
        Me.ButtonHitung = New System.Windows.Forms.Button()
        Me.TextBoxNilaiPerkiraan = New System.Windows.Forms.TextBox()
        Me.LabelNilaiKira = New System.Windows.Forms.Label()
        Me.DataGridIXYF = New System.Windows.Forms.DataGridView()
        Me.ColumnI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columny = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columnfxy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridIXYF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelXbawah
        '
        Me.LabelXbawah.AutoSize = True
        Me.LabelXbawah.Location = New System.Drawing.Point(16, 235)
        Me.LabelXbawah.Name = "LabelXbawah"
        Me.LabelXbawah.Size = New System.Drawing.Size(48, 13)
        Me.LabelXbawah.TabIndex = 0
        Me.LabelXbawah.Text = "x Bawah"
        '
        'LabelXatas
        '
        Me.LabelXatas.AutoSize = True
        Me.LabelXatas.Location = New System.Drawing.Point(28, 261)
        Me.LabelXatas.Name = "LabelXatas"
        Me.LabelXatas.Size = New System.Drawing.Size(36, 13)
        Me.LabelXatas.TabIndex = 1
        Me.LabelXatas.Text = "x Atas"
        '
        'LabelYrendah
        '
        Me.LabelYrendah.AutoSize = True
        Me.LabelYrendah.Location = New System.Drawing.Point(41, 287)
        Me.LabelYrendah.Name = "LabelYrendah"
        Me.LabelYrendah.Size = New System.Drawing.Size(18, 13)
        Me.LabelYrendah.TabIndex = 2
        Me.LabelYrendah.Text = "y1"
        '
        'Labelh
        '
        Me.Labelh.AutoSize = True
        Me.Labelh.Location = New System.Drawing.Point(46, 313)
        Me.Labelh.Name = "Labelh"
        Me.Labelh.Size = New System.Drawing.Size(13, 13)
        Me.Labelh.TabIndex = 3
        Me.Labelh.Text = "h"
        '
        'LabelSearchX
        '
        Me.LabelSearchX.AutoSize = True
        Me.LabelSearchX.Location = New System.Drawing.Point(9, 339)
        Me.LabelSearchX.Name = "LabelSearchX"
        Me.LabelSearchX.Size = New System.Drawing.Size(55, 13)
        Me.LabelSearchX.TabIndex = 4
        Me.LabelSearchX.Text = "x search y"
        '
        'TextBoxXbawah
        '
        Me.TextBoxXbawah.Location = New System.Drawing.Point(70, 232)
        Me.TextBoxXbawah.Name = "TextBoxXbawah"
        Me.TextBoxXbawah.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxXbawah.TabIndex = 5
        '
        'TextBoxXAtas
        '
        Me.TextBoxXAtas.Location = New System.Drawing.Point(70, 258)
        Me.TextBoxXAtas.Name = "TextBoxXAtas"
        Me.TextBoxXAtas.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxXAtas.TabIndex = 6
        '
        'TextBoxy1
        '
        Me.TextBoxy1.Location = New System.Drawing.Point(70, 284)
        Me.TextBoxy1.Name = "TextBoxy1"
        Me.TextBoxy1.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxy1.TabIndex = 7
        '
        'TextBoxh
        '
        Me.TextBoxh.Location = New System.Drawing.Point(70, 310)
        Me.TextBoxh.Name = "TextBoxh"
        Me.TextBoxh.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxh.TabIndex = 8
        '
        'TextBoxXsearch
        '
        Me.TextBoxXsearch.Location = New System.Drawing.Point(70, 336)
        Me.TextBoxXsearch.Name = "TextBoxXsearch"
        Me.TextBoxXsearch.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxXsearch.TabIndex = 9
        '
        'ButtonHitung
        '
        Me.ButtonHitung.Location = New System.Drawing.Point(391, 334)
        Me.ButtonHitung.Name = "ButtonHitung"
        Me.ButtonHitung.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHitung.TabIndex = 10
        Me.ButtonHitung.Text = "Hitung"
        Me.ButtonHitung.UseVisualStyleBackColor = True
        '
        'TextBoxNilaiPerkiraan
        '
        Me.TextBoxNilaiPerkiraan.Location = New System.Drawing.Point(271, 232)
        Me.TextBoxNilaiPerkiraan.Name = "TextBoxNilaiPerkiraan"
        Me.TextBoxNilaiPerkiraan.Size = New System.Drawing.Size(195, 20)
        Me.TextBoxNilaiPerkiraan.TabIndex = 11
        '
        'LabelNilaiKira
        '
        Me.LabelNilaiKira.AutoSize = True
        Me.LabelNilaiKira.Location = New System.Drawing.Point(190, 235)
        Me.LabelNilaiKira.Name = "LabelNilaiKira"
        Me.LabelNilaiKira.Size = New System.Drawing.Size(75, 13)
        Me.LabelNilaiKira.TabIndex = 12
        Me.LabelNilaiKira.Text = "Nilai Perkiraan"
        '
        'DataGridIXYF
        '
        Me.DataGridIXYF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridIXYF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnI, Me.ColumnX, Me.Columny, Me.Columnfxy})
        Me.DataGridIXYF.Location = New System.Drawing.Point(12, 12)
        Me.DataGridIXYF.Name = "DataGridIXYF"
        Me.DataGridIXYF.Size = New System.Drawing.Size(454, 214)
        Me.DataGridIXYF.TabIndex = 13
        '
        'ColumnI
        '
        Me.ColumnI.HeaderText = "i"
        Me.ColumnI.Name = "ColumnI"
        '
        'ColumnX
        '
        Me.ColumnX.HeaderText = "x"
        Me.ColumnX.Name = "ColumnX"
        '
        'Columny
        '
        Me.Columny.HeaderText = "y"
        Me.Columny.Name = "Columny"
        '
        'Columnfxy
        '
        Me.Columnfxy.HeaderText = "f(x,y)"
        Me.Columnfxy.Name = "Columnfxy"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 367)
        Me.Controls.Add(Me.DataGridIXYF)
        Me.Controls.Add(Me.LabelNilaiKira)
        Me.Controls.Add(Me.TextBoxNilaiPerkiraan)
        Me.Controls.Add(Me.ButtonHitung)
        Me.Controls.Add(Me.TextBoxXsearch)
        Me.Controls.Add(Me.TextBoxh)
        Me.Controls.Add(Me.TextBoxy1)
        Me.Controls.Add(Me.TextBoxXAtas)
        Me.Controls.Add(Me.TextBoxXbawah)
        Me.Controls.Add(Me.LabelSearchX)
        Me.Controls.Add(Me.Labelh)
        Me.Controls.Add(Me.LabelYrendah)
        Me.Controls.Add(Me.LabelXatas)
        Me.Controls.Add(Me.LabelXbawah)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridIXYF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelXbawah As Label
    Friend WithEvents LabelXatas As Label
    Friend WithEvents LabelYrendah As Label
    Friend WithEvents Labelh As Label
    Friend WithEvents LabelSearchX As Label
    Friend WithEvents TextBoxXbawah As TextBox
    Friend WithEvents TextBoxXAtas As TextBox
    Friend WithEvents TextBoxy1 As TextBox
    Friend WithEvents TextBoxh As TextBox
    Friend WithEvents TextBoxXsearch As TextBox
    Friend WithEvents ButtonHitung As Button
    Friend WithEvents TextBoxNilaiPerkiraan As TextBox
    Friend WithEvents LabelNilaiKira As Label
    Friend WithEvents DataGridIXYF As DataGridView
    Friend WithEvents ColumnI As DataGridViewTextBoxColumn
    Friend WithEvents ColumnX As DataGridViewTextBoxColumn
    Friend WithEvents Columny As DataGridViewTextBoxColumn
    Friend WithEvents Columnfxy As DataGridViewTextBoxColumn
End Class
