using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoPonu.Models
{
    public class Produto 
    {
        public int estoque, preco;
        public string nome;
       
        //Faz a conexão com o banco de dados
        const string stringConexao = "Server=ESN509VMYSQL;Database=db_Projeto_Ponu;User id=aluno;Password=Senai1234";
        MySqlConnection conecta = new MySqlConnection(stringConexao); //Variavel que faz a conexão com o banco
        MySqlCommand query; //Variavel que faz os comandos


        //Métodos

        //Metodo que pega o estoque do produto
        public int pegarEstoque(int id)
        {
            try {
                conecta.Open(); //Abre a conexão
                query = new MySqlCommand("select quantidade from produto where id_produto=@id", conecta); //Define o comando SQL
                query.Parameters.AddWithValue("@id", id); //Parametros para evitar SQLInjection

                MySqlDataReader leitor = query.ExecuteReader(); //Lê o resultado da query
                int quantidade = 0;
                while (leitor.Read()) {
                     quantidade = int.Parse(leitor["quantidade"].ToString()); //Adiciona o resultado para a variavel
                }
                return quantidade;

            }
            catch (MySqlException f) //Pega erros, em caso de erro, define o estoque como 0
            {      
                return 0;
            }
            
            finally
            {
                conecta.Close(); //Fecha a conexão
            }
            
        }

        //Método que pega qualquer dado do banco de dados de produto
        public string pegarDados(int id, string dado)
        {
            try
            {
                conecta.Open();//Abre a conexão
                query = new MySqlCommand("select * from produto where id_produto= @id", conecta); //Define o comando SQL
                query.Parameters.AddWithValue("@id", id);//Parametros para evitar SQLInjection

                MySqlDataReader leitor = query.ExecuteReader(); //Lê o resultado da query

                string dadoSaida="";
                while (leitor.Read()) {
                    dadoSaida = leitor[dado].ToString(); //Adiciona o resultado em uma variável
                }
                
                return dadoSaida;

            }
            catch (MySqlException) //Em caso de erro retorna a mensagem de erro
            {
                return "Erro";
            }
            finally
            {
                conecta.Close();
            }
        }

        //Altera o estoque no banco de dados
        public string AlterarBanco(int id,int quantidade, Boolean remover) {
            try {
                conecta.Open(); //Abre a conexão
                if (remover == false) { //Verificação para ver se deve adicionar ou retirar do banco
                    //Comando SQL
                    query = new MySqlCommand("update produto SET quantidade = quantidade+@quantidade where id_produto = @id", conecta);
                    query.Parameters.AddWithValue("@id", id); //Parametros para evitar SQLInjection
                    query.Parameters.AddWithValue("@quantidade", quantidade);
                    query.ExecuteNonQuery(); //Executa o comando

                    return "Sucesso";
                }
                else if(remover == true)
                {//Verificação para ver se deve adicionar ou retirar do banco
                 //Comando SQL
                    query = new MySqlCommand("update produto SET quantidade = quantidade-@quantidade where id_produto = @id", conecta);
                    query.Parameters.AddWithValue("@id", id);//Parametros para evitar SQLInjection
                    query.Parameters.AddWithValue("@quantidade", quantidade);
                    query.ExecuteNonQuery();//Executa o comando

                    return "Removido";
                } else { //Se remove não tiver valor, deolve um erro
                    return "Erro desconhecido";
                }
            } catch (MySqlException) {
                //Erro em casos de problema com o BCD
                return "Erro";
            } finally {
                conecta.Close();
            }
        }




    }
}
