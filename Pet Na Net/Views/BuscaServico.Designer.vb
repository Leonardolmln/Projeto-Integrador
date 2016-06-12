<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaServico
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataServicoMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CPFMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoServicoCB = New System.Windows.Forms.ComboBox()
        Me.EmpresaLB = New System.Windows.Forms.Label()
        Me.NumNFRB = New System.Windows.Forms.RadioButton()
        Me.BuscarNFBT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataServicoMTF)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CPFMTF)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TipoServicoCB)
        Me.Panel1.Controls.Add(Me.EmpresaLB)
        Me.Panel1.Controls.Add(Me.NumNFRB)
        Me.Panel1.Controls.Add(Me.BuscarNFBT)
        Me.Panel1.Location = New System.Drawing.Point(12, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 164)
        Me.Panel1.TabIndex = 15
        '
        'DataServicoMTF
        '
        Me.DataServicoMTF.Location = New System.Drawing.Point(359, 47)
        Me.DataServicoMTF.Mask = "00\/00\/0000\ 00\:00"
        Me.DataServicoMTF.Name = "DataServicoMTF"
        Me.DataServicoMTF.Size = New System.Drawing.Size(96, 20)
        Me.DataServicoMTF.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Data do Serviço"
        '
        'CPFMTF
        '
        Me.CPFMTF.Location = New System.Drawing.Point(373, 11)
        Me.CPFMTF.Mask = "000\.000\.000\-00"
        Me.CPFMTF.Name = "CPFMTF"
        Me.CPFMTF.Size = New System.Drawing.Size(82, 20)
        Me.CPFMTF.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "CPF do Cliente:"
        '
        'TipoServicoCB
        '
        Me.TipoServicoCB.FormattingEnabled = True
        Me.TipoServicoCB.Location = New System.Drawing.Point(266, 82)
        Me.TipoServicoCB.Name = "TipoServicoCB"
        Me.TipoServicoCB.Size = New System.Drawing.Size(189, 21)
        Me.TipoServicoCB.TabIndex = 3
        '
        'EmpresaLB
        '
        Me.EmpresaLB.AutoSize = True
        Me.EmpresaLB.Location = New System.Drawing.Point(175, 85)
        Me.EmpresaLB.Name = "EmpresaLB"
        Me.EmpresaLB.Size = New System.Drawing.Size(85, 13)
        Me.EmpresaLB.TabIndex = 25
        Me.EmpresaLB.Text = "Tipo do Serviço:"
        '
        'NumNFRB
        '
        Me.NumNFRB.AutoSize = True
        Me.NumNFRB.Checked = True
        Me.NumNFRB.Enabled = False
        Me.NumNFRB.Location = New System.Drawing.Point(18, 60)
        Me.NumNFRB.Name = "NumNFRB"
        Me.NumNFRB.Size = New System.Drawing.Size(150, 43)
        Me.NumNFRB.TabIndex = 1
        Me.NumNFRB.TabStop = True
        Me.NumNFRB.Text = "Busca Por CPF do Cliente," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Data do Serviço e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Tipo do Serviço"
        Me.NumNFRB.UseVisualStyleBackColor = True
        '
        'BuscarNFBT
        '
        Me.BuscarNFBT.Location = New System.Drawing.Point(178, 123)
        Me.BuscarNFBT.Name = "BuscarNFBT"
        Me.BuscarNFBT.Size = New System.Drawing.Size(113, 23)
        Me.BuscarNFBT.TabIndex = 4
        Me.BuscarNFBT.Text = "Buscar Serviço"
        Me.BuscarNFBT.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(470, 71)
        Me.Panel2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar Serviço"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pet_Na_Net.My.Resources.Resources.Busca
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BuscaServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 270)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BuscaServico"
        Me.Text = "BuscaServico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TipoServicoCB As System.Windows.Forms.ComboBox
    Friend WithEvents EmpresaLB As System.Windows.Forms.Label
    Friend WithEvents NumNFRB As System.Windows.Forms.RadioButton
    Friend WithEvents BuscarNFBT As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CPFMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataServicoMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
