using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System.IO;
using System;
using System.Data;
using MySqlX.XDevAPI;

namespace ProjetoPonu.Models
{
    public class Login
    {
        //Faz a conexão com o banco de dados
        const string stringConexao = "Server=ESN509VMYSQL;Database=db_Projeto_Ponu;User id=aluno;Password=Senai1234";
        MySqlConnection conecta = new MySqlConnection(stringConexao); //Variavel que faaz a conexão com o banco
        MySqlCommand query; //Variavel que faz os comandos


        //Métodos
        //Metodo que cadastra o cliente
        public string cadastroCliente(string nome, string sobrenome, int idade, string email, string cep, string cpf, string senha, IFormFile arq)
        {
            String tipoArquivo = arq.ContentType;

            if (tipoArquivo.Contains("image")) //Vê se o arquivo enviado é uma imagem
            {
                {//se for imagem eu vou gravar no banco
                    MemoryStream s = new MemoryStream();
                    arq.CopyTo(s);
                    byte[] bytesArquivo = s.ToArray(); //Transforma o arquivo em uma sequencia de bytes para enviar ao banco

                    try
                    {
                        conecta.Open();
                        query = new MySqlCommand("Insert into cliente(nome,sobrenome,idade,email,cep,cpf,senha,imagem) " +
                            "VALUES (@nome,@sobrenome,@idade,@email,@cep,@cpf,@senha,@imagem)", conecta); //Define o comando SQL
                        //Parameters para evitar SQLInjection
                        query.Parameters.AddWithValue("@nome", nome);
                        query.Parameters.AddWithValue("@sobrenome", sobrenome);
                        query.Parameters.AddWithValue("@idade", idade);
                        query.Parameters.AddWithValue("@email", email);
                        query.Parameters.AddWithValue("@senha", senha);
                        query.Parameters.AddWithValue("@cpf", cpf);
                        query.Parameters.AddWithValue("@cep", cep);
                        query.Parameters.AddWithValue("@imagem", bytesArquivo);

                        query.ExecuteNonQuery(); //Executa o comando
                        return "Sucesso";
                    }
                    catch (MySqlException f) //Em caso de erro, retorna o erro
                    {
                        return "Erro" + f.ToString();

                    }
                    finally
                    {
                        conecta.Close(); //Fecha a conexão independente do caso

                    }
                }

            }
            else //Se não for uma imagem, retorna uma mensagem
            {
                return "Imagem não encontrada";
            }
        }


        //Metodo de login
        public string LogarConta(string login, string senha)
        {
            try
            {
                conecta.Open(); // Abre a conexão
                query = new MySqlCommand("Select * from cliente where cpf=@login and senha=@senha", conecta); //Define o comando sql
                //Parametros para evitar SQLInjection
                query.Parameters.AddWithValue("@login", login.Trim().ToString());
                query.Parameters.AddWithValue("@senha", senha.Trim().ToString());

                MySqlDataReader leitor = query.ExecuteReader();//Lê o resultado do Query ao banco

                if (!leitor.HasRows) /*Se o que foi lido, tiver colunas, ou seja, se existir algum valor no bcd
                                      * ,ele dá sucesso no login*/
                {
                    return "Usuario nao encontrado";
                }
                else
                {
                    return "Sucesso";
                }

            }
            catch (MySqlException f) //Pega os erros e os retorna como mensagem
            {
                return f.ToString();
            }
            finally
            {
                conecta.Close(); //Fecha a conexão
            }

        }

        //Metodo que exclui um cliente
        public string ExcluirLogin(string cpf, string senha)
        {
            try
            {
                conecta.Open();//Abre a conexão
                query = new MySqlCommand("DELETE from cliente WHERE cpf = @cpf and senha = @senha", conecta);//Define o comando SQL
                //Parametros para evitar SQLInjection
                query.Parameters.AddWithValue("@cpf", cpf);
                query.Parameters.AddWithValue("@senha", senha);

                query.ExecuteNonQuery();//Executa o comando
                return "Sucesso";//Retorna a mensagem para o alert

            }
            catch (MySqlException f) //Em caso de erro retorna o erro como mensagem
            {
                return "Erro" + f;
            }
            finally
            {
                conecta.Close(); // fecha a conexão
            }
        }
    }
}
