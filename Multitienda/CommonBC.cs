using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multitienda.Negocio
{
    public class CommonBC
    {
        private static MultitiendaEDM _modeloMultitienda;
        public static MultitiendaEDM ModeloMultitienda
        {
            get
            {
                if (_modeloMultitienda == null)
                {
                    _modeloMultitienda = new MultitiendaEDM();
                }
                return _modeloMultitienda;
            }
        }
        
        public CommonBC()
        {

        }
    }
}