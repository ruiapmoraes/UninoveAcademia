using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UninoveAcademia.Util;
using UninoveAcademia.Queries;

namespace UninoveAcademia.ADO
{
    public class CargoADO: ADOBase //Herdando da classe ADOBase
    {
        private bool InsereCargo(int codigo, string cargo)
        {
            string query = string.Format(Queries.Create.SistemaQueriesInsert.qInsertCargo, codigo, cargo);
            //ADOBase objCon = new ADOBase();
            bool bRet = false;
            RealizaComandoSQL(query, "");
            return bRet;
        }
    }
}
