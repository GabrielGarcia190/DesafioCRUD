﻿using CRUD2_0;
using Dapper;
using DesafioCRUD.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesafioCRUD.Repositories
{
    public class ConsultarClienteRepository
    {

        string query = "SELECT c.id_Cliente, C.nome_Cliente AS 'Nome', c.sobrenome, c.dataNascimento, c.numTelefone, c.Rua AS 'NomeRua', c.numero AS 'NumeroCasa', c.cep, c.Bairro, c.Cidade, c.UF , g.nomeGenero AS 'Genero' FROM Cliente c INNER JOIN Genero g ON c.id_genero = g.id_genero WHERE ";
        public Cliente BuscarPorId(int id_cliente)
        {
            using (var conexao = ConexaoBanco.ObterConexao())
            {

                query += "id_cliente = @Id";

                var respota = conexao.QueryFirstOrDefault<Cliente>(query, new { Id = id_cliente });


                return respota;
            }
        }

        public IEnumerable BuscarPorNome(string nome_cliente)
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    query += "nome_Cliente LIKE @Nome + '%'";
                    var resposta = conexao.Query(query, new { Nome = nome_cliente }).ToList();

                    return resposta;

                }
            }
            catch (Exception error)
            {

                throw new Exception($"Não foi possível realizar a consulta: \n Motivo: {error.Message}");
            }
        }
        public IEnumerable BuscarPorCidade(string nome_cidade)
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    query += "Cidade LIKE @Cidade + '%'";
                    var resposta = conexao.Query(query, new { Cidade = nome_cidade }).ToList();

                    return resposta;

                }
            }
            catch (Exception error)
            {

                throw new Exception($"Não foi possível realizar a consulta: \n Motivo: {error.Message}");
            }
        }

        public IEnumerable BuscarPorTelefone(string numero_telefone) {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    query += "numTelefone LIKE '%' + @NumTelefone + '%'";
                    var resposta = conexao.Query(query, new { NumTelefone = numero_telefone }).ToList();

                    return resposta;
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Não foi possível realizar a consulta: \n Motivo: {error.Message}");
            }
        }

        public IEnumerable BuscarPorDataNascimento (DateTime dataNascimento)
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    query += "dataNascimento <= @DataNascimento";
                    var resposta = conexao.Query(query, new { DataNascimento = dataNascimento }).ToList();

                    return resposta;
                }
            }
            catch (Exception error)
            {

                throw new Exception($"Não foi possível realizar a consulta: \n Motivo: {error.Message}");
            }

        }

        public IEnumerable BuscarPorGenero (string genero) {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    query += "g.nomeGenero LIKE @Genero";
                    var resposta = conexao.Query(query, new { Genero = genero }).ToList();

                    return resposta;
                }
            }
            catch (Exception error)
            {

                throw new Exception($"Não foi possível realizar a consulta: \n Motivo: {error.Message}");
            }
        }
    }



}
