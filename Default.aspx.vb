Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Net.Mail
Public Class _Default
    Inherits System.Web.UI.Page
    Public x As Integer
    Public connectionstring As String = ConfigurationManager.ConnectionStrings(ConfigurationManager.AppSettings("Conexion")).ToString()
    Public EmailActivo As String = ConfigurationManager.AppSettings("EmailActivo")
    Public Email As String = ConfigurationManager.AppSettings(EmailActivo)
    Public EmailPass As String = ConfigurationManager.AppSettings(EmailActivo & "Pass")
    Dim con As New SqlConnection(connectionstring)

    Protected Sub BAlogin_Click(sender As Object, e As ImageClickEventArgs) Handles BAlogin.Click
        pLoginMenu.Visible = False
        pLogin.Visible = True
    End Sub



    Protected Sub bVolverlogin_Click(sender As Object, e As ImageClickEventArgs) Handles bVolverlogin.Click

        pLoginMenu.Visible = True
        pLogin.Visible = False
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tUsuario.TextChanged

    End Sub



    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles didProvU.SelectedIndexChanged

    End Sub



    Protected Sub bRegistrase_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistrarse.Click
        pLoginMenu.Visible = False
        pRegistrase.Visible = True
    End Sub

    Protected Sub bRegistrarseUO_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistrarseUO.Click
        pLoginMenu.Visible = True
        pRegistrase.Visible = False
    End Sub


    Protected Sub bRegistraste_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistraste.Click
        pLoginMenu.Visible = False
        pRegistrase.Visible = True
    End Sub
    Private Sub Loguea()
        Dim usu As String = tUsuario.Text.Trim.ToUpper
        Dim pass As String = tClave.Text.Trim

        Dim da1 As New SqlDataAdapter("select * from " & Session("QueEs") &
    " where upper(ltrim(rtrim(usuario)))='" & usu & "' And ltrim(rtrim(password))='" & pass & "'", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "Login")

        If ds1.Tables("Login").Rows.Count = 0 Then
            lErrorlogin.Text = "El usuario o la clave son incorrectos. Revise por favor."
            lErrorlogin.Visible = True
            Exit Sub
        End If

        Select Case Session("QueEs")
            Case "Usuarios"
                Session("idUsuario") = ds1.Tables("Login").Rows(0)("idUsuario")
                Session("Usuario") = usu
                Session("Password") = pass
                Session("TipoDocumento") = ds1.Tables("Login").Rows(0)("tDoc")
                Session("Documento") = ds1.Tables("Login").Rows(0)("Doc").ToString.Trim
                Session("ApellidoYNombre") = ds1.Tables("Login").Rows(0)("Nombre").ToString.Trim & " " & ds1.Tables("Login").Rows(0)("Apellido").ToString.Trim
                Session("Email") = ds1.Tables("Login").Rows(0)("Email").ToString.Trim
                Session("idprov") = ds1.Tables("Login").Rows(0)("idprov").ToString.Trim
                Session("Localidad") = ds1.Tables("Login").Rows(0)("Localidad").ToString.Trim
                Session("Direccion") = ds1.Tables("Login").Rows(0)("Direccion").ToString.Trim
                Session("Telefonos") = ds1.Tables("Login").Rows(0)("Telefonos").ToString.Trim

                lBienvenidoAreaU.Text = "Bienvenido " & Session("ApellidoYNombre") & ", a tu Área de Usuario."
                LimpiarRegistroU()
                pLogin.Visible = False
                pAreaUsuario.Visible = True

            Case "Administrador"
                Session("idAdmin") = ds1.Tables("Login").Rows(0)("idAdmin")
                Session("Usuario") = usu
                Session("Password") = pass
                lBienvenidoAreaAdmin.Text = "Bienvenido " & Session("ApellidoYNombre") & ", a tu Área de Administrador."
                LimpiarRegistroU()
                pLogin.Visible = False
                pAreaAdmin.Visible = True
        End Select
    End Sub

    Protected Sub bRegistrarseU_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistrarse.Click

        Dim ok As Boolean = True
        LimpiarErroresRegistroU()

        tNombreU.Text = tNombreU.Text.Trim.ToUpper
        If comprobar(tNombreU.Text) = False Then
            ArreglarCampo(tNombreU)
            ok = False
            lENombreU.Text = "El nombre contenía caracteres inválidos, fueron quitados"
            lENombreU.Visible = True
        End If

        tApellidoU.Text = tApellidoU.Text.Trim.ToUpper
        If comprobar(tApellidoU.Text) = False Then
            ArreglarCampo(tApellidoU)
            ok = False
            lEApellidoU.Text = "El apellido contenía caracteres inválidos, fueron quitados"
            lEApellidoU.Visible = True
        End If

        tDocU.Text = tDocU.Text.Trim
        If comprobar(tDocU.Text) = False Or Not IsNumeric(tDocU.Text) Then
            SoloNumeros(tDocU)
            ok = False
            lEDocU.Text = "El documento ingresado es inválido, se ajustó a número"
            lEDocU.Visible = True
        End If

        ArreglarCampo(tEmailU)
        If ValidateEmail(tEmailU.Text) = False Then
            ok = False
            lEEmailU.Text = "El email  no es válido. "
            lEEmailU.Visible = True
        End If

        'AQUI

        tLocalidadU.Text = tLocalidadU.Text.Trim().ToUpper
        If comprobar(tLocalidadU.Text) = False Then
            ArreglarCampo(tLocalidadU)
            ok = False
            lELocalidadU.Text = "La localidad contenia caracteres invalidos, fueron quitados."
            lELocalidadU.Visible = True
        End If

        tDireccionU.Text = tDireccionU.Text.Trim().ToUpper
        If comprobar(tDireccionU.Text) = False Then
            ArreglarCampo(tDireccionU)
            ok = False
            lEDireccionU.Text = "La Dirección contenía caracteres inválidos, fueorn quitados"
            lEDireccionU.Visible = True
        End If
        tTelefonosU.Text = tTelefonosU.Text.Trim().ToUpper
        If comprobar(tTelefonosU.Text) = False Then
            ArreglarCampo(tTelefonosU)
            ok = False
            lETelefonosU.Text = "El teléfono contenía caracteres inválidos, fueron quitados"
            lETelefonosU.Visible = True
        End If

        'AQUI2
        Dim FechaNacimiento As Date
        controlDeNacimiento(tF_Nac, ok, lEFNac, lEdad, True, FechaNacimiento)

        tUsuarioU.Text = tUsuarioU.Text.Trim().ToUpper
        If comprobar(tUsuarioU.Text) = False Or tUsuarioU.Text.IndexOf(" ") > -1 Then
            tUsuarioU.Text = tUsuarioU.Text.Replace(" ", "")
            ArreglarCampo(tUsuarioU)
            ok = False
            lEUsuarioU.Text = "El usuario contenia caracteres inválidos, fueron quitados."
            lEUsuarioU.Visible = True
        End If
        If tUsuarioU.Text.Length < 5 Then
            ok = False
            lEUsuarioU.Text = "El usuario debe tener de 5 a 10 caracteres, letras y/o números."
            lEUsuarioU.Visible = True
        End If
        tPassU.Text = tPassU.Text.Trim()
        If comprobar(tPassU.Text) = False Or tPassU.Text.IndexOf(" ") > -1 Then
            tPassU.Text = tPassU.Text.Replace(" ", "")
            ArreglarCampo(tPassU)
            ok = False
            lEpassU.Text = "La Clave contenía caracteres inválidos. Pruebe con letras y numeros."
            lEpassU.Visible = True
        End If
        tPass2U.Text = tPass2U.Text.Trim()
        If comprobar(tPass2U.Text) = False Or tPass2U.Text.IndexOf(" ") > -1 Then
            tPass2U.Text = tPass2U.Text.Replace(" ", "")
            ArreglarCampo(tPass2U)
            ok = False
            lEPass2U.Text = "La segunda clave contenía caracteres inválidos. Pruebe con letras y numeros"
            lEPass2U.Visible = True

        End If
        If ok = False Then
            lErorresU.Text = "Revise los errores por favor y luego reintente"
            lErorresU.Visible = True
            Exit Sub
        End If
        If tPass2U.Text <> tPassU.Text Then
            ok = False
            lEPass2U.Text = "Las 2 claves son diferentes."
            lEPass2U.Visible = True

        End If


        Session("Usuario") = tUsuarioU.Text
        Session("Password") = tPassU.Text
        Session("TipoDocumento") = dTDocU.SelectedValue.Trim
        Session("Documento") = tDocU.Text.Trim
 


        If YaExisteSQL("select idusuario from usuarios where usuario='" & Session("Usuario") & "'") Then
            ok = False
            lEUsuarioU.Text = "El usuario elegido ya existe. Pruebe con otro."
            lEUsuarioU.Visible = True
        End If
        If YaExisteSQL("select idusuario from usuarios where doc='" & Session("Documento") & "'and tdoc='" & Session("TipoDocumento") & "'") Then
            ok = False
            lEDocU.Text = "Ya existe el" & Session("TipoDocumento") & " " & Session("Documento")
            lEUsuarioU.Visible = True
        End If

        If ok = False Then
            lErorresU.Text = "Solo se permite una inscripción por persona."
            lErorresU.Visible = True
            Exit Sub
        End If

        Session("Usuario") = tUsuarioU.Text.ToLower
        Session("Password") = tPassU.Text
        Session("TipoDocumento") = dTDocU.SelectedValue.Trim
        Session("Documento") = tDocU.Text.Trim
        Session("ApellidoYNombre") = tNombreU.Text.Trim & " " & tApellidoU.Text.Trim
        Session("Email") = tEmailU.Text.Trim

        LimpiarErroresRegistroU()
        LimpiarErroresRegistroU()
        Session("sqlIngreso") = "insert into Usuarios(Apellido,Nombre,tDoc, Doc, Usuario, Password, Email, idProv, Localidad, Direccion, Telefonos, fNacimiento) values ('" _
            & tApellidoU.Text.Trim & "','" & tNombreU.Text.Trim & "','" & Session("TipoDocumento") & "','" _
            & Session("Documento") & "','" & Session("Usuario") & "','" & Session("Password") & "','" _
            & Session("Email") & "','" & didProvU.SelectedValue & "','" & tLocalidadU.Text.Trim & "','" _
            & tDireccionU.Text.Trim & "','" & tTelefonosU.Text.Trim & "','" & FechaNacimiento.ToString("yyyy-MM-dd") & "')"
        Dim codigo As String = CreaCodigo(4)
        Session("codigo") = codigo
        Dim en As String = Chr(13) & Chr(10), mensaje As String = "saludos" &
            Session("apellindoynombre") & "." & en & en &
            " te escribimos desde helados UNLZ, en respuesta a tu solicitud de registro" &
            "como nuevo usuario de nuestra aplicacion." & en & en &
            "ingresar el codigo:" & codigo & " " & " que se le pide" & en & en & en & en &
            "(NO RESPONDA A ESTE MAIL, ES AUTOMATICO)" & en & en
        Dim ok2 As String = EnviarMail(Session("email"), "Registro como usuario", mensaje)
        tValidar.Text = ""
        lCodigo.Visible = False
        pRegistrase.Visible = False
        pverificamail.visible = True






    End Sub
    Sub controlDeNacimiento(ByRef xtF_nac As TextBox, ByRef ok As Boolean, ByRef xlEFNac As Label, ByRef xlEdad As Label, ByVal Valida18 As Boolean, ByRef FechaNacimiento As Date)

        ArreglarCampo(xtF_nac)

        xlEFNac.Visible = False

        If xtF_nac.Text.Length < 6 Then

            ok = False

            xlEFNac.Text &= "El campo fecha de nacimiento debe tener 6 números"

            xlEdad.Text = "0"

            xlEFNac.Visible = True

        Else

            Dim Fechax As String = xtF_nac.Text

            Dim AñoX As Integer = VNum(Fechax.Substring(4, 2))

            If AñoX + 2000 > Date.Today.Year Then AñoX += 1900 Else AñoX += 2000

            Fechax = AñoX.ToString.Trim & " -" & Fechax.Substring(2, 2) & "-" & Fechax.Substring(0, 2)

            If Not IsDate(Fechax) Then

                ok = False

                xlEFNac.Text &= "El campo fecha de nacimiento, es una fecha invalida."

                xlEdad.Text = "0"

                xlEFNac.Visible = True

            Else

                Dim dFechax As Date

                dFechax = CDate(Fechax)

                FechaNacimiento = dFechax

                If dFechax > Date.Today Then

                    ok = False

                    xlEFNac.Text &= "Nació en el futuro...."

                    xlEdad.Text = "0"

                    xlEFNac.Visible = True

                Else

                    Dim Edad As Integer = CalcularEdad(dFechax)

                    xlEdad.Text = Edad

                    If Edad < 18 And Valida18 Then

                        ok = False

                        xlEFNac.Text &= "Debe ser mayor de edad (18 años)."

                        xlEdad.Text = "0"

                        xlEFNac.Visible = True

                    End If

                End If

            End If

        End If
    End Sub






    Sub ArreglarCampo(ByRef campo As TextBox)
        campo.Text = campo.Text.Trim.Replace("'", "").Replace("""", "").Replace("*", "").Replace("+", "").Replace("-", "").Replace("/", "").Replace(":", "").Replace("´", "").Replace("<", "").Replace(">", "").Replace("=", "").Replace("&", "")
    End Sub
    Function comprobar(ByVal user As String) As Boolean
        If user Is System.DBNull.Value Then
            Return False
        Else
            Dim aux As Boolean = True
            Dim listanegra, x As String
            listanegra = "'*+-/:;´><&" & """"
            If user <> "" Then
                For Each x In user
                    If aux = True Then
                        If InStr(1, listanegra, x) > 0 Then
                            aux = False
                        Else
                            aux = True
                        End If
                    Else
                        Return False
                    End If
                Next
                If aux = True Then
                    Return True
                End If
            Else
                Return False

            End If
        End If
    End Function
    Sub LimpiarErroresCambiarDatos()
        EEmailU.Text = ""
        EEmailU.Visible = False
        ELocalidadU.Text = ""
        ELocalidadU.Visible = False
        EDireccionU.Text = ""
        EDireccionU.Visible = False
        ETelefonosU.Text = ""
        ETelefonosU.Visible = False
        ELocalidadU.Text = ""
        ELocalidadU.Visible = False
        EUsuarioU.Text = ""
        EUsuarioU.Visible = False
        EPassU.Text = ""
        EPassU.Visible = False
        lErrorU.Text = ""
        lErrorU.Visible = False
    End Sub

    Sub LimpiarErroresRegistroU()
        lErorresU.Text = ""
        lErorresU.Visible = False
        lEFNac.Text = ""
        lEFNac.Visible = False
        lENombreU.Text = ""
        lENombreU.Visible = False
        lEApellidoU.Text = ""
        lEApellidoU.Visible = False
        lEDocU.Text = ""
        lEDocU.Visible = False
        lEEmailU.Text = ""
        lEEmailU.Visible = False
        lELocalidadU.Text = ""
        lELocalidadU.Visible = False
        lEDireccionU.Text = ""
        lEDireccionU.Visible = False
        lETelefonosU.Text = ""
        lETelefonosU.Visible = False
        lEUsuarioU.Text = ""
        lEUsuarioU.Visible = False
        lEpassU.Text = ""
        lEpassU.Visible = False
        lEPass2U.Text = ""
        lEPass2U.Visible = False

    End Sub



    Sub LimpiarRegistroU()

        LimpiarErroresRegistroU()
        pRegistrase.Visible = False

        tNombreU.Text = ""
        tApellidoU.Text = ""
        dTDocU.SelectedIndex = 0
        tDocU.Text = ""
        tEmailU.Text = ""
        didProvU.SelectedIndex = 0
        tLocalidadU.Text = ""
        tDireccionU.Text = ""
        tTelefonosU.Text = ""
        tUsuarioU.Text = ""
        tPassU.Text = ""
        tPass2U.Text = ""

    End Sub
    Sub limpiarLogin()
        lErrorlogin.Text = ""
        lErrorlogin.Visible = False
        tUsuario.Text = ""
        tClave.Text = ""
        pRegistrase.Visible = False
    End Sub


    Public Function ValidateEmail(ByVal email As String) As Boolean

        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success

    End Function
    Sub SoloNumeros(ByRef campo As TextBox)
        Dim cam As String = campo.Text.Trim, salida As String = "", c As String
        For Each c In cam
            If IsNumeric(c) Then
                salida &= c
            End If
        Next
        campo.Text = salida
    End Sub
    Function VNum(ByVal NTexto As String) As Decimal
        'transforma un textyo con algo, puede ser num, punto o perro y devuelve siempre un valor decimal

        Return CDec(Val(NTexto.Trim.Replace(",", ".")))
    End Function
    Function NumSQL(ByVal numero As String) As String
        'Recibe un numero desde un textbox por ejmplo, lo verifica como numero valido,
        'y luego le cambia la como por punto para que sea valido en una sentencia de sql.

        Return CStr(VNum(numero)).Trim.Replace(",", ".")
    End Function

    Function RellenaNum(ByVal numero As Integer, ByVal cantidad As Integer) As String
        'Rellena con 0s adelante el numero. Ideal para dias y meses:
        'RellenaNum(3,2)--->"03" RellenaNum(3,4)--->"0003"
        Dim snum As String = CStr(numero).Trim
        Return "00000000000000000000".Substring(0, cantidad - snum.Length) & snum
    End Function

    Function FechaSQL(ByVal fecha As Date) As String
        'Devuelve fecha en el formato 'AAAAMMDD'
        Return "'" & RellenaNum(Year(fecha), 4) & RellenaNum(Month(fecha), 2) & RellenaNum(fecha.Day, 2) & "'"
    End Function

    Public Function AñoMes(ByVal fecha As Date) As String
        'Devuelve  'AAAA-MM'
        Return RellenaNum(Year(fecha), 4) & "-" & RellenaNum(Month(fecha), 2)
    End Function

    Public Function Vstr(ByVal cosa As Object) As String
        'Vstr – Verifica string: lo que hace es garantizar que sea un string real y válido, y no un
        'null(con la función IsDBNull), que ya vimos que es la nada de cada tipo de dato y no es lo mismo que vacio para un string
        If IsDBNull(cosa) Then Return "" Else Return CStr(cosa)
    End Function

    Function CalcularEdad(ByVal FechaNac As Date) As Integer
        Dim edad As Integer = DateTime.Today.AddTicks(-FechaNac.Ticks).Year - 1
        Return edad
    End Function
    Public Function SQL_Accion(ByVal Sql_de_accion As String) As Boolean
        'Ejecuta la consulta de accion 'sl_de_accion' abriendo la conexion automaticamente
        'Se da cuenta si es de insert, update o delete, porque mira dentro de la sentencia que se le pasa
        'devuelve true si se pudo hacer, y false si hubo algun error
        Dim adapter As New SqlDataAdapter, salida As Boolean = True

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            'con.Open()
            If Sql_de_accion.ToUpper.IndexOf("INSERT") Then
                'mSGbOX(Sql_de_accion)
                adapter.InsertCommand = New SqlCommand(Sql_de_accion, con)
                adapter.InsertCommand.ExecuteNonQuery()

            Else
                If Sql_de_accion.ToUpper.IndexOf("UPDATE") Then
                    adapter.UpdateCommand = New SqlCommand(Sql_de_accion, con)
                    adapter.UpdateCommand.ExecuteNonQuery()
                Else
                    If Sql_de_accion.ToUpper.IndexOf("DELETE") Then
                        adapter.DeleteCommand = New SqlCommand(Sql_de_accion, con)
                        adapter.DeleteCommand.ExecuteNonQuery()
                    Else
                        'esta mal la sintaxis porque no hay ni insert ni delete ni update
                        salida = False

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            salida = False
        End Try
        'con.Close()
        Return salida
    End Function
    Function LeeUnCampo(ByVal sql As String, ByVal campo As String) As Object
        'se le pasa un select de sql con un campo y devuelve el valor del campo como object. Se supone que devuelve nada o 1 registro (no más que 1)
        'por ejemplo valor=LeeUnCampo("select cosa from tabla where condi=1","cosa") valor tomará cosa. Si no encuentra nada devuelve "**NADA**". Si hay error devuelve "**ERROR**"
        Dim da1 As New SqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            da1.Fill(ds1, "datos")
            If ds1.Tables("datos").Rows.Count < 1 Then
                Return "**NADA**"
            Else
                Return ds1.Tables("datos").Rows(0)(campo)
            End If
        Catch
            Return "**ERROR**"
        End Try
    End Function

    Public Function YaExisteSQL(ByVal sql As String) As Boolean
        'se le pasa un select de sql que n teoria busca algo,
        'por ejemplo un numero de cheque, si hay registros la funcion devuelve true
        ' estilo "el cheque ya existe", si no esta, devuelve false
        Dim ar As String
        Dim da1 As New SqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "afidesc")
        If ds1.Tables("afidesc").Rows.Count < 1 Then
            Return False
        Else
            Return True

        End If
    End Function




    Protected Sub tPass2U_TextChanged(sender As Object, e As EventArgs) Handles tPass2U.TextChanged

    End Sub

    Protected Sub bAhoraQueHago_Click(sender As Object, e As ImageClickEventArgs) Handles bAhoraQueHago.Click
        pAreaUsuario.Visible = False
        pAhoraQueHago.Visible = True
    End Sub

    Protected Sub bVolverLoginU1_Click(sender As Object, e As ImageClickEventArgs) Handles bVolverLoginU1.Click
        limpiarLogin()
        LimpiarRegistroU()
        lReenviarClave.Text = ""
        pLogin.Visible = True
        pAreaUsuario.Visible = False
        tUsuario.Text = Session("Usuario")
        tClave.Text = Session("Password")


    End Sub

    Protected Sub bVolverLoginU2_Click(sender As Object, e As ImageClickEventArgs) Handles bVolverLoginU2.Click
        pAhoraQueHago.Visible = False
        pAreaUsuario.Visible = True

    End Sub

    Protected Sub bVolverAtuArea_Click(sender As Object, e As ImageClickEventArgs) Handles bVolverAtuArea.Click

    End Sub

    Protected Sub bCambiardatos_Click(sender As Object, e As ImageClickEventArgs) Handles bCambiardatos.Click
        Dim ok As Boolean = True
        LimpiarErroresCambiarDatos()
        ArreglarCampo(tEmailC)
        If ValidateEmail(tEmailC.Text) = False Then
            ok = False
            EEmailU.Text = "El email  no es válido. "
            EEmailU.Visible = True
        End If

        'AQUI

        tLocalidadC.Text = tLocalidadC.Text.Trim().ToUpper
        If comprobar(tLocalidadC.Text) = False Then
            ArreglarCampo(tLocalidadC)
            ok = False
            ELocalidadU.Text = "La localidad contenia caracteres invalidos, fueron quitados."
            ELocalidadU.Visible = True
        End If

        tDirecC.Text = tDirecC.Text.Trim().ToUpper
        If comprobar(tDirecC.Text) = False Then
            ArreglarCampo(tDirecC)
            ok = False
            EDireccionU.Text = "La Dirección contenía caracteres inválidos, fueorn quitados"
            EDireccionU.Visible = True
        End If
        tTelC.Text = tTelC.Text.Trim().ToUpper
        If comprobar(tTelC.Text) = False Then
            ArreglarCampo(tTelC)
            ok = False
            ETelefonosU.Text = "El teléfono contenía caracteres inválidos, fueron quitados"
            ETelefonosU.Visible = True
        End If

        'AQUI2

        If comprobar(tUsuarioC.Text) = False Or tUsuarioC.Text.IndexOf(" ") > -1 Then
            tUsuarioC.Text = tUsuarioC.Text.Replace(" ", "")
            ArreglarCampo(tUsuarioC)
            ok = False
            EUsuarioU.Text = "El usuario contenia caracteres inválidos, fueron quitados."
            EUsuarioU.Visible = True
        End If
        If tUsuarioC.Text.Length < 5 Then
            ok = False
            EUsuarioU.Text = "El usuario debe tener de 5 a 10 caracteres, letras y/o números."
            EUsuarioU.Visible = True
        End If
        tClaveC.Text = tClaveC.Text.Trim()
        If comprobar(tClaveC.Text) = False Or tClaveC.Text.IndexOf(" ") > -1 Then
            tClaveC.Text = tClaveC.Text.Replace(" ", "")
            ArreglarCampo(tClaveC)
            ok = False
            EPassU.Text = "La Clave contenía caracteres inválidos. Pruebe con letras y numeros."
            EPassU.Visible = True
        End If

        If ok = False Then
            lErrorU.Text = "Revise los errores por favor y luego reintente"
            lErrorU.Visible = True
            Exit Sub
        End If
        Session("Email") = tEmailC.Text.Trim
        Session("Provincia") = dProvinciaC.Text.Trim
        Session("Localidad") = tLocalidadC.Text.Trim
        Session("Telefonos") = tTelC.Text.Trim
        Session("Usuario") = tUsuarioC.Text.ToLower
        Session("Password") = tClaveC.Text
        LimpiarErroresCambiarDatos()
        Dim usuarioId As Integer = Session("idUsuario")
        If SQL_Accion("UPDATE Usuarios SET Direccion = '" & tDirecC.Text.Trim & "',  Password = '" & tClaveC.Text.Trim & "', Usuario = '" & tUsuarioC.Text.Trim & "', Localidad = '" & tLocalidadC.Text.Trim & "', idProv= '" & dProvinciaC.Text.Trim & "', Email='" & tEmailC.Text.Trim & "', Telefonos='" & tTelC.Text.Trim & "' WHERE idUsuario = " & usuarioId) = False Then
            lErrorU.Text = "Se ha producido un error al querer guardar tus datos.."
            lErrorU.Visible = True
            Exit Sub
        End If
        LimpiarErroresCambiarDatos()
        pCambiarDatos.Visible = False
        pAreaDatos.Visible = True



    End Sub
    Sub CargarCervezas()

        Dim x As Integer = 0, cosa As String
        Dim da2 As New SqlDataAdapter("select * from Web_Cervezas order by Tipos", con)
        Dim ds2 As New DataSet
        dCervezas.Items.Clear()
        da2.Fill(ds2, "dato")
        If ds2.Tables("dato").Rows.Count = 0 Then
            dCervezas.Items.Add("*** No hay cervezas disponibles en éste momento...***")
            Exit Sub
        End If
        For x = 0 To ds2.Tables("dato").Rows.Count - 1
            cosa = ds2.Tables("dato").Rows(x)("Tipos").ToString.Trim

            dCervezas.Items.Add(cosa)
        Next
        dCervezas.SelectedIndex = 0
        lCosaAgregar.Text = dCervezas.SelectedItem.ToString
        lQueEs.Text = "Cerveza"

    End Sub
    Sub CargaTemporal()
        Dim idU As Integer = VNum(Session("idUsuario"))
        Dim consulta As String = "select item,Cantidad from Web_Pedidos_Temporal where Num_Cli=" & Session("idUsuario") & " order by item"
        Dim da1 As New SqlDataAdapter(consulta, con)

        Dim ds1 As New DataSet
        da1.Fill(ds1, "histo")
        gListaPedidos.DataSource = ds1.Tables("histo")
        gListaPedidos.DataSource = ds1.Tables("histo")
        gListaPedidos.DataBind()
        If ds1.Tables("histo").Rows.Count = 0 Then
            lErrorHistorico.Text = ""
            gListaPedidos.Visible = False
            bSolicitarPedido.Visible = False
            bQuitarTodos.Visible = False
            lPedidoCreado.Visible = False
        Else
            gListaPedidos.Visible = True
            bSolicitarPedido.Visible = True
            bQuitarTodos.Visible = True
            lPedidoCreado.Visible = True
        End If

    End Sub


    Protected Sub bModificarDatos_Click(sender As Object, e As ImageClickEventArgs) Handles bModificarDatos.Click
        pAreaUsuario.Visible = False
        pCambiarDatos.Visible = True
    End Sub





    Protected Sub bPedidos_Click(sender As Object, e As ImageClickEventArgs) Handles bPedidos.Click
        Dim en As String = "</BR>"
        lInstrucciones.Text = "INSTRUCCIONES: " & en & en & "1) Elija la cervezas que desea solicitar a la fábrica." _
            & ", y se verá el elegido en 'Agregar:'." & en & "2) Indique la cantidad de unidades de cervezas." & en _
            & "3) Oprima el botón 'Agregar a la lista'. El item elegido y la cantidad se verán en la lista inferior." _
            & "Si quiere sacar algún item (lo quita completo), " _
            & "sólo presione sobre el item en la lista para seleccionarlo y oprima 'Quitar'." _
            & "Si agrega un item que ya estaba en la lista, se suman las cantidades. " & en _
            & "4) cuando haya terminado oprima 'Enviar el Pedido'." _
            & "Todos los items figurarán como 'Solicitado', y desde 'Revisar estado de los Pedidos'," _
            & "podrá ver si cambiaron a 'Despachando' o 'Enviado'." _
            & "Desde allí podrá anular los pedidos que aún estén en 'Solicitado'."
        lInstrucciones.Visible = False
        bInstrucciones.Text = "Abrir Instrucciones"

        pPedidos.Visible = False
        lCosaAgregar.Text = ""
        CargarCervezas()

        bQuitarTodos.Visible = False
        bSolicitarPedido.Visible = False
        lErrorPedido.Text = ""
        'Borro el temporal de pedidos para el cliente

        If IsNothing(Session("idUsuario")) Then
            pLogin.Visible = True
            Exit Sub

        End If
        SQL_Accion("delete Web_Pedidos_Temporal where Num_Cli=" & Session("idUsuario"))
        CargaTemporal()
        pNuevospedidos.Visible = True

    End Sub

    Protected Sub bSolicitarPedido_Click(sender As Object, e As ImageClickEventArgs) Handles bSolicitarPedido.Click
        Dim idu As Integer = VNum(Session("idUsuario"))
        Dim npedido As Integer = 0, vitem As String = "", vtipo As String = "", vCantidad As Integer = 0, cosa As String
        Dim linea As String = ""
        Dim en As String = Chr(13) & Chr(10)

        lErrorPedido.Text = ""

        If SQL_Accion("insert into web_pedidos (num_cli) values (" & Session("idUsuario") & ")") = True Then
            Dim da2 As New SqlDataAdapter("select top 1 npedido from web_pedidos where num_cli=" & Session("idUsuario") & " order by npedido desc", con)
            Dim ds2 As New DataSet
            da2.Fill(ds2, "dato")

            If ds2.Tables("dato").Rows.Count > 0 Then
                npedido = ds2.Tables("dato").Rows(0)("npedido")
                ' Obtengo el número que le asignó y lo uso para crear los detalles.
                If SQL_Accion("INSERT INTO WEB_Pedidos_detalle (item, Cantidad, nPedido) " &
                          "Select WEB_Pedidos_Temporal.Item, WEB_Pedidos_Temporal.Cantidad, " &
                          npedido & " As Npedido FROM WEB_Pedidos_Temporal where num_cli=" & idu) = True Then
                    lPedidoCreado.Text = "El pedido N° " & npedido & ", fue creado correctamente."
                    pNuevospedidos.Visible = False
                    pPedidoCreado.Visible = True
                    If SQL_Accion("delete web_pedidos_temporal where num_cli=" & idu) = False Then
                        lErrorPedido.Text = "Hubo un Error al intentar guardar el pedido. Intente más tarde."
                    End If
                Else
                    lErrorPedido.Text = "Hubo un Error al intentar guardar el detalle del pedido " &
                    npedido & ", que quedó vacío o con carga parcial. Anúlelo e intente más tarde."
                End If
            Else
                lErrorPedido.Text = "Hubo un Error al intentar guardar el detalle del pedido " &
                npedido & ", que quedó vacío o con carga parcial. Anúlelo e intente más tarde."
            End If
        Else
            lErrorPedido.Text = "Hubo un Error al intentar guardar el pedido. Intente más tarde."
        End If
    End Sub



    Protected Sub bTodoslospedidos_Click(sender As Object, e As ImageClickEventArgs) Handles bTodoslospedidos.Click
        CargaHistorico()
    End Sub

    Protected Sub bTerminarp_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminarp.Click
        pPedidos.Visible = False
        pAreaUsuario.Visible = True

    End Sub

    Protected Sub bCancelarPedido_Click(sender As Object, e As ImageClickEventArgs) Handles bCancelarPedido.Click
        If SQL_Accion("delete web_pedidos_temporal where num_cli=" & VNum(Session("idUsuario"))) = False Then
        End If
        pNuevospedidos.Visible = False
            pPedidos.Visible = True

    End Sub

    Protected Sub ImageButton3_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton33.Click
        pPedidoCreado.Visible = False
        pPedidos.Visible = True
    End Sub

    Protected Sub bTerminarHistorico_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminarHistorico.Click
        pHistorico.Visible = False
        pPedidos.Visible = True

    End Sub



    Protected Sub ImageButton4_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton4.Click
        CargaHistorico()
    End Sub

    Protected Sub ImageButton6_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton6.Click
        pVerunPedido.Visible = False
        pHistorico.Visible = True
    End Sub

    Protected Sub bVolveratuarea_Click1(sender As Object, e As ImageClickEventArgs) Handles bVolveratuarea.Click
        pAreaDatos.Visible = False
        pAreaUsuario.Visible = True
    End Sub

    Protected Sub bInstrucciones_Click(sender As Object, e As EventArgs) Handles bInstrucciones.Click
        If bInstrucciones.Text = "Abrir Instrucciones" Then
            bInstrucciones.Text = "Cerrar Instrucciones"
            lInstrucciones.Visible = True
        Else
            bInstrucciones.Text = "Abrir Instrucciones"
            lInstrucciones.Visible = False
        End If
    End Sub

    Protected Sub dCervezas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dCervezas.SelectedIndexChanged
        lCosaAgregar.Text = dCervezas.SelectedItem.ToString
        lQueEs.Text = "cervezas"
    End Sub

    Protected Sub bAgreagarALista_Click(sender As Object, e As ImageClickEventArgs) Handles bAgreagarALista.Click
        Dim x As Integer = 0, c As String, numero As Integer = 0
        Dim Cosa As String = lCosaAgregar.Text.Trim
        If Cosa = "----------" Then Exit Sub

        Dim Cantidad As Integer = VNum(tCantUni.SelectedValue.ToString)
        If Cantidad <= 0 Then Exit Sub
        lErrorPedido.Text = ""

        'veo si ya está el item en la lista
        Dim da2 As New SqlDataAdapter("select Cantidad from Web_Pedidos_Temporal where Num_Cli=" & Session("idUsuario") & " and ltrim(rtrim(item))='" & Cosa & "'", con)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "dato")

        If ds2.Tables("dato").Rows.Count > 0 Then
            'ya estaba, le leo la cantidad y reemplazo
            Cantidad += VNum(ds2.Tables("dato").Rows(0)("Cantidad"))
            If SQL_Accion("update Web_Pedidos_Temporal set Cantidad=" & Cantidad & "where Num_Cli=" & Session("idUsuario") & " and ltrim(rtrim(item))='" & Cosa & "'") = False Then
                lErrorPedido.Text = "No puedo modificar el item elegido. Intente más tarde."
                Exit Sub
            End If
        Else
            If SQL_Accion("insert into Web_Pedidos_Temporal (Num_Cli, item, Cantidad) values (" & Session("idUsuario") & ", '" & Cosa & "'," & Cantidad & ")") = False Then
                lErrorPedido.Text = "No puedo agregar el item a la lista. Intente más tarde."
                Exit Sub
            End If
        End If
        tCantUni.SelectedIndex = 0
        CargaTemporal()
    End Sub
    Protected Sub gListaPedidos_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gListaPedidos.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = gListaPedidos.Rows(index)
        Dim Item As String = row.Cells(1).Text, en As String = Chr(13) & Chr(10)
        Dim consulta As String = "delete Web_Pedidos_Temporal where ltrim(rtrim(item))='" & Item & "' and Num_Cli=" & VNum(Session("idUsuario"))

        lErrorPedido.Text = ""
        If (e.CommandName = "Quitar") Then
            If SQL_Accion(consulta) = False Then
                lErrorPedido.Text = "No puedo quitar el item de la lista. Intente más tarde"
                Exit Sub
            End If
            CargaTemporal()
        End If

    End Sub
    Sub CargaHistorico()

        lErrorHistorico.Text = ""

        Dim idu As Integer = VNum(Session("idUsuario"))

        Dim dal As New SqlDataAdapter("select Npedido, fecha, estado from web_pedidos where num_cli=" &
                                      idu & "And estado<>'Enviado' order by npedido desc", con)

        Dim ds1 As New DataSet
        dal.Fill(ds1, "histo")
        gHistorico.DataSource = ds1.Tables("histo")
        gHistorico.DataBind()

        If ds1.Tables("histo").Rows.Count = 0 Then

            lErrorHistorico.Text = "No hay pedidos anteriores o hubo un error al cargarlos. Reintente nis tarde."

            gHistorico.Visible = False

        Else

            gHistorico.Visible = True
        End If


        pPedidos.Visible = False

        pHistorico.Visible = True

    End Sub

    Protected Sub bQuitarTodos_Click(sender As Object, e As ImageClickEventArgs) Handles bQuitarTodos.Click
        If SQL_Accion("delete Web_Pedidos_Temporal where Num_Cli=" & VNum(Session("idUsuario"))) = False Then
            lErrorPedido.Text = "No puedo quitar a todos los items de la lista. Intente más tarde."
            Exit Sub
        End If
        CargaTemporal()
    End Sub

    Protected Sub gHistorico_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gHistorico.RowCommand

        Dim index As Integer = convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = gHistorico.Rows(index)

        Dim Npedido As Integer = Vnum(row.Cells(2).Text), en As String = Chr(13) & Chr(10)

        If (e.CommandName = "Ver") Then

            Label4.Text = "Detalle del Pedido N°" & Npedido

            lErrorVerUnPedido.Text = ""

            Dim dal As New SqlDataAdapter("SELECT web_pedidos_detalle.Item, " &
                                          "web_pedidos_detalle.Cantidad FROM web_pedidos_detalle INNER JOIN WEB_Cervezas ON " &
                                          "web_pedidos_detalle.Item = WEB_Cervezas.Tipos WHERE web_pedidos_detalle.NPedido =" &
                                          Npedido & "ORDER BY WEB_Cervezas.CODH", con)

            Dim ds1 As New DataSet
            dal.Fill(ds1, "histo")

            gVerUnPedido.DataSource = ds1.Tables("histo")

            gVerUnPedido.DataBind()

            If ds1.Tables("histo").Rows.Count = 0 Then

                lErrorHistorico.Text = "Hubo un error al cargar los items del pedido" &
                    Npedido & ", porque no se leyó ninguno. Reintente más tarde."

                gVerunpedido.Visible = False

            Else
                gVerunpedido.Visible = True

            End If

            pHistorico.Visible = False

            pVerUnPedido.Visible = True

        End If

        If (e.CommandName = "Anular") Then

            'tengo que mirar primero el estado del pedido
            '(pudo haber dejado abierto con Solicitado pero ya se lo enviaron)

            lErrorHistorico.Text = ""

            Dim dal As New SqlDataAdapter("select estado from web_pedidos where npedido=" & Npedido, con)

            Dim ds1 As New DataSet

            dal.Fill(ds1, "histo")

            If ds1.Tables("histo").Rows.Count = 0 Then

                lErrorHistorico.Text = "No puedo acceder al pedido " & Npedido & "Reintente nás tarde."

                Exit Sub

            Else

                Dim Estado As String = ds1.Tables("histo")(0)("estado").ToString.Trim

                If Estado <> "Solicitado" Then

                    lErrorHistorico.Text = "El pedido tiene Estados='" & Estado & "' y ya no puede cancelarse por web (sólo 'Solicitado'). Llame a la fábrica " &
                        "por favor."

                    Exit Sub

                Else

                    If Estado = "Anulado" Then

                        lErrorHistorico.Text = "El pedido N" & Npedido & ", YA estaba Anulado..."

                        Exit Sub

                    End If

                    lErrorHistorico.Text = ""

                    If SQL_Accion("update web_pedidos set estado ='Anulado' where npedido =" &
              Npedido) = False Then

                        lErrorHistorico.Text = "No he podido cambiar el estado, hubo algún" &
                            "error de conexión. Por favor, reintente más tarde o llame a la " &
                            "fábrica para avisar de la anulación."

                        Exit Sub

                    Else

                        lPedidoAnulado.Text = "El pedido nº" & Npedido & ", fue ANULADO"

                        pHistorico.Visible = False

                        pPedidoAnulado.Visible = True

                        Exit Sub

                    End If

                End If

            End If

        End If

    End Sub
    Function EnviarMail(ByVal EmailDestino As String, ByVal Subject As String, ByVal Mensaje As String) As String
        Dim Resultado As String = "OK"
        Dim SmtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        Try
            mail = New MailMessage()

            mail.From = New MailAddress(Email, "sistema.unlziiii")
            mail.To.Add(EmailDestino)
            mail.Subject = Subject
            mail.Body = Mensaje
            mail.IsBodyHtml = False
            mail.Priority = MailPriority.Normal

            If EmailActivo = "EmailGmail" Then
                SmtpServer.Credentials = New Net.NetworkCredential(Email, EmailPass)
                SmtpServer.Host = "smtp.gmail.com"
                SmtpServer.Port = 587
                SmtpServer.EnableSsl = True
            Else
                SmtpServer.Credentials = New Net.NetworkCredential(Email, EmailPass)
                SmtpServer.Host = "dtcwin033.ferroso.com"
                SmtpServer.Port = 465
                SmtpServer.EnableSsl = True
            End If

            SmtpServer.Send(mail)
        Catch
            Resultado = Err.Description

        End Try
        mail.Dispose()
        Return Resultado
    End Function


    Protected Sub ImageButton5_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton5.Click
        CargaHistorico()
        pPedidoAnulado.Visible = False
        pHistorico.Visible = True

    End Sub

    Protected Sub bRecuperarclave_Click(sender As Object, e As ImageClickEventArgs) Handles bRecuperarclave.Click
        Dim usu As String = tUsuario.Text.Trim.ToUpper, Email As String, xusuario As String, mensaje As String, pass As String

        Dim en As String = Chr(13) & Chr(10)
        If comprobar(usu) = False Then

            lReenviarClave.Text = "***El usuario es incorrecto. Revisa por favor, ***"

            lReenviarClave.Visible = True

            Exit Sub

        End If

        Dim da2 As New SqlDataAdapter("select LTRIM(RTRIM(nombre)) + ' ' + LTRIM(RTRIM(apellido)) as usuario, password," &
    "Email From usuarios Where upper(LTRIM(RTRIM(usuario)))='" & usu & "'", con)


        Dim ds2 As New DataSet
        da2.Fill(ds2, "Login")

        If ds2.Tables("Login").Rows.Count = 0 Then

            lReenviarClave.Text = "*** El usuario es incorrecta. Revisa por favor, ***"
            lReenviarClave.Visible = True

            Exit Sub

        End If

        Email = ds2.Tables("Login").Rows(0)("email").ToString.Trim.ToLower

        pass = ds2.Tables("Login").Rows(0)("password").ToString.Trim.ToLower
        xusuario = ds2.Tables("Login").Rows(0)("usuario").ToString.Trim

        mensaje = "Hola" & " " & xusuario & "." & en & en & "Le escribimos desde cervezas goldenhour , respondiendo a su pedido " &
        "de recuperación de clave." & en & en & "Su usuario es" & """" & usu & """" & en & "Su clave es " &
       """" & pass & """" & en & en & "Ya podés volver a entrar y armar tus pedidos!" & en &
        "Un gran saludo desde cervezas goldenhour!" & en & en & en & en &
        "(Por favor no respondas a este email, es automático... gracias!)" & en & en




        Dim ok As String = EnviarMail(Email, "cervezas goldenhour Clave Recuperada", mensaje)

        If ok = "OK" Then

            lReenviarClave.Text = "*** Ya te enviamos un mail con la clave! ***"

        Else
            lReenviarClave.Text = "*** Hubo un error al querer enviar el mail... ***"

        End If
        lReenviarClave.Visible = True

    End Sub
    Public Function CreaCodigo(ByVal cantCaracteres As Integer) As String
        Dim strRand As String = Nothing, r As New Random, c As String, i As Integer
        'Crea un código de tantos caracteres como cantCaracteres, mezclando números y letras mayúsculas Dim strRand As String Nothing, r As New Random, c As String, i As Integer =

        For i = 0 To cantCaracteres - 1

            If Math.Round(r.Next(0, 2)) = 0 Then
                c = Chr(Math.Round(r.Next(48, 58)))
            Else
                c = Chr(Math.Round(r.Next(65, 91)))
            End If

            strRand &= c


        Next

        Return strRand

    End Function

    Protected Sub bValidar_Click(sender As Object, e As EventArgs) Handles bValidar.Click

        pVerificamail.Visible = False

        Dim sqlIngreso As String = Session("sqlIngreso") & ""
        If sqlIngreso.Length < 10 Or sqlIngreso.IndexOf("insert") < 0 Then
            lErorresU.Text = "Hubo un error con el código. Por favor, trate de generar un nuevo código."
            lErorresU.Visible = True

            Exit Sub

        End If

        If tValidar.Text.Trim.ToUpper <> Session("Codigo") Then

            lCodigo.Visible = True
            Exit Sub

        End If

        If SQL_Accion(sqlIngreso) = False Then
            lErorresU.Text = "Hubo un error al tratar de validar al código. Por favor, " &
             "trate de generar un nuevo código."

            lErorresU.Visible = True

            Exit Sub

        End If

        Session("idUsuario") = VNum(LeeUnCampo("select top 1 idUsuario from usuarios where Usuario='" _
        & Session("Usuario") & "' and Pass = '" & Session("Password") & "'", "idusuario"))

        lBienvenidoAreaU.Text = "Bienvenido " & Session("ApellidoYNombre") & "!"

        Dim mensaje As String, xusuario As String = Session("ApellidoYNombre"),
            en As String = Chr(13) & Chr(10)

        mensaje = "Bienvenido" & xusuario & " a los Cursos de ASP .NET!." & en & en &
      "Te damos una cordial bienvenida a la comunidad ASP.NET!." & en & en _
       & "Tu usuario es " & """" & Session("Usuario") & """" & en &
       "Tu clave es " & """" & Session("Password") & """" & en & en _
       & "Ya podés loguearte para ver tus datos!!." & en & en

        LimpiarRegistroU()

        pVerificamail.Visible = False
        pAreaUsuario.Visible = True
        bRegistrarseUO.Focus()

    End Sub

    Protected Sub bRegresarRegistro_Click(sender As Object, e As EventArgs) Handles bRegresarRegistro.Click
        pVerificamail.Visible = False
        tValidar.Text = ""
        pRegistrase.Visible = True
    End Sub

    Protected Sub ImageButton7_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton7.Click
        pVerificamail.Visible = False
        tValidar.Text = ""
        pRegistrase.Visible = True
    End Sub

    Protected Sub bHacerPedido_Click(sender As Object, e As ImageClickEventArgs) Handles bHacerPedido.Click
        pAreaUsuario.Visible = False
        pPedidos.Visible = True
    End Sub

    Protected Sub bCancelaryvolver_Click(sender As Object, e As ImageClickEventArgs) Handles bCancelaryvolver.Click
        pCambiarDatos.Visible = False
        pAreaUsuario.Visible = True
    End Sub

    Protected Sub bRegistraseVolverLoginU13_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistraseVolverLoginU13.Click
        pLoginMenu.Visible = False
        pPortada.Visible = True
    End Sub



    Protected Sub bPortada_Click(sender As Object, e As ImageClickEventArgs) Handles bPortada.Click
        pPortada.Visible = False
        pLoginMenu.Visible = True
    End Sub



    Protected Sub bModificarproduc_Click(sender As Object, e As EventArgs) Handles bModificarproduc.Click
        pAreaAdmin.Visible = False
        pModificarproductos.Visible = True
        CargarCervezas2()
    End Sub




    Sub CargarCervezas2()
        Dim x As Integer = 0, cosa As String
        Dim da2 As New SqlDataAdapter("select * from Web_Cervezas order by Tipos", con)
        Dim ds2 As New DataSet
        dProductos.Items.Clear()
        da2.Fill(ds2, "dato")
        If ds2.Tables("dato").Rows.Count = 0 Then
            dProductos.Items.Add("*** No hay cervezas disponibles en este momento... ***")
            Exit Sub
        End If
        For x = 0 To ds2.Tables("dato").Rows.Count - 1
            cosa = ds2.Tables("dato").Rows(x)("Tipos").ToString.Trim

            dProductos.Items.Add(cosa)
        Next
        dProductos.SelectedIndex = 0
        lCosaAgregar.Text = dProductos.SelectedItem.ToString
        lQueEs.Text = "Tipos"
    End Sub

    Protected Sub dProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dProductos.SelectedIndexChanged
        Dim mode As String = dProductos.SelectedValue.Trim.ToUpper

        Dim da1 As New SqlDataAdapter("select * from Web_Cervezas where upper(ltrim(rtrim(Tipos))) ='" & mode & "'", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "dato")
        Session("CodH") = ds1.Tables("dato").Rows(0)("CodH")
        Session("Tipos") = ds1.Tables("dato").Rows(0)("Tipos")
        Session("precio") = ds1.Tables("dato").Rows(0)("Precio")
        Session("stock") = ds1.Tables("dato").Rows(0)("Stock")


        tNombreMod.Text = Session("Tipos")
        tPrecioMod.Text = Session("precio")
        pStockMod.Text = Session("stock")


    End Sub

    Protected Sub bModificarpro_Click(sender As Object, e As EventArgs) Handles bModificarpro.Click
        Dim productoID As Integer = Session("CodH")



        If SQL_Accion("UPDATE Web_Cervezas SET Tipos = '" & tNombreMod.Text.Trim & "',  precio = '" & tPrecioMod.Text.Trim & "', stock = '" & pStockMod.Text.Trim & "' WHERE CodH = " & productoID) Then
            tNombreMod.Text = ""
            tPrecioMod.Text = ""
            pStockMod.Text = ""

            Label10.Text = "Se modifico el producto con exito."
            Label10.Visible = True

        End If

    End Sub
    Protected Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim mode As String = dProductos.SelectedValue.Trim.ToUpper

        SQL_Accion("DELETE FROM Web_Cervezas where upper(ltrim(rtrim(Tipos))) ='" & mode & "'")
        CargarCervezas2()
        tNombreMod.Text = ""
        tPrecioMod.Text = ""
        pStockMod.Text = ""

        Label10.Text = "Se eliminó el producto con éxito."
        Label10.Visible = True
    End Sub


    Protected Sub bCancelarvolverAdmin_Click(sender As Object, e As EventArgs) Handles bCancelarvolverAdmin.Click
        pAreaAdmin.Visible = True
        pModificarproductos.Visible = False
        tNombreMod.Text = ""
        tPrecioMod.Text = ""
        pStockMod.Text = ""

    End Sub

    Protected Sub bAgregarprod_Click(sender As Object, e As ImageClickEventArgs) Handles bAgregarprod.Click


        Dim ok As Boolean = True
        LimpiarErroresRegistroP()
        tNombreProd.Text = tNombreProd.Text.Trim()
        If comprobar(tNombreProd.Text) = False Then
            ArreglarCampo(tNombreProd)
            ok = False
            lErrorNomProd.Text = "el nombre contenia caracteres invalidos, fueron quitados."
            lErrorNomProd.Visible = True
        End If

        tStock.Text = tStock.Text.Trim()
        If comprobar(tStock.Text) = False Then
            ArreglarCampo(tStock)
            ok = False
            lErrorStockProd.Text = "el stock contenía caracteres inválidos, fueorn quitados"
            lErrorStockProd.Visible = True
        End If
        tPrecio.Text = tPrecio.Text.Trim()
        If comprobar(tPrecio.Text) = False Then
            ArreglarCampo(tPrecio)
            ok = False
            lErrorPreProd.Text = "el precio contenía caracteres inválidos, fueron quitados"
            lErrorPreProd.Visible = True
        End If
        If ok = False Then
            lErrorPro.Text = "Revise los errores por favor y luego reintente"
            lErrorPro.Visible = True
            Exit Sub
        End If





        Session("Tipos") = tNombreProd.Text.Trim
        Session("stock") = tStock.Text.Trim
        Session("precio") = tPrecio.Text.Trim



        LimpiarErroresRegistroP()
        SQL_Accion("INSERT into Web_Cervezas (Tipos,precio,stock) values('" & tNombreProd.Text.Trim & "','" & tPrecio.Text.Trim & "','" & tStock.Text.Trim & "')")
        LimpiarCamposProducto()
        pAgregarProductos.Visible = False
        pAreaAdmin.Visible = True
    End Sub
    Sub LimpiarErroresRegistroP()
        lErrorNomProd.Text = ""
        lErrorNomProd.Visible = False
        lErrorStockProd.Text = ""
        lErrorStockProd.Visible = False
        lErrorPreProd.Text = ""
        lErrorPreProd.Visible = False
    End Sub
    Private Sub LimpiarCamposProducto()

        tNombreProd.Text = ""
        tPrecio.Text = ""
        tStock.Text = ""
    End Sub

    Protected Sub tCantUni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tCantUni.SelectedIndexChanged

    End Sub

    Protected Sub bAgregarProducto_Click(sender As Object, e As ImageClickEventArgs) Handles bAgregarProducto.Click
        pAreaAdmin.Visible = False
        pAgregarProductos.Visible = True
    End Sub

    Protected Sub bVolverAreaAdmin_Click(sender As Object, e As ImageClickEventArgs) Handles bVolverAreaAdmin.Click
        pAgregarProductos.Visible = False
        pAreaAdmin.Visible = True
    End Sub
    Protected Sub bEditarUsuarios_Click(sender As Object, e As EventArgs) Handles terminarvolveradmin1.Click
        pAreaAdmin.Visible = False
        pEditarUsuario.Visible = True
        CargarUsuario1()
    End Sub
    Sub CargarUsuario1()
        Dim x As Integer = 0, cosa As String
        Dim da2 As New SqlDataAdapter("select * from Usuarios order by Apellido", con)
        Dim ds2 As New DataSet
        dUsuario.Items.Clear()
        da2.Fill(ds2, "dato")
        If ds2.Tables("dato").Rows.Count = 0 Then
            dUsuario.Items.Add("*** No hay usuarios disponibles en este momento ***")
            Exit Sub
        End If
        For x = 0 To ds2.Tables("dato").Rows.Count - 1
            cosa = ds2.Tables("dato").Rows(x)("Apellido").ToString.Trim

            dUsuario.Items.Add(cosa)
        Next
        dUsuario.SelectedIndex = 0
        lCosaAgregar.Text = dUsuario.SelectedItem.ToString
        lQueEs.Text = "Usuarios"
    End Sub
    Protected Sub dUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dUsuario.SelectedIndexChanged
        Dim ape As String = dUsuario.SelectedValue.Trim.ToUpper

        Dim da1 As New SqlDataAdapter("select * from Usuarios where upper(ltrim(rtrim(Apellido))) ='" & ape & "'", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "dato")
        Session("idUsuario") = ds1.Tables("dato").Rows(0)("idUsuario")
        Session("Nombre") = ds1.Tables("dato").Rows(0)("Nombre")
        Session("Apellido") = ds1.Tables("dato").Rows(0)("Apellido")
        Session("Doc") = ds1.Tables("dato").Rows(0)("Doc")
        Session("Activo") = ds1.Tables("dato").Rows(0)("Activo")

        tNombreEdit.Text = Session("Nombre")
        tApellidoEdit.Text = Session("Apellido")
        tDniEdit.Text = Session("Doc")
        tActivoedit.Text = Session("Activo")

    End Sub



    Protected Sub bBloquear_Click(sender As Object, e As EventArgs) Handles bBloquear.Click

        SQL_Accion("update Usuarios set activo = 'NO' where Doc='" & tDniEdit.Text.Trim & "'")

        Dim ape As String = dUsuario.SelectedValue.Trim.ToUpper
        Dim da1 As New SqlDataAdapter("select * from Usuarios where upper(ltrim(rtrim(Apellido))) ='" & ape & "'", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "dato")
        Session("Activo") = ds1.Tables("dato").Rows(0)("Activo")
        tActivoedit.Text = Session("Activo")

        Dim usu As String = tDniEdit.Text.Trim.ToUpper, email As String, xusuario As String, mensaje As String, pass As String
        Dim en As String = Chr(13) & Chr(10)



        Dim da2 As New SqlDataAdapter("select ltrim(rtrim(Nombre)) + ' ' + ltrim(rtrim(Apellido)) as Usuario,Password," & " Email from Usuarios where upper(ltrim(rtrim(Doc)))='" & usu & "'", con)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "Login")

        email = ds2.Tables("login").Rows(0)("Email").ToString.Trim.ToLower
        pass = ds2.Tables("Login").Rows(0)("Password").ToString.Trim.ToLower
        xusuario = ds2.Tables("Login").Rows(0)("Usuario").ToString.Trim

        mensaje = "Hola usuario" & xusuario & "." & en & en & "Le escribimos desde Cerveceria Goldenhour." & en & en & "Le informamos que su usario ha sido bloqueado" & en & en & "hasta luego" & en & en & en & en & en

        Dim ok As String = EnviarMail(email, "Cerveceria Goldenhour - Usuario Bloqueado", mensaje)


    End Sub

    Protected Sub bDesbloquear_Click(sender As Object, e As EventArgs) Handles bDesbloquear.Click
        Dim ape As String = dUsuario.SelectedValue.Trim.ToUpper
        SQL_Accion("update Usuarios set activo = 'SI' where Doc='" & tDniEdit.Text.Trim & "'")
        Dim da1 As New SqlDataAdapter("select * from Usuarios where upper(ltrim(rtrim(Apellido))) ='" & ape & "'", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "dato")
        Session("Activo") = ds1.Tables("dato").Rows(0)("Activo")
        tActivoedit.Text = Session("Activo")
    End Sub

    Protected Sub bEliminarEdit_Click(sender As Object, e As EventArgs) Handles bEliminarEdit.Click

        Dim doc As String = tDniEdit.Text.Trim.ToUpper, email As String, xusuario As String, mensaje As String, pass As String

        Dim en As String = Chr(13) & Chr(10)

        Dim da2 As New SqlDataAdapter("select ltrim(rtrim(Nombre)) + ' ' + ltrim(rtrim(Apellido)) as Usuario,Password," & " Email from Usuarios where upper(ltrim(rtrim(Doc)))='" & doc & "'", con)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "Login")

        email = ds2.Tables("login").Rows(0)("Email").ToString.Trim.ToLower
        pass = ds2.Tables("Login").Rows(0)("Password").ToString.Trim.ToLower
        xusuario = ds2.Tables("Login").Rows(0)("Usuario").ToString.Trim

        mensaje = "Hola usuario " & xusuario & "." & en & en & "Le escribimos desde Cerveceria Goldenhour." & en & en & "Le informamos que su usario ha sido eliminado." & en & en & en & "hasta luego" & en & en & en & en & en

        Dim ok As String = EnviarMail(email, "Cerveceria Goldenhour - Usuario eliminado -", mensaje)



        SQL_Accion("DELETE FROM Usuarios where upper(ltrim(rtrim(Doc))) ='" & doc & "'")
        CargarUsuario1()
        tNombreEdit.Text = ""
        tApellidoEdit.Text = ""
        tDniEdit.Text = ""
        tActivoedit.Text = ""
        Label11.Text = "Se eliminó el usuario con éxito."
        Label11.Visible = True
    End Sub



    Protected Sub pEditarUsuarios_Click(sender As Object, e As ImageClickEventArgs) Handles bEditarUsuarios.Click
        pAreaAdmin.Visible = False
        pLogin.Visible = True
    End Sub
   

    Sub cargarPedidos1()
        Dim idU As Integer = (Session("idUsuario"))
        Dim da1 As New SqlDataAdapter("select Npedido, NUM_CLI, Fecha, Estado  from WEB_Pedidos order by NPedido asc", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "histo")
        gVerPedidosTotales.DataSource = ds1.Tables("histo")
        gVerPedidosTotales.DataBind()
    End Sub

    Protected Sub gVerPedidosTotales_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gVerPedidosTotales.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = gVerPedidosTotales.Rows(index)
        Dim Npedido As Integer = VNum(row.Cells(2).Text), en As String = Chr(13) & Chr(10)
        Dim Item As String = row.Cells(1).Text, enter As String = Chr(13) & Chr(10)
        Dim email As String, mensaje As String



        If (e.CommandName = "Anular") Then

            lErrorVerPedidoadmin.Text = ""
            Dim da1 As New SqlDataAdapter("select estado from WEB_Pedidos where NPedido= " & Npedido, con)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")
            If ds1.Tables("histo").Rows.Count = 0 Then
                lErrorHistorico.Text = "No puedo acceder al pedido Nº " & Npedido & ". Reintente mas tarde. "
                Exit Sub
            Else
                Dim Estado As String = ds1.Tables("histo")(0)("Estado").ToString.Trim
                If Estado <> "Solicitado" Then
                    lErrorHistorico.Text = "El pedido tiene Estado='" & Estado & "' y ya no puede cancelarse por web (solo 'solicitado'). Llame a la fábrica " & "por favor."
                    Exit Sub
                Else
                    If Estado = "Anulado" Then
                        lErrorHistorico.Text = "El pedido Nª " & Npedido & " , Ya estaba Anulado... "
                        Exit Sub
                    End If
                    lErrorHistorico.Text = ""
                    If SQL_Accion("update WEB_Pedidos set Estado = 'ANULADO' where NPedido=" & Npedido) = False Then
                        lErrorVerPedidoadmin.Text = "No he podido cambiar el estado, hubo algún " & "error de conexión. Por favor, reintente mas tarde o comuniquese" & " con administracion para avisar de la anulación. "
                        Exit Sub
                    Else
                        lPedidoAnulado1.Text = " El pedido Nª " & Npedido & " , fue ANULADO "
                        pVerPedidoadmin.Visible = False
                        pPedidoAnulado.Visible = True
                        ImageButton12.Visible = True
                        bTerminarYVolverPedidoAnulado.Visible = False


                        Exit Sub
                    End If
                End If
            End If
        End If
        If (e.CommandName = "Editar") Then
            Label105.Text = Npedido
            cargarPedidos1()
            lErrorVerPedidoadmin.Text = ""
            Dim da1 As New SqlDataAdapter("SELECT WEB_Pedidos_Detalle.Item, " & "WEB_Pedidos_Detalle.cantidad, " & "WEB_Pedidos_Detalle.NPedido FROM WEB_Pedidos_Detalle INNER JOIN Web_Cervezas ON " & "WEB_Pedidos_Detalle.Item = Web_Cervezas.Tipos WHERE WEB_Pedidos_Detalle.NPedido=" & Npedido & " ORDER BY Web_Cervezas.CodH", con)

            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")
            gVerUnPedidoEditar.DataSource = ds1.Tables("histo")
            gVerUnPedidoEditar.DataBind()
            If ds1.Tables("histo").Rows.Count = 0 Then
                lErrorVerPedidoadmin.Text = "Hubo un error al cargar los items del pedido " & Npedido & ", porque no se leyo ninguno. Intente mas tarde."
                gVerUnPedidoEditar.Visible = False
            Else
                gVerUnPedidoEditar.Visible = True
            End If
            pVerPedidosUsuarios.Visible = False
            pEditarPedidos.Visible = True

        End If
        If (e.CommandName = "PasarEnviado") Then
            Dim da2 As New SqlDataAdapter("select Usuarios.Email from Usuarios INNER JOIN WEB_Pedidos ON Usuarios.idUsuario = WEB_Pedidos.NUM_CLI WHERE WEB_Pedidos.NPedido='" & Npedido & "'", con)
            Dim ds2 As New DataSet
            da2.Fill(ds2, "Login")
            email = ds2.Tables("login").Rows(0)("Email").ToString.Trim.ToLower

            mensaje = "Hola " & enter & enter & "Le escribimos desde Cervezas GoldenHour ." & enter & enter & "Le informamos que su pedido " & Npedido & " ha sido ENVIADO. " & enter & enter & "  hasta luego  ." & enter & enter & enter & enter

            Dim ok As String = EnviarMail(email, "Cervezas GoldenHour - Pedido Enviado", mensaje)
            SQL_Accion("update WEB_Pedidos set Estado = 'Enviado' where NPedido=" & Npedido)
            cargarPedidos1()
        End If
    End Sub



    Protected Sub ImageButton13_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton13.Click
        pAreaAdmin.Visible = True
        pVerPedidosUsuarios.Visible = False
    End Sub

    Protected Sub bTerminarYVolverPedidoAnulado_Click(sender As Object, e As EventArgs) Handles bTerminarYVolverPedidoAnulado.Click
        cargarPedidos1()
        pVerPedidosUsuarios.Visible = True
        pPedidoAnulado.Visible = False

    End Sub

    Protected Sub gVerUnPedidoEditar_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gVerUnPedidoEditar.RowCommand

        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = gVerUnPedidoEditar.Rows(index)
        Dim Item As String = row.Cells(1).Text, en As String = Chr(13) & Chr(10)
        Dim npedido As String = row.Cells(3).Text, an As String = Chr(13) & Chr(10)
        Dim email As String, mensaje As String
        Dim enter As String = Chr(13) & Chr(10)

        Dim da2 As New SqlDataAdapter("select Usuarios.Email from Usuarios INNER JOIN WEB_Pedidos ON Usuarios.idUsuario = WEB_Pedidos.NUM_CLI INNER JOIN WEB_Pedidos_Detalle ON WEB_Pedidos.NPedido = WEB_Pedidos_Detalle.Npedido  WHERE WEB_Pedidos_Detalle.Npedido='" & npedido & "'", con)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "Login")
        email = ds2.Tables("login").Rows(0)("Email").ToString.Trim.ToLower

        mensaje = "hola" & enter & enter & "Le escribimos desde Cervezas GoldenHour." & enter & enter & "Le informamos que su pedido, El item eliminado es: " & Item & " " & enter & enter & " hasta luego" & enter & enter & enter & enter & enter

        Dim ok As String = EnviarMail(email, "Cervezas GoldenHour - Item Eliminado -", mensaje)

        Dim consulta As String = "DELETE FROM WEB_Pedidos_Detalle where upper(ltrim(rtrim(Npedido))) ='" & npedido & "' and upper(ltrim(rtrim(Item))) ='" & Item & "'"
        lErrorPedido.Text = ""
        If (e.CommandName = "Quitar") Then
            If SQL_Accion(consulta) = False Then
                lErrorVerUnPedidoEditarQuitar.Text = "No puedo quitar el item de la lista. Intente mas tarde."
                Exit Sub
            End If
            Dim da1 As New SqlDataAdapter("SELECT WEB_Pedidos_Detalle.Item, " & "WEB_Pedidos_Detalle.cantidad, " & "WEB_Pedidos_Detalle.Npedido FROM WEB_Pedidos_Detalle INNER JOIN Web_Cervezas ON " & "WEB_Pedidos_Detalle.Item = Web_Cervezas.Tipos WHERE WEB_Pedidos_Detalle.NPedido=" & npedido & " ORDER BY Web_Cervezas.CodH", con)

            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")
            gVerUnPedidoEditar.DataSource = ds1.Tables("histo")
            gVerUnPedidoEditar.DataBind()

        End If

    End Sub

    Protected Sub bvolverpedidosadmin_Click(sender As Object, e As EventArgs) Handles bvolverpedidosadmin.Click
        pEditarPedidos.Visible = False
        pVerPedidosUsuarios.Visible = True
    End Sub

    Protected Sub bVerpedidosadmin_Click(sender As Object, e As ImageClickEventArgs) Handles bVerpedidosadmin.Click
        cargarPedidos1()
        pVerPedidosUsuarios.Visible = True
        pAreaAdmin.Visible = False

    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        cargarPedidos1()
    End Sub

    Protected Sub bTerminarvolveredit_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminarvolveredit.Click
        pEditarUsuario.Visible = False
        pAreaAdmin.Visible = True
    End Sub

    Protected Sub bEditarUsuarios_Click(sender As Object, e As ImageClickEventArgs)

    End Sub

    Protected Sub bModificarproduc_Click(sender As Object, e As ImageClickEventArgs)

    End Sub

    Protected Sub bvolverpedidosadmin_Click(sender As Object, e As ImageClickEventArgs) Handles bvolverpedidosadmin.Click

    End Sub

    Protected Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click

        Dim usu As String = tUsuario.Text.Trim.ToUpper
        Dim pass As String = tClave.Text.Trim

        ' Verificar si hay caracteres peligrosos en los campos de entrada
        If comprobar(tUsuario.Text.Trim) = False Or comprobar(tClave.Text.Trim) = False Then
            lErrorlogin.Text = "El usuario o la clave son incorrectos. Revise por favor."
            lErrorlogin.Visible = True
            Exit Sub
        End If

        ' Verificar si el usuario es un Administrador
        Dim daAdmin As New SqlDataAdapter("select * from Administrador where upper(ltrim(rtrim(usuario)))='" & usu & "' And ltrim(rtrim(password))='" & pass & "'", con)
        Dim dsAdmin As New DataSet
        daAdmin.Fill(dsAdmin, "Login")

        If dsAdmin.Tables("Login").Rows.Count > 0 Then
            Session("QueEs") = "Administrador"
        Else
            ' Verificar si el usuario es un Usuario
            Dim daUser As New SqlDataAdapter("select * from Usuarios where upper(ltrim(rtrim(usuario)))='" & usu & "' And ltrim(rtrim(password))='" & pass & "'", con)
            Dim dsUser As New DataSet
            daUser.Fill(dsUser, "Login")

            If dsUser.Tables("Login").Rows.Count > 0 Then
                Session("QueEs") = "Usuarios"
            Else
                lErrorlogin.Text = "El usuario o la clave son incorrectos. Revise por favor."
                lErrorlogin.Visible = True
                Exit Sub
            End If
        End If

        Loguea()
    End Sub
End Class


