<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbltab = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.pnlShow = New System.Windows.Forms.Panel()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblCondicion = New System.Windows.Forms.Label()
        Me.gboxBtns = New System.Windows.Forms.GroupBox()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lblhora2 = New System.Windows.Forms.Label()
        Me.bynlimpiar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbtabla = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtcfecha = New System.Windows.Forms.MonthCalendar()
        Me.tmhora = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFcad = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFact = New System.Windows.Forms.Label()
        Me.tmTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudAño = New System.Windows.Forms.NumericUpDown()
        Me.pnlShow.SuspendLayout()
        Me.gboxBtns.SuspendLayout()
        CType(Me.nudAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltab
        '
        Me.lbltab.AutoSize = True
        Me.lbltab.BackColor = System.Drawing.Color.Transparent
        Me.lbltab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltab.ForeColor = System.Drawing.Color.White
        Me.lbltab.Location = New System.Drawing.Point(355, 84)
        Me.lbltab.Name = "lbltab"
        Me.lbltab.Size = New System.Drawing.Size(51, 15)
        Me.lbltab.TabIndex = 20
        Me.lbltab.Text = "Label2"
        Me.lbltab.Visible = False
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.White
        Me.lblfecha.Location = New System.Drawing.Point(355, 135)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(51, 15)
        Me.lblfecha.TabIndex = 26
        Me.lblfecha.Text = "Label2"
        Me.lblfecha.Visible = False
        '
        'pnlShow
        '
        Me.pnlShow.BackColor = System.Drawing.Color.Transparent
        Me.pnlShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlShow.Controls.Add(Me.lblhora)
        Me.pnlShow.Controls.Add(Me.lblCondicion)
        Me.pnlShow.Location = New System.Drawing.Point(18, 189)
        Me.pnlShow.Name = "pnlShow"
        Me.pnlShow.Size = New System.Drawing.Size(472, 173)
        Me.pnlShow.TabIndex = 25
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.White
        Me.lblhora.Location = New System.Drawing.Point(180, 122)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(108, 33)
        Me.lblhora.TabIndex = 13
        Me.lblhora.Text = "Label2"
        '
        'lblCondicion
        '
        Me.lblCondicion.AutoSize = True
        Me.lblCondicion.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondicion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCondicion.Location = New System.Drawing.Point(86, 30)
        Me.lblCondicion.Name = "lblCondicion"
        Me.lblCondicion.Size = New System.Drawing.Size(20, 29)
        Me.lblCondicion.TabIndex = 12
        Me.lblCondicion.Text = " "
        '
        'gboxBtns
        '
        Me.gboxBtns.BackColor = System.Drawing.Color.Transparent
        Me.gboxBtns.Controls.Add(Me.ReflectionLabel1)
        Me.gboxBtns.Controls.Add(Me.lblhora2)
        Me.gboxBtns.Controls.Add(Me.bynlimpiar)
        Me.gboxBtns.Controls.Add(Me.btnCerrar)
        Me.gboxBtns.Controls.Add(Me.btnBuscar)
        Me.gboxBtns.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gboxBtns.Location = New System.Drawing.Point(18, 368)
        Me.gboxBtns.Name = "gboxBtns"
        Me.gboxBtns.Size = New System.Drawing.Size(472, 82)
        Me.gboxBtns.TabIndex = 24
        Me.gboxBtns.TabStop = False
        Me.gboxBtns.Text = "Comandos:"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(183, 32)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(157, 43)
        Me.ReflectionLabel1.TabIndex = 14
        Me.ReflectionLabel1.Text = "<b><font size=""+8""><i>Tráfico</i><font color=""#B02B2C"">Línea3</font></font></b>"
        '
        'lblhora2
        '
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora2.Location = New System.Drawing.Point(228, 13)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(62, 15)
        Me.lblhora2.TabIndex = 13
        Me.lblhora2.Text = "lblHora2"
        '
        'bynlimpiar
        '
        Me.bynlimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bynlimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bynlimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.bynlimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.bynlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.bynlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bynlimpiar.ForeColor = System.Drawing.Color.White
        Me.bynlimpiar.Location = New System.Drawing.Point(78, 19)
        Me.bynlimpiar.Name = "bynlimpiar"
        Me.bynlimpiar.Size = New System.Drawing.Size(71, 48)
        Me.bynlimpiar.TabIndex = 12
        Me.bynlimpiar.Text = "Limpiar"
        Me.bynlimpiar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(6, 19)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(71, 48)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscar.Location = New System.Drawing.Point(364, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 48)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Consultar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cmbtabla
        '
        Me.cmbtabla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbtabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtabla.FormattingEnabled = True
        Me.cmbtabla.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16"})
        Me.cmbtabla.Location = New System.Drawing.Point(447, 21)
        Me.cmbtabla.Name = "cmbtabla"
        Me.cmbtabla.Size = New System.Drawing.Size(39, 21)
        Me.cmbtabla.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(372, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 26)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Seleccionar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         tabla:"
        '
        'mtcfecha
        '
        Me.mtcfecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtcfecha.Location = New System.Drawing.Point(18, 15)
        Me.mtcfecha.MaxSelectionCount = 1
        Me.mtcfecha.Name = "mtcfecha"
        Me.mtcfecha.TabIndex = 21
        '
        'tmhora
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Tomato
        Me.Label2.Location = New System.Drawing.Point(104, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Este producto tiene fecha de vigencia hasta el:"
        '
        'lblFcad
        '
        Me.lblFcad.AutoSize = True
        Me.lblFcad.BackColor = System.Drawing.Color.Transparent
        Me.lblFcad.ForeColor = System.Drawing.Color.Snow
        Me.lblFcad.Location = New System.Drawing.Point(335, 470)
        Me.lblFcad.Name = "lblFcad"
        Me.lblFcad.Size = New System.Drawing.Size(41, 13)
        Me.lblFcad.TabIndex = 28
        Me.lblFcad.Text = "lblFcad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(114, 497)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 26)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Para mayor información, contacte al proveedor de la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aplicación al 04169051541 / " & _
    "(0239)2120365"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblFact
        '
        Me.lblFact.AutoSize = True
        Me.lblFact.Location = New System.Drawing.Point(394, 497)
        Me.lblFact.Name = "lblFact"
        Me.lblFact.Size = New System.Drawing.Size(39, 13)
        Me.lblFact.TabIndex = 30
        Me.lblFact.Text = "Label3"
        Me.lblFact.Visible = False
        '
        'tmTiempo
        '
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMes.Location = New System.Drawing.Point(291, 21)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(77, 21)
        Me.cmbMes.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(214, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 26)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Seleccionar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           mes:"
        '
        'nudAño
        '
        Me.nudAño.Enabled = False
        Me.nudAño.Location = New System.Drawing.Point(473, 148)
        Me.nudAño.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nudAño.Minimum = New Decimal(New Integer() {1950, 0, 0, 0})
        Me.nudAño.Name = "nudAño"
        Me.nudAño.Size = New System.Drawing.Size(17, 20)
        Me.nudAño.TabIndex = 33
        Me.nudAño.Value = New Decimal(New Integer() {1950, 0, 0, 0})
        Me.nudAño.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(509, 545)
        Me.Controls.Add(Me.nudAño)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMes)
        Me.Controls.Add(Me.lblFact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFcad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltab)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.pnlShow)
        Me.Controls.Add(Me.gboxBtns)
        Me.Controls.Add(Me.cmbtabla)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtcfecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condición de las Tablas"
        Me.pnlShow.ResumeLayout(False)
        Me.pnlShow.PerformLayout()
        Me.gboxBtns.ResumeLayout(False)
        Me.gboxBtns.PerformLayout()
        CType(Me.nudAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltab As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents pnlShow As System.Windows.Forms.Panel
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lblCondicion As System.Windows.Forms.Label
    Friend WithEvents gboxBtns As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbtabla As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtcfecha As System.Windows.Forms.MonthCalendar
    Friend WithEvents tmhora As System.Windows.Forms.Timer
    Friend WithEvents bynlimpiar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFcad As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFact As System.Windows.Forms.Label
    Friend WithEvents tmTiempo As System.Windows.Forms.Timer
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudAño As System.Windows.Forms.NumericUpDown

End Class
