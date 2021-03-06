using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;
using Basics_KnowledgeSWDT;
using Verify = Microsoft.CodeAnalysis.CSharp.CodeFix.Testing.MSTest.CodeFixVerifier<
    Basics_KnowledgeSWDT.Basics_KnowledgeSWDTAnalyzer,
    Basics_KnowledgeSWDT.Basics_KnowledgeSWDTCodeFixProvider>;

namespace Basics_KnowledgeSWDT.Test
{
    [TestClass]
    public class UnitTest
    {
        //No diagnostics expected to show up
        [TestMethod]
        public async Task TestMethod1()
        {
            var test = @"";

            await Verify.VerifyCSharpDiagnosticAsync(test);
        }

        //Diagnostic and CodeFix both triggered and checked for
        [TestMethod]
        public async Task TestMethod2()
        {
            var test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace ConsoleApplication1
    {
        class TypeName
        {   
        }
    }";

            var fixtest = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace ConsoleApplication1
    {
        class TYPENAME
        {   
        }
    }";

            var expected = Verify.Diagnostic("Basics_KnowledgeSWDT").WithLocation(11, 15).WithArguments("TypeName");
            await Verify.VerifyCSharpFixAsync(test, expected, fixtest);
        }
    }
}
