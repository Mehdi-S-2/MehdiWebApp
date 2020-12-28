$(document).ready(function () {
    function responsiveView() {
        var wSize = $(window).width();
        if (wSize < 768) {
            $('#main-container').addClass('sidebar-closed');
        }

        if (wSize >= 768) {
            $('#main-container').removeClass('sidebar-closed');
        }
    }

    $(window).on('load', responsiveView);
    $(window).on('resize', responsiveView);

    $('#sidebar-toggle-box').click(function () {
        $('#main-container').toggleClass("sidebar-closed");
    });
});