$(document).ready(function () {
    $("tr.registro-venta").click(function () {
        var id = $(this).find("td.id-venta").html();
        $("tr.registro-detalle").hide();
        $("tr.registro-detalle").has("td.id-venta:contains('" + id + "')").show();
    });

    $("#txt-buscar").on('input', function () {
        var nombreBuscado = $("#txt-buscar").val().toUpperCase();

        $("tr.producto").each(function (index, data) {
            var nombreProducto = ($(this).find("td.nombre").html().toUpperCase());
            if (nombreProducto.startsWith(nombreBuscado)) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });

        var cantidadVisibles = $(".producto:visible").length;
        if (cantidadVisibles === 1) {
            $("#botonEnviar").attr('disabled', false);
        } else {

            $("#botonEnviar").attr('disabled', true);
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
});

var cont = 0;
var id_fila_selected = [];
function agregar() {
    cont++;
    var fila = '<tr class="selected" id="fila' + cont + '" onclick="seleccionar(this.id);"><td>' + cont + '</td><td>Articulo de la lista</td><td>0.00</td></tr>';
    $('#tabla').append(fila);
    reordenar();
}

function seleccionar(id_fila) {
    if ($('#' + id_fila).hasClass('seleccionada')) {
        $('#' + id_fila).removeClass('seleccionada');
    }
    else {
        $('#' + id_fila).addClass('seleccionada');
    }
    id_fila_selected.push(id_fila);
}

function eliminar(id_fila) {
    for (var i = 0; i < id_fila.length; i++) {
        $('#' + id_fila[i]).remove();
    }
    reordenar();
}

function reordenar() {
    var num = 1;
    $('#tabla tbody tr').each(function () {
        $(this).find('td').eq(0).text(num);
        num++;
    });
}
function eliminarTodasFilas() {
    $('#tabla tbody tr').each(function () {
        $(this).remove();
    });

}