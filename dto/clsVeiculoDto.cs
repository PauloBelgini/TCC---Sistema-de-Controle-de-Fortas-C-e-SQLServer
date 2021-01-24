using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dto
{
    public class clsVeiculoDto
    {
        private int _codigo;
        private String _nome;
        private String _combustiveis;
        private int _km;
        private decimal _chassi;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public String Combustiveis
        {
            get { return _combustiveis; }
            set { _combustiveis = value; }
        }

        public int KM
        {
            get { return KM; }
            set { KM = value; }
        }

        public decimal Chassi
        {
            get { return Chassi; }
            set { Chassi = value; }
        }



    }
}
