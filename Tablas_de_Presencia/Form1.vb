Public Class Form1
    Private _año As Integer
    Private _mes As Integer
    Public Property dia As Integer
    Dim V() As String = {"Es tu 1er. día de trabajo" & Chr(13) & _
                            "         para la noche.", "Es tu 2do. día de trabajo" & Chr(13) & _
                            "         para la noche.", "Es tu 3er. día de trabajo" & Chr(13) & _
                            "         para la noche.", "Es tu 4to. día de trabajo" & Chr(13) & _
                            "         para la noche.", "Es tu 5to. día de trabajo" & Chr(13) & _
                            "         para la noche.", "       Estás de noche.", "      Es tu 1er. día libre" & Chr(13) & _
                            "           de la noche.", "      Es tu 2do. día libre" & Chr(13) & _
                            "           de la noche.", "Es tu 1er. día de trabajo" & Chr(13) & _
                            "            para los 3.", "Es tu 2do. día de trabajo" & Chr(13) & _
                            "            para los 3.", "Es tu 3er. día de trabajo" & Chr(13) & _
                            "            para los 3.", "Es tu 4to. día de trabajo" & Chr(13) & _
                            "            para los 3.", "Es tu 5to. día de trabajo" & Chr(13) & _
                            "            para los 3.", "    Es tu 1er. día libre" & Chr(13) & _
                            "            de los 3.", "    Es tu 2do. día libre" & Chr(13) & _
                            "            de los 3.", "    Es tu 3er. día libre" & Chr(13) & _
                            "            de los 3."}
    Private sDir As String = "C:\Users\vit\Videos\Emoticones\Molesto\"
    Dim fechaf As Date
    Dim Result As String
    Dim tabla As Integer
    Dim fecha As Date
    Dim N As Integer
    Dim Tab As Integer
    Dim hora As Date
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
        'If My.Settings.ProReg = False Then
        '    If My.Settings.Pro = False Then
        '        Me.tmhora.Start()
        '        Me.tmTiempo.Start()
        '        Me.lblFact.Text = DateTime.Now
        '        My.Settings.FeCa = DateTime.Now.AddSeconds(30)
        '        My.Settings.Pro = True
        '        My.Settings.Save()
        '        Me.Size = New Size(Width:=519, Height:=399)
        '        Me.gboxBtns.Location = New Point(16, 182)
        '        Me.Label2.Location = New Point(90, 293)
        '        Me.lblFcad.Location = New Point(318, 293)
        '        Me.Label4.Location = New Point(110, 320)
        '        Me.Label3.Location = New Point(214, 18)
        '        Me.cmbMes.Location = New Point(291, 21)
        '        Me.lbltab.Visible = False
        '        Me.lblfecha.Visible = False
        '        Me.pnlShow.Visible = False
        '        Me.tmhora.Start()
        '    Else
        '        Me.tmhora.Start()
        '        Me.tmTiempo.Start()
        '        Me.lblFact.Text = DateTime.Now
        '        Me.lblFcad.Text = My.Settings.FeCa
        '        Me.Size = New Size(Width:=519, Height:=399)
        '        Me.gboxBtns.Location = New Point(16, 182)
        '        Me.Label2.Location = New Point(90, 293)
        '        Me.lblFcad.Location = New Point(318, 293)
        '        Me.Label4.Location = New Point(110, 320)
        '        Me.Label3.Location = New Point(214, 18)
        '        Me.cmbMes.Location = New Point(291, 21)
        '        Me.lbltab.Visible = False
        '        Me.lblfecha.Visible = False
        '        Me.pnlShow.Visible = False
        '        Me.tmhora.Start()
        '    End If
        'Else
        Me.Size = New Size(Width:=519, Height:=310)
        Me.gboxBtns.Location = New Point(16, 182)
        Me.Label3.Location = New Point(214, 18)
        Me.cmbMes.Location = New Point(291, 21)
        Me.lbltab.Visible = False
        Me.lblfecha.Visible = False
        Me.pnlShow.Visible = False
        Me.tmhora.Start()
        'End If
        cambiarFecha(Date.Now)
    End Sub
    Public Property año As Integer
        Get
            Return _año
        End Get
        Set(value As Integer)
            If _año <> value Then
                _año = value
                If _año <> nudAño.Value Then
                    nudAño.Value = _año
                End If
            End If
            If _año <> Me.mtcfecha.SelectionStart.Year And mes > 0 And dia > 0 Then
                mtcfecha.SelectionStart = New Date(_año, _mes, dia)
            End If
        End Set
    End Property
    Public Property mes As Integer
        Get
            Return _mes
        End Get
        Set(value As Integer)
            If _mes <> value Then
                _mes = value
                If _mes <> Me.cmbMes.SelectedIndex + 1 Then
                    Me.cmbMes.SelectedIndex = _mes - 1
                End If
                If _mes <> Me.mtcfecha.SelectionStart.Month And _año > 0 And dia > 0 Then
                    mtcfecha.SelectionStart = New Date(_año, _mes, dia)
                End If
            End If
        End Set
    End Property
    Public Sub cambiarFecha(ByRef fecha As Date)
        dia = fecha.Day
        mes = fecha.Month
        año = fecha.Year
    End Sub

    Private Sub btnBustar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

        If Me.cmbtabla.Text = "" Then
            MsgBox("Debe seleccionar una Tabla!", MsgBoxStyle.Critical, "Atención")
        Else
            fechaf = Me.mtcfecha.SelectionStart
            Result = Me.lblCondicion.Text
            tabla = Me.cmbtabla.Text
            Tab = Me.cmbtabla.Text
            hora = Me.lblhora.Text
            If tabla = 1 Then
                fecha = "30/06/2017"
            ElseIf tabla = 2 Then
                fecha = "02/07/2017"
            ElseIf tabla = 3 Then
                fecha = "04/07/2017"
            ElseIf tabla = 4 Then
                fecha = "06/07/2017"
            ElseIf tabla = 5 Then
                fecha = "08/07/2017"
            ElseIf tabla = 6 Then
                fecha = "10/07/2017"
            ElseIf tabla = 7 Then
                fecha = "12/07/2017"
            ElseIf tabla = 8 Then
                fecha = "14/07/2017"
            ElseIf tabla = 9 Then
                fecha = "16/07/2017"
            ElseIf tabla = 10 Then
                fecha = "18/07/2017"
            ElseIf tabla = 11 Then
                fecha = "20/07/2017"
            ElseIf tabla = 12 Then
                fecha = "22/07/2017"
            ElseIf tabla = 13 Then
                fecha = "24/07/2017"
            ElseIf tabla = 14 Then
                fecha = "26/07/2017"
            ElseIf tabla = 15 Then
                fecha = "28/07/2017"
            ElseIf tabla = 16 Then
                fecha = "30/07/2017"
            End If
            Call Tablas()

            Me.lbltab.Text = ("Condición de" & Chr(13) & _
                                 "la Tabla: " & Me.cmbtabla.Text)
            Me.lblfecha.Text = ("Para la fecha: " & Chr(13) & _
                                Format$(fechaf, "dd/MM/yyyy"))
            If My.Settings.ProReg = False Then
                Me.lbltab.Visible = True
                Me.lblfecha.Visible = True
                Me.lblhora2.Visible = False
                Me.Label2.Location = New Point(90, 483)
                Me.lblFcad.Location = New Point(318, 483)
                Me.Label4.Location = New Point(110, 510)
                Me.Size = New Size(Width:=519, Height:=578)
                Me.gboxBtns.Location = New Point(16, 372)
                Me.Label3.Location = New Point(214, 18)
                Me.cmbMes.Location = New Point(291, 21)
                Me.lbltab.Visible = True
                Me.lblfecha.Visible = True
                Me.pnlShow.Visible = True
            Else
                Me.lbltab.Visible = True
                Me.lblfecha.Visible = True
                Me.lblhora2.Visible = False
                Me.Label2.Visible = False
                Me.lblFcad.Visible = False
                Me.Label4.Visible = False
                Me.Size = New Size(Width:=519, Height:=500)
                Me.gboxBtns.Location = New Point(16, 372)
                Me.Label3.Location = New Point(214, 18)
                Me.cmbMes.Location = New Point(291, 21)
                Me.lbltab.Visible = True
                Me.lblfecha.Visible = True
                Me.pnlShow.Visible = True
            End If

        End If
    End Sub
    Sub Tablas()
        N = DateDiff(DateInterval.Day, fecha, fechaf) Mod 16
        If N + tabla <= 15 Then
            N = (N + tabla) Mod 16
            If N < 0 Then
                N = N * (-1)
                Result = V([N])
                Me.lblCondicion.Text = Result
            Else
                Result = V([N])
                Me.lblCondicion.Text = Result
            End If
            If (N = 3) Then
            End If
        Else
            N = (N + tabla) Mod 16
            Result = V(N)
            Me.lblCondicion.Text = V([N])
        End If
    End Sub

    Public Sub ActTiempo()
        Me.lblFact.Text = DateTime.Now
        Me.lblFcad.Text = My.Settings.FeCa.ToString("dd/MM/yyyy")
    End Sub

    Private Sub tmhora_Tick(sender As System.Object, e As System.EventArgs) Handles tmhora.Tick
        Me.lblhora.Text = DateTime.Now.ToString("HH:mm:ss")
        Me.lblhora2.Text = DateTime.Now.ToString("HH:mm")
    End Sub

    Private Sub bynlimpiar_Click(sender As System.Object, e As System.EventArgs) Handles bynlimpiar.Click
        If My.Settings.ProReg = False Then
            Me.lblCondicion.Text = ""
            Me.lblfecha.Text = ""
            Me.lbltab.Text = ""
            Me.cmbtabla.SelectedIndex = -1
            Me.mtcfecha.SetDate(Now)
            Me.Size = New Size(Width:=519, Height:=399)
            Me.gboxBtns.Location = New Point(16, 182)
            Me.lblhora2.Visible = True
            Me.lbltab.Visible = False
            Me.lblfecha.Visible = False
            Me.pnlShow.Visible = False
            Me.Label2.Location = New Point(90, 293)
            Me.lblFcad.Location = New Point(318, 293)
            Me.Label4.Location = New Point(110, 320)
            Me.Label3.Location = New Point(214, 18)
            Me.cmbMes.Location = New Point(291, 21)
        Else
            Me.lblCondicion.Text = ""
            Me.lblfecha.Text = ""
            Me.lbltab.Text = ""
            Me.cmbtabla.SelectedIndex = -1
            Me.mtcfecha.SetDate(Now)
            Me.Size = New Size(Width:=519, Height:=310)
            Me.gboxBtns.Location = New Point(16, 182)
            Me.Label3.Location = New Point(214, 18)
            Me.cmbMes.Location = New Point(291, 21)
            Me.lblhora2.Visible = True
            Me.lbltab.Visible = False
            Me.lblfecha.Visible = False
            Me.pnlShow.Visible = False
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub cmbtabla_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtabla.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub tmTiempo_Tick(sender As System.Object, e As System.EventArgs) Handles tmTiempo.Tick
        ActTiempo()
        If DateTime.Now > My.Settings.FeCa Then
            Me.Hide()
            SerialReg.Show()
            Me.tmTiempo.Stop()
        End If
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        mes = Me.cmbMes.SelectedIndex + 1
    End Sub

    Private Sub mtcfecha_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles mtcfecha.DateChanged
        cambiarFecha(mtcfecha.SelectionStart)
    End Sub

    Private Sub nudAño_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudAño.ValueChanged
        año = nudAño.Value
    End Sub
End Class
