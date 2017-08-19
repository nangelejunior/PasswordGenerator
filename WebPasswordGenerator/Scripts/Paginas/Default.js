$(document).ready(function () {
    var $txtCharacters = $('#txtCharacters'),
		$txtMin = $('#txtMin'),
		$txtMax = $('#txtMax'),
		$lnkGerar = $('#lnkGerar'),
		$lnkLimpar = $('#lnkLimpar'),
		$tbResultado = $('#tbResultado'),
		$dvDialog = $('#dvDialog'),
		$dvMsg = $('#dvMsg');

    $txtCharacters.val("1234567890qwertyuiopasdfghjklzxcvbnm!@#$%&*QWERTYUIOPASDFGHJKLZXCVBNM");
    $txtMin.val("4");
    $txtMax.val("8");
    $tbResultado.children('tbody').html("<tr><td>&nbsp;</td></tr>");

    $txtMin.on("keypress", function (event) {
        return onlyNumber(event);
    });

    $txtMax.on("keypress", function (event) {
        return onlyNumber(event);
    });

    $lnkGerar.on("click", function () {
        var _characters,
			_min,
			_max;

        try {

            if ($txtCharacters.val() == "")
                throw new UserException("Preencha o campo Caracteres!");

            _characters = new String($txtCharacters.val());

            if ($txtMin.val().trim() == "")
                throw new UserException("Preencha o campo Tamanho M&iacute;nimo!");

            _min = new Number($txtMin.val());

            if ($txtMax.val().trim() == "")
                throw new UserException("Preencha o campo Tamanho M&aacute;ximo!");

            _max = new Number($txtMax.val());

            if (_min > _max)
                throw new UserException("O campo M&iacute;nimo é maior M&aacute;ximo!");

            if (_min < 4)
                throw new UserException("O campo Tamanho M&iacute;nimo deve ser superior a 4!");

            if (_max > _characters.length)
                throw new UserException("O campo Tamanho M&aacute;ximo deve ser inferior a " + _characters.length + "!");

            $.ajax({
                type: "POST",
                url: "http://localhost:12319/PasswordGenerator.svc/GetPasswords",
                data: JSON.stringify({ characters: _characters.replace("&", "&#38;"), minSize: _min, maxSize: _max, numberPasswords: 20 }),
                dataType: "json",
                contentType: "application/json",
                success: function (data) {
                    $tbResultado.children('tbody').children('tr').remove();
                    $.each(data.GetPasswordsResult, function () {
                        $tbResultado.children('tbody').append("<tr><td>" + new String(this) + "</tr></td>");
                    });
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    msgErro(jqXHR.responseJSON.ExceptionMessage, 200, 300);
                }
            });

        } catch (err) {

            if (err.name == "UserException") {
                msgAviso(err.message, 200, 300);
            } else {
                msgErro(err.message, 200, 300);
            }

        }
    });

    // $(document).on({
    // DOMNodeInserted: function(){

    // }
    // });

    $lnkLimpar.on("click", function () {
        $tbResultado.children('tbody').html("<tr><td>&nbsp;</td></tr>");
    });

    function onlyNumber(event) {
        var tecla = event.which;

        if ((tecla > 47 && tecla < 58)) {
            return true;
        } else {
            if (tecla == 8 || tecla == 0)
                return true;
            else
                return false;
        }
    }

    function UserException(message) {
        this.message = message;
        this.name = "UserException";
    }

    function msgAviso(msg, height, width) {
        mensagem("Aviso", msg, height, width)
    }

    function msgErro(msg, height, width) {
        mensagem("Erro", msg, height, width)
    }

    function msgSucesso(msg, height, width) {
        mensagem("Sucesso", msg, height, width)
    }

    function mensagem(title, msg, height, width) {
        $dvMsg.html(msg);

        $dvDialog.dialog({
            autoOpen: true,
            modal: true,
            title: title,
            height: height,
            width: width
        });
    }
});