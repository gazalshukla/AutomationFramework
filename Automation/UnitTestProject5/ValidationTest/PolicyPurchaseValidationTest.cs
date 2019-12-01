using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLOperations;
using NUnit.Framework;
using TPLFramework;

namespace TPLTest
{
    [TestFixture]
    class PolicyPurchaseValidationTest : TestBase
    {
        PolicyPurchaseValidationOp validate = new PolicyPurchaseValidationOp();
        HelperClass hc1 = new HelperClass();        
        [Test]
        [Category("ValidationTest")]
        [Ignore("Ignore a test")]
        public void PolicyPurchaseValidation()
        {

            hc1.LogintoApplication("qasophos00@gmail.com", "123456");
            validate.PolicyHolderValidationOp();
            validate.PolicyHolderSelectValidationOp();
            validate.PolicyHolderEditValidationOp();
            validate.AddVehicleValidationOp();
            validate.AddVehicleSelectValidationOp();
            validate.SelectEffectiveDateVaidatioOp();
            validate.QuoteListValidationOp();
            validate.SummaryReportValidationOp();

        }

    }
}
