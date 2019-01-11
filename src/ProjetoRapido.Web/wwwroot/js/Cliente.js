function DeleteCliente(id) {
    url = '/Clientes/Delete';

    $.ajax({
        url: url,
        type: "POST",
        data: { id: id },
        success: function () {
            toastr.success(`Cliente id ${id} removido com sucesso!`);
            goToIndex();
        }
        , error: function () {
            toastr.error(`Erro ao remover o id ${id}`);
            sleep(2000);
        }
    });
};

function EditCliente(id) {
    url = '/Clientes/Edit';
    $.ajax({
        url: url,
        type: "GET",
        datatype: "html",
        data: { id: id },
        success: function (data) {
            var divCliente = $("#divClientes");
            divCliente.empty();
            divCliente.show();
            divCliente.html(data);
            $('.modal').modal('show');
        }
        , error: function (data) {
            toastr.error(data.responseText);
            sleep(2000);
        }
    });
}

function modalClose() {
    jQuery.noConflict();
    $('.modal').modal('hide');
    $('.modal-backdrop').css('display', 'none');
}

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

function obterEnderecoCep(cep) {
    if (!cep)
        return;

    var url = `https://viacep.com.br/ws/${cep}/json/`;

    $.ajax({
        url: url
        , type: "GET"
        , datatype: "json"
        , success: function (data) {
            limparCampos();
            setEndereco(data);
        }
        , error: function () {
            toastr.error(`Cep ${cep} não encontrado!`);
        }
    });
}

function setEndereco(json) {

    $('input[name=Logradouro]').val(json.logradouro);
    $('input[name=Bairro]').val(json.bairro);
    $('input[name=Cidade]').val(json.localidade);
    $('input[name=Estado]').val(json.uf);
}

function limparCampos() {

    $('input[name=Logradouro]').val('');
    $('input[name=Numero]').val('');
    $('input[name=Bairro]').val('');
    $('input[name=Cidade]').val('');
    $('input[name=Estado]').val('');
}

function goToIndex() {
    setTimeout(() => {
        window.location.href = "/Clientes/Index";
    }, 1000);
    
}