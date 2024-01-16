export const Seli = {};

Seli.navToggle = function() {
    const btn = document.getElementById('menu-btn')
    const menu = document.getElementById('menu')
    btn.classList.toggle('open')
    menu.classList.toggle('hidden')
    menu.classList.toggle('flex')
}

Seli.dropDownVDNMobie = function() {
    const btnDropdownMobie = document.getElementById('btn-dropdown-mobie')

    const dropdownMobie = document.getElementById('dropdown-mobie')
    btnDropdownMobie.classList.toggle('open')
    dropdownMobie.classList.toggle('hidden')
    dropdownMobie.classList.toggle('flex')
}

Seli.showPopupCount = function() {
    const btnShow = document.getElementById('btn-open')
    const popup = document.getElementById('dropdown-guest')
    btnShow.classList.toggle('open')
    popup.classList.toggle('hidden')
    popup.classList.toggle('flex')
}

Seli.slickSlider = function() {
    $(".slider").not('.slick-initialized').slick({
        infinite: true,
        slidesToShow: 5,
        slidesToScroll: 1,
        prevArrow: '.prev',
        nextArrow: '.next',
        responsive: [{
                breakpoint: 1350,
                settings: {
                    slidesToShow: 4,
                    slidesToScroll: 4,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 650,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1.125,
                    slidesToScroll: 1
                }
            }
        ]
    });
    $(".slider-promotions").not('.slick-initialized').slick({
        dots: true,
        infinite: true,
        speed: 300,
        slidesToShow: 1,
        // centerMode: true,
        variableWidth: true,
    });
    $(".slider-suggest").not('.slick-initialized').slick({
        infinite: true,
        dots:true,
        slidesToShow: 4,
        slidesToScroll: 1,
        prevArrow: '.prev-suggest',
        nextArrow: '.next-suggest',
        responsive: [{
                breakpoint: 1500,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 1,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 1030,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 1,
                    dots: true
                }
            },
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1,
                    dots: true
                }
            },
            {
                breakpoint: 650,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1,
                    dots: true
                }
            },
            {
                breakpoint: 500,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    dots: true
                }
            },
        ]
    });
    $(".slider-payment-instructions").not('.slick-initialized').slick({
        infinite: true,
        slidesToShow: 5,
        slidesToScroll: 1,
        arrows: false,
        responsive: [{
                breakpoint: 1350,
                settings: {
                    slidesToShow: 4,
                    slidesToScroll: 4,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 650,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2,
                    dots: true
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    dots: true
                }
            }
        ]
    });
    $('.single-item').not('.slick-initialized').slick({
        autoplay: true,
        autoplaySpeed: 2000,
    });
    $(".slider-room-by-host").not('.slick-initialized').slick({
        infinite: false,
        slidesToShow: 3,
        slidesToScroll: 1,
        prevArrow: '.prev',
        nextArrow: '.next',
        responsive: [
            {
                breakpoint: 1200,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1,
                    dots: false
                }
            },
            {
                breakpoint: 400,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    dots: false
                }
            }
        ]
    });
    $(".slider-date-time-picker").not('.slick-initialized').slick({
        infinite: false,
        slidesToShow: 5,
        slidesToScroll: 5,
        prevArrow: '.prev-hour',
        nextArrow: '.next-hour',
    });
    $(".slider-start-time-picker").not('.slick-initialized').slick({
        infinite: false,
        slidesToShow: 5,
        slidesToScroll: 5,
        prevArrow: '.prev-time',
        nextArrow: '.next-time',
    });
}

Seli.slickSliderImgHomeStay = function(value) {
    // console.log('.img-prev-' + value)
    $('.slide-image-homepage-'+ value).not('.slick-initialized').slick({
        prevArrow: '.img-prev-' + value,
        nextArrow: '.img-next-' + value ,
        dots:true,
        infinite:false,
        lazyLoad: 'ondemand',
 
    });
    // $('.slide-image-homepage-'+ value).on('afterChange', function(slick, currentSlide,currentIndex){
    //     console.log(slick);
    //     console.log(currentSlide);
    //     console.log(currentIndex);
    // 
    //     $('.img-next-' + value).css('slick-disabled')
    //     console.log(          $('.img-next-' + value));
    //
    //     // if(currentIndex === 1) {
    //     //  
    //     // }
    //     // else {
    //     //     $('.slick-next').css('pointer-events', 'all')
    //     // }
    // });
}

