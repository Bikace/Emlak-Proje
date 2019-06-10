        $(document).ready(function () {

            var evler = new Array();
            var resim = document.getElementsByClassName('resim');
            for (i = 0; i < resim.length; i++) {
                evler[i] = resim[i].getAttribute("src");
            }

            //var evler = ["Resimler\\ev1.jpg", "Resimler\\ev2.jpg", "Resimler\\ev3.jpg", "Resimler\\ev4.jpg", "Resimler\\ev5.jpg",
            //           "Resimler\\ev6.jpg", "Resimler\\ev7.jpg", "Resimler\\ev8.jpg", "Resimler\\ev9.jpg", "Resimler\\ev10.jpg", "Resimler\\ev11.jpg", "Resimler\\ev12.jpg"];

            var secili = 0;


            document.getElementsByClassName('kutu')[secili].style.opacity = "1";
            var secilikutusayisi = 6;
            var durum = 0;
            var oksol = document.querySelector('.sol-ok');
            var oksag = document.querySelector('.sag-ok');
            var bresim = document.querySelector('.buyukresim');

            oksol.addEventListener('click', function () {

                if (secili > 0) {
                    document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                    secili--;
                    document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                    bresim.setAttribute("src", evler[secili]);

                    durum--;

                    if (durum == -1 && secili > secilikutusayisi - 1) {
                        durum = secilikutusayisi - 1;
                        for (i = 1; i <= secilikutusayisi; i++) {
                            $(".cerceve div").eq(secili + 1 - i).show(1000);
                            //document.getElementsByClassName('kutu')[secili + 1 - i].style.display = "block";
                            $(".cerceve div").eq(secili + i).hide(1000);
                            //document.getElementsByClassName('kutu')[secili + i].style.display = "none";
                        }
                    }

                    if (durum == -1 && secili <= secilikutusayisi - 1) {
                        durum = secili;

                        for (i = 0; i <= secili; i++) {
                            $(".cerceve div").eq(secili + secilikutusayisi - i).hide(1000);
                            //document.getElementsByClassName('kutu')[secili + secilikutusayisi - i].style.display = "none";
                            $(".cerceve div").eq(secili - i).show(1000);
                            //document.getElementsByClassName('kutu')[secili - i].style.display = "block";
                        }
                    }



                }
            });

            oksag.addEventListener('click', function () {

                if (secili < evler.length - 1) {
                    document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                    secili++;
                    document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                    bresim.setAttribute("src", evler[secili]);

                    durum++;

                    if (durum == secilikutusayisi && evler.length - secili >= secilikutusayisi) {
                        durum = 0;
                        for (i = 1; i <= secilikutusayisi; i++) {
                            //document.getElementsByClassName('kutu')[secili - i].style.display = "none";
                            $(".cerceve div").eq(secili - i).hide(1000);
                            //document.getElementsByClassName('kutu')[secili - 1 + i].style.display = "block";
                            $(".cerceve div").eq(secili - 1 + i).show(1000);
                        }
                    }
                    if (durum == secilikutusayisi && evler.length - secili <= secilikutusayisi - 1) {
                        durum = secilikutusayisi - (evler.length - secili);

                        for (i = 0; i < evler.length - secili; i++) {
                            //document.getElementsByClassName('kutu')[secili - secilikutusayisi + i].style.display = "none";
                            $(".cerceve div").eq(secili - secilikutusayisi + i).hide(1000);
                            //document.getElementsByClassName('kutu')[secili + i].style.display = "block";
                            $(".cerceve div").eq(secili + i).show(1000);
                        }
                    }

                }

            });
            document.getElementsByClassName('kutu')[0].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 0;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[1].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 1;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[2].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 2;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[3].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 3;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[4].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 4;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[5].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 5;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[6].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 6;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[7].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 7;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[8].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 8;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[9].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 9;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[10].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 10;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });
            document.getElementsByClassName('kutu')[11].addEventListener('click', function () {
                document.getElementsByClassName('kutu')[secili].style.opacity = "0.6";
                secili = 11;
                document.getElementsByClassName('kutu')[secili].style.opacity = "1";
                bresim.setAttribute("src", evler[secili]);
                durum = secili % secilikutusayisi;

            });



        });

