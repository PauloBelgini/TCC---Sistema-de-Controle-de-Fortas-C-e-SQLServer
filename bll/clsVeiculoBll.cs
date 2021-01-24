using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using dto;

namespace bll
{
    class clsVeiculoBll
    {
        private clsVeiculoBll _veiculosDal;

        public List<clsVeiculoBll> obterListaTotal()
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
    }
}