Seli.toggleText = function() {
    var dots = document.getElementById("dots");
    var moreText = document.getElementById("more");
    var button = document.getElementById("button");

    if (dots.classList.contains("hidden")) {
        // Show the dots
        dots.classList.remove("hidden");

        // Hide the more text
        moreText.classList.add("hidden");

        // change text of the button
        button.innerHTML = "Hiển thị thêm cơ sở vật chất";
    } else {
        // Hide the dots
        dots.classList.add("hidden");

        // hide the more text
        moreText.classList.remove("hidden");

        // change text of the button
        button.innerHTML = "Thu gọn cơ sở vật chất";
    }
}

Seli.slickSliderImgAll = function(id) {
    $('.detail-room').not('.slick-initialized').slick({
        prevArrow: '.img-all-prev',
        nextArrow: '.img-all-next',
        dots: true,
        infinite: true,
        speed: 500,
        fade: true,
        cssEase: 'linear',
    });
     $('.detail-room').slick('slickGoTo', id,true);
}

Seli.scrollFormSearch = function (height){
    var search =  document.querySelectorAll('div.form-search');
    var search = search[0];

    var menu =  document.querySelectorAll('div.menu');
    var menu = menu[0];

    //Truy xuất div menu
    window.addEventListener("scroll",function(){
        var x = pageYOffset;
        if(x > height){
            search.classList.add("bg-[#F4F4F4]");
            search.classList.add("shadow-lg");
            menu.classList.remove("rounded-lg");
            menu.classList.remove("shadow-lg");
            menu.classList.remove("border-x");
            menu.classList.remove("border-gray-200");
        }
        else{
            search.classList.remove("bg-[#F4F4F4]");
            search.classList.remove("shadow-lg");
            menu.classList.add("rounded-lg");
            menu.classList.add("shadow-lg");
            menu.classList.add("border-x");
            menu.classList.add("border-gray-200");
        }
    })
}

Seli.initMap2 = function(){
    var geojson = {
        'type': 'FeatureCollection',
        'features': [
            {
                'type': 'Feature',
                'properties': {
                    'message': 'Foo',
                    'iconSize': [60, 60]
                },
                'geometry': {
                    'type': 'Point',
                    'coordinates': [-66.324462890625, -16.024695711685304]
                }
            },
            {
                'type': 'Feature',
                'properties': {
                    'message': 'Bar',
                    'iconSize': [50, 50]
                },
                'geometry': {
                    'type': 'Point',
                    'coordinates': [-61.2158203125, -15.97189158092897]
                }
            },
            {
                'type': 'Feature',
                'properties': {
                    'message': 'Baz',
                    'iconSize': [40, 40]
                },
                'geometry': {
                    'type': 'Point',
                    'coordinates': [-63.29223632812499, -18.28151823530889]
                }
            }
        ]
    };

    var map = new maplibregl.Map({
        container: 'map',
        style:
            'https://api.maptiler.com/maps/streets/style.json?key=get_your_own_OpIi9ZULNHzrESv6T2vL',
        center: [-65.017, -16.457],
        zoom: 5
    });

    // add markers to map
    geojson.features.forEach(function (marker) {
        // create a DOM element for the marker
        var el = document.createElement('div');
        el.className = 'marker';
        el.style.backgroundImage =
            'url(https://placekitten.com/g/' +
            marker.properties.iconSize.join('/') +
            '/)';
        el.style.width = marker.properties.iconSize[0] + 'px';
        el.style.height = marker.properties.iconSize[1] + 'px';

        el.addEventListener('click', function () {
            window.alert(marker.properties.message);
        });

        // add marker to map
        new maplibregl.Marker(el)
            .setLngLat(marker.geometry.coordinates)
            .addTo(map);
    });
}

Seli.hideScroll = function (value){
    document.getElementsByTagName("body")[0].style.overflowY=value;
}

Seli.selectOption = function(){
    $( "option" ).addClass( "option" );
    $('.option').css("padding","10px 0");
    
    $('.hourselect').focus(function() {
        $(this).attr('size',3);
        $(this).css("text-align","center");
        $(this).css("width","100px");
    });
    $('.hourselect').blur(function() {
        $(this).attr('size',1);
    });
    
    $('.minuteselect').focus(function() {
        $(this).attr('size',3);
        $(this).css("text-align","center");
        $(this).css("width","100px");
    });
    $('.minuteselect').blur(function() {
        $(this).attr('size',1);
    });

    $( ".calendar-time" ).append( "<p>Test</p>" );
}
