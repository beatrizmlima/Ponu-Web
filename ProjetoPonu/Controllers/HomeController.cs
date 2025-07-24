using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Tls;
using ProjetoPonu.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPonu.Controllers
{
    public class HomeController : Controller
    {
        //Configurações padrão do MVC
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Método padrão, do INDEX, que define os ViewBags de active como vazio, assim definindo em qual página está selecionado
        public IActionResult Index()
        {
            ViewBag.Inicial = "active";
            ViewBag.ActiveProdutos = "";
            ViewBag.ActiveBlog = "";
            ViewBag.ActiveContato = "";
            ViewBag.ActiveLogin = "";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //Controlers que alternam entre as views

        //View carrinho
        public IActionResult Cart()
        {
            return View("cart");
        }

        //View contato, e, define ela como ativa
        public IActionResult Contact()
        {
            ViewBag.ActiveContato = "active";
            return View("contact");

        }

        //View blog, e, define ele como ativo
        public IActionResult Blog()
        {
            ViewBag.ActiveBlog = "active";
            return View("blog");
        }

        //View blog, e, define ele como ativo
        public IActionResult Shop()
        {
            ViewBag.ActiveProdutos = "active";

            return View("shop");
        }

        //View blog, e, define ele como ativo
        public IActionResult Login()
        {
            ViewBag.ActiveLogin = "active";
            return View("Login");
        }

        //View produto, e, pega o estoque dos produtos no banco de dados
        public IActionResult Sproduto()
        {
            Produto produto = new Produto();
            ViewBag.QuantidadeProduto = produto.pegarEstoque(3);
            return View("sproduct");
        }

        [HttpPost]
        //Metodo que adiciona os produtos ao carrinho
        public IActionResult AdicionarCarrinho(IFormCollection form)
        {
            Produto produto = new Produto();
            //Pegando valores do forms
            string nome = produto.pegarDados(3, "nome");
            double preco = double.Parse(produto.pegarDados(3,"preco"));
            int quantidade = int.Parse(form["quantidade"]);

            //Adicionando os valores ao ViewBag para coloca-los na tela
            ViewBag.quantidadeProduto = quantidade;
            ViewBag.preco = preco;
            ViewBag.nome = nome;
            ViewBag.AdcCarrinho = true; //Define se o produto vai aparecer no carrinho

            //Calcula o preço final
            float precoFinal = (float)preco * quantidade;
            ViewBag.precoFinal = precoFinal.ToString("N2");

            //Remove a quantidade selecionada do banco
            produto.AlterarBanco(3, quantidade, true);

            return View("cart");
        }



        [HttpPost]
        //Cadastra a conta do cliente
        public IActionResult CadastrarConta(IFormCollection form)
        {
            //Pega os dados no forms
            string nome = form["nome"].ToString();
            string sobrenome = form["sobrenome"].ToString();
            string email = form["email"].ToString();
            int idade = int.Parse(form["idade"]);
            string cep = form["cep"].ToString();
            string cpf = form["cpf"].ToString();
            string senha = form["senha"].ToString();
            IFormFile arq = form.Files.First();

            Login cadastro = new Login();

            //Cadastra o cliente
            string resultado = cadastro.cadastroCliente(nome, sobrenome, idade, email, cep, cpf, senha,arq);

            if (resultado == "Sucesso")
            {
                ViewBag.Alert = resultado; //Faz o alert na tela com o resultado da operação
                return View("index");          
            }
            else if(resultado == "Imagem não encontrada")
            {
                ViewBag.Alert = resultado;
                return View("login");
            }
            else
            {
                ViewBag.Alert = resultado;
                return View("login");
            }

        }

        [HttpPost]
        //Faz o login
        public IActionResult LoginConta(IFormCollection form)
        {
            //Pega os valores no Forms
            string cpf = form["cpf"].ToString();
            string senha = form["senha"].ToString();
            Login login = new Login();

            //Testa se o login existe , no banco de dados
            string resultado = login.LogarConta(cpf, senha);

            if (resultado == "Sucesso")
            {
                ViewBag.Alert = resultado;//Mostra o alert na tela
                return View("index");
            }
            else
            {
                ViewBag.Alert = resultado;
                return View("login");
            }


        }
        [HttpPost]
        //Remove o produto do carrinho, e volta ele para o banco de daos
        public IActionResult RemoverProduto(IFormCollection form)
        {
            ViewBag.RemoverProduto = true; //Faz o produto sumir do carrinho
            Produto remover = new Produto();
            //Pega a quantidade no forms
            int quantidade = int.Parse(form["quantidade"]);

            //Retorna o valor da quantidade para o banco
            remover.AlterarBanco(3, quantidade, false);

            ViewBag.Alert = "Sucesso"; //Faz o alerta na tela
            return View("cart");
        }

        [HttpPost]
        //Exclui a conta do usuário do Banco de dados
        public IActionResult ExcluirLogin(IFormCollection form)
        {
            //Pega os dados do forms
            string cpf = form["cpf"].ToString();
            string senha = form["senha"].ToString();

            Login excluir = new Login();

            string resultado = excluir.ExcluirLogin(cpf,senha); //Exclui o usuario do BCD

            if(resultado == "Sucesso")
            {
                ViewBag.Alert = resultado; //Mostra o alert na tela
                return View("login");

            }
            else
            {
                ViewBag.Alert = resultado;
                return View("login");
            }
            
        }
    }
    



}

