<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Simulacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Simulacao))
        Me.Btm_FazSimulacao = New System.Windows.Forms.Button()
        Me.Txt_Fila = New System.Windows.Forms.TextBox()
        Me.Txt_Caixas = New System.Windows.Forms.TextBox()
        Me.Lbl_Tempo = New System.Windows.Forms.Label()
        Me.Lbl_TempoMedia = New System.Windows.Forms.Label()
        Me.Lbl_TamanhoFila = New System.Windows.Forms.Label()
        Me.Grp_Estatisticas = New System.Windows.Forms.GroupBox()
        Me.Grp_Parametros = New System.Windows.Forms.GroupBox()
        Me.Txt_TempoPasso = New System.Windows.Forms.TextBox()
        Me.Lbl_TempoPasso = New System.Windows.Forms.Label()
        Me.Txt_TempoSimulacao = New System.Windows.Forms.TextBox()
        Me.Lbl_TempoSimulacao = New System.Windows.Forms.Label()
        Me.Txt_NumCaixas = New System.Windows.Forms.TextBox()
        Me.Lbl_NumCaixas = New System.Windows.Forms.Label()
        Me.Txt_NumeroClientesMaximo = New System.Windows.Forms.TextBox()
        Me.Lbl_NumClientesMaximo = New System.Windows.Forms.Label()
        Me.Txt_NumeroClientesMinimo = New System.Windows.Forms.TextBox()
        Me.Lbl_NumClientesMinimo = New System.Windows.Forms.Label()
        Me.Txt_TempoMaiorServico = New System.Windows.Forms.TextBox()
        Me.Lbl_TempoMaiorServico = New System.Windows.Forms.Label()
        Me.Txt_TempoMenorServico = New System.Windows.Forms.TextBox()
        Me.Lbl_TempoMenorServico = New System.Windows.Forms.Label()
        Me.Grp_Estatisticas.SuspendLayout()
        Me.Grp_Parametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btm_FazSimulacao
        '
        Me.Btm_FazSimulacao.Location = New System.Drawing.Point(12, 340)
        Me.Btm_FazSimulacao.Name = "Btm_FazSimulacao"
        Me.Btm_FazSimulacao.Size = New System.Drawing.Size(75, 23)
        Me.Btm_FazSimulacao.TabIndex = 0
        Me.Btm_FazSimulacao.Text = "Button1"
        Me.Btm_FazSimulacao.UseVisualStyleBackColor = True
        '
        'Txt_Fila
        '
        Me.Txt_Fila.Location = New System.Drawing.Point(781, 40)
        Me.Txt_Fila.Multiline = True
        Me.Txt_Fila.Name = "Txt_Fila"
        Me.Txt_Fila.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Fila.Size = New System.Drawing.Size(163, 382)
        Me.Txt_Fila.TabIndex = 1
        '
        'Txt_Caixas
        '
        Me.Txt_Caixas.Location = New System.Drawing.Point(497, 40)
        Me.Txt_Caixas.Multiline = True
        Me.Txt_Caixas.Name = "Txt_Caixas"
        Me.Txt_Caixas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Caixas.Size = New System.Drawing.Size(252, 187)
        Me.Txt_Caixas.TabIndex = 2
        '
        'Lbl_Tempo
        '
        Me.Lbl_Tempo.AutoSize = True
        Me.Lbl_Tempo.Location = New System.Drawing.Point(6, 24)
        Me.Lbl_Tempo.Name = "Lbl_Tempo"
        Me.Lbl_Tempo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Tempo.TabIndex = 3
        Me.Lbl_Tempo.Text = "Label1"
        '
        'Lbl_TempoMedia
        '
        Me.Lbl_TempoMedia.AutoSize = True
        Me.Lbl_TempoMedia.Location = New System.Drawing.Point(6, 48)
        Me.Lbl_TempoMedia.Name = "Lbl_TempoMedia"
        Me.Lbl_TempoMedia.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TempoMedia.TabIndex = 4
        Me.Lbl_TempoMedia.Text = "Label1"
        '
        'Lbl_TamanhoFila
        '
        Me.Lbl_TamanhoFila.AutoSize = True
        Me.Lbl_TamanhoFila.Location = New System.Drawing.Point(6, 70)
        Me.Lbl_TamanhoFila.Name = "Lbl_TamanhoFila"
        Me.Lbl_TamanhoFila.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TamanhoFila.TabIndex = 5
        Me.Lbl_TamanhoFila.Text = "Label1"
        '
        'Grp_Estatisticas
        '
        Me.Grp_Estatisticas.Controls.Add(Me.Lbl_Tempo)
        Me.Grp_Estatisticas.Controls.Add(Me.Lbl_TamanhoFila)
        Me.Grp_Estatisticas.Controls.Add(Me.Lbl_TempoMedia)
        Me.Grp_Estatisticas.Location = New System.Drawing.Point(497, 233)
        Me.Grp_Estatisticas.Name = "Grp_Estatisticas"
        Me.Grp_Estatisticas.Size = New System.Drawing.Size(252, 100)
        Me.Grp_Estatisticas.TabIndex = 6
        Me.Grp_Estatisticas.TabStop = False
        Me.Grp_Estatisticas.Text = "GroupBox1"
        '
        'Grp_Parametros
        '
        Me.Grp_Parametros.Controls.Add(Me.Txt_TempoPasso)
        Me.Grp_Parametros.Controls.Add(Me.Lbl_TempoPasso)
        Me.Grp_Parametros.Controls.Add(Me.Txt_TempoSimulacao)
        Me.Grp_Parametros.Controls.Add(Me.Lbl_TempoSimulacao)
        Me.Grp_Parametros.Controls.Add(Me.Txt_NumCaixas)
        Me.Grp_Parametros.Controls.Add(Me.Lbl_NumCaixas)
        Me.Grp_Parametros.Controls.Add(Me.Txt_NumeroClientesMaximo)
        Me.Grp_Parametros.Controls.Add(Me.Lbl_NumClientesMaximo)
        Me.Grp_Parametros.Controls.Add(Me.Txt_NumeroClientesMinimo)
        Me.Grp_Parametros.Controls.Add(Me.Lbl_NumClientesMinimo)
        Me.Grp_Parametros.Controls.Add(Me.Txt_TempoMaiorServico)
        Me.Grp_Parametros.Controls.Add(Me.Lbl_TempoMaiorServico)
        Me.Grp_Parametros.Controls.Add(Me.Txt_TempoMenorServico)
        Me.Grp_Parametros.Controls.Add(Me.Lbl_TempoMenorServico)
        Me.Grp_Parametros.Location = New System.Drawing.Point(12, 40)
        Me.Grp_Parametros.Name = "Grp_Parametros"
        Me.Grp_Parametros.Size = New System.Drawing.Size(467, 293)
        Me.Grp_Parametros.TabIndex = 7
        Me.Grp_Parametros.TabStop = False
        Me.Grp_Parametros.Text = "GroupBox1"
        '
        'Txt_TempoPasso
        '
        Me.Txt_TempoPasso.Location = New System.Drawing.Point(9, 241)
        Me.Txt_TempoPasso.Name = "Txt_TempoPasso"
        Me.Txt_TempoPasso.Size = New System.Drawing.Size(100, 20)
        Me.Txt_TempoPasso.TabIndex = 13
        '
        'Lbl_TempoPasso
        '
        Me.Lbl_TempoPasso.AutoSize = True
        Me.Lbl_TempoPasso.Location = New System.Drawing.Point(6, 225)
        Me.Lbl_TempoPasso.Name = "Lbl_TempoPasso"
        Me.Lbl_TempoPasso.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TempoPasso.TabIndex = 12
        Me.Lbl_TempoPasso.Text = "Label1"
        '
        'Txt_TempoSimulacao
        '
        Me.Txt_TempoSimulacao.Location = New System.Drawing.Point(9, 193)
        Me.Txt_TempoSimulacao.Name = "Txt_TempoSimulacao"
        Me.Txt_TempoSimulacao.Size = New System.Drawing.Size(100, 20)
        Me.Txt_TempoSimulacao.TabIndex = 11
        '
        'Lbl_TempoSimulacao
        '
        Me.Lbl_TempoSimulacao.AutoSize = True
        Me.Lbl_TempoSimulacao.Location = New System.Drawing.Point(6, 177)
        Me.Lbl_TempoSimulacao.Name = "Lbl_TempoSimulacao"
        Me.Lbl_TempoSimulacao.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TempoSimulacao.TabIndex = 10
        Me.Lbl_TempoSimulacao.Text = "Label1"
        '
        'Txt_NumCaixas
        '
        Me.Txt_NumCaixas.Location = New System.Drawing.Point(9, 142)
        Me.Txt_NumCaixas.Name = "Txt_NumCaixas"
        Me.Txt_NumCaixas.Size = New System.Drawing.Size(100, 20)
        Me.Txt_NumCaixas.TabIndex = 9
        '
        'Lbl_NumCaixas
        '
        Me.Lbl_NumCaixas.AutoSize = True
        Me.Lbl_NumCaixas.Location = New System.Drawing.Point(6, 126)
        Me.Lbl_NumCaixas.Name = "Lbl_NumCaixas"
        Me.Lbl_NumCaixas.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_NumCaixas.TabIndex = 8
        Me.Lbl_NumCaixas.Text = "Label1"
        '
        'Txt_NumeroClientesMaximo
        '
        Me.Txt_NumeroClientesMaximo.Location = New System.Drawing.Point(258, 92)
        Me.Txt_NumeroClientesMaximo.Name = "Txt_NumeroClientesMaximo"
        Me.Txt_NumeroClientesMaximo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_NumeroClientesMaximo.TabIndex = 7
        '
        'Lbl_NumClientesMaximo
        '
        Me.Lbl_NumClientesMaximo.AutoSize = True
        Me.Lbl_NumClientesMaximo.Location = New System.Drawing.Point(255, 75)
        Me.Lbl_NumClientesMaximo.Name = "Lbl_NumClientesMaximo"
        Me.Lbl_NumClientesMaximo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_NumClientesMaximo.TabIndex = 6
        Me.Lbl_NumClientesMaximo.Text = "Label1"
        '
        'Txt_NumeroClientesMinimo
        '
        Me.Txt_NumeroClientesMinimo.Location = New System.Drawing.Point(9, 92)
        Me.Txt_NumeroClientesMinimo.Name = "Txt_NumeroClientesMinimo"
        Me.Txt_NumeroClientesMinimo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_NumeroClientesMinimo.TabIndex = 5
        '
        'Lbl_NumClientesMinimo
        '
        Me.Lbl_NumClientesMinimo.AutoSize = True
        Me.Lbl_NumClientesMinimo.Location = New System.Drawing.Point(6, 75)
        Me.Lbl_NumClientesMinimo.Name = "Lbl_NumClientesMinimo"
        Me.Lbl_NumClientesMinimo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_NumClientesMinimo.TabIndex = 4
        Me.Lbl_NumClientesMinimo.Text = "Label1"
        '
        'Txt_TempoMaiorServico
        '
        Me.Txt_TempoMaiorServico.Location = New System.Drawing.Point(258, 47)
        Me.Txt_TempoMaiorServico.Name = "Txt_TempoMaiorServico"
        Me.Txt_TempoMaiorServico.Size = New System.Drawing.Size(100, 20)
        Me.Txt_TempoMaiorServico.TabIndex = 3
        '
        'Lbl_TempoMaiorServico
        '
        Me.Lbl_TempoMaiorServico.AutoSize = True
        Me.Lbl_TempoMaiorServico.Location = New System.Drawing.Point(255, 30)
        Me.Lbl_TempoMaiorServico.Name = "Lbl_TempoMaiorServico"
        Me.Lbl_TempoMaiorServico.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TempoMaiorServico.TabIndex = 2
        Me.Lbl_TempoMaiorServico.Text = "Label1"
        '
        'Txt_TempoMenorServico
        '
        Me.Txt_TempoMenorServico.Location = New System.Drawing.Point(9, 47)
        Me.Txt_TempoMenorServico.Name = "Txt_TempoMenorServico"
        Me.Txt_TempoMenorServico.Size = New System.Drawing.Size(100, 20)
        Me.Txt_TempoMenorServico.TabIndex = 1
        '
        'Lbl_TempoMenorServico
        '
        Me.Lbl_TempoMenorServico.AutoSize = True
        Me.Lbl_TempoMenorServico.Location = New System.Drawing.Point(6, 30)
        Me.Lbl_TempoMenorServico.Name = "Lbl_TempoMenorServico"
        Me.Lbl_TempoMenorServico.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TempoMenorServico.TabIndex = 0
        Me.Lbl_TempoMenorServico.Text = "Label1"
        '
        'Frm_Simulacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 450)
        Me.Controls.Add(Me.Grp_Parametros)
        Me.Controls.Add(Me.Grp_Estatisticas)
        Me.Controls.Add(Me.Txt_Caixas)
        Me.Controls.Add(Me.Txt_Fila)
        Me.Controls.Add(Me.Btm_FazSimulacao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Simulacao"
        Me.Text = "Frm_Simulacao"
        Me.Grp_Estatisticas.ResumeLayout(False)
        Me.Grp_Estatisticas.PerformLayout()
        Me.Grp_Parametros.ResumeLayout(False)
        Me.Grp_Parametros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_FazSimulacao As Button
    Friend WithEvents Txt_Fila As TextBox
    Friend WithEvents Txt_Caixas As TextBox
    Friend WithEvents Lbl_Tempo As Label
    Friend WithEvents Lbl_TempoMedia As Label
    Friend WithEvents Lbl_TamanhoFila As Label
    Friend WithEvents Grp_Estatisticas As GroupBox
    Friend WithEvents Grp_Parametros As GroupBox
    Friend WithEvents Txt_TempoMaiorServico As TextBox
    Friend WithEvents Lbl_TempoMaiorServico As Label
    Friend WithEvents Txt_TempoMenorServico As TextBox
    Friend WithEvents Lbl_TempoMenorServico As Label
    Friend WithEvents Txt_NumeroClientesMaximo As TextBox
    Friend WithEvents Lbl_NumClientesMaximo As Label
    Friend WithEvents Txt_NumeroClientesMinimo As TextBox
    Friend WithEvents Lbl_NumClientesMinimo As Label
    Friend WithEvents Txt_NumCaixas As TextBox
    Friend WithEvents Lbl_NumCaixas As Label
    Friend WithEvents Txt_TempoPasso As TextBox
    Friend WithEvents Lbl_TempoPasso As Label
    Friend WithEvents Txt_TempoSimulacao As TextBox
    Friend WithEvents Lbl_TempoSimulacao As Label
End Class
