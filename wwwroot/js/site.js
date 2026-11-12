// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function () {

    let favoritos = JSON.parse(localStorage.getItem("favoritos")) || [];

    const botoes = document.querySelectorAll(".btn-favorito");

    botoes.forEach(function (botao) {

        const carro = botao.dataset.carro;

        // Verificar se já está nos favoritos
        if (favoritos.includes(carro)) {
            botao.innerHTML = "♥ Remover dos favoritos";
        }

        // Quando o utilizador clicar
        botao.addEventListener("click", function () {

            if (favoritos.includes(carro)) {

                favoritos = favoritos.filter(function (item) {
                    return item !== carro;
                });

                botao.innerHTML = "♡ Adicionar aos favoritos";
                alert("Carro removido dos favoritos!")

            } else {

                favoritos.push(carro);

                botao.innerHTML = "♥ Remover dos favoritos";
                alert("Carro adicionado aos favoritos!")

            }

            // Guardar favoritos
            localStorage.setItem("favoritos", JSON.stringify(favoritos));

        });

    });

});

document.addEventListener("DOMContentLoaded", function () {

    let venda = JSON.parse(localStorage.getItem("venda")) || [];

    const botoes = document.querySelectorAll(".btn-venda");

    botoes.forEach(function (botao) {

        const carro = botao.dataset.carro;

        // Verificar se já está nos favoritos
        if (venda.includes(carro)) {
            botao.innerHTML = "Vendido";
        }

        // Quando o utilizador clicar
        botao.addEventListener("click", function () {

            if (venda.includes(carro)) {

                venda = venda.filter(function (item) {
                    return item !== carro;
                });

                botao.innerHTML = "Vender";
                alert("O seu carro voltou para loja!")
                

            } else {

                venda.push(carro);

                botao.innerHTML = "Vendido";
                alert("Aguarde iremos arranjar um comprador para o seu carro!")
                

            }

            // Guardar favoritos
            localStorage.setItem("venda", JSON.stringify(venda));

        });

    });

});