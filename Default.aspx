<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Sistema._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">



<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema</title>
   <link type="text/css" href="~/Content/bootstrap.min.css" rel="stylesheet"/>
    <script type="text/javascript" src="~/Scripts/bootstrap.min.js"></script>

    <style type="text/css">
        #form1 {
            width: 767px;
            height: 886px;
            margin: auto auto;
            margin-top: auto;
            margin-bottom: auto;
        }

        .auto-style1 {
            width: 400px;
        }
        .auto-style2 {
            width: 274px;
        }
        .auto-style3 {
            width: 324px;
        }
        .auto-style4 {
            height: 27px;
        }
        .auto-style5 {
            width: 855px;
            height: 893px;
            margin-right: 3px;
        }
        .auto-style6 {
            width: 732px;
        }
        .auto-style8 {
            width: 100%;
            height: 58px;
        }
        .auto-style9 {
            width: 100%;
            height: 115px;
        }
        .auto-style10 {
            width: 732px;
            height: 56px;
        }
        .auto-style11 {
            width: 100%;
            height: 85px;
        }
        .auto-style12 {
            width: 100%;
            height: 417px;
        }
        .auto-style15 {
            width: 301px;
        }
        .auto-style24 {
            width: 301px;
            height: 41px;
        }
        .auto-style27 {
            width: 732px;
            height: 41px;
        }
        .auto-style32 {
            width: 1040px;
            height: 41px;
        }
        .auto-style36 {
            width: 1040px;
            height: 38px;
        }
        .auto-style37 {
            width: 301px;
            height: 38px;
        }
        .auto-style38 {
            width: 732px;
            height: 38px;
        }
        .auto-style39 {
            width: 1040px;
        }
        .auto-style43 {
            width: 1040px;
            height: 59px;
        }
        .auto-style44 {
            width: 301px;
            height: 59px;
        }
        .auto-style45 {
            width: 732px;
            height: 59px;
        }
        .auto-style46 {
            width: 1040px;
            height: 62px;
        }
        .auto-style47 {
            width: 301px;
            height: 62px;
        }
        .auto-style48 {
            width: 732px;
            height: 62px;
        }
        .auto-style49 {
            margin-left: 4px;
        }
        .auto-style50 {
            width: 787px;
            height: 38px;
        }
        .auto-style51 {
            height: 99px;
            width: 787px;
        }
        .auto-style52 {
            width: 758px;
        }
        .auto-style54 {
            margin-right: 2px;
        }
        .auto-style55 {
            width: 1040px;
            height: 39px;
        }
        .auto-style56 {
            width: 301px;
            height: 39px;
        }
        .auto-style57 {
            width: 732px;
            height: 39px;
        }
        .auto-style58 {
            width: 1040px;
            height: 40px;
        }
        .auto-style59 {
            width: 301px;
            height: 40px;
        }
        .auto-style60 {
            width: 732px;
            height: 40px;
        }
        .auto-style61 {
            width: 1040px;
            height: 48px;
        }
        .auto-style62 {
            width: 301px;
            height: 48px;
        }
        .auto-style63 {
            width: 732px;
            height: 48px;
        }
        .auto-style64 {
            width: 1040px;
            height: 47px;
        }
        .auto-style65 {
            width: 301px;
            height: 47px;
        }
        .auto-style66 {
            width: 732px;
            height: 47px;
        }
        .auto-style67 {
            width: 1040px;
            height: 43px;
        }
        .auto-style68 {
            width: 301px;
            height: 43px;
        }
        .auto-style69 {
            width: 732px;
            height: 43px;
        }
        .auto-style70 {
            margin-top: 3px;
        }
        .auto-style71 {
            width: 772px;
        }
        .auto-style72 {
            width: 758px;
            height: 53px;
        }
        .auto-style73 {
            width: 773px;
            height: 23px;
        }
        .auto-style74 {
            width: 773px;
            height: 196px;
        }
        .auto-style75 {
            width: 769px;
        }
        .auto-style76 {
            margin-top: 3px;
            margin-right: 0px;
        }
        .auto-style77 {
            width: 765px;
        }
        .auto-style78 {
            width: 731px;
        }
        .auto-style80 {
            width: 766px;
            height: 109px;
        }
        .auto-style81 {
            margin-left: 0px;
        }
        .auto-style82 {
            margin-left: 34px;
        }
        .auto-style83 {
            width: 534px;
        }
        .auto-style84 {
            width: 234px;
        }
        .auto-style85 {
            width: 773px;
            height: 50px;
        }
        .auto-style86 {
            width: 770px;
        }
        .auto-style91 {
            width: 704px;
        }
        .auto-style92 {
            width: 1114px;
        }
        .auto-style93 {
            height: 28px;
        }
        .auto-style94 {
            width: 771px;
            height: 202px;
        }
        .auto-style95 {
            width: 766px;
            height: 188px;
        }
        .auto-style96 {
            width: 771px;
            height: 44px;
        }
        .auto-style98 {
            width: 771px;
            height: 340px;
        }
        .auto-style99 {
            height: 226px;
        }

  
        .auto-style100 {
            margin-left: 32px;
        }
        .auto-style101 {
            height: 41px;
        }

  
        .auto-style102 {
            width: 179px;
        }
        .auto-style103 {
            margin-left: 2px;
            margin-top: 64px;
        }

  
        .auto-style105 {
            margin-left: 68;
            margin-bottom: 3;
        }
        
  
        .auto-style107 {
            width: 423px;
        }
        .auto-style108 {
            width: 766px;
        }
        .auto-style109 {
            width: 761px;
        }
        
  
        .auto-style110 {
            width: 765px;
            margin-top: 40px;
        }
        .auto-style111 {
            width: 100%;
            margin-top: 20px;
        }
        
  
        .auto-style112 {
            width: 139px;
        }
        
  
        .auto-style113 {
            margin-left: 301px;
        }
        
  
        .auto-style114 {
            margin-left: 327px;
        }
        
  
        .auto-style115 {
            width: 733px;
        }
                
  
        .auto-style118 {
            width: 366px;
            height: 56px;
        }
        .auto-style119 {
            height: 56px;
        }
        .auto-style120 {
            width: 652px;
            height: 56px;
        }
        .auto-style121 {
            height: 83px;
        }
        
  
        .auto-style122 {
            width: 392px;
        }
        .auto-style123 {
            width: 353px;
        }
        
  
        .auto-style124 {
            width: 863px;
        }
        
  
        .auto-style125 {
            height: 289px;
        }
        
  
        .auto-style127 {
            width: 732px;
            height: 50px;
        }
        
  
    </style>
