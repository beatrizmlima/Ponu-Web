/*Tornando o menu hamburguer responsivo clicável*/
const bar = document.getElementById('bar');
const nav = document.getElementById('navbar');
const close = document.getElementById('close');

/*Se o menu for clicado mostrar nav bar, se não mante-la escondida*/
if (bar) {
    bar.addEventListener('click', () => {
        nav.classList.add('active')
    })
}

/*Se o botão de close for clicado retirar a nav bar, se não manter nav bar*/
if (close) {
    close.addEventListener('click', () => {
        nav.classList.remove('active')
    })
}