var count = 0;
$(document).ready(function () {
    //$("#codt").text(localStorage.getItem("ct"));
    //$("#categoria").text(localStorage.getItem("cat"));
    //$("#modalidad").text(localStorage.getItem("mod"));
    getListaParticipante();
   
        $('#selectParticipante').on('change', function () {
            // Para asignar un nuevo valor a la variable global "a" no se usa var, 
            // solo el nombre de la variable
            a = $("#selectParticipante option:selected").text();
            var codt = document.getElementById('codt').value;
            var codtp = a + codt;
            $("#codtp").val(codtp);
        })
});
var getListaParticipante = function () {

    var codt = document.getElementById('codt').value;
    console.log(codt, ' codt');

    $.ajax({
        url: "/TPuntajes/GetParticipante",
        type: "GET",
        data: { codt: codt },
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectParticipante = $('#selectParticipante');

            selectParticipante.find('option').remove();
            if (count == 0)//cambie 
                selectParticipante.append('<option value="0" selected>--Seleccione</option>');
            var listatemporal = response.participanteLista;
            $.each(listatemporal, function (key, value) { //temp es la lista que va recorrer 
                selectParticipante.append('<option value=' + value.codigo + '>' + value.codigo + '</option>');
            });
        },
        error: function (response) {
            console.log(codt)
        }
    });
};
var concatenar = function () {
    var codp = document.getElementById('selectParticipante').value;
    var codt = document.getElementById('codt').value;
    var codtp = codp + codt;
}