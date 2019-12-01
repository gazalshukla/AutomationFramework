using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLOperations;
using NUnit.Framework;
using TPLFramework;
using TPLOperations.ValidationOperation;

namespace TPLTest.ValidationTest 
{
    [TestFixture]
    public class ValidationTest : TestBase
    {
        LoginValidationOperation val = new LoginValidationOperation();

        [Test]
        [Category("ValidationTest")]
      public void EmailBlankValidation()
        {
            val.EmailBlankOp();
        }
        [Test]
        [Category("ValidationTest")]
        public void PasswordBlankValidation()
        {
            val.PasswordBlankOp();
        }
        [Test]
        [Category("ValidationTest")]
        public void UnamePassBlankValidation()
        {
            val.blankUnamePassOp();
        }
        [Test]
        [Category("ValidationTest")]
        public void WrongCredsValidation()
        {
            val.WrongCredsValidationOp();
        }
        [Test]
        [Category("ValidationTest")]
        public void InvalidPassword()
        {
            val.invalidEmailOp();
        }
        [Test]
        [Category("ValidationTest")]
        public void InvalidEmail()
        {
            val.invalidPassOp();
        }
        [Test]
        [Category("ValidationTest")]
        public void CloseButton()
        {
            val.CloseButtonOp();
        }
    }
}