</head>
<body bgcolor="#ffffff">
    <form id="form1" runat="server" class="auto-style5" colspan="1">
        <script src="bootstrap/js/bootstrap.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.min.js" integrity="sha384-BBtl+eGJRgqQAUMxJ7pMwbEyER4l1g+O15P+16Ep7Q9Q+zqX6gSbd85u4mG4QzX+" crossorigin="anonymous"></script>
        <asp:Panel ID="pPortada" runat="server" Height="613px" Width="760px" BackColor="White" ForeColor="#663300">
            <table style="width:100%;">
               
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style102">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <table style="width:100%;">
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style102">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style102">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:ImageButton ID="bPortada" runat="server"
                ImageAlign="Middle" ImageUrl="~/imagenes para Clase 4/inicio.png" Height="439px" Width="750px" BorderColor="#696056" BorderStyle="Groove" CssClass="auto-style103" /> 
            
        </asp:Panel>
        <asp:Panel ID="pLogin" runat="server" Height="498px"
            Font-Bold="true" ForeColor="Blue" Width="760px" 
            Font-Size="Large" BorderStyle="Solid" Visible="false" BorderColor="#696056">
        
            
                         <table style="width:100%;">
                             <tr>
                                 <td>
                                     <asp:Label ID="version" runat="server" 
                                         Font-Bold="True" Font-Size="Large" ForeColor="#999999" Text="Usuario"></asp:Label>
                                 </td>
                             </tr>
                             <tr>
                                 <td align="center">
                                     <asp:Label ID="Label104" runat="server" 
                                         Font-Bold="True" Font-Size="X-Large" 
                                         Text="Ingresa tu Usuario y Clave, y oprimi ENTRAR" ForeColor="#4F443C"></asp:Label>
                                  
                                 </td>
                             </tr>
                         </table>

             <table style="width:100%;">
                             <tr>
                                 <td class="auto-style4" colspan="2">
                             
                                 </td>
                             </tr>
                             <tr>
                                 <td class="auto-style2">
                                     <asp:Label ID="Label3" runat="server" 
                                         Font-Bold="True" Font-Size="X-Large" 
                                         Text="Usuario:" ForeColor="#4F443C"></asp:Label>
                                  
                                     <asp:TextBox ID="tUsuario" runat="server" Height="35px" Width="134px" MaxLength="10"></asp:TextBox>
                                  
                                 </td>
                                 <td class="auto-style3">
                                     <asp:Label ID="Label105" Font-Bold="True" Font-Size="X-Large"  
                                         runat="server" Text="Contraseña" ForeColor="#4F443C"></asp:Label>
                                     <asp:TextBox ID="tClave" runat="server" Height="35px" Width="143px" MaxLength="10" TextMode="Password"></asp:TextBox>
                                 </td>
                               
                             </tr>
                         </table>
            
             <table style="width:100%;">
 <tr>
                <td class="auto-style127" align="center">
                  

                </td>
                    <td class="auto-style127" align="center">
                    <asp:Button ID="bLogin" runat="server" Text="Login" OnClick="bLogin_Click" Width="120px" />
                </td>
            </tr>
                             <tr>
                                 <td align="center" class="auto-style6">
                                     <asp:Label ID="lErrorlogin" runat="server" 
                                         Font-Bold="True" Font-Size="X-Large" 
                                         visible="False"
                                         Text="lError login:" ForeColor="#4F443C"></asp:Label>
                                     </td>
                                 </tr>
                                         </table>
             <table style="width:100%;">
                             <tr>
                                 <td class="auto-style6">
                         <asp:ImageButton ID="bRecuperarclave" runat="server" Height="61px"
                             ImageUrl="~/imagenes para Clase 4/reenviaarclave.png" Width="514px" />
                     </td>
                                   <td align="center" class="auto-style6">
                                     <asp:Label ID="lReenviarClave" runat="server" 
                                         Font-Bold="True" Font-Size="X-Large" 
                                         visible="False"
                                         Text="lReenviar clave:" ForeColor="#4F443C"></asp:Label>
                                     </td>
                 </tr>
                 <tr>
                     
                         <td class="auto-style6">
                             &nbsp;</td>
                     
                 </tr>

                </table>
                         <table style="width:100%;">
                             <tr>
                                 <td align="center" class="auto-style6">
                         <asp:ImageButton ID="bVolverlogin" runat="server" Height="68px"
                             ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="259px" />
                     </td>
                 </tr>

                </table>

        </asp:Panel>
           
    
          <asp:Panel ID="pLoginMenu" runat="server" Height="392px"
              Font-Bold="true" ForeColor="Blue"
              Width="757px" Font-Size="Large" BorderStyle="Solid" Visible="false" CssClass="auto-style54" BorderColor="#696056">

              <table class="auto-style8">
                  <tr>
                    <td align="center">
                                     <asp:Label ID="Label1" runat="server" 
                                         Font-Bold="True" Font-Size="X-Large" 
                                         Text="Ingresa tu Usuario y Clave, y oprimi ENTRAR" ForeColor="#696056"></asp:Label>
                             </td>
         
                  </tr>
              </table>
                              


               <table class="auto-style9">
                  <tr>
                      <td  class="auto-style6">
                          <asp:ImageButton ID="bRegistraste" runat="server" Height="95px" ImageUrl="~/imagenes para Clase 4/registrateaqui.jpg" Width="743px" BorderColor="#4F443C" BorderStyle="Groove" />
                            </td>
                  </tr>
              </table>
              
               <table class="auto-style9">
                  <tr>
                      <td  class="auto-style6">
                          <asp:ImageButton ID="BAlogin" runat="server" Height="94px" ImageUrl="~/imagenes para Clase 4/yaregistrado.jpg" Width="742px" BorderColor="#4F443C" BorderStyle="Groove" />
                            </td>
                  </tr>
              </table>

               <table class="auto-style8">
                  <tr>
                      <td align="center" class="auto-style6">
                         <asp:ImageButton ID="bRegistraseVolverLoginU13" runat="server" Height="71px"
                             ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="308px" CssClass="auto-style81" />
                            </td>
                  </tr>
              </table>

          </asp:Panel>
    <asp:Panel ID="pRegistrase" runat="server"  Font-Bold="true" ForeColor="Blue"
        Height="867px"  style="margin-right: 0px"  BorderStyle="Solid" CssClass="auto-style54"
              Font-Size="Large"  Visible="false" Width="772px" BorderColor="#4F443C">  

             <table class="auto-style8">
                  <tr>
                      <td align="center">
                                     <asp:Label ID="Label56" runat="server" 
                                         Font-Bold="True" Font-Size="X-Large" 
                                         Text="Regístrarse" ForeColor="#4F443C"></asp:Label>
                                  
                                 </td>
                  </tr>
              </table>

                     <table class="auto-style11">
                  <tr>
                      <td  class="auto-style10">
                        <label class="auto-style80" style="font-family: 'Times New Roman'; color: #4F443C;"  >
                            Para poder registrarte debés ser mayor de 18 años, residir en Argentina y contar con documento valido en Argentina que acredite tu identidad.
                          <br />
                          Sólo se puede hacer un registro por documento.Los datos deben ser reales, correctos y vigentes.
                          <br />
                          Todos los datos a continuación (menos Origen) son obligatorios:
                        </label>
                            </td>
                  </tr>
              </table>
                 <table class="auto-style12">
                  <tr>
                      <td class="auto-style61">
                          <asp:label runat="server" Font-Size="17px" ForeColor="#4F443C" > tu/s nombre/s:</asp:label>
                      </td>
                      <td class="auto-style62">
                          <asp:TextBox ID="tNombreU" runat="server" Font-Size="X-Large" ForeColor="Black" Width="290px" MaxLength="20" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                      </td>
                      <td class="auto-style63">
                          <asp:label runat="server" Font-Size="17px" forecolor="red" visible="False" id="lENombreU"></asp:label>
                      </td>
                  </tr>
                     <tr>
                         <td class="auto-style64">
                             <asp:label runat="server" Font-Size="17px" ForeColor="#4F443C" > Apellido/s:</asp:label>
                         </td>
                         <td class="auto-style65">
                             <asp:TextBox ID="tApellidoU" runat="server" Font-Size="X-Large" ForeColor="Black" Width="290px" MaxLength="20" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style66">
                              <asp:label runat="server" Font-Size="17px" forecolor="red" visible="False" id="lEApellidoU"></asp:label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style32">
                             <asp:label runat="server" Font-Size="17px" ForeColor="#4F443C" >Tipo de doc:</asp:label>
                         </td>
                         <td class="auto-style24">
                             <asp:DropDownList ID="dTDocU" runat="server" Font-Size="X-Large" ForeColor="Black" Height="28px" Width="292px">
                                 <asp:ListItem  Value="DNI">Doc. Nacional de Identidad</asp:ListItem>
                                 <asp:ListItem Value="LC">Libreta Cívica</asp:ListItem>
                                 <asp:ListItem Value="LE">Libreta de Enrolamiento</asp:ListItem>
                             </asp:DropDownList>
                         </td>
                         <td class="auto-style27">
                            
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style67">
                              <asp:label runat="server" Font-Size="17px" ForeColor="#4F443C" >Nº de doc (sin puntos, ni espacios):</asp:label>
                         </td>
                         <td class="auto-style68"><asp:TextBox ID="tDocU" runat="server" Font-Size="X-Large" ForeColor="Black" Width="290px" MaxLength="20" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style69">
                             <asp:label runat="server" Font-Size="17px" forecolor="red" id="lEDocU" visible="False" ></asp:label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style61"><asp:label runat="server" Font-Size="17px" ForeColor="#4F443C" >Fecha Nac.: (ddmmaa)</asp:label></td>
                         <td class="auto-style62">
                             <asp:TextBox ID="tF_Nac" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" Width="116px" MaxLength="6" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         <asp:label id="lEdad" runat="server" Font-Size="17px" ForeColor="#4F443C">0 </asp:label>
                             </td>
                         <td class="auto-style63">
                             <asp:label runat="server" Font-Size="17px"  forecolor="red"  id="lEFNac" visible="false" ></asp:label>
                         </td>
                     </tr>
                      <tr>
                         <td class="auto-style46">
                              <asp:label runat="server" Font-Size="17px" ForeColor="#4F443C" >Email válido para notificaciones:</asp:label>
                         </td>
                         <td class="auto-style47">
                             <asp:TextBox ID="tEmailU"  runat="server" Height="49px" Width="291px" Font-Size="X-Large" ForeColor="Black" MaxLength="100" Rows="2" TextMode="MultiLine" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style48">
                              <asp:label runat="server" Font-Size="17px" forecolor="red"  id="lEEmailU" visible="false" ></asp:label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style39">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Provincia:</asp:Label>
                         </td>
                         <td class="auto-style15">
                             <asp:DropDownList ID="didProvU" runat="server" Font-Size="X-Large" ForeColor="Black">
                             <asp:ListItem Value="1">Buenos Aires</asp:ListItem>

                             <asp:ListItem Value="2">Catamarca</asp:ListItem>

                             <asp:ListItem Value="3">Chaco</asp:ListItem>

                             <asp:ListItem Value="4">Chubut</asp:ListItem>

                            <asp:ListItem Value="5">CABA</asp:ListItem>

                           <asp:ListItem Value="6">Córdoba</asp:ListItem>

                          <asp:ListItem Value="7">Corrientes</asp:ListItem>

                          <asp:ListItem Value="8">Entre Rios</asp:ListItem>

                           <asp:ListItem Value="9">Formosa</asp:ListItem>

                          <asp:ListItem Value="10">Jujuy</asp:ListItem>

                          <asp:ListItem Value="11">La Pampa</asp:ListItem>

                         <asp:ListItem Value="12">La Rioja</asp:ListItem>

                         <asp:ListItem Value="13">Mendoza</asp:ListItem>

                         <asp:ListItem Value="14">Misiones</asp:ListItem>

                        <asp:ListItem Value="15">Neuquén</asp:ListItem>

                        <asp:ListItem Value="16">Rio Negro</asp:ListItem>

                        <asp:ListItem Value="17">Salta</asp:ListItem>

                        <asp:ListItem Value="18">San Juan</asp:ListItem>

                        <asp:ListItem Value="19">San Luis</asp:ListItem>

                        <asp:ListItem Value="20">Santa Cruz</asp:ListItem>

                       <asp:ListItem Value="21">Santa Fe</asp:ListItem>

                       <asp:ListItem Value="22">Santiago del Estero</asp:ListItem>

                       <asp:ListItem Value="23">Tucumán</asp:ListItem>
 
                      <asp:ListItem Value="24">Tierra del Fuego</asp:ListItem>
                             </asp:DropDownList>
                         </td>
                         <td class="auto-style6">&nbsp;</td>
                         </tr>
                     <tr>
                         <td class="auto-style58">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Localidad:</asp:Label>
                         </td>
                         <td class="auto-style59">
                             <asp:TextBox ID="tLocalidadU" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" MaxLength="25" Width="291px" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style60"> 
                             <asp:Label ID="lELocalidadU"  forecolor="red" runat="server" Font-Size="17px" visible="false"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style43">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Direccion:</asp:Label>
                         </td>
                         <td class="auto-style44">
                             <asp:TextBox ID="tDireccionU" runat="server" BorderStyle="Groove" Height="54px" MaxLength="100" Font-Size="X-Large" ForeColor="Black"  Rows="2" TextMode="MultiLine" Width="294px" BorderColor="#4F443C"></asp:TextBox>
                         </td>
                         <td class="auto-style45">
                              <asp:Label ID="lEDireccionU" forecolor="red" runat="server" Font-Size="17px" visible="false"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style36">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Teléfono: (agregue característica)</asp:Label>
                         </td>
                         <td class="auto-style37">
                             <asp:TextBox ID="tTelefonosU" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" Width="291px" MaxLength="25" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style38">
                              <asp:Label ID="lETelefonosU" forecolor="red" runat="server" Font-Size="17px" visible="False" ></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style36">
                              <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Usuario:</asp:Label>
                         </td>
                         <td class="auto-style37">
                             <asp:TextBox ID="tUsuarioU" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" Width="291px" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style38">
                             <asp:Label ID="lEUsuarioU" forecolor="red" runat="server" Font-Size="17px" visible="false" ></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style55">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Clave:</asp:Label>
                         </td>
                         <td class="auto-style56">
                             <asp:TextBox ID="tPassU" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" Width="291px" MaxLength="10" TextMode="Password" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style57">
                             <asp:Label ID="lEpassU" runat="server" Font-Size="17px" forecolor="red" visible="False"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style55">
                              <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Repetir Clave:</asp:Label>
                         </td>
                         <td class="auto-style56">
                             <asp:TextBox ID="tPass2U" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" Width="291px" MaxLength="10" TextMode="Password" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style57">
                              <asp:Label ID="lEPass2U" runat="server" Font-Size="17px"  forecolor="red" visible="false"></asp:Label>
                         </td>
                     </tr>
              </table>
