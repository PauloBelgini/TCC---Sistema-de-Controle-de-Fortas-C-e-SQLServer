using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dto
{
    class clsMotoristaDto
    {
        private int _codigo;
        private String _nome;
        private String _observacoes;
        private String _email;
        private decimal _cnh;
        private decimal _categoria;
        private string _telefone;


        public String email
        {
            get { return _email; }
            set
            {
                try
                {
                    if (value.Trim().Length < 1)
                    {
                        throw new Exception("O campo nome não pode ser vazio!");
                    }
                    else
                    {
                        _nome = value;
                    }
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }


        public String Nome
        {
            get { return _nome; }
            set
            {
                try
                {
                    if (value.Trim().Length < 1)
                    {
                        throw new Exception("O campo nome não pode ser vazio!");
                    }
                    else
                    {
                        _nome = value;
                    }
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        public String Observacoes
        {
            get { return _observacoes; }
            set { _observacoes = value; }
        }


        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }


        public decimal Cnh
        {
            get { return Cnh; }
            set { Cnh = value; }
        }

        public char Telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }

        public char Categoria
        {
            get { return Categoria; }
            set { Categoria = value; }
        }
    }

}