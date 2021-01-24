using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dto
{
    class clsLoginDto
    {
        private int _codigo;
        private String _nome;
        private String _senha;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
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

        public String Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }


    }
}