<asp:Label ID="lErorresU" runat="server" Font-Size="17px" forecolor="red" visible="false"></asp:Label>
        <table>
            <tr>
                <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bRegistrarse" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/registrarsee.png" Width="315px" />

                </td>
                    <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bRegistrarseUO" runat="server" Height="66px"
                             ImageUrl="~/imagenes para Clase 4/cancelaarvolver.png" Width="299px" CssClass="auto-style49" />
                </td>
            </tr>
          
        </table>

          </asp:Panel>

         <asp:Panel ID="pAreaUsuario" runat="server" 
        Height="535px"   Font-Bold="true" ForeColor="Blue" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style71">
                 <tr>
                     <td class="auto-style50" align="center">
                         <asp:Label runat="server" Font-Size="30px" Text="Bienvenido/a " ID="lBienvenidoAreaU" ForeColor="#4F443C"  ></asp:Label>

                     </td>
                                              
                 </tr>
                           
                 <tr>
                     <td align="center" class="auto-style51">
                                                
                        
                             <asp:ImageButton ID="bAhoraQueHago" runat="server" Height="82px"
                             ImageUrl="~/imagenes para Clase 4/ahoraa_que_hago.png" Width="315px" />
                          <br />
                         </td>
                     </tr>
                     <tr>
                     <td  align="center" class="auto-style52">
                             <asp:ImageButton ID="bHacerPedido" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/hacerpeedido.png" Width="360px" />
                         </td>
                         </tr>              
                      <tr>
                     <td class="auto-style52" align="center">
                     <asp:ImageButton ID="bModificarDatos" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/modificardaatos.png" Width="360px" CssClass="auto-style49" />
                </td>
                 </tr>

                      
                      <tr>
                     <td class="auto-style52" align="center">
                     <asp:ImageButton ID="bVolverLoginU1" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="308px" CssClass="auto-style49" />
                </td>
                 </tr>
                </table>
          </asp:Panel>
        <asp:Panel ID="pAhoraQueHago" runat="server" 
        Height="363px"   Font-Bold="true" ForeColor="Blue" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style71">
                 <tr>
                    <td class="auto-style72" align="center">
                        <asp:Label runat="server"  Font-Size="24px" ForeColor="#4F443C">te cuento un poco</asp:Label>

                    </td>
                 </tr>
               </table>
            <br />
                   <table  class="auto-style75">
                     <tr>
                         <td align="center" class="auto-style74">
                             <asp:Label runat="server" ForeColor="Black" Font-Size="17px">aplicacion para pedir cervezas de todo tipo</asp:Label>
                         </td>
                     </tr>
                       <tr>
                           <td align="center"  class="auto-style73">
                                <asp:ImageButton ID="bVolverLoginU2" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="308px" CssClass="auto-style49" />
                           </td>
                       </tr>
             

                 </table>
                 </asp:Panel>
        <asp:Panel ID="pCambiarDatos" runat="server" height="587px" 
            ForeColor="blue" Font-Bold="true" visible="false"   BorderStyle="Solid" 
              Font-Size="Large"  CssClass="auto-style70" BorderColor="#4F443C">  

             <table  class="auto-style8">
                  <tr>
                      <td align="center">
                         <asp:Label  runat="server"  Font-Size="24px" ForeColor="#4F443C">Cambiar tus datos personales</asp:Label>
                 </td>
                          </tr>
                 </table>
                 <table>
            
                      <tr>
                         <td class="auto-style46">
                              <asp:label runat="server" Font-Size="17px" ForeColor="#4F443C" >Email válido para notificaciones:</asp:label>
                         </td>
                         <td class="auto-style47">
                             <asp:TextBox ID="tEmailC"  runat="server" Height="49px" Width="291px" Font-Size="X-Large" ForeColor="Black" MaxLength="100" Rows="2" TextMode="MultiLine" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style48">
                              <asp:label runat="server" Font-Size="17px" forecolor="red"  id="EEmailU" visible="false" ></asp:label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style39">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Provincia:</asp:Label>
                         </td>
                         <td class="auto-style15">
                             <asp:DropDownList ID="dProvinciaC" runat="server" Font-Size="X-Large" ForeColor="Black">
                             <asp:ListItem Value="1">Buenos Aires</asp:ListItem>

                             <asp:ListItem Value="2">Catamarca</asp:ListItem>

                             <asp:ListItem Value="3">Chaco</asp:ListItem>

                             <asp:ListItem Value="4">Chubut</asp:ListItem>

                            <asp:ListItem Value="5">CABA</asp:ListItem>

                           <asp:ListItem Value="6">Córdoba</asp:ListItem>

                          <asp:ListItem Value="7">Corrientes</asp:ListItem>

                          <asp:ListItem Value="8">Entre Rios</asp:ListItem>

                           <asp:ListItem Value="9">Formosa</asp:ListItem>

                          <asp:ListItem Value="10">Jujuy</asp:ListItem>

                          <asp:ListItem Value="11">La Pampa</asp:ListItem>

                         <asp:ListItem Value="12">La Rioja</asp:ListItem>

                         <asp:ListItem Value="13">Mendoza</asp:ListItem>

                         <asp:ListItem Value="14">Misiones</asp:ListItem>

                        <asp:ListItem Value="15">Neuquén</asp:ListItem>

                        <asp:ListItem Value="16">Rio Negro</asp:ListItem>

                        <asp:ListItem Value="17">Salta</asp:ListItem>

                        <asp:ListItem Value="18">San Juan</asp:ListItem>

                        <asp:ListItem Value="19">San Luis</asp:ListItem>

                        <asp:ListItem Value="20">Santa Cruz</asp:ListItem>

                       <asp:ListItem Value="21">Santa Fe</asp:ListItem>

                       <asp:ListItem Value="22">Santiago del Estero</asp:ListItem>

                       <asp:ListItem Value="23">Tucumán</asp:ListItem>
 
                      <asp:ListItem Value="24">Tierra del Fuego</asp:ListItem>
                             </asp:DropDownList>
                         </td>
                         <td class="auto-style6">&nbsp;</td>
                         </tr>
                     <tr>
                         <td class="auto-style58">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Localidad:</asp:Label>
                         </td>
                         <td class="auto-style59">
                             <asp:TextBox ID="tLocalidadC" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" MaxLength="25" Width="291px" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style60"> 
                             <asp:Label ID="ELocalidadU"  forecolor="red" runat="server" Font-Size="17px" visible="false"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style43">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Direccion:</asp:Label>
                         </td>
                         <td class="auto-style44">
                             <asp:TextBox ID="tDirecC" runat="server" BorderStyle="Groove" Height="54px" MaxLength="100" Font-Size="X-Large" ForeColor="Black"  Rows="2" TextMode="MultiLine" Width="294px" BorderColor="#4F443C"></asp:TextBox>
                         </td>
                         <td class="auto-style45">
                              <asp:Label ID="EDireccionU" forecolor="red" runat="server" Font-Size="17px" visible="false"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style36">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Teléfono: (agregue característica)</asp:Label>
                         </td>
                         <td class="auto-style37">
                             <asp:TextBox ID="tTelC" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" Width="291px" MaxLength="25" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style38">
                              <asp:Label ID="ETelefonosU" forecolor="red" runat="server" Font-Size="17px" visible="False" ></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style36">
                              <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Usuario:</asp:Label>
                         </td>
                         <td class="auto-style37">
                             <asp:TextBox ID="tUsuarioC" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" Width="291px" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style38">
                             <asp:Label ID="EUsuarioU" forecolor="red" runat="server" Font-Size="17px" visible="false" ></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style55">
                             <asp:Label runat="server" Font-Size="17px" ForeColor="#4F443C">Clave:</asp:Label>
                         </td>
                         <td class="auto-style56">
                             <asp:TextBox ID="tClaveC" runat="server" Font-Size="X-Large" ForeColor="Black" Height="24px" Width="291px" MaxLength="10" TextMode="Password" BorderColor="#4F443C" BorderStyle="Groove"></asp:TextBox>
                         </td>
                         <td class="auto-style57">
                             <asp:Label ID="EPassU" runat="server" Font-Size="17px" forecolor="red" visible="False"></asp:Label>
                         </td>
                     </tr>
                     
              </table>
