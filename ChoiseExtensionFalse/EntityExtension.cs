using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Common;
using LSEXT;
using LSSERVICEPROVIDERLib;

namespace ChoiseExtensionFalse
{


    [ComVisible(true)]
    [ProgId("ChoiseExtensionFalse.ChoiseExtensionFalsecls")]
    public class ChoiseExtensionFalse : IWorkflowChoice
    {
        private INautilusServiceProvider sp;

          
        bool IWorkflowChoice.Execute(ref LSExtensionParameters Parameters)
        {
            var sp = Parameters["SERVICE_PROVIDER"];
            var ntlsCon = Utils.GetNtlsCon(sp);
        
            return false;
        }
       
    
    }
}
