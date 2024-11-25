

$(document).ready(function () {

    $('#Cidades').DataTable({
        language:
        {
            "decimal": "", "emptyTable": "Sem registros na tabela", "info": "Mostrando _START_ de _END_ de _TOTAL_ Registros",
            "infoEmpty": "Mostrando 0 de 0 de 0 Registros", "infoFiltered": "(filtered from _MAX_ total Registros)",
            "infoPostFix": "", "thousands": ",", "lengthMenu": "Mostrar _MENU_ Registros", "loadingRecords": "Loading...",
            "processing": "", "search": "Procurar:", "zeroRecords": "No matching records found",
            "paginate": { "first": "Primeiro", "last": "Último", "next": "Próximo", "previous": "Anterior" },
            "aria": { "orderable": "Order by this column", "orderableReverse": "Reverse order this column" }
        }
    });
  
    $('#Empresa').DataTable({
        language:
        {
            "decimal": "", "emptyTable": "Sem registros na tabela", "info": "Mostrando _START_ de _END_ de _TOTAL_ Registros",
            "infoEmpty": "Mostrando 0 de 0 de 0 Registros", "infoFiltered": "(filtered from _MAX_ total Registros)",
            "infoPostFix": "", "thousands": ",", "lengthMenu": "Mostrar _MENU_ Registros", "loadingRecords": "Loading...",
            "processing": "", "search": "Procurar:", "zeroRecords": "No matching records found",
            "paginate": { "first": "Primeiro", "last": "Último", "next": "Próximo", "previous": "Anterior" },
            "aria": { "orderable": "Order by this column", "orderableReverse": "Reverse order this column" }
        }
    });

   



});