<asp:Label ID="lErrorU" runat="server" Font-Size="17px" forecolor="Red" visible="False"></asp:Label>
        <table>
            <tr>
                <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bCambiardatos" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/cambiaarlosdatos.png" Width="315px" />

                </td>
                    <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bCancelaryvolver" runat="server" Height="66px"
                             ImageUrl="~/imagenes para Clase 4/cancelaarvolver.png" Width="299px" CssClass="auto-style49" />
                </td>
            </tr>
          
        </table>

          </asp:Panel>
         <asp:Panel ID="pAreaDatos" runat="server" height="587px" 
            ForeColor="blue" Font-Bold="true" visible="false"   BorderStyle="Solid" 
              Font-Size="Large"  CssClass="auto-style76" Width="767px" BorderColor="#4F443C">  

             <table  class="auto-style8">
                 <tr>
                     <td align="center">
                        <asp:label Font-Size="26px" runat="server" ForeColor="#4F443C">Tus datos han sido cambiados correctamente</asp:label>
                     </td>
                 </tr>
                 </table>
             <br />
             <table class="auto-style78" >
                  <tr>
                <td class="auto-style77" align="center">
                     <asp:ImageButton ID="bVolveratuarea" runat="server" Height="80px"
                             ImageUrl="~/imagenes para Clase 4/volveer.png" Width="315px" />

                </td>

                 </tr>
             </table>
             </asp:Panel>
        <asp:Panel ID="pPedidos" runat="server" 
        Height="363px"   Font-Bold="true" ForeColor="Blue" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style71">
                 <tr>
                    <td class="auto-style72" align="center">
                        <asp:Label runat="server"  Font-Size="24px" ForeColor="#4F443C">Menu pedidos </asp:Label>
                        
           
                    </td>
                 </tr>
               </table>
            <br />
                   <table  class="auto-style75">
                     <tr>
                          <td align="center"  class="auto-style73">
                                <asp:ImageButton ID="bPedidos" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/nuevopedidoo.png" Width="321px" CssClass="auto-style81" />
                           </td>
                     </tr>
                       <tr>
                           <td align="center"  class="auto-style73">
                                <asp:ImageButton ID="bTodoslospedidos" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/todoslospedidoss.png" Width="321px" CssClass="auto-style81" />
                           </td>
                       </tr>
                 </table>
            <br />

            <table  class="auto-style75">
                     <tr>
                         <td align="center"  class="auto-style73">
                                <asp:ImageButton ID="bTerminarp" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="321px" CssClass="auto-style81" />
                           </td>
                     </tr>
                       
                           </table>
                 </asp:Panel>
         <asp:Panel ID="pNuevospedidos" runat="server" 
        Height="747px"   Font-Bold="true" ForeColor="#4F443C" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style71">
                 <tr>
                    <td class="auto-style72" align="center">
                        <asp:Label runat="server"  Font-Size="24px" ForeColor="#4F443C">Nuevo Pedido a Fábrica </asp:Label>
                    </td>
                 </tr>
                 </table>
             <table class="auo-style72">
                 <tr>
                     
                     <td class="auto-style84">
                         <asp:Button ID="bInstrucciones" runat="server" Text="abrir instrucciones" Height="25px" Width="192px" />
                     </td>
                     <td class="auto-style83 "><asp:label Font-Size="10px" runat="server" ForeColor="Black" ID="lInstrucciones">Instrucciones</asp:label></td>
                 </tr>
             </table>
             <br />
             <table class="auto-style85">
               <tr>
                     <td class="auto-style84"><asp:Label runat="server" ForeColor="#4F443C"> gusto de cerveza</asp:Label></td>
                   </tr>
                 <tr>
                   <td class="auto-style93">
                         <asp:DropDownList ID="dCervezas" runat="server" Width="383px" BackColor="White" ForeColor="Black" AutoPostBack="True">
                         </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td>&nbsp;</td>
                     </tr>
                 <tr>
                     <td>
                         &nbsp;</td>

                 </tr>
                 </table>
             <br />
             <table class="auto-style86">
                 <tr>
  <td class="auto-style92" ><asp:Label runat="server" ForeColor="#4F443C" >Agregar</asp:Label></td>
       <td class="auto-style91" align="center"><asp:Label runat="server" ForeColor="#4F443C" ID="lCosaAgregar" ></asp:Label></td>
                     <td align="center"><asp:Label runat="server" ForeColor="#4F443C" ID="lQueEs" ></asp:Label></td>
                 </tr>
                 <tr>
                     <td class="auto-style92"><asp:Label runat="server" ForeColor="#4F443C" >Cantidad de unidades:</asp:Label></td>
                     <td class="auto-style91" align="center">
                         <asp:DropDownList ID="tCantUni" runat="server" BackColor="White" ForeColor="Black">
                             <asp:ListItem Value="1">1</asp:ListItem>
                                <asp:ListItem Value="2">2</asp:ListItem>
                                <asp:ListItem Value="3">3</asp:ListItem>
                                <asp:ListItem Value="4">4</asp:ListItem>
                                <asp:ListItem Value="5">5</asp:ListItem>
                                <asp:ListItem Value="6">6</asp:ListItem>
                                <asp:ListItem Value="7">7</asp:ListItem>
                                <asp:ListItem Value="8">8</asp:ListItem>
                                <asp:ListItem Value="9">9</asp:ListItem>
                                <asp:ListItem Value="10">10</asp:ListItem>
                                <asp:ListItem Value="11">11</asp:ListItem>
                                <asp:ListItem Value="12">12</asp:ListItem>
                                
                         </asp:DropDownList>
                     </td>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bAgreagarALista" runat="server" Height="44px"
                             ImageUrl="~/imagenes para Clase 4/agregar.png" Width="138px" CssClass="auto-style82" />

                     </td>
                 </tr>
                 </table>
             <br />
             <table class="auto-style76">
                 <tr>
                     <td align="center" class="auto-style92"><asp:Label runat="server" ForeColor="#4F443C">Esta es la lista de su pedido</asp:Label></td>

                 </tr>
                 <tr>
                     <td class="auto-style92">

                         <asp:GridView ID="gListaPedidos" runat="server" Height="16px" Width="769px" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="#4F443C">
                             <Columns>
                                 <asp:ButtonField ButtonType="Image" CommandName="Quitar" ImageUrl="~/Imagenes para Clase 4/quitar.png" Text="Quitar" >
                                 <ControlStyle ForeColor="#4F443C" />
                                 </asp:ButtonField>
                                 <asp:BoundField DataField="item" HeaderText="Item Solicitado" />
                                 <asp:BoundField DataField="Cantidad" HeaderText="cant." />
                             </Columns>
                             <FooterStyle BackColor="#CCCCCC" />
                             <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                             <RowStyle BackColor="White" />
                             <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                             <SortedAscendingCellStyle BackColor="#F1F1F1" />
                             <SortedAscendingHeaderStyle BackColor="#808080" />
                             <SortedDescendingCellStyle BackColor="#CAC9C9" />
                             <SortedDescendingHeaderStyle BackColor="#383838" />
                         </asp:GridView>

                     </td>
                 </tr>
             </table>
             <table class="auto-style77">
                 <tr>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bQuitarTodos" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/quitartodos.png" Width="179px" CssClass="auto-style82" />
                        
                     </td>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bSolicitarPedido" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/solicitarrr.png" Width="179px" CssClass="auto-style82" />

                     </td>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bCancelarPedido" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/cancelaarvolver.png" Width="179px" CssClass="auto-style82" />

                     </td>
                 </tr>

             </table>
             <asp:Label runat="server" ForeColor="red"  ID="lErrorPedido"></asp:Label>  
       </asp:Panel>

         <asp:Panel ID="pPedidoCreado" runat="server" 
        Height="391px"   Font-Bold="true" ForeColor="Blue" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style94">
                 <tr>
                                <td align="center" class="auto-style72">
                                    <asp:Label ID="lPedidoCreado" runat="server" Font-Size="24px" ForeColor="#4F443C"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <table class="auto-style95">
                            <tr>
                                <td align="center">
                        <asp:ImageButton ID="ImageButton33" runat="server" CssClass="auto-style82" Height="70px" ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="216px" />
                    </td>
                 </tr>
                 </table>
             </asp:Panel>
         <asp:Panel ID="pHistorico" runat="server" 
        Height="486px"   Font-Bold="true" ForeColor="Blue" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style96">
                 <tr>
                                <td align="center" class="auto-style72">
                                    <asp:Label ID="Label2" runat="server" Font-Size="24px" ForeColor="#4F443C">Histórico de Pedidos y Revisar Estado </asp:Label>
                                </td>
                            </tr>
                 <tr>
                     <td><asp:Label ID="lErrorHistorico" runat="server" Font-Size="15px" ForeColor="#4F443C"></asp:Label></td>
                 </tr>
                        </table>
               <table class="auto-style76">
             
                 <tr>
                     <td class="auto-style92">

                         <asp:GridView ID="gHistorico" runat="server" Height="16px" Width="769px" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                             <Columns>
                                 <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver pedido" >
                                 <ControlStyle BackColor="Lime" BorderColor="Black" />
                                 </asp:ButtonField>
                                 <asp:ButtonField ButtonType="Button" CommandName="Anular" HeaderText="(sòlo &quot;solicitado&quot;)" Text="Anular Pedido" >
                                 <ControlStyle BackColor="#FF3300" BorderColor="Black" />
                                 </asp:ButtonField>
                                 <asp:BoundField DataField="NPedido" HeaderText="Nº Pedido" ReadOnly="True" />
                                 <asp:BoundField DataField="Fecha" HeaderText="Fecha y Hora" DataFormatString="{0:dd/MM/yyyy HH:mm:tt}" ReadOnly="True" />
                                 <asp:BoundField DataField="estado" HeaderText="Estado del Pedido" />
                             </Columns>
                             <FooterStyle BackColor="#CCCCCC" />
                             <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                             <RowStyle BackColor="White" />
                             <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                             <SortedAscendingCellStyle BackColor="#F1F1F1" />
                             <SortedAscendingHeaderStyle BackColor="#808080" />
                             <SortedDescendingCellStyle BackColor="#CAC9C9" />
                             <SortedDescendingHeaderStyle BackColor="#383838" />
                         </asp:GridView>

                     </td>
                 </tr>
             </table>
             <table class="auto-style77">
                 <tr>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="ImageButton4" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/actualizarr.png" Width="179px" CssClass="auto-style82" />
                        
                     </td>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bTerminarHistorico" runat="server" Height="57px"
                             ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="209px" CssClass="auto-style82" />

                     </td>
                     </tr>
                 </table>
             </asp:Panel>
         <asp:Panel ID="pVerunPedido" runat="server" 
        Height="486px"   Font-Bold="true" ForeColor="Blue" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style96">
                 <tr>
                                <td align="center" class="auto-style72">
                                    <asp:Label ID="Label4" runat="server" Font-Size="24px" ForeColor="#4F443C"> Detalle del pedido Nº </asp:Label>
                                </td>
                            </tr>
             
                        </table>
               <table class="auto-style76">
             
                 <tr>
                     <td class="auto-style92">

                         <asp:GridView ID="gVerunpedido" runat="server" Height="16px" Width="769px" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                             <Columns>
                                 <asp:BoundField DataField="Item" HeaderText="Item Solicitado" />
                                 <asp:BoundField DataField="Cantidad" HeaderText="Cant." />
                             </Columns>
                             <FooterStyle BackColor="#CCCCCC" />
                             <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                             <RowStyle BackColor="White" />
                             <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                             <SortedAscendingCellStyle BackColor="#F1F1F1" />
                             <SortedAscendingHeaderStyle BackColor="#808080" />
                             <SortedDescendingCellStyle BackColor="#CAC9C9" />
                             <SortedDescendingHeaderStyle BackColor="#383838" />
                         </asp:GridView>

                     </td>
                 </tr>
             </table>
             <table class="auto-style77">
                   <tr>
                     <td><asp:Label ID="lErrorVerUnPedido" runat="server" Font-Size="15px" ForeColor="#4F443C"></asp:Label></td>
                 </tr>
                 <tr>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="ImageButton6" runat="server" Height="52px"
                             ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="203px" CssClass="auto-style82" />

                     </td>
                     </tr>
                 </table>
             </asp:Panel>
         <asp:Panel ID="pPedidoAnulado" runat="server" 
        Height="486px"   Font-Bold="true" ForeColor="Blue" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style98" >
                 
                 <tr align="center">
                     <td align="center" class="auto-style99"><asp:Label ID="lPedidoAnulado" runat="server" Font-Size="21px" ForeColor="#4F443C"></asp:Label></td>
                     </tr>
                       <tr>

                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="ImageButton5" runat="server" Height="66px"
                             ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="234px" CssClass="auto-style82" />

                     </td>
                     </tr>
                     </table>
             </asp:Panel>
        <asp:Panel ID="pVerificamail" runat="server" 
        Height="363px"   Font-Bold="true" ForeColor="Blue" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style71">
                 <tr>
                    <td class="auto-style72" align="center">
                        <asp:Label runat="server"  Font-Size="19px" ForeColor="#4F443C">te hemos enviado un codigo de verificacion al email que ingresaste  </asp:Label>
                        
           
                    </td>
                 </tr>
               </table>
            <br />
                   <table  class="auto-style75">
                       
                     <tr>
                       
