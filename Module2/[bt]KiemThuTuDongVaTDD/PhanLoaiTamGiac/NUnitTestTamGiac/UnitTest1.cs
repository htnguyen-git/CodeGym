using NUnit.Framework;
using PhanLoaiTamGiac;
namespace NUnitTestTamGiac
{
    public class Tests
    {
        TamGiac tamgiac;
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3,4,5,5,6,7)]
        public void TestCheckType()
        {
            double canhA = 1;
            double canhB = 2;
            double canhC = 3;
            TamGiac tg = new TamGiac(canhA, canhB, canhC);
            StringAssert.AreEqualIgnoringCase(TrangThaiMotTamGiac.notTriangle, TamGiac.CheckType(tg));

            double canhA2 = 3;
            double canhB2 = 4;
            double canhC2 = 5;
            TamGiac tg2 = new TamGiac(canhA2, canhB2, canhC2);
            StringAssert.AreEqualIgnoringCase(TrangThaiMotTamGiac.isTamGiacVuong, TamGiac.CheckType(tg2));

            double canhA3 = 3;
            double canhB3 = 4;
            double canhC3 = 4;
            TamGiac tg3 = new TamGiac(canhA3, canhB3, canhC3);
            StringAssert.AreEqualIgnoringCase(TrangThaiMotTamGiac.isTamGiacCan, TamGiac.CheckType(tg3));
        }
    }
}