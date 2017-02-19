$(document).ready(function () {
    $("tr.registro-venta").click(function () {
        var id = $(this).find("td.id-venta").html();
        $("tr.registro-detalle").hide();
        $("tr.registro-detalle").has("td.id-venta:contains('" + id + "')").show();
    });

    $("#txt-buscar").on('input', function () {
        var nombreBuscado = $("#txt-buscar").val().toUpperCase();

        $("#tabla-productos tr.producto").each(function (index, data) {
            var nombreProducto = ($(this).find("td.nombre").html().toUpperCase());
            if (nombreProducto.startsWith(nombreBuscado)) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });

        var cantidadVisibles = $("#tabla-productos tr.producto:visible").length;
        if (cantidadVisibles === 1) {
            $("#bt_add").attr('disabled', false);
        } else {

            $("#bt_add").attr('disabled', true);
        }
    });

    $('#bt_add').click(function () {
        agregar();
    });
    $('#bt_del').click(function () {
        eliminar(id_fila_selected);
    });
    $('#bt_delall').click(function () {
        eliminarTodasFilas();
    });
    $(document).on("click", ".producto-venta", function () {

        seleccionar($(this).find('td.numero-fila').html())
    });
});

var cont = 0;
var id_fila_selected = [];
function agregar() {
    cont++;
    var producto = $("#tabla-productos").find("tr.producto:visible").addClass('producto-venta');;
    $('#tabla tbody').append(producto.clone().prepend('<td class="numero-fila" id="' + cont + '"></td>'));
    reordenar();
}

function seleccionar(id_fila) {
    if ($('#' + id_fila).closest('tr').hasClass('seleccionada')) {
        $('#' + id_fila).closest('tr').removeClass('seleccionada');
    }
    else {
        $('#' + id_fila).closest('tr').addClass('seleccionada');
    }
    id_fila_selected.push(id_fila);
}

function eliminar(id_fila) {
    for (var i = 0; i < id_fila.length; i++) {
        $('#' + id_fila[i]).closest('tr').remove();
    }
    reordenar();
}

function reordenar() {
    var num = 1;
    $('#tabla tbody tr').each(function () {
        $(this).find('td').eq(0).text(num);
        $(this).find('td.numero-fila').attr("id", num);
        num++;
    });
}
function eliminarTodasFilas() {
    $('#tabla tbody tr').each(function () {
        $(this).remove();
    });

}