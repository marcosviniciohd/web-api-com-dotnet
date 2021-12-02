using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace webapi.Models
{
    public class Produtos
    {
        public int CodProduto { get; set; }

        public string? Nome { get; set; }

        public double Valor { get; set; }

        public double Quantidade { get; set;}

        public List<Produtos> SelecionarProdutos(){
             List<Produtos> listaProdutos = new();

             MySqlConnection conn = new("server=localhost;user=root;password=jesus;database=bd_csharp;port=3306");

             try{

             }catch(Exception ex){
                 throw ex;
             }
             
             return listaProdutos;
        }
    }
}
