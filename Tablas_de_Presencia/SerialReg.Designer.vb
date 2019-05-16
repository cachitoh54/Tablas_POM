<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SerialReg))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btnSerial = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(241, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "_"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "INTRODUZCA EL SERIAL DEL PRODUCTO A REGISTRAR"
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(257, 50)
        Me.txt3.MaxLength = 4
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 20)
        Me.txt3.TabIndex = 15
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(135, 50)
        Me.txt2.MaxLength = 4
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 14
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(12, 50)
        Me.txt1.MaxLength = 4
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 13
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSerial
        '
        Me.btnSerial.Location = New System.Drawing.Point(85, 101)
        Me.btnSerial.Name = "btnSerial"
        Me.btnSerial.Size = New System.Drawing.Size(209, 38)
        Me.btnSerial.TabIndex = 12
        Me.btnSerial.Text = "Registrar Producto"
        Me.btnSerial.UseVisualStyleBackColor = True
        '
        'SerialReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 156)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnSerial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SerialReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSerial As System.Windows.Forms.Button
End Class
