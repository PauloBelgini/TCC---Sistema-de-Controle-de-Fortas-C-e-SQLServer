using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using dto;

namespace bll
{
    class clsViagensBll
    {
        private clsViagensBll _veiculosDal;

        public List<clsViagensBll> obterListaTotal()
        {
            try
            {
                return _veiculosDal.obterListaTotal();
            }
            catch (Exception ex)
            {
                throw new Exception("BLL > " + ex.Message);
            }
        }

        public List<clsViagensBll> Inserir()
        {
            try
            {
                return _veiculosDal.obterListaTotal();
            }
            catch (Exception ex)
            {
                throw new Exception("Insert" + ex.Message);
            }
        }


    }
}
