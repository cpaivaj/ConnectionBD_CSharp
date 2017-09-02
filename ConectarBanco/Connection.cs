﻿using System;
using MySql.Data.MySqlClient; // C:/ProgramFiles(x86)/MySQL/MySQL Connector Net 6.9.9/Assemblies/v4.0/MySql.Data.dll
using System.Data;

namespace ConectarBanco
{
    class Connection
    {
        public static MySqlConnection connection;
        private MySqlDataAdapter mAdapter;
        public static DataSet mDataSet;
        private string tabelaBD = "falas";

        public Connection(String server, String dataBase, String user, bool conectar)
        {
            mDataSet = new DataSet();
            connection = new MySqlConnection("server=" + server + "; database=" + dataBase + "; userid=" + user + ";");

            if (conectar)
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    Console.WriteLine("Erro ao conectar com o banco");                    
                }

                if (connection.State == ConnectionState.Open)
                {
                    mAdapter = new MySqlDataAdapter("SELECT * FROM " + tabelaBD, connection);
                    mAdapter.Fill(mDataSet, tabelaBD);

                    ImprimeConteudo();
                }
            }
            else
            {
                connection.Close();
            }
        }

        public void InserirDado()
        {

        }

        public void RemoverDado()
        {

        }

        public void EditarDado()
        {

        }

        public void ImprimeConteudo()
        {
            string aux;

            try
            {
                for (int i = 0; i < mDataSet.Tables[tabelaBD].Rows.Count; i++)
                {
                    aux = Convert.ToString(mDataSet.Tables[tabelaBD].Rows[i]["fala"]);
                    Console.WriteLine(aux + " ");                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
        }
    }
}
