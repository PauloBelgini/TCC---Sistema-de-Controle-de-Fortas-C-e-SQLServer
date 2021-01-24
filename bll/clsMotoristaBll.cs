using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using dto;
namespace bll
{
    class clsMotoristaBll
    {
        private clsMotoristaBll _veiculosDal;

        public List<clsMotoristaBll> obterListaTotal()
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
