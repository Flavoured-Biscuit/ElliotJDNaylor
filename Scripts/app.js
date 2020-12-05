$(document).ready(function () {
    InitNavigation();
});

function InitNavigation() {
    var navItems = $("nav ul li");

    var loc = window.location.pathname;
    navItems.find('a').each(function () {
        $(this).toggleClass('active', $(this).attr('href') == loc);
    });
}