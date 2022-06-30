/*Declaração de Variáveis*/
var enderecoReceita = "https://localhost:5001/Receitas/Receita/"
var enderecoGerarReceita = "https://localhost:5001/Receitas/GerarReceita/"
var receita;
var insumo = [];




//Formulário
function preencherFormulario(dadosReceita) {
    $("#NomeReceita").val(dadosReceita.nome)
    $("#CategoriaReceita").val(dadosReceita.categoria.nome) // .nome por ser relacional


}
function limparForumlario() {
    $("#NomeReceita").val("");
    $("#CategoriaReceita").val("");
    $("#campoQuantidade").val("");


}



$("#receitaForm").on("submit", function (event) {
    event.preventDefault();
    var receitaTabela = receita;
    var quantidade = $("#campoQuantidade").val()
    var medida = $("#medidaReceita").val()
    var ingrediente = $("#IngredienteReceita").val()
    adicionarNaTabela(receitaTabela, quantidade, medida, ingrediente)
    limparForumlario();


});
//Tabela Insumos
var receitaTemp = {};
function adicionarNaTabela(r, q, m, i) {
    // var receitaTemp = {};
    Object.assign(receitaTemp, receita);
    //   var receitaFinal = { receita: receitaTemp, quantidade: q, medida: m, ingrediente: i }; alterar para os campos do
    var receitaFinal = { ReceitaID: receitaTemp.id, Quantidade: q, MedidaID: m, IngredienteID: i };

    insumo.push(receitaFinal);

    $("#insumos").append(`
    <tr>
        <td>${r.id}</td>
        <td>${r.nome}</td>
        <td>${q}</td>
        <td>${m}</td>
        <td>${i}</td>
      
       
    </tr>`);

}
{/* <td><button class="btn btn-danger" id="excluir" onclick="removerInsumo(this);">Excluir</button></td> 
var removerInsumo = (function (elemento) {
    $(elemento).closest('tr').remove();
}); */}
// botão excluir da tabela 

{/* <td><button class="btn btn-danger" id="excluir">Excluir</button></td>   */ } //botão original
/*Ajax */






/*Ajax */
$("#pesquisar").click(function () {
    var codReceita = $("#codReceita").val();
    var enderecoTemporario = enderecoReceita + codReceita;
    $.post(enderecoTemporario, function (dados, status) {
        receita = dados;
        preencherFormulario(receita);
        console.log(receita);

    }).fail(function () {
        alert("Receita não localizada");
    })
});



//modal - mensagem e botão de finalizar receita

$("#finalizarReceita").click(function () {
    if (receita == null) {
        alert("Opção inválida! Receita não finalizada!")
        return;
    }
    // insumo.forEach(elemento => {
    //     elemento.receita = elemento.receita.id;
    //     // elemento.medida = elemento.medida.id;
    //     // elemento.ingrediente = elemento.ingrediente.id;

    // });

    // var _insumoReceita = { ReceitaID: insumo, quantidade: quantidade, IngredienteID: ingrediente, MedidaID : medida };
    console.log(insumo);
    $.ajax({
        type: "POST",
        url: enderecoGerarReceita,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(insumo),
        success: function (data) {
            console.log("Dados enviados com sucesso");
            console.log(data);
        }


    });
    window.location.href = "https://localhost:5001/Gestao/Receitas"
    // window.location.href = 'Gestao/Receitas' //Redirecionando ok

});
// $("#fecharModal").click(function () {
//     window.location.href = 'https://localhost:5001/Gestao/Receitas'
// });