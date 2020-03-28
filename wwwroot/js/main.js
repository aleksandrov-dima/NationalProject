$('#layout-drawer-scrollview').on('load scroll', function () {
    console.log('scroll');
});
$(document).ready(function () {
    //круглый график

    $('.graph_doughnut').each(function () {
        var $id_attr = $(this).attr('id');
        var $obj = document.getElementById($id_attr);
        var circle = Circles.create({
            id: $obj.id,
            value: $obj.getAttribute('data-proc'),
            radius: 60,//getWidth(),
            width: 32,
            duration: 750,
            text: function (value) { return value + '%'; },
            textClass: 'circles-text',
            colors: ['#e6e6e6', $obj.getAttribute('data-color')],//colors[i - 1],
            styleText: false
        });
        

    });
});