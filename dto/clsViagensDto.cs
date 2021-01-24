using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dto
{
    class clsViagensDto
    {
        private int _codigo;
        private String _nome;
        private String _observacoes;
        private string _motorista;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public String Motorista
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
    }




}

