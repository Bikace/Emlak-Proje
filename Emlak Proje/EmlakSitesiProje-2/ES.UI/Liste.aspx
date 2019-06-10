<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Liste.aspx.cs" Inherits="ES.UI.Liste" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .dropdown {
            display: inline-block;
        }

        .kutu {
            border: 1px solid gray;
            height: 140px;
            width: 100%;
            line-height: 1.4;
            margin-bottom: 15px;
            min-width: 900px;
        }

            .kutu img.gorsel {
                height: 100%;
                width: 150px;
                float: left;
            }

        .kutu_baslik_yazi {
            padding-top: 5px;
        }

        .kutu_alt_yazi {
            font-size: 12px;
        }

        .odaSayisi {
        }

        .FiyatYazi {
            font-size: 27px;
            padding-bottom: 5px;
            display: block;
            font-weight: 600;
        }

        .OneCikanyazi {
            background-color: gold;
            font-size: 12px;
            font-weight: 500;
            color: white;
            float: right;
            margin-top: 10px;
            padding: 3px;
            border-radius: 5px;
        }

        .calender {
            width: 25px;
            height: 25px;
            float: right;
            margin-top: 50px;
        }

        .calenderYazi {
            margin-top: 50px;
            float: right;
            font-weight: 500;
        }

        .FavoriKutu {
            display: none;
            /*border: 1px solid black;*/
            height: 130px;
            width: 180px;
            background-color: white;
            float: right;
            padding: 7px;
        }

        .chehckboxByt {
            height: 20px;
            width: 20px;
        }

        #Kars {
            font-weight: 500;
        }

        #kontrol {
            margin-right: 10px;
        }

        .OneCikanyazi.True {
            visibility: visible;
        }

        .OneCikanyazi.False {
            visibility: hidden;
        }

        .btn2 {
            border: 1px solid gray;
            line-height: 2px;
        }

        .PB {
            text-align: right;
        }

        .aclass a {
            color: inherit;
        }

            .aclass a:hover {
                text-decoration: inherit;
                color: darkgray;
            }

        .kutu_baslik_yazi {
            padding-top: 0px;
        }

        .stil {
            margin-left: 20px;
            border: 1px solid black;
        }

        .stil1 {
            border: 1px solid black;
        }
    </style>
    <script type="text/javascript">
        function functionx(evt) {
            if (evt.charCode > 31 && (evt.charCode < 48 || evt.charCode > 57)) {
                alert("Sadece rakam giriniz");
                return false;
            }
        }


        $(document).ready(function () {


            $.ajax({
                type: 'GET',
                url: 'http://localhost:52387/api/default',
                success: function (data) {
                    console.log(data);
                    $.each(data, function (i, val) {
                        $("#ContentPlaceHolder1_ddIl").append('<option>' + val + '</option >')
                    });
                }
            });

            //$("#ContentPlaceHolder1_ddIlce").html("Tüm İlçeler")
            //$("#ContentPlaceHolder1_ddIlce").val("Tüm İlçeler")

            $("#ContentPlaceHolder1_ddIl").change(function () {
                debugger;
                var selectedIl = $("#ContentPlaceHolder1_ddIl option:selected").text();
                $("#ContentPlaceHolder1_hdn_il").val(selectedIl);
                $("#ContentPlaceHolder1_hdn_ilce").val("0");
                $.ajax({
                    type: 'GET',
                    url: 'http://localhost:52387/api/default?Il=' + selectedIl,
                    success: function (data) {
                        console.log(data);
                        $("#ContentPlaceHolder1_ddIlce").html("İlçeler")
                        $.each(data, function (i, val) {
                            $("#ContentPlaceHolder1_ddIlce").append('<option>' + val + '</option >')
                        });
                    }
                });
            });

            $("#ContentPlaceHolder1_ddIlce").change(function () {
                debugger;
                var selectedIlce = $("#ContentPlaceHolder1_ddIlce option:selected").text();
                $("#ContentPlaceHolder1_hdn_ilce").val(selectedIlce);
            });

        });

    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:HiddenField ID="hdn_il" runat="server" />
    <asp:HiddenField ID="hdn_ilce" runat="server" />

    <div class="row" style="background-color: rgb(245,246,247); margin-top: 10px;">
        <div class="col-12">

            <asp:DropDownList ID="ddKonutDurum" runat="server" CssClass="stil1 btn btn-default btn-sm dropdown-toggle">
                <asp:ListItem Text="Daire Tipleri" Value="0"> </asp:ListItem>
      <%--          <asp:ListItem Text="Kiralık" Value="1"> </asp:ListItem>
                <asp:ListItem Text="Satılık" Value="2"> </asp:ListItem>
                <asp:ListItem Text="Kiralık/Satılık" Value="3"> </asp:ListItem>--%>

            </asp:DropDownList>
            <asp:DropDownList ID="ddIl" CssClass="stil  btn btn-default btn-sm dropdown-toggle" runat="server" OnSelectedIndexChanged="ddIl_SelectedIndexChanged">
                <asp:ListItem Text="Tüm İlçeler" Value="0"> </asp:ListItem>

            </asp:DropDownList>

            <asp:DropDownList ID="ddIlce" CssClass="stil  btn btn-default btn-sm dropdown-toggle" runat="server">
                <asp:ListItem Text="Tüm İller" Value="0"> </asp:ListItem>

            </asp:DropDownList>
            <asp:TextBox ID="txtMaxFiyat" CssClass="stil btn btn-sm" onkeypress="return functionx(event)" placeholder="Fiyat Max Giriniz" runat="server" OnTextChanged="txtMaxFiyat_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtMinFiyat" CssClass="stil btn btn-sm" onkeypress="return functionx(event)" placeholder="Fiyat Min Giriniz" runat="server"></asp:TextBox>


            <asp:DropDownList ID="ddDaireTipi" CssClass="stil btn btn-default btn-sm dropdown-toggle" runat="server">

                <asp:ListItem Text="Daire Tipleri" Value="0"> </asp:ListItem>

                <asp:ListItem Text="1+0" Value="13"> </asp:ListItem>
                <asp:ListItem Text="1+1" Value="11"> </asp:ListItem>
                <asp:ListItem Text="2+1" Value="9"> </asp:ListItem>
                <asp:ListItem Text="3+1" Value="5"> </asp:ListItem>
                <asp:ListItem Text="2+1" Value="12"> </asp:ListItem>

            </asp:DropDownList>

            <asp:DropDownList ID="ddFiyatArtanAzalan" CssClass="stil  btn btn-default btn-sm dropdown-toggle" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddFiyatArtanAzalan_SelectedIndexChanged">

                <asp:ListItem Text="Fiyata Göre" Value="0"> </asp:ListItem>
                <asp:ListItem Text="FiyatAzalan" Value="1"> </asp:ListItem>
                <asp:ListItem Text="FiyatArtan" Value="2"> </asp:ListItem>

            </asp:DropDownList>
            <asp:DropDownList ID="ddTariheGore" CssClass="stil  btn btn-default btn-sm dropdown-toggle" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddTariheGore_SelectedIndexChanged">

                <asp:ListItem Text="Tarihe Göre" Value="0"> </asp:ListItem>
                <asp:ListItem Text="Yeniler" Value="1"> </asp:ListItem>
                <asp:ListItem Text="Eskiler" Value="2"> </asp:ListItem>

            </asp:DropDownList>

            <%-- <asp:Label ID="Label1" runat="server" Text="Ara: "></asp:Label>--%>
            <asp:TextBox ID="txtAra" CssClass="stil  btn btn-default btn-sm dropdown-toggle" placeholder="Arama yapabilirsiniz" runat="server">  </asp:TextBox>
            <asp:Button ID="btnAra" CssClass="stil  btn btn-default btn-sm btn-primary" runat="server" Text="Ara" OnClick="btnAra_Click" />

        </div>

    </div>

    <div class="row">

        <div class="col-xl-4 col-md-8 col-sm-12" style="margin-top: 50px">
            <div class="row justify-content-center">

                <div class="col-9" style="line-height: 0.1">

                    <div><strong>Portfoy Bilgisi</strong> </div>
                    <hr />
                    <div>
                        Kiralık Konut Sayısı
                        <div class="PB">
                            <asp:Label ID="lblkiralikKonutSayisi" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>

                    <hr />
                    <div>
                        Satılık Konut Sayısı
                        <div class="PB">
                            <asp:Label ID="lblsatilikKonutSayisi" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>
                    <hr />
                    <div>
                        Toplam İlan Sayısı
                        <div class="PB">
                            <asp:Label ID="lbltoplamIlanSayisi" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>
                    <hr />
                    <div>
                        Konut Adedi
                        <div class="PB">
                            <asp:Label ID="lblKonutAdedi" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>
                    <hr />
                    <div>
                        Ofis Adedi
                        <div class="PB">
                            <asp:Label ID="lblOfisAdedi" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>
                </div>

            </div>


        </div>
        <div class="col-xl-8 col-md-10 col-sm-12" style="margin-top: 60px">

            <div class="row">
                <asp:Label ID="lblPortfoy" runat="server" Text="Label"></asp:Label>
                <asp:Repeater ID="rptPortfoy" runat="server">
                    <ItemTemplate>
                        <div class="row kutu aclass" id="bkutu2">
                            <a href="Detay.aspx?id=<%# Eval("PortfoyID") %>">
                                <img class="gorsel" src="Assets\Images\KucukFoto\<%#Eval("KapakFotoYol")%>" />

                                <div class="col justify-content-center">

                                    <div class="OneCikanyazi <%# Eval("OneCikan") %>">ÖNE ÇIKAN</div>
                                    <div class="kutu_baslik_yazi"><strong><%# Eval("AciklamaBaslik") %></strong> </div>

                                    <div class="kutu_alt_yazi">Daire <%# Eval("Emlak.Adre.Il") %>-<%# Eval("Emlak.Adre.Ilce") %></div>
                                    <p class="calenderYazi"><%# Eval("CreateDate","{0:d}") %></p>
                                    <img class="calender" src="Assets\Images\calender.png" />
                                    <div class="odaSayisi">

                                        <i style="background-image: url('Assets/Images/Search.png'); background-position: 608px 184px; width: 25px; height: 22px; display: inline-block"></i>
                                        <p class="kutu_alt_yazi d-inline-block"><strong><%# Eval("Emlak.DaireTip.Adi") %></strong></p>

                                        <i style="background-image: url('Assets/Images/Search.png'); background-position: 615px 89px; width: 25px; height: 22px; display: inline-block"></i>
                                        <p class="kutu_alt_yazi d-inline-block"><strong><%# Eval("Emlak.NetMetreKare") %> m2</strong></p>

                                        <i style="background-image: url('Assets/Images/Search.png'); background-position: 826px 89px; width: 26px; height: 22px; display: inline-block"></i>
                                        <p class="kutu_alt_yazi d-inline-block" style="font-size: 13px"><strong><%# Eval("Emlak.KatSayisi") %>.Kat</strong></p>

                                        <p class="FiyatYazi"><%# Eval("FiyatMax","{0:###,##}") %>TL </p>

                                    </div>
                            </a>
                        </div>

                        <div class="FavoriKutu" id="fkutu2">

                            <button class="btn btn-light btn-block btn-md btn2" style="font-weight: 500">
                                <img src='Assets/Images/kalp.png' height="23" width="23" style="padding-right: 5px;" />Favorilere Ekle</button>
                            <button class="btn btn-light btn-block btn-md btn2" style="height: 36px;" id="Button1">
                                <input type="checkbox" id="Checkbox1">Karşılaştır</button>
                            <button class="btn btn-success btn-block btn-md btn2">
                                <img src='Assets/Images/telefon.png' height="21" width="21" style="padding-right: 5px;" />Telefona Bak</button>


                        </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
