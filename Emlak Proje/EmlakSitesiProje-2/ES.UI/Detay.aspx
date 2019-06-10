<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Detay.aspx.cs" Inherits="ES.UI.Detay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .menu .bg-dark {
            background-color: #009cfb;
        }

        #alan {
            margin-top: 20px;
            line-height: 30px;
            max-width: 250px;
            width: auto;
            background-color: #3c4d53;
        }

            #alan p {
                color: #fff;
                font-size: 15px;
            }

            #alan a {
                color: #a7b9bf;
            }

                #alan a:hover {
                    color: limegreen;
                }

            #alan li {
                list-style-type: none;
            }


        #footlogo li {
            list-style-type: none;
            float: left;
            text-align: center;
            color: #ffffff;
        }

        #footmarka li {
            list-style-type: none;
            float: left;
            text-align: center;
        }

        #footson li {
            list-style-type: none;
            float: left;
            text-align: center;
            max-width: 250px;
            width: auto;
            font-size: 12px;
            display: block;
            margin: 5px;
        }

        #footson a {
            color: #a7b9bf;
        }

        #footer4 {
            background-color: #344348;
        }



        #ust {
            width: 100%;
            margin: auto;
        }

        #alt {
            margin: auto;
        }

        #sol {
            height: auto;
            font-size: 18px;
            font-weight: 700;
            text-align: left;
            font-family: sans-serif;
            color: #3c4d53;
            margin-top: 5px;
        }


        #cont2 {
            background-color: #f5f6f7;
            margin-top: 80px;
            margin-bottom: 20px;
        }

        #harita {
            margin: auto;
        }

        #sag {
            vertical-align: middle;
        }


        .bilgi {
            list-style-type: none;
            margin: 0;
            padding: 0;
            border: 1px solid #cdd6de;
            text-align: center;
        }

            .bilgi li {
                display: inline-block;
                padding: 2px;
                margin-left: 10px;
                font-weight: 700;
            }




        #ilan {
            /*margin: 0;*/
            /*vertical-align: baseline;*/
            color: #52ca46;
            /*transition: all .2s;*/
            display: none;
            width: auto;
            height: 30px;
            line-height: 30px;
            text-align: center;
            font-size: 12px;
            /*letter-spacing: -.2px;*/
            font-weight: 500;
            border: 1px solid #cdd6de;
            margin-right: 10px;
            /*cursor: pointer;*/
            padding: 0 20px;
            display: inline-block;
            text-decoration: none;
        }

        .breadcrumb {
            padding: 5px;
            background-color: transparent;
            font-size: 13px;
        }

            .breadcrumb a {
                color: rgba(0,0,0,.4);
            }

                .breadcrumb a:hover {
                    text-decoration: none;
                    color: #52ca46;
                }



        #altsolbir {
            background-color: white;
            border: 1px solid #cdd6de;
            line-height: 45px;
        }


            #altsolbir ul {
                list-style-type: none;
                margin: 0;
                padding: 0;
            }

                #altsolbir ul li {
                    display: inline-block;
                }

                    #altsolbir ul li a {
                        color: #3c4d53;
                        text-decoration: none;
                        padding: 10px;
                    }

                        #altsolbir ul li a:hover {
                            text-decoration: none;
                            border-top: 3px solid #52ca46;
                        }

                        #altsolbir ul li a:active {
                            text-decoration: none;
                            border-top: 3px solid #52ca46;
                        }

        #altsagbir {
            text-align: center;
            padding-top: 20px;
            background-color: white;
            border: 1px solid #cdd6de;
        }


        #altsagiki {
            padding-top: 20px;
            /*padding-left: 40px;*/
            font-size: 15px;
            padding-bottom: 20px;
            background-color: white;
            border: 1px solid #cdd6de;
        }

        #altsaguc {
            border: 1px solid #cdd6de;
            /*padding-left: 80px;*/
            line-height: 100px;
            background-color: white;
        }

            #altsaguc a {
                color: #52ca46;
            }

                #altsaguc a:hover {
                    text-decoration: none;
                }

        #altsagdort {
            border: 1px solid #cdd6de;
            background-color: white;
            margin-top: 30px;
            /*padding-left: 90px;*/
            line-height: 50px;
            color: #3c4d53;
        }


            #altsagdort:hover {
                background-color: #f5f6f7;
                color: #52ca46;
                text-decoration: none;
            }

        #altsagbes {
            margin-top: 30px;
            padding-left: 90px;
        }

            #altsagbes a:hover {
                text-decoration: none;
            }


        #altsoliki {
            background-color: white;
            border: 1px solid #cdd6de;
            /*padding-left:40px;*/
        }


        #altsoluc {
            background-color: white;
            border: 1px solid #cdd6de;
            color: #3c4d53;
            font-size: 14px;
            font-weight: 500;
            line-height: 50px;
        }

            #altsoluc ul {
                list-style-type: none;
                margin: 0;
                padding: 0;
            }

                #altsoluc ul a {
                    display: inline-block;
                    width: 173px;
                    text-align: center;
                    color: #3c4d53;
                }

                    #altsoluc ul a:hover {
                        background-color: #f5f6f7;
                        border-right: 1px solid #cdd6de;
                        border-left: 1px solid #cdd6de;
                        text-decoration: none;
                    }

        #altsoldort {
            background-color: white;
            border: 1px solid #cdd6de;
            margin-top: 30px;
            padding: 30px;
        }

        .binabilgi {
            margin: 0;
            padding: 0;
            list-style-type: none;
        }

            .binabilgi li {
                display: inline-block;
                font-size: 14px;
            }


        #altsolbes {
            background-color: white;
            border: 1px solid #cdd6de;
        }


        .ozellik {
            padding-top: 20px;
            border-right: 1px solid #cdd6de;
        }

            .ozellik ul {
                list-style-type: none;
                color: #3c4d53;
            }

                .ozellik ul li {
                    line-height: 35px;
                }

                 .buyukcerceve {
            width: 630px;
            height: 300px;
        }

        .buyukresim {
            width: 100%;
            height: 100%;
            margin-left: 0px;
        }

        .cerceve {
            width: 630px;
            height: 100px;
            overflow: hidden;
        }

        .resim {
            width: 100%;
            height: 100%;
        }

        .kutu {
            position: relative;
            background-color: red;
            width: 100px;
            height: 100px;
            float: left;
            display: inline-block;
            margin: 2px;
            font-size: 40px;
            opacity: 0.6;
            cursor: pointer;
        }

        .sag-ok {
            position: relative;
            top: 335px;
            left: 620px;
            width: 40px;
            height: 30px;
            display: inline-block;
            background-color: lavender;
            text-align: center;
            font-weight: bold;
            border: 2px solid gray;
            border-radius: 10px;
            z-index: 21;
            cursor: pointer;
        }

        .sol-ok {
            position: relative;
            top: 335px;
            left: 90px;
            width: 40px;
            height: 30px;
            display: inline-block;
            background-color: lavender;
            text-align: center;
            font-weight: bold;
            border: 2px solid gray;
            border-radius: 10px;
            z-index: 20;
            cursor: pointer;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" id="cont2">
        <div class="row" id="ust">
            <div class="col-lg-8" id="sol">
                <asp:Label ID="lblaciklama" runat="server" Text="Label"></asp:Label><%--Tekirdağ çorlu reşadiye mah 3+1 130 m2 kiralık esila emlaktan--%>
            </div>
            <div class="col-lg-4" id="sag">

                <ul class="bilgi">
                    <li>
                        <img src="assets\Images\koltuk.png" /><asp:Label ID="lblodaSayisi" runat="server" Text="Label"></asp:Label></li>
                    <li>
                        <img src="assets\Images\m2.png" /><asp:Label ID="lblMetreKare" runat="server" Text="Label"></asp:Label>m</li>
                    <li>
                        <img src="assets\Images\kat.png" /><asp:Label ID="lblKatSayisi" runat="server" Text="Label"></asp:Label>. kat</li>
                    <li style="font-size: 22px; border-left: 1px solid #cdd6de;">&nbsp;
                        <asp:Label ID="lblFiyatMax" runat="server" Text="Label"></asp:Label>
                        TL&nbsp;</li>

                </ul>

            </div>
        </div>
        <div class="row" id="harita">

            <a id="ilan" href="https://www.emlakjet.com/kiralik-daire/tekirdag-corlu-resadiye-mahallesi">&#8592;Bölgedeki İlanlar
            </a>

            <nav aria-label="breadcrumb" id="breadcrumb">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item">
                        <asp:LinkButton ID="linkKonutDurum" runat="server" PostBackUrl="">
                            <asp:Label ID="lblKonutDurum2" runat="server" Text="Label"></asp:Label>
                        </asp:LinkButton></li>
                    <li class="breadcrumb-item">
                        <asp:LinkButton ID="linkTur" runat="server" PostBackUrl="">
                            <asp:Label ID="lblTur" runat="server" Text="Label"></asp:Label>
                        </asp:LinkButton></li>
                    <li class="breadcrumb-item">
                        <asp:LinkButton ID="linkIl" runat="server" PostBackUrl="">
                            <asp:Label ID="lblIl" runat="server" Text="Label"></asp:Label>
                        </asp:LinkButton></li>
                    <li class="breadcrumb-item">
                        <asp:LinkButton ID="linkIlce" runat="server" PostBackUrl="">
                            <asp:Label ID="lblIlce" runat="server" Text="Label"></asp:Label>
                        </asp:LinkButton></li>

                </ol>
            </nav>





        </div>


        <div class="row justify-content-between" id="alt">
            <div class="col-sm-8 col-md-8 col-lg-8 col-xl-8" id="altsol">
                <div class="bosluk">
                    <div class="row" id="altsolbir">
                        <ul>
                            <li><a href="#">Fotoğraf</a></li>
                            <li><a href="#">Harita</a></li>
                            <li><a href="#" style="border-left: 1px solid #cdd6de">
                                <img src="assets\Images\kalp.png" /></a></li>
                            <li><a href="#" style="border-left: 1px solid #cdd6de">
                                <img src="assets\Images\paylas.png" /></a></li>
                        </ul>
                    </div>


                    <div class="row justify-content-center" id="altsoliki">



                        <div class="sol-ok"><<</div>
                        <div class="sag-ok">>></div>
                        <div id="carousel">
                            <asp:Repeater ID="rptCarouselBuyukFotograf" runat="server">
                                <ItemTemplate>
                                    <div class="buyukcerceve">
                                        <img class="buyukresim" src="Assets\Images\BuyukFoto\<%#Eval("BuyukFotoYol")%>" />
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                            <div class="cerceve">
                                <asp:Repeater ID="rptCarouselKucukFotograf" runat="server">
                                    <ItemTemplate>
                                        <div class="kutu">
                                            <img class="resim" src="Assets\Images\KucukFoto\<%#Eval("KucukFotoYol")%>" />
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>

                        </div>

                    </div>


                    <div class="row" id="altsoluc">
                        <div class="col">
                            <ul>
                                <a href="#">
                                    <li>Yakındaki İlanlar</li>
                                </a>
                                <asp:LinkButton ID="linkEmlakcininTumIlanlari" runat="server">
                               
                                    <li>Emlakçının Tüm İlanları</li>
                                </asp:LinkButton>
                                <a href="#">
                                    <li>Fiyatı Takip Et</li>
                                </a>
                                <a href="#">
                                    <li>Mesaj Gönder</li>
                                </a>


                            </ul>
                        </div>

                    </div>


                    <div class="row" id="altsoldort">
                        <div class="col-12">
                            Açıklama
                                <br />
                            <br />
                            <p style="font-style: italic; font-family: sans-serif; line-height: 24px; font-weight: 300">
                                <asp:Label ID="lblAciklama2" runat="server" Text="Label"></asp:Label>
                            </p>

                            <br />
                            <p style="font-weight: bold; font-weight: 400">İlan Künyesi</p>

                        </div>

                        <div class="col-lg-6">
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>İlan Numarası</li>
                                <li style="float: right; font-weight: 500;">7028725</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>İlan Oluşturma Tarihi</li>
                                <li style="float: right; font-weight: 500;">25.02.2019</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>İlan Güncelleme Tarihi</li>
                                <li style="float: right; font-weight: 500;">02.03.2019</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Türü</li>
                                <li style="float: right; font-weight: 500;">Daire</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Kategori</li>
                                <li style="float: right; font-weight: 500;">
                                    <asp:Label ID="lblkonutDurumu" runat="server" Text="Label"></asp:Label></li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Cinsi</li>
                                <li style="float: right; font-weight: 500;"></li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Site İçerisinde</li>
                                <li style="float: right; font-weight: 500;">Hayır</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Yapı Tipi</li>
                                <li style="float: right; font-weight: 500;">-</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Bina Yaşı</li>
                                <li style="float: right; font-weight: 500;">
                                    <asp:Label ID="lblbinaYasi" runat="server" Text="Label"></asp:Label></li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Kat Sayısı</li>
                                <li style="float: right; font-weight: 500;">
                                    <asp:Label ID="lblkatSayisi2" runat="server" Text="Label"></asp:Label></li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Daire Katı</li>
                                <li style="float: right; font-weight: 500;">3. Kat</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Isıtma</li>
                                <li style="float: right; font-weight: 500;">Kombi Doğalgaz</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Aidat</li>
                                <li style="float: right; font-weight: 500;"></li>
                            </ul>


                        </div>
                        <div class="col-lg-6">
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Kullanım Durumu</li>
                                <li style="float: right; font-weight: 500;">Boş</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Brüt Metrekare</li>
                                <li style="float: right; font-weight: 500;">
                                    <asp:Label ID="lblbrutMetrekare" runat="server" Text="Label"></asp:Label>m2</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Net Metrekare</li>
                                <li style="float: right; font-weight: 500;">
                                    <asp:Label ID="lblMetreKare2" runat="server" Text="Label"></asp:Label>m2</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Salon Metrekare</li>
                                <li style="float: right; font-weight: 500;">-</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Oda sayısı</li>
                                <li style="float: right; font-weight: 500;">
                                    <asp:Label ID="lblodaSayisi2" runat="server" Text="Label"></asp:Label></li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Banyo Sayısı</li>
                                <li style="float: right; font-weight: 500;">
                                    <asp:Label ID="lblbanyoSayisi" runat="server" Text="Label"></asp:Label></li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>
                                WC Sayısı/li>
                                    <li style="float: right; font-weight: 500;">
                                        <asp:Label ID="lblwcsayisi" runat="server" Text="Label"></asp:Label></li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Takas</li>
                                <li style="float: right; font-weight: 500;">-</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Yapı Durumu</li>
                                <li style="float: right; font-weight: 500;">-</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Eşya Durumu</li>
                                <li style="float: right; font-weight: 500;">-</li>
                            </ul>
                            <hr style="background-color: #cdd6de;" />
                            <ul class="binabilgi">
                                <li>Depozito</li>
                                <li style="float: right; font-weight: 500;">
                                    <asp:Label ID="lbldepozito" runat="server" Text="Label"></asp:Label>
                                    TRY</li>
                            </ul>



                        </div>


                    </div>

                    <div class="row" style="margin-top: 50px; font-weight: bold; margin-bottom: 20px;">
                        Özellikler
                    </div>

                    <div class="row justify-content-center" id="altsolbes">

                        <div class="col-lg-4 ozellik">

                            <p style="padding-left: 40px; font-weight: 500">İç Özellikler</p>
                            <ul>
                                <li>
                                    <asp:Image ID="Image3" runat="server" />
                                    <asp:Image ID="imgAcikBalkon" runat="server" ImageUrl="" />&nbsp;Açık Balkon</li>
                                <li>
                                    <asp:Image ID="imgCelikKapi" runat="server" ImageUrl="" />&nbsp;Çelik Kapı</li>
                                <li>
                                    <asp:Image ID="imgDolaplıMutfak" runat="server" ImageUrl="" />&nbsp;Dolaplı Mutfak</li>
                                <li>
                                    <asp:Image ID="imgDusakabin" runat="server" ImageUrl="" />&nbsp;Duşakabinli</li>
                                <li>
                                    <asp:Image ID="imgFransizBalkon" runat="server" ImageUrl="" />&nbsp;Fransız Balkon</li>
                                <li>
                                    <asp:Image ID="imgKapaliBalkon" runat="server" ImageUrl="" />&nbsp;Kapalı Balkon</li>
                                <li>
                                    <asp:Image ID="imgKartonpiyer" runat="server" ImageUrl="" />&nbsp;Kartonpiyer</li>
                                <li>
                                    <asp:Image ID="imgLaminant" runat="server" ImageUrl="" />&nbsp;Laminant</li>
                                <li>
                                    <asp:Image ID="imgOcakDogalgazi" runat="server" ImageUrl="" />&nbsp;Ocak Doğalgazı</li>
                                <li>
                                    <asp:Image ID="imgSeramikZemin" runat="server" ImageUrl="" />&nbsp;Seramik Zemin</li>
                                <li>
                                    <asp:Image ID="imgSicakSu" runat="server" ImageUrl="" />&nbsp;Sıcak Su</li>


                            </ul>




                        </div>



                        <div class="col-lg-4 ozellik">
                            <p style="padding-left: 40px; font-weight: 500">Dış Özellikler</p>
                            <ul>
                                <li>
                                    <asp:Image ID="imgAsansor" runat="server" ImageUrl="" />&nbsp;Asansör</li>
                                <li>
                                    <asp:Image ID="imgGuneyCepheli" runat="server" ImageUrl="" />&nbsp;Güney Cepheli</li>
                                <li>
                                    <asp:Image ID="imgHidrofor" runat="server" ImageUrl="" />&nbsp;Hidrofor</li>
                                <li>
                                    <asp:Image ID="imgısıYalıtım" runat="server" ImageUrl="" />&nbsp;Isı Yalıtımı</li>



                            </ul>
                        </div>

                        <div class="col-lg-4 ozellik">
                            <p style="padding-left: 40px; font-weight: 500">Konum Özellikleri</p>
                            <ul>
                                <li>
                                    <asp:Image ID="imgcaddeYakin" runat="server" ImageUrl="" />&nbsp;<asp:Label ID="lblcaddeyeYakin" runat="server" Text="Label"></asp:Label></li>
                                <li>
                                    <asp:Image ID="imgdolmus" runat="server" ImageUrl="" />&nbsp;Dolmuş</li>
                                <li>
                                    <asp:Image ID="imgokulaYakin" runat="server" ImageUrl="" />&nbsp;Okula Yakın</li>



                            </ul>
                        </div>


                        <br />
                        <br />
                        <br />


                    </div>

                </div>
            </div>
            <div class="col-sm-4 col-md-4 col-lg-4 col-xl-4" id="altsag">

                <div class="row justify-content-center" id="altsagbir" style="margin-left: 5px;">

                    <p style="color: #52ca46;">ESİLA EMLAK</p>
                    <hr style="background-color: #52ca46; width: 300px" />
                    <p>
                        İlan No:&nbsp; <b>
                            <asp:Label ID="lblIlanNo" runat="server" Text="Label"></asp:Label></b>
                    </p>

                </div>
                <div class="row justify-content-center" id="altsagiki" style="margin-left: 5px;">
                    <div class="col">
                        <p style="font-weight: 500">
                            <img src="assets\Images\avtr.png">
                            &nbsp;<asp:Label ID="lblpersonel" runat="server" Text="Label"></asp:Label>
                        </p>
                        <br />
                        <ul style="margin: 0; padding: 0; list-style-type: none;">
                            <li style="float: left; display: inline-block;">
                                <img src="assets\Images\tlfn.png">
                                &nbsp;</li>
                            <a href="#">
                                <li style="float: left; display: inline-block; line-height: 50px; display: block; width: 250px; text-align: center; background-color: #52ca46; color: white; font-size: 20px; font-weight: 400">Telefona Bak</li>
                            </a>
                        </ul>

                    </div>
                </div>
                <div class="row justify-content-center" id="altsaguc" style="margin-left: 5px;">
                    <asp:LinkButton ID="linkPersonel" runat="server">Bu Emlakçının Diğer İlanları &#8594;</asp:LinkButton>
                </div>


                <a href="#" style="text-decoration: none">
                    <div class="row justify-content-center" id="altsagdort" style="margin-left: 5px;">
                        <img src="assets\Images\bayrak.png">
                        &nbsp;
                                Hatalı İlan Bildir

                    </div>
                </a>



                <div class="row" id="altsagbes" style="margin-left: 5px;">
                    <!--<img src="assets\Images\unlem.png"> &nbsp;-->
                    <a href="#" style="color: #7b8d93; font-size: 12px; font-weight: 300;">Emlak alırken bunlara dikkat edin</a>

                </div>


            </div>
        </div>

    </div>


     <script src="Assets\js\Jquery\jquery-3.3.1.js"></script>
    <script src="Assets\js\Jquery\jquery-ui.js"></script>
    <script src="Assets\js\Jquery\jquery-3.3.1.min.js"></script>
    <script src="Assets\js\Jquery\Carousel.js"></script>
</asp:Content>