<td class="auto-style56" style="text-align: center;">
    <asp:TextBox ID="tValidar" runat="server" Height="35px" Width="134px" MaxLength="10" CssClass="auto-style100"></asp:TextBox>
</td>
                           
                     </tr>
                       <tr>
                           <td align="center"  class="auto-style73">
                                <asp:Label runat="server" ID="lCodigo"   Font-Size="19px" ForeColor="#4F443C">***codigo incorrecto*** </asp:Label>
                           </td>
                       </tr>
                       <tr>
                           <td>

                              <asp:Button ID="bValidar" runat="server" Height="38px" Text="Validar el código" Width="225px" style="margin: 0 auto; display: block;" />


                           </td>
                       </tr>
                       <tr>
                           <td class="auto-style101">

                               <asp:Button ID="bRegresarRegistro" style="margin: 0 auto; display: block;" runat="server" Height="39px" Text="Regresar al registro" Width="223px" />

                           </td>
                       </tr>

                       <tr>
                    <td class="auto-style6" align="center">
                     <asp:ImageButton ID="ImageButton7" runat="server" Height="61px"
                             ImageUrl="~/imagenes para Clase 4/cancelaarvolver.png" Width="272px" CssClass="auto-style100" />
                </td>
            </tr>
                 </table>
            </asp:Panel>
         <asp:Panel ID="pAreaAdmin" runat="server" 
        Height="535px"   Font-Bold="true" ForeColor="Blue" BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style71">
                 <tr>
                     <td class="auto-style50" align="center">
                         <asp:Label runat="server" Font-Size="30px" Text="Bienvenido/a " ID="lBienvenidoAreaAdmin" ForeColor="#4F443C"  ></asp:Label>

                     </td>
                                              
                 </tr>
                  <tr>
                     <td align="center" class="auto-style51">
                                                
                        
                             <asp:ImageButton ID="bAgregarProducto" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/agregarprod.png" Width="360px" />
                          <br />
                         </td>
                     </tr>
                           
                
                     <tr>
                     <td  align="center" class="auto-style52">
                             <asp:ImageButton ID="bModificarproduc" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/modificarpro.png" Width="360px" />
                         </td>
                         </tr>              
                  <tr>
                     <td align="center" class="auto-style51">
                                                
                        
                             <asp:ImageButton ID="terminarvolveradmin1" runat="server" CssClass="auto-style49" Height="78px" ImageUrl="~/imagenes para Clase 4/editarusuarios.png" Width="327px" />
                          <br />
                         </td>

                     </tr>
                   <tr>
                         <td class="auto-style52" align="center">
                     <asp:ImageButton ID="bVerpedidosadmin" runat="server" Height="73px"
                             ImageUrl="~/imagenes para Clase 4/verpedidos.png" Width="360px" CssClass="auto-style49" />
                </td>
                 </tr>

                      
                      <tr>
                     <td class="auto-style52" align="center">
                         <asp:ImageButton ID="bEditarUsuarios" runat="server" Height="73px" ImageUrl="~/imagenes para Clase 4/volveer.png" Width="360px" />
                </td>

                 </tr>
               
                </table>
          </asp:Panel>
         <asp:Panel ID="pAgregarProductos" runat="server"  Height="535px"    BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style109">
                 <tr>
                    <td class="auto-style72" align="center">
                        <asp:Label runat="server"  Font-Size="24px" ForeColor="#4F443C">Agregar productos </asp:Label>
                    </td>
                 </tr>
                 </table>
           
                <table class="auto-style111">
                      <tr>
                        <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">Nombre</asp:Label>
                        </td>
                        <td class="auto-style107">
                            <asp:TextBox ID="tNombreProd" runat="server" Width="373px"></asp:TextBox>
                        </td>
                        <td>   <asp:Label ID="lErrorNomProd" runat="server" Font-Bold="True" Visible="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">precio</asp:Label>
                        </td>
                        <td class="auto-style107">
                          <asp:TextBox ID="tPrecio" runat="server" Width="373px"></asp:TextBox>
                            </td>
                        <td>  <asp:Label ID="lErrorPreProd" runat="server" Font-Bold="True" Visible="False"></asp:Label></td>
                    </tr>
                     <tr>
                        <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">stock</asp:Label>
                        </td>
                        <td class="auto-style107">
                            <asp:TextBox ID="tStock" runat="server" Width="373px"></asp:TextBox>
                        </td>
                        <td><asp:Label ID="lErrorStockProd" runat="server" Font-Bold="True" Visible="False"></asp:Label></td>
                    </tr>
                            </table>
                            <table class="auto-style110">
                 <tr>
             
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bAgregarprod" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/agregarprod.png" Width="179px" CssClass="auto-style82" />

                     </td>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bVolverAreaAdmin" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/cancelaarvolver.png" Width="179px" CssClass="auto-style82" />

                     </td>
                 </tr>

             </table>
                            <br />
                            <asp:Label ID="lErrorPro" runat="server" Font-Bold="True" Visible="False"></asp:Label>
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style252">
                                        <br />
                                    </td>
                                </tr>
                            </table>
               
        </asp:Panel>
         <asp:Panel ID="pModificarproductos" runat="server"  Height="535px"    BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style109">
                 <tr>
                    <td class="auto-style72" align="center">
                        <asp:Label runat="server"  Font-Size="24px" ForeColor="#4F443C">modificacion producto </asp:Label>
                    </td>
                 </tr>
                 </table>
                <table class="auto-style108"">
                  
                  <tr>
                       <td class="auto-style198">
                                    <asp:Label ID="lQueEsProd" runat="server" Text="Label"></asp:Label>
                                </td>
                      <td class="auto-style83">
                               <asp:DropDownList ID="dProductos" runat="server" AutoPostBack="True" BackColor="White" ForeColor="Black" Height="61px" Width="516px" CssClass="auto-style105">
                </asp:DropDownList>
                      </td>
                      <td class="auto-style198">
                                    <asp:Label ID="lAgregarProd" runat="server" Text="Label"></asp:Label>
                                </td>
                  </tr>
           
                </table>
                <table class="auto-style111">
                      <tr>
                        <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">Nombre</asp:Label>
                        </td>
                        <td class="auto-style107">
                            <asp:TextBox ID="tNombreMod" runat="server" Width="373px"></asp:TextBox>
                        </td>
                        <td>   <asp:Label ID="lEnom" runat="server" Font-Bold="True" Visible="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">precio</asp:Label>
                        </td>
                        <td class="auto-style107">
                          <asp:TextBox ID="tPrecioMod" runat="server" Width="373px"></asp:TextBox>
                            </td>
                        <td>  <asp:Label ID="lEpre" runat="server" Font-Bold="True" Visible="False"></asp:Label></td>
                    </tr>
                     <tr>
                        <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">stock</asp:Label>
                        </td>
                        <td class="auto-style107">
                            <asp:TextBox ID="pStockMod" runat="server" Width="373px"></asp:TextBox>
                        </td>
                        <td><asp:Label ID="lEstock" runat="server" Font-Bold="True" Visible="False"></asp:Label></td>
                    </tr>
                            </table>
                            <table class="auto-style110">
                 <tr>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bEliminar" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/eliminarprod.png" Width="179px" CssClass="auto-style82" />
                        
                     </td>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bModificarpro" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/modificarpro.png" Width="179px" CssClass="auto-style82" />

                     </td>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bCancelarvolverAdmin" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/cancelaarvolver.png" Width="179px" CssClass="auto-style82" />

                     </td>
                 </tr>

             </table>
                            <br />
                            <asp:Label ID="Label10" runat="server" Font-Bold="True" Visible="False"></asp:Label>
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style252">
                                        <br />
                                    </td>
                                </tr>
                            </table>
               
        </asp:Panel>
         <asp:Panel ID="pEditarUsuario" runat="server"  Height="535px"    BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
             <table class="auto-style109">
                 <tr>
                    <td class="auto-style72" align="center">
                        <asp:Label runat="server"  Font-Size="24px" ForeColor="#4F443C"> Editar Usuario </asp:Label>
                    </td>
                 </tr>
                 </table>
                <table class="auto-style108"">
                  
                  <tr>
                       <td>
                                </td>
                      <td class="auto-style83">
                               <asp:DropDownList ID="dUsuario" runat="server" AutoPostBack="True" BackColor="White" ForeColor="Black" Height="61px" Width="516px" CssClass="auto-style105">
                </asp:DropDownList>
                      </td>
                      <td>
                                </td>
                  </tr>
           
                </table>
                <table class="auto-style111">
                      <tr>
                        <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">Nombre</asp:Label>
                        </td>
                        <td class="auto-style107">
                            <asp:TextBox ID="tNombreEdit" runat="server" Width="373px"></asp:TextBox>
                        </td>
                        <td>   &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">Apellido</asp:Label>
                        </td>
                        <td class="auto-style107">
                          <asp:TextBox ID="tApellidoEdit" runat="server" Width="373px"></asp:TextBox>
                            </td>
                        <td>  &nbsp;</td>
                    </tr>
                     <tr>
                        <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">D.N.I</asp:Label>
                        </td>
                        <td class="auto-style107">
                            <asp:TextBox ID="tDniEdit" runat="server" Width="373px"></asp:TextBox>
                        </td>

                        

                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                         <td class="auto-style112">
                            <asp:Label runat="server" ForeColor="#4F443C">Activo</asp:Label>
                        </td>
                        <td class="auto-style107">
                          <asp:TextBox ID="tActivoedit" runat="server" Width="373px"></asp:TextBox>
                            </td>
                        <td></td>
                    </tr>
                            </table>
                            <table class="auto-style110">
                 <tr>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bEliminarEdit" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/eliminarprod.png" Width="179px" CssClass="auto-style82" />
                        
                     </td>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bBloquear" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/bloquear.png" Width="179px" CssClass="auto-style82" />

                     </td>
                     <td class="auto-style6" align="center">
                     <asp:ImageButton ID="bDesbloquear" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/desbloquear.png" Width="179px" CssClass="auto-style82" />

                     </td>
                 </tr>

             </table>
                            <br />
                            <asp:Label ID="Label11" runat="server" Font-Bold="True" Visible="False"></asp:Label>
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style252">
                                        <asp:ImageButton ID="bTerminarvolveredit" runat="server" Height="65px"
                             ImageUrl="~/imagenes para Clase 4/cancelaarvolver.png" Width="200px" CssClass="auto-style113" />
                                    </td>
                                </tr>
                            </table>
             </asp:Panel>
        <asp:Panel ID="pVerPedidosUsuarios" runat="server" Height="535px"   BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
            <table class="auto-style254">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style172">
                        <asp:Label ID="lErrorVerPedidoadmin" runat="server" ForeColor="Red" Text="ErrorHistorico" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style257"></td>
                    <td class="auto-style258">
                        <asp:GridView ID="gVerPedidosTotales" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="196px" Width="708px">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Anular" Text="Anular Pedido" HeaderText="anular" />
                                <asp:BoundField DataField="Npedido" HeaderText="Nº pedido" ReadOnly="True" />
                                <asp:BoundField DataField="num_cli" HeaderText="Nº cliente" />
                                <asp:BoundField DataField="estado" HeaderText="estado" />
                                <asp:BoundField DataField="fecha" HeaderText="fecha" DataFormatString="{0:dd/MM/yyyy HH:mm:ss}" />
                                <asp:ButtonField ButtonType="Button" CommandName="PasarEnviado" HeaderText="pasar a enviado" Text="Enviado" />
                                <asp:ButtonField ButtonType="Button" CommandName="Editar" HeaderText="editar" Text="Editar" />
                            </Columns>
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style257"></td>
                </tr>
                </table>
            <table  class="auto-style2565">
                <tr>
                     <td class="auto-style124" align="center">
                     <asp:ImageButton ID="ImageButton1" runat="server" Height="51px"
                             ImageUrl="~/imagenes para Clase 4/actualizarr.png" Width="182px" CssClass="auto-style82" />
                        </td>
                    <td class="auto-style1323">

                        <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/imagenes para Clase 4/cancelaarvolver.png" Height="53px" Width="178px" CssClass="auto-style114" />
                    </td>
                     
                </tr>
            </table>
        </asp:Panel>
         <asp:Panel ID="pVerPedidoadmin" runat="server" Height="535px"   BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
            <table class="auto-style253" align="center">
                <tr>
                    <td class="auto-style115">
                        <asp:Label ID="lPedidoAnulado1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                </table>
                <table class="auto-style121">
                <tr>
                    <td class="auto-style118"></td>
                    <td class="auto-style120">
                        <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/imagenes para Clase 4/cancelaarvolver.png" Width="302px" Height="59px" />
                        
                    </td>
                    <td class="auto-style119"></td>
                </tr>
                    
            </table>
             <table>
                 <tr>
                   <td class="auto-style123"></td>
                    <td>
                        <asp:ImageButton ID="bTerminarYVolverPedidoAnulado" runat="server" ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="419px" Height="66px" />
                        
                    </td>
                    <td class="auto-style122"></td>
                </tr>
             </table>

        </asp:Panel>
        <asp:Panel ID="pEditarPedidos" runat="server" Height="535px"    BorderStyle="Solid" 
              Font-Size="Large"  Visible="false" CssClass="auto-style70" BorderColor="#4F443C">
            <table class="auto-style255">
                <tr>
                    <td>&nbsp;</td>
                    <td><strong><span class="auto-style215">Quitar ítem del pedido Nª </span>
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style125"></td>
                    <td class="auto-style125"><strong>
                        <asp:GridView ID="gVerUnPedidoEditar" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="152px" Width="707px">
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Quitar" Text="Quitar" />
                                <asp:BoundField DataField="Item" HeaderText="Item Solicitado" />
                                <asp:BoundField DataField="cantidad" HeaderText="Cant." />
                                <asp:BoundField DataField="NPedido" HeaderText="NPedido" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        </strong>
                        <br />
                       
                        <asp:ImageButton ID="bvolverpedidosadmin" runat="server" ImageUrl="~/imagenes para Clase 4/terminaarvolver.png" Width="357px" Height="67px" />
                        
                    </td>
                    <td class="auto-style125"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lErrorVerUnPedidoEditarQuitar" runat="server" ForeColor="Red" Text="Se ha producido un error." Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            </asp:Panel>
    </form>
</body>
</html>
