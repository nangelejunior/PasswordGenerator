<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="GeradorSenhasWeb._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script src="Scripts/Paginas/Default.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Gerador de Senhas
    </h2>
    <div>
        <div>
            <p>
                <label for="txtCharacters">Caracteres:</label>
                <input id="txtCharacters" type="text" maxlength="100" size="100" />
            </p>
            <p>
                <label for="txtMin">Tamanho M&iacute;nimo:</label>
                <input id="txtMin" type="text" maxlength="3" size="5" />
            </p>
            <p>
                <label for="txtMax">Tamanho M&aacute;ximo:</label>
                <input id="txtMax" type="text" maxlength="3" size="5" />
            </p>
            <p>
                <label for="lnkGerar">&nbsp;</label>
                <a id="lnkGerar" href="#">Gerar</a>
                <a id="lnkLimpar" href="#">Limpar</a>
            </p>
        </div>
        <div>
            <fieldset>
                <legend>Resultado</legend>
                <table id="tbResultado">
                    <tbody>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                    </tbody>
                </table>
            </fieldset>
        </div>
        <div id="dvDialog" style="display: none;">
            <table>
                <tbody>
                    <tr>
                        <td>
                            <div id="dvMsg">
                                &nbsp</div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
