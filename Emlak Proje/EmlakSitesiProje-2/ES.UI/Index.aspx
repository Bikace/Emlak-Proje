<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ES.UI.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #oneCikanlar .kutu {
            margin: 20PX;
            border-radius: 5px;
            border: 1px solid grey;
        }

        #oneCikanlar .kutuyazi1 {
            color: gray;
        }

        .aclass a {
            color: inherit;
        }

        aclass a:hover {
            text-decoration: inherit;
        }

        #oneCikanlar .kutuyazi2 {
            color: darkslategray;
            font-size: 15px;
            max-height: 20px;
        }

        #oneCikanlar .kuturesim img {
            width: 100%;
            border-top-left-radius: 5px;
            border-top-right-radius: 5px;
        }

        #oneCikanlar #icerik {
            margin-bottom: 30px;
        }

        #oneCikanlar .menu {
            color: white;
            text-align: center;
        }

        #oneCikanlar #ustmenu {
            background-color: #009cfb;
        }

        #oneCikanlar #banner img {
            max-width: 12000px;
            max-height: 500px;
            height: 100%;
            width: 100%;
            margin: auto;
        }

        #oneCikanlar #yazi {
            margin-left: 20px;
            color: cornflowerblue;
            font-size: 30px;
            margin-top: 20px;
        }

        #oneCikanlar #bolum img {
            margin: 7px;
            width: 100%;
        }

        #oneCikanlar #persbolum {
            margin-top: 100px;
            margin-bottom: 100px;
        }

        #oneCikanlar .persresim {
            margin: 10px;
        }

        #oneCikanlar .buyut {
            transition: all .2s ease-in-out;
        }

            #oneCikanlar .buyut:hover {
                transform: scale(1.2);
            }

        #oneCikanlar .persyazi {
            text-align: center;
            color: #00458B;
            font-size: 13px;
        }


        #oneCikanlar #alan {
            margin-top: 20px;
            line-height: 30px;
            max-width: 250px;
            width: auto;
            background-color: #3c4d53;
        }

            #oneCikanlar #alan p {
                color: #fff;
                font-size: 15px;
            }

            #oneCikanlar #alan a {
                color: #a7b9bf;
            }

                #oneCikanlar #alan a:hover {
                    color: limegreen;
                }

            #oneCikanlar #alan li {
                list-style-type: none;
            }


        #oneCikanlar #footlogo li {
            list-style-type: none;
            float: left;
            text-align: center;
            color: #ffffff;
        }

        #oneCikanlar #footmarka li {
            list-style-type: none;
            float: left;
            text-align: center;
        }

        #oneCikanlar #footson li {
            list-style-type: none;
            float: left;
            text-align: center;
            max-width: 250px;
            width: auto;
            font-size: 12px;
            display: block;
            margin: 5px;
        }

        #oneCikanlar #footson a {
            color: #a7b9bf;
        }

        #oneCikanlar #footer4 {
            background-color: #344348;
        }

        #oneCikanlar .kategoriItem {
            width: 100%;
            height: 100%;
            position: relative;
        }

            #oneCikanlar .kategoriItem .textArea {
                width: 100%;
                height: 100%;
                position: absolute;
                top: 0;
                margin: 7px;
            }

        #oneCikanlar .icyazi {
            margin-top: 20px;
            font-size: 50px;
            font-weight: 400;
            /*text-align: left;*/
            width: 15%;
            /*line-height:1.14;*/
            padding-top: 10px;
            margin-left: 70px;
            color: white;
            letter-spacing: 1px;
            line-height: 1.3;
        }

        #oneCikanlar .orange {
            background-color: #ffaa19;
            font-size: 12px;
            width: 150px;
            color: white;
            text-align: center;
            margin-top: 50px;
            margin-left: 70px;
        }

            #oneCikanlar .orange p {
                padding: 6px 10px 6px 10px;
            }

        #oneCikanlar .altyazi {
            width: 50%;
            color: white;
            font-size: 18px;
            margin-left: 70px;
            font-weight: 500;
            margin-top: 50px;
        }

        #oneCikanlar .buton {
            width: 40%;
            background-color: #f16666;
            font-size: 18px;
            color: white;
            padding: 10px 5px 10px 20px;
            font-weight: 500;
            margin-left: 10%;
            margin-top: 10%;
            border-radius: 3px;
        }

        #oneCikanlar .baslik {
            margin-left: 10%;
            margin-top: 10%;
            width: 280px;
            color: #263238;
            font-size: 29px;
            text-align: left;
            font-weight: 500;
        }

        #oneCikanlar .sagyazi {
            font-size: 16px;
            font-weight: 300;
            line-height: 1.31;
            text-align: left;
            color: #64777d;
            margin-top: 25px;
            margin-bottom: 25px;
            margin-left: 10%;
            width: 160px;
        }

        .red {
            background-color: red;
        }

        .white {
            background-color: white;
        }

        .pink {
            background-color: pink;
        }

        .border {
            border: 50px solid white;
        }

        .blue {
            background-color: blue;
        }

        .gray {
            background-color: white;
        }

        .whitesmoke {
            background-color: whitesmoke;
        }

        .minHeight300 {
            min-height: 400px;
        }

        .baslıkrengi {
            background-color: #3795f5;
            margin: 0px;
        }

        .bgblue {
            background-color: #3795f5 !important;
        }

        #banner img {
            max-width: 1838px;
            max-height: 920px;
            width: 100%;
            height: 100%;
            margin: auto;
        }

        #logo img {
            margin-left: 100px;
            margin-right: 10px;
            max-width: 70px;
            max-height: 37px;
            width: 100%;
            height: 100%;
            margin-bottom: 0px;
        }

        .text {
            color: white;
            list-style-type: none;
            position: relative;
            display: inline;
            margin-top: 0px;
            margin-right: 20px;
            margin-left: 20px;
            margin-bottom: 0px;
            padding: 5px;
        }

        .ılanver {
            border: 1px solid whitesmoke;
            border-radius: 10px;
            background-color: whitesmoke;
            padding: 5px;
            margin-left: 11px;
            margin-top: 3px;
            margin-bottom: 5px;
            padding-top: 5px;
            padding-bottom: 5px;
            color: #3795f5;
            list-style-type: none;
        }

        .text1 {
            color: black;
            list-style-type: none;
            position: relative;
            display: inline;
            vertical-align: middle;
        }

        .text2 {
            color: white;
            list-style-type: none;
            padding: 5px;
            border: 1px solid aqua;
            border-top: none;
            border-bottom: none;
            margin-top: 4px;
            margin-bottom: 0px;
        }

        .text3 {
            color: white;
            list-style-type: none;
            padding: 5px;
            border: 1px solid aqua;
            border-left: none;
            border-top: none;
            margin-bottom: 0px;
            margin-top: 4px;
            border-bottom: none;
        }

        .yellow {
            background-color: yellow;
        }

        .pink {
            background-color: #3c4d53;
        }

        .content {
            margin: 50px;
        }

        .calisanlar_fotograf img {
            width: 100%;
            height: 100%;
            max-width: 100%;
            max-height: 100%;
        }



        .text-block {
            position: absolute;
            top: 100px;
            left: 30px;
            padding-left: 20px;
            padding-right: 20px;
            line-height: 1.1;
            font-family: 'Times New Roman';
        }

        .text-block2 {
            position: absolute;
            top: 333px;
            left: 30px;
            padding-left: 20px;
            padding-right: 20px;
            line-height: 1.1;
            font-size: 20px;
            color: brown;
            font-family: 'Times New Roman';
        }

        .text-block3 {
            position: absolute;
            top: 460px;
            left: 45px;
            border-radius: 6px;
            padding: 8px;
            line-height: 1.1;
            font-size: 20px;
            color: white;
            background-color: #f16666;
            font-family: 'Times New Roman';
        }

        .text-block4 {
            position: absolute;
            top: 10px;
            left: 25px;
            padding: 8px;
            line-height: 50px;
            font-size: 40px;
            color: black;
            font-family: 'Times New Roman';
        }

        .text-block5 {
            position: absolute;
            top: 163px;
            left: 32px;
            font-family: 'Times New Roman';
            color: brown;
            font-size: 20px;
        }

        .text-block6 {
            position: absolute;
            top: 240px;
            left: 32px;
            border-radius: 3px;
            padding: 6px 10px 6px 10px;
            line-height: 1.1;
            font-size: 20px;
            color: white;
            background-color: #f16666;
            font-family: 'Times New Roman';
        }

        .text-block7 {
            position: absolute;
            top: 54px;
            left: 32px;
            font-family: 'Times New Roman';
            color: black;
            font-size: 19px;
            line-height: 19px;
        }

        .resimüstyazı {
            position: absolute;
            top: 40px;
            left: 50px;
            padding-left: 6px;
            padding-right: 6px;
            border-radius: 5px;
            padding-top: 3px;
            padding-bottom: 3px;
            background-color: #ffaa19;
            font-family: 'Times New Roman';
            color: white;
        }

        .imagetext {
            font-size: 56px;
            font-family: MuseoSans,sans-serif;
        }


        .btn-primary2 {
            background-color: #3795f5;
        }
    </style>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="banner">
        <div id="carouselExampleControls" class="carousel slide" data-ride="carousel" style="text-align: center">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="Assets\Images\Ev7.jpg" width="90%" height="700">
                </div>
                <div class="carousel-item">
                    <img src="Assets\Images\Anasayfaresim.jpg" width="90%" height="700">
                </div>
                <div class="carousel-item">
                    <img src="Assets\Images\Ev11.jpg" width="90%" height="700">
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>
    <div id="oneCikanlar" class="container">
        <div class="row">
            <div class="col-10" id="yazi">
                Öne Çıkan İlanlar
            </div>
        </div>

        <div id="icerik" class="row justify-content-center">
            <asp:Repeater ID="rptOneCikanlar" runat="server">
                <ItemTemplate>
                    <div class="col-lg-3 col-md-3 col-sm-6 col-xs-12">
                        <div class="kutu">
                            <div class="kuturesim">
                                <img src="Assets\Images\BuyukFoto\<%#Eval("KapakFotoYol")%>" />
                            </div>
                            <div class="kutuyazi1 text-truncate"><%# Eval("Emlak.KonutDurum.Adi") %></div>
                            <div class="kutuyazi2 text-truncate"><%# Eval("AciklamaBaslik") %> </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <div id="reklampanel" class="row">

        <div class="col-md-6 col-sm-12 col-xs-12 white aclass">
            <a href="Liste.aspx?DaireTipID=11&konutDurumID=2">
                <img src="Assets\Images\oda1.jpg" style="opacity: 0.6">
                <div class="resimüstyazı"><b>EMLAKJET'İN SEÇİMİ</b></div>
                <div class="text-block">
                    <div class="imagetext"><b>1+1</b></div>
                    <div class="imagetext"><b>Satılık</b> </div>
                    <div class="imagetext"><b>Daireler </b></div>
                </div>
                <div class="text-block2">
                    <div><b>Bana küçük bir ev de yeter </b></div>
                    <div><b>diyenlere... Gönlünüze göre </b></div>
                    <div><b>1+1 satılık daireler EmlakJet'te! </b></div>
                </div>
                <div class="text-block3">
                    <b>1+1 Daireleri Gör -></b>
                </div>
            </a>
        </div>
        <div class="col-md-6 col-sm-12 col-xs-12 aclass">
            <div class="row">
                <a href="Liste.aspx?Max=300000&Daire=1">
                    <div class="col-12 white " style="padding-bottom: 5px;">
                        <img src="Assets\Images\oda2.jpg" style="opacity: 0.6">
                        <div class="text-block4">
                            <div><b>300 Bin Tl'nin</b></div>
                            <div><b>Altında Daireler</b> </div>
                        </div>
                        <div class="text-block5">
                            <div><b>Hesabını Bilene Fırsat Daireler...</b></div>
                        </div>
                        <div class="text-block6">
                            <b>Bütçeye Uygun Daireleri Gör -></b>
                        </div>
                    </div>
                </a>
                <div class="col-md-6 col-sm-12 col-xs-12 white">
                    <img src="Assets\Images\evv.jpg" style="opacity: 0.6">
                    <div class="text-block7">
                        <div><b>Hayalinizdeki</b></div>
                        <div><b>Müstakil Ev</b></div>
                        <br />
                        <div style="line-height: 10px; color: white">
                            <p>Bahçesinde keyif</p>
                        </div>
                        <div style="line-height: 10px; color: white">
                            <p>yapabileceğin </p>
                        </div>
                        <div style="line-height: 10px; color: white">
                            <p>müstakil ev seni </p>
                        </div>
                        <div style="line-height: 10px; color: white">
                            <p>bekiyor </p>
                        </div>
                    </div>
                    <div class="text-block6 " style="top: 210px">
                        <b>Evleri Gör -></b>
                    </div>
                </div>
                <div class="col-md-6 col-sm-12 col-xs-12 white aclass">
                    <a href="Liste.aspx?KonutEv=1&KonutTur=1">
                        <img src="Assets\Images\evv.jpg" style="opacity: 0.6">
                        <div class="text-block7">
                            <div><b>Öğrenciler</b></div>
                            <div><b>Üniversite Yakını </b></div>
                            <div><b>Kiralıklar </b></div>
                            <br />
                            <div style="line-height: 10px; color: #00ffea">
                                <p>Okuldan başka bir </p>
                            </div>
                            <div style="line-height: 10px; color: #00ffea">
                                <p>şeyi dert etme,kafana </p>
                            </div>
                            <div style="line-height: 10px; color: #00ffea">
                                <p>göre evler burada! </p>
                            </div>
                        </div>
                    </a>
                    <div class="text-block6 " style="top: 210px">
                        <b>Evleri Gör -></b>
                    </div>

                </div>
            </div>
        </div>

    </div>
    <div class="row justify-content-center " id="personeller" style="margin-top: 50px">
        <div class="col-8">
            <div class="row">
                <asp:Repeater ID="rptResimler" runat="server">
                    <ItemTemplate>
                        <div class="col-xs-12 col-sm-6 col-md-4 col-lg-4 col-xl-2 calisanlar_fotograf">
                            <div style="font-size: 12px; text-align: center">
                                <img src="Assets\Images\<%# Eval("Adi")%><%# Eval("PersonelID") %>.jpg" style="font-family: 'Times New Roman'"><%# Eval("Adi") %><%# Eval("Soyadi") %>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </div>

</asp:Content>
