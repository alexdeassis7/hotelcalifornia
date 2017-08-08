var aplicacion = "Velez Blog";

/*function darBienvenida(){
    alert("Bienvenido al Blog de Velez!!!");
}
$('#ingresar').on('click', darBienvenida);*/

$(document).on('ready', function () {

    /*$('#ingresar').on('click', function () {

        //$('#iniciar').hide();
        $('#iniciar').addClass('hide');
        $('.menuUsuario').removeClass('hide');
        //le permitimos eliminar los artículos
        $(".articulo .close").removeClass("hide");

        var email = $('#loginEmail').val();
        //$('.usuario span:first').text(email);
        $('#nombreUsuario').text(email);

        alert("Bienvenido al Blog de Velez!!!");
    });

    $("#salir").on('click', function () {
        $(".menuUsuario").addClass("hide");
        $("#iniciar").removeClass("hide");
        $(".articulo .close").addClass("hide");
    });   */

    $(".articulo .close").on('click', function () {
        //acá el this es el botón al que le hice click.
        $(this).parent().remove();
    });

});

