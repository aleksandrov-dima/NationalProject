$('#layout-drawer-scrollview').on('load scroll', function () {
    console.log('scroll');
});
$(document).ready(function () {

    //круглый график
    $('.graph_doughnut').each(function () {
        var $id_attr = $(this).attr('id');
        var $obj = document.getElementById($id_attr);
        var key = $(this).attr('data-key');
        
        if (key == null) {
            key = '%';
        }
        
        var circle = Circles.create({
            id: $obj.id,
            value: $obj.getAttribute('data-proc'),
            radius: 60,//getWidth(),
            width: 32,
            duration: 750,
            text: function (value) {
                return value +' '+ key;
            },
            textClass: 'circles-text',
            colors: ['#e6e6e6', $obj.getAttribute('data-color')],//colors[i - 1],
            styleText: false
        });
        

    });

    //news read xml
    var url = 'http://minec.cap.ru/rss?type=news&action=9158ce83-0531-4e21-a4b1-6ed753a1e274';
    

});