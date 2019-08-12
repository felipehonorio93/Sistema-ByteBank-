<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ContaCorrenteDT
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ContaCorrenteDT))
        Me.Txt_CPF = New System.Windows.Forms.TextBox()
        Me.Txt_Conta = New System.Windows.Forms.TextBox()
        Me.Txt_Agencia = New System.Windows.Forms.TextBox()
        Me.Lbl_ContaCorrente = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SalvarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Cmb_CPF = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_CPF
        '
        Me.Txt_CPF.Location = New System.Drawing.Point(12, 104)
        Me.Txt_CPF.Name = "Txt_CPF"
        Me.Txt_CPF.Size = New System.Drawing.Size(190, 20)
        Me.Txt_CPF.TabIndex = 22
        '
        'Txt_Conta
        '
        Me.Txt_Conta.Location = New System.Drawing.Point(12, 78)
        Me.Txt_Conta.Name = "Txt_Conta"
        Me.Txt_Conta.Size = New System.Drawing.Size(190, 20)
        Me.Txt_Conta.TabIndex = 19
        '
        'Txt_Agencia
        '
        Me.Txt_Agencia.Location = New System.Drawing.Point(12, 52)
        Me.Txt_Agencia.Name = "Txt_Agencia"
        Me.Txt_Agencia.Size = New System.Drawing.Size(190, 20)
        Me.Txt_Agencia.TabIndex = 18
        '
        'Lbl_ContaCorrente
        '
        Me.Lbl_ContaCorrente.AutoSize = True
        Me.Lbl_ContaCorrente.Location = New System.Drawing.Point(9, 35)
        Me.Lbl_ContaCorrente.Name = "Lbl_ContaCorrente"
        Me.Lbl_ContaCorrente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ContaCorrente.TabIndex = 17
        Me.Lbl_ContaCorrente.Text = "Label1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalvarToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(219, 25)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SalvarToolStripButton
        '
        Me.SalvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalvarToolStripButton.Image = CType(resources.GetObject("SalvarToolStripButton.Image"), System.Drawing.Image)
        Me.SalvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarToolStripButton.Name = "SalvarToolStripButton"
        Me.SalvarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SalvarToolStripButton.Text = "&Salvar"
        '
        'Cmb_CPF
        '
        Me.Cmb_CPF.FormattingEnabled = True
        Me.Cmb_CPF.Location = New System.Drawing.Point(12, 130)
        Me.Cmb_CPF.Name = "Cmb_CPF"
        Me.Cmb_CPF.Size = New System.Drawing.Size(190, 21)
        Me.Cmb_CPF.TabIndex = 24
        '
        'Frm_ContaCorrenteDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 206)
        Me.Controls.Add(Me.Cmb_CPF)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Txt_CPF)
        Me.Controls.Add(Me.Txt_Conta)
        Me.Controls.Add(Me.Txt_Agencia)
        Me.Controls.Add(Me.Lbl_ContaCorrente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ContaCorrenteDT"
        Me.Text = "Frm_ContaCorrente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_CPF As TextBox
    Friend WithEvents Txt_Conta As TextBox
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents Lbl_ContaCorrente As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SalvarToolStripButton As ToolStripButton
    Friend WithEvents Cmb_CPF As ComboBox
End Class